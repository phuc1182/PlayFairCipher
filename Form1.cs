namespace PlayFairCipher
{
    public partial class Form1 : Form
    {
        private readonly PlayFairEngine _engine = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKey.Text = "MONARCHY";
            txtPlainText.Text = "HELLO WORLD";
            txtCipherInput.Text = "";
            txtCipherText.Text = "";
            txtSteps.Text = "";
            UpdateMatrix();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;
            var plain = txtPlainText.Text;

            txtCipherText.Text = _engine.Encrypt(key, plain);
            txtSteps.Text = _engine.EncryptDetailed(key, plain);
            UpdateMatrix();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;
            var cipherInput = string.IsNullOrWhiteSpace(txtCipherInput.Text)
                ? txtCipherText.Text
                : txtCipherInput.Text;

            txtPlainText.Text = _engine.Decrypt(key, cipherInput);
            txtSteps.Text = _engine.DecryptDetailed(key, cipherInput);
            UpdateMatrix();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtPlainText.Clear();
            txtCipherInput.Clear();
            txtCipherText.Clear();
            txtSteps.Clear();
            txtMatrix.Clear();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            UpdateMatrix();
        }

        private void UpdateMatrix()
        {
            txtMatrix.Text = _engine.GetMatrixDisplay(txtKey.Text);
        }
    }
}