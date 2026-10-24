namespace PlayFairCipher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Label labelCipherInput;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelSteps;

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtCipherInput;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.RichTextBox txtMatrix;
        private System.Windows.Forms.RichTextBox txtSteps;

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;

        private void InitializeComponent()
        {
            this.labelKey = new System.Windows.Forms.Label();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.labelCipherInput = new System.Windows.Forms.Label();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();

            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtCipherInput = new System.Windows.Forms.TextBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.txtMatrix = new System.Windows.Forms.RichTextBox();
            this.txtSteps = new System.Windows.Forms.RichTextBox();

            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // labelKey
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(20, 20);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(54, 15);
            this.labelKey.Text = "Khóa:";

            // txtKey
            this.txtKey.Location = new System.Drawing.Point(120, 20);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(260, 23);
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);

            // labelPlainText
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Location = new System.Drawing.Point(20, 60);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(78, 15);
            this.labelPlainText.Text = "Bản rõ:";

            // txtPlainText
            this.txtPlainText.Location = new System.Drawing.Point(120, 60);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainText.Size = new System.Drawing.Size(260, 110);

            // labelCipherInput
            this.labelCipherInput.AutoSize = true;
            this.labelCipherInput.Location = new System.Drawing.Point(20, 185);
            this.labelCipherInput.Name = "labelCipherInput";
            this.labelCipherInput.Size = new System.Drawing.Size(79, 15);
            this.labelCipherInput.Text = "Bản mã nhập:";

            // txtCipherInput
            this.txtCipherInput.Location = new System.Drawing.Point(120, 185);
            this.txtCipherInput.Multiline = true;
            this.txtCipherInput.Name = "txtCipherInput";
            this.txtCipherInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipherInput.Size = new System.Drawing.Size(260, 110);

            // labelCipherText
            this.labelCipherText.AutoSize = true;
            this.labelCipherText.Location = new System.Drawing.Point(20, 310);
            this.labelCipherText.Name = "labelCipherText";
            this.labelCipherText.Size = new System.Drawing.Size(73, 15);
            this.labelCipherText.Text = "Bản mã:";

            // txtCipherText
            this.txtCipherText.Location = new System.Drawing.Point(120, 310);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipherText.Size = new System.Drawing.Size(260, 110);

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(120, 440);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(90, 32);
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(220, 440);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(90, 32);
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(320, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 32);
            this.btnClear.Text = "Xóa";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // labelMatrix
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(470, 20);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(73, 15);
            this.labelMatrix.Text = "Bảng khóa:";

            // txtMatrix
            this.txtMatrix.Location = new System.Drawing.Point(470, 40);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.Size = new System.Drawing.Size(260, 140);
            this.txtMatrix.Font = new System.Drawing.Font("Consolas", 14F);

            // labelSteps
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(470, 200);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(119, 15);
            this.labelSteps.Text = "Hiển thị từng bước:";

            // txtSteps
            this.txtSteps.Location = new System.Drawing.Point(470, 220);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.ReadOnly = true;
            this.txtSteps.Size = new System.Drawing.Size(260, 220);
            this.txtSteps.Font = new System.Drawing.Font("Consolas", 10F);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playfair Cipher Demo";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.labelCipherInput);
            this.Controls.Add(this.txtCipherInput);
            this.Controls.Add(this.labelCipherText);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.txtSteps);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}