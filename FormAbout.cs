namespace PlayFairCipher
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            LoadContent();
        }

        private void btnZoomIn_Click(object? sender, EventArgs e)
        {
            Zoom(1.2f);
        }

        private void btnZoomOut_Click(object? sender, EventArgs e)
        {
            Zoom(0.833f);
        }

        private void btnResetZoom_Click(object? sender, EventArgs e)
        {
            this.rtbContent.ZoomFactor = 1.0f;
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Zoom(float factor)
        {
            try
            {
                var newZoom = this.rtbContent.ZoomFactor * factor;
                if (newZoom >= 0.5f && newZoom <= 5.0f)
                {
                    this.rtbContent.ZoomFactor = newZoom;
                }
            }
            catch
            {
                // Bỏ qua nếu vượt ngưỡng zoom của RichTextBox
            }
        }

        private void LoadContent()
        {
            rtbContent.Clear();
            AppendTitle("HỆ MẬT PLAYFAIR (PLAYFAIR CIPHER)");
            AppendText("\n");

            AppendHeader("1. Lịch sử & Nguồn gốc");
            AppendBullet("Phát minh:", "Được nhà khoa học người Anh Charles Wheatstone phát minh vào năm 1854.");
            AppendBullet("Tên gọi:", "Được đặt tên theo Nam tước Lyon Playfair - người đã tích cực quảng bá và đề xuất đưa hệ mật này vào ứng dụng thực tế.");
            AppendBullet("Ý nghĩa lịch sử:", "Đây là hệ mật mã hóa thay thế đa ký tự (digraph substitution cipher) đầu tiên trên thế giới được đưa vào thực tế, từng được quân đội Khối Thịnh vượng chung Anh sử dụng trong Chiến tranh Boer và cả Thế chiến I & II nhờ tính bảo mật cao và tiện dụng trên chiến trường mà không cần thiết bị máy móc phức tạp.");
            AppendText("\n");

            AppendHeader("2. Cấu trúc Ma trận khóa (5x5)");
            AppendBullet("Kích thước:", "Bảng vuông 5 hàng x 5 cột = 25 ô vuông.");
            AppendBullet("Bộ chữ cái:", "Bảng chữ cái tiếng Anh gồm 26 chữ cái, nên quy ước gộp 2 chữ cái 'I' và 'J' vào chung 1 ô (hoặc bỏ chữ 'Q').");
            AppendBullet("Cách tạo ma trận:", "1) Điền các ký tự của Từ Khóa (Key) từ trái qua phải, từ trên xuống dưới (loại bỏ mọi ký tự đã trùng lặp).\n2) Điền các chữ cái còn lại trong bảng Alphabet (A-Z, trừ J) vào các ô trống còn lại theo thứ tự chữ cái.");
            AppendText("\n");

            AppendHeader("3. Quy tắc tiền xử lý Bản rõ (PlainText)");
            AppendBullet("Chuẩn hóa:", "Loại bỏ khoảng trắng, dấu câu; chuyển tất cả thành chữ in hoa; thay thế 'J' bằng 'I'.");
            AppendBullet("Tách cặp:", "Chia văn bản thành các cặp 2 ký tự (digraph).");
            AppendBullet("Xử lý trùng lặp:", "Nếu trong cùng một cặp xuất hiện 2 ký tự giống nhau (ví dụ: 'LL'), chèn ký tự đệm 'X' vào giữa để tạo thành 'LX', ký tự thứ hai sẽ được dời sang cặp sau (nếu ký tự trùng là 'X' thì chèn đệm 'Q').");
            AppendBullet("Độ dài lẻ:", "Nếu sau khi chia cặp mà còn dư 1 ký tự lẻ ở cuối, thêm ký tự đệm 'X' (hoặc 'Q') vào cuối để đảm bảo độ dài chẵn.");
            AppendText("\n");

            AppendHeader("4. Quy tắc Mã hóa từng cặp ký tự");
            AppendBullet("Trường hợp 1 - Cùng hàng:", "Thay thế mỗi ký tự bằng ký tự nằm ngay bên PHẢI nó (nếu ở cuối hàng thì quay vòng về đầu hàng).");
            AppendBullet("Trường hợp 2 - Cùng cột:", "Thay thế mỗi ký tự bằng ký tự nằm ngay bên DƯỚI nó (nếu ở đáy cột thì quay vòng lên đỉnh cột).");
            AppendBullet("Trường hợp 3 - Hình chữ nhật (khác hàng, khác cột):", "Thay thế mỗi ký tự bằng ký tự nằm trên CÙNG HÀNG với nó và CÙNG CỘT với ký tự còn lại của cặp.");
            AppendText("\n");

            AppendHeader("5. Quy tắc Giải mã");
            AppendBullet("Nguyên tắc:", "Quy trình giải mã hoàn toàn đối xứng, chỉ cần đảo ngược hướng di chuyển:");
            AppendBullet("Cùng hàng:", "Dịch chuyển sang TRÁI 1 cột (quay vòng sang cuối hàng nếu chạm mép trái).");
            AppendBullet("Cùng cột:", "Dịch chuyển lên TRÊN 1 hàng (quay vòng xuống đáy cột nếu chạm mép trên).");
            AppendBullet("Hình chữ nhật:", "Quy tắc giữ nguyên: lấy ký tự cùng hàng với nó và cùng cột với ký tự còn lại.");
            AppendText("\n");

            AppendHeader("6. Mẹo thao tác trên giao diện:");
            AppendBullet("Phóng to / Thu nhỏ:", "Bạn có thể bấm nút Phóng to / Thu nhỏ bên dưới, hoặc giữ phím Ctrl + Cuộn chuột (Scroll) trực tiếp trên văn bản.");
            AppendBullet("Toàn màn hình:", "Bấm nút Phóng to cửa sổ (Maximize ở góc trên bên phải) để đọc toàn màn hình thoải mái.");
        }

        private void AppendTitle(string title)
        {
            rtbContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbContent.SelectionColor = Color.FromArgb(0, 102, 204);
            rtbContent.AppendText(title + "\n");
        }

        private void AppendHeader(string header)
        {
            rtbContent.SelectionFont = new Font("Segoe UI", 13F, FontStyle.Bold);
            rtbContent.SelectionColor = Color.FromArgb(40, 40, 40);
            rtbContent.AppendText(header + "\n");
        }

        private void AppendBullet(string label, string text)
        {
            rtbContent.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            rtbContent.SelectionColor = Color.FromArgb(70, 70, 70);
            rtbContent.AppendText("  • " + label + " ");

            rtbContent.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Regular);
            rtbContent.SelectionColor = Color.FromArgb(50, 50, 50);
            rtbContent.AppendText(text + "\n");
        }

        private void AppendText(string text)
        {
            rtbContent.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Regular);
            rtbContent.AppendText(text);
        }
    }
}
