using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlayFairCipher
{
    public class FormScaler
    {
        private readonly Form _form;
        private Size _originalFormSize;
        private readonly Dictionary<Control, (Rectangle Bounds, float FontSize)> _initialStates = new();

        public FormScaler(Form form)
        {
            _form = form;
            _originalFormSize = form.ClientSize;
            RecordControls(form);
            _form.Resize += Form_Resize;
        }

        private void RecordControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                _initialStates[c] = (c.Bounds, c.Font.Size);
                if (c.HasChildren)
                {
                    RecordControls(c);
                }
            }
        }

        private void Form_Resize(object? sender, EventArgs e)
        {
            if (_originalFormSize.Width == 0 || _originalFormSize.Height == 0) return;

            float scaleX = (float)_form.ClientSize.Width / _originalFormSize.Width;
            float scaleY = (float)_form.ClientSize.Height / _originalFormSize.Height;
            float fontScale = Math.Min(scaleX, scaleY);

            _form.SuspendLayout();
            foreach (var kvp in _initialStates)
            {
                var c = kvp.Key;
                var initial = kvp.Value;

                int newX = (int)Math.Round(initial.Bounds.X * scaleX);
                int newY = (int)Math.Round(initial.Bounds.Y * scaleY);
                int newW = (int)Math.Round(initial.Bounds.Width * scaleX);
                int newH = (int)Math.Round(initial.Bounds.Height * scaleY);

                c.SetBounds(newX, newY, newW, newH);

                float newFontSize = initial.FontSize * fontScale;
                if (newFontSize >= 6f && Math.Abs(c.Font.Size - newFontSize) > 0.5f)
                {
                    try
                    {
                        c.Font = new Font(c.Font.FontFamily, newFontSize, c.Font.Style);
                    }
                    catch { }
                }
            }
            _form.ResumeLayout();
        }
    }
}