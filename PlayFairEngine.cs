using System.Text;

namespace PlayFairCipher
{
    public sealed class PlayFairEngine
    {
        private const string Alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";

        public string GetMatrixDisplay(string key)
        {
            var matrix = BuildMatrix(key);
            var sb = new StringBuilder();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    sb.Append(matrix[row, col]);
                    if (col < 4) sb.Append("  ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string Encrypt(string key, string plainText)
        {
            var normalized = NormalizeText(plainText);
            var matrix = BuildMatrix(key);
            var pairs = PreparePairs(normalized);

            var result = new StringBuilder();

            foreach (var pair in pairs)
            {
                var a = pair[0];
                var b = pair[1];
                var posA = FindPosition(matrix, a);
                var posB = FindPosition(matrix, b);

                if (posA.Row == posB.Row)
                {
                    result.Append(matrix[posA.Row, (posA.Col + 1) % 5]);
                    result.Append(matrix[posB.Row, (posB.Col + 1) % 5]);
                }
                else if (posA.Col == posB.Col)
                {
                    result.Append(matrix[(posA.Row + 1) % 5, posA.Col]);
                    result.Append(matrix[(posB.Row + 1) % 5, posB.Col]);
                }
                else
                {
                    result.Append(matrix[posA.Row, posB.Col]);
                    result.Append(matrix[posB.Row, posA.Col]);
                }
            }

            return result.ToString();
        }

        public string Decrypt(string key, string cipherText)
        {
            var normalized = NormalizeText(cipherText);
            var matrix = BuildMatrix(key);
            var pairs = SplitPairs(normalized);

            var result = new StringBuilder();

            foreach (var pair in pairs)
            {
                var a = pair[0];
                var b = pair[1];
                var posA = FindPosition(matrix, a);
                var posB = FindPosition(matrix, b);

                if (posA.Row == posB.Row)
                {
                    result.Append(matrix[posA.Row, (posA.Col + 4) % 5]);
                    result.Append(matrix[posB.Row, (posB.Col + 4) % 5]);
                }
                else if (posA.Col == posB.Col)
                {
                    result.Append(matrix[(posA.Row + 4) % 5, posA.Col]);
                    result.Append(matrix[(posB.Row + 4) % 5, posB.Col]);
                }
                else
                {
                    result.Append(matrix[posA.Row, posB.Col]);
                    result.Append(matrix[posB.Row, posA.Col]);
                }
            }

            return result.ToString();
        }

        public string EncryptDetailed(string key, string plainText)
        {
            var sb = new StringBuilder();
            var normalized = NormalizeText(plainText);
            var matrix = BuildMatrix(key);
            var pairs = PreparePairs(normalized);

            sb.AppendLine("=== MÃ HÓA PLAYFAIR ===");
            sb.AppendLine($"Khóa: {key}");
            sb.AppendLine($"Bản rõ chuẩn hóa: {normalized}");
            sb.AppendLine($"Các cặp: {string.Join(" ", pairs)}");
            sb.AppendLine();
            sb.AppendLine("Bảng ma trận:");
            sb.AppendLine(GetMatrixDisplay(key));
            sb.AppendLine();

            foreach (var pair in pairs)
            {
                var a = pair[0];
                var b = pair[1];
                var posA = FindPosition(matrix, a);
                var posB = FindPosition(matrix, b);

                sb.AppendLine($"Cặp [{pair}]");
                sb.AppendLine($"  {a} ở ({posA.Row},{posA.Col})");
                sb.AppendLine($"  {b} ở ({posB.Row},{posB.Col})");

                if (posA.Row == posB.Row)
                {
                    var ra = matrix[posA.Row, (posA.Col + 1) % 5];
                    var rb = matrix[posB.Row, (posB.Col + 1) % 5];
                    sb.AppendLine("  Quy tắc: cùng hàng -> dịch phải 1 cột");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }
                else if (posA.Col == posB.Col)
                {
                    var ra = matrix[(posA.Row + 1) % 5, posA.Col];
                    var rb = matrix[(posB.Row + 1) % 5, posB.Col];
                    sb.AppendLine("  Quy tắc: cùng cột -> dịch xuống 1 hàng");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }
                else
                {
                    var ra = matrix[posA.Row, posB.Col];
                    var rb = matrix[posB.Row, posA.Col];
                    sb.AppendLine("  Quy tắc: hình chữ nhật -> hoán vị cột");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string DecryptDetailed(string key, string cipherText)
        {
            var sb = new StringBuilder();
            var normalized = NormalizeText(cipherText);
            var matrix = BuildMatrix(key);
            var pairs = SplitPairs(normalized);

            sb.AppendLine("=== GIẢI MÃ PLAYFAIR ===");
            sb.AppendLine($"Khóa: {key}");
            sb.AppendLine($"Bản mã chuẩn hóa: {normalized}");
            sb.AppendLine($"Các cặp: {string.Join(" ", pairs)}");
            sb.AppendLine();
            sb.AppendLine("Bảng ma trận:");
            sb.AppendLine(GetMatrixDisplay(key));
            sb.AppendLine();

            foreach (var pair in pairs)
            {
                var a = pair[0];
                var b = pair[1];
                var posA = FindPosition(matrix, a);
                var posB = FindPosition(matrix, b);

                sb.AppendLine($"Cặp [{pair}]");
                sb.AppendLine($"  {a} ở ({posA.Row},{posA.Col})");
                sb.AppendLine($"  {b} ở ({posB.Row},{posB.Col})");

                if (posA.Row == posB.Row)
                {
                    var ra = matrix[posA.Row, (posA.Col + 4) % 5];
                    var rb = matrix[posB.Row, (posB.Col + 4) % 5];
                    sb.AppendLine("  Quy tắc: cùng hàng -> dịch trái 1 cột");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }
                else if (posA.Col == posB.Col)
                {
                    var ra = matrix[(posA.Row + 4) % 5, posA.Col];
                    var rb = matrix[(posB.Row + 4) % 5, posB.Col];
                    sb.AppendLine("  Quy tắc: cùng cột -> dịch lên 1 hàng");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }
                else
                {
                    var ra = matrix[posA.Row, posB.Col];
                    var rb = matrix[posB.Row, posA.Col];
                    sb.AppendLine("  Quy tắc: hình chữ nhật -> hoán vị cột");
                    sb.AppendLine($"  Kết quả: {ra}{rb}");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private static char[,] BuildMatrix(string key)
        {
            var used = new HashSet<char>();
            var chars = new List<char>();

            foreach (var ch in NormalizeKey(key))
            {
                if (used.Add(ch))
                    chars.Add(ch);
            }

            foreach (var ch in Alphabet)
            {
                if (used.Add(ch))
                    chars.Add(ch);
            }

            var matrix = new char[5, 5];
            for (int i = 0; i < chars.Count; i++)
            {
                matrix[i / 5, i % 5] = chars[i];
            }

            return matrix;
        }

        private static string NormalizeKey(string key)
        {
            var sb = new StringBuilder();

            foreach (var ch in key.ToUpperInvariant())
            {
                var c = ch == 'J' ? 'I' : ch;
                if (Alphabet.Contains(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }

        private static string NormalizeText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            var sb = new StringBuilder();

            foreach (var ch in text.ToUpperInvariant())
            {
                var c = ch == 'J' ? 'I' : ch;
                if (Alphabet.Contains(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }

        private static List<string> PreparePairs(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new List<string>();

            var builder = new StringBuilder(text);

            for (int i = 0; i < builder.Length - 1; i++)
            {
                if (builder[i] == builder[i + 1])
                {
                    builder.Insert(i + 1, 'X');
                    i++;
                }
            }

            if (builder.Length % 2 != 0)
                builder.Append('X');

            var result = new List<string>();
            for (int i = 0; i < builder.Length; i += 2)
                result.Add(builder.ToString(i, 2));

            return result;
        }

        private static List<string> SplitPairs(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new List<string>();

            var builder = new StringBuilder(text);
            if (builder.Length % 2 != 0)
                builder.Append('X');

            var result = new List<string>();
            for (int i = 0; i < builder.Length; i += 2)
                result.Add(builder.ToString(i, 2));

            return result;
        }

        private static (int Row, int Col) FindPosition(char[,] matrix, char letter)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (matrix[row, col] == letter)
                        return (row, col);
                }
            }

            throw new InvalidOperationException($"Không tìm thấy ký tự '{letter}' trong ma trận.");
        }
    }
}