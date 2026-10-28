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
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelSteps;

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.RichTextBox txtMatrix;
        private System.Windows.Forms.RichTextBox txtSteps;

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelKey = new Label();
            labelPlainText = new Label();
            labelCipherText = new Label();
            labelMatrix = new Label();
            labelSteps = new Label();
            txtKey = new TextBox();
            txtPlainText = new TextBox();
            txtCipherText = new TextBox();
            txtMatrix = new RichTextBox();
            txtSteps = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            btnInformationCipherPlayFair = new Button();
            SuspendLayout();
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new Point(23, 53);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(46, 20);
            labelKey.TabIndex = 0;
            labelKey.Text = "Khóa:";
            // 
            // labelPlainText
            // 
            labelPlainText.AutoSize = true;
            labelPlainText.Location = new Point(23, 179);
            labelPlainText.Name = "labelPlainText";
            labelPlainText.Size = new Size(55, 20);
            labelPlainText.TabIndex = 2;
            labelPlainText.Text = "Bản rõ:";
            // 
            // labelCipherText
            // 
            labelCipherText.AutoSize = true;
            labelCipherText.Location = new Point(23, 343);
            labelCipherText.Name = "labelCipherText";
            labelCipherText.Size = new Size(62, 20);
            labelCipherText.TabIndex = 4;
            labelCipherText.Text = "Bản mã:";
            // 
            // labelMatrix
            // 
            labelMatrix.AutoSize = true;
            labelMatrix.Location = new Point(537, 27);
            labelMatrix.Name = "labelMatrix";
            labelMatrix.Size = new Size(126, 20);
            labelMatrix.TabIndex = 9;
            labelMatrix.Text = "Ma trận khóa 5x5:";
            // 
            // labelSteps
            // 
            labelSteps.AutoSize = true;
            labelSteps.Location = new Point(844, 27);
            labelSteps.Name = "labelSteps";
            labelSteps.Size = new Size(137, 20);
            labelSteps.TabIndex = 11;
            labelSteps.Text = "Hiển thị từng bước:";
            labelSteps.Click += labelSteps_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(137, 53);
            txtKey.Margin = new Padding(3, 4, 3, 4);
            txtKey.Multiline = true;
            txtKey.Name = "txtKey";
            txtKey.ScrollBars = ScrollBars.Vertical;
            txtKey.Size = new Size(297, 118);
            txtKey.TabIndex = 1;
            txtKey.TextChanged += txtKey_TextChanged;
            // 
            // txtPlainText
            // 
            txtPlainText.Location = new Point(137, 179);
            txtPlainText.Margin = new Padding(3, 4, 3, 4);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.ScrollBars = ScrollBars.Vertical;
            txtPlainText.Size = new Size(297, 145);
            txtPlainText.TabIndex = 3;
            // 
            // txtCipherText
            // 
            txtCipherText.Location = new Point(137, 343);
            txtCipherText.Margin = new Padding(3, 4, 3, 4);
            txtCipherText.Multiline = true;
            txtCipherText.Name = "txtCipherText";
            txtCipherText.ScrollBars = ScrollBars.Vertical;
            txtCipherText.Size = new Size(297, 145);
            txtCipherText.TabIndex = 5;
            // 
            // txtMatrix
            // 
            txtMatrix.Font = new Font("Consolas", 14F);
            txtMatrix.Location = new Point(537, 53);
            txtMatrix.Margin = new Padding(3, 4, 3, 4);
            txtMatrix.Name = "txtMatrix";
            txtMatrix.ReadOnly = true;
            txtMatrix.Size = new Size(201, 172);
            txtMatrix.TabIndex = 10;
            txtMatrix.Text = "";
            // 
            // txtSteps
            // 
            txtSteps.Font = new Font("Consolas", 10F);
            txtSteps.Location = new Point(844, 53);
            txtSteps.Margin = new Padding(3, 4, 3, 4);
            txtSteps.Name = "txtSteps";
            txtSteps.ReadOnly = true;
            txtSteps.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtSteps.Size = new Size(476, 567);
            txtSteps.TabIndex = 12;
            txtSteps.Text = "";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(137, 516);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(103, 43);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(251, 516);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(103, 43);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(366, 516);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 43);
            btnClear.TabIndex = 8;
            btnClear.Text = "Xóa";
            btnClear.Click += btnClear_Click;
            // 
            // btnInformationCipherPlayFair
            // 
            btnInformationCipherPlayFair.Location = new Point(23, 566);
            btnInformationCipherPlayFair.Name = "btnInformationCipherPlayFair";
            btnInformationCipherPlayFair.Size = new Size(297, 29);
            btnInformationCipherPlayFair.TabIndex = 13;
            btnInformationCipherPlayFair.Text = "Hệ mật PlayFair( PlayFair cipher) là gì ?";
            btnInformationCipherPlayFair.UseVisualStyleBackColor = true;
            btnInformationCipherPlayFair.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1363, 633);
            Controls.Add(btnInformationCipherPlayFair);
            Controls.Add(labelKey);
            Controls.Add(txtKey);
            Controls.Add(labelPlainText);
            Controls.Add(txtPlainText);
            Controls.Add(labelCipherText);
            Controls.Add(txtCipherText);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(btnClear);
            Controls.Add(labelMatrix);
            Controls.Add(txtMatrix);
            Controls.Add(labelSteps);
            Controls.Add(txtSteps);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Playfair Cipher ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInformationCipherPlayFair;
    }
}
