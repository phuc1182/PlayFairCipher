namespace PlayFairCipher
{
    public partial class Form1 : Form
    {
        private readonly PlayFairEngine _engine = new();

        public Form1()
        {
            InitializeComponent();
            _ = new FormScaler(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKey.Text = "NHÓM KHÔNG SÁU";
            txtPlainText.Text = "CƠ SỞ AN NINH MẠNG";
            txtCipherText.Text = "";
            txtSteps.Text = "";

            UpdateMatrix();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;
            var plain = txtPlainText.Text;

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập khóa (key).", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKey.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(plain))
            {
                MessageBox.Show("Vui lòng nhập bản rõ để mã hóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlainText.Focus();
                return;
            }

            var cipher = _engine.Encrypt(key, plain);
            txtCipherText.Text = cipher;
            txtSteps.Text = _engine.EncryptDetailed(key, plain);
            UpdateMatrix();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;
            var cipherText = txtCipherText.Text;

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập khóa (key).", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKey.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cipherText))
            {
                MessageBox.Show("Vui lòng nhập bản mã để giải mã.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCipherText.Focus();
                return;
            }

            try
            {
                var plain = _engine.Decrypt(key, cipherText);
                txtPlainText.Text = plain;
                txtSteps.Text = _engine.DecryptDetailed(key, cipherText);
                UpdateMatrix();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi bản mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtPlainText.Clear();
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

        private void labelSteps_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var aboutForm = new FormAbout();
            aboutForm.ShowDialog(this);
        }
    }
}
