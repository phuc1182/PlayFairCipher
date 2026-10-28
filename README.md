# ỨNG DỤNG THỬ NGHIỆM HỆ MẬT PLAYFAIR

Ứng dụng desktop mô phỏng quá trình mã hóa và giải mã bằng hệ mật Playfair, được xây dựng bằng C# Windows Forms.

Ứng dụng phục vụ mục đích học tập, nghiên cứu nguyên lý hoạt động của hệ mật cổ điển Playfair và không được khuyến nghị sử dụng để bảo vệ dữ liệu thực tế.

---

## Chức năng chính

- Nhập khóa bí mật.
- Tạo ma trận Playfair 5×5 từ khóa.
- Tự động loại bỏ các ký tự trùng trong khóa.
- Gộp hai chữ cái `I` và `J`.
- Chuẩn hóa bản rõ trước khi mã hóa.
- Tự động chia văn bản thành từng cặp ký tự.
- Chèn ký tự `X` giữa hai chữ cái giống nhau trong một cặp.
- Thêm ký tự `X` nếu văn bản có số ký tự lẻ.
- Mã hóa văn bản bằng hệ mật Playfair.
- Giải mã bản mã Playfair.
- Hiển thị văn bản sau khi chuẩn hóa.
- Hiển thị các cặp ký tự được xử lý.
- Sao chép kết quả.
- Xóa dữ liệu và nhập lại.
- Hiển thị phần tìm hiểu về hệ mật Playfair.
- Kiểm tra và thông báo khi người dùng nhập thiếu dữ liệu.

---

## Công nghệ sử dụng

- Ngôn ngữ: C#
- Nền tảng: .NET Windows
- Giao diện: Windows Forms
- Môi trường phát triển: Visual Studio Community
- Quản lý mã nguồn: Git và GitHub

---

## Quy ước của ứng dụng

Ứng dụng sử dụng bảng chữ cái gồm 25 ký tự:

```text
ABCDEFGHIKLMNOPQRSTUVWXYZ
