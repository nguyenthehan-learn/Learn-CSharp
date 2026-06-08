// ============================================
// BÀI 2: BIẾN & KIỂU DỮ LIỆU
// ============================================
// BIẾN (variable) = một "cái hộp" có tên, dùng để LƯU dữ liệu.
// Trong game: máu nhân vật, điểm số, tên người chơi... đều là biến.
//
// Cú pháp khai báo biến:   <kiểu>  <tên> = <giá trị>;
//
// 📛 QUY ƯỚC ĐẶT TÊN BIẾN trong C# (rất quan trọng, theo cho quen):
//   - Dùng tiếng Anh, KHÔNG dấu, KHÔNG khoảng trắng.
//   - Kiểu "camelCase": chữ đầu thường, mỗi từ sau viết hoa chữ cái đầu.
//     Ví dụ:  health , moveSpeed , playerName , isAlive
//   - Tên nên có nghĩa, nói lên nó chứa gì. Tránh đặt a, b, x1...
// ============================================


// --- 1. SỐ NGUYÊN: int (không có phần thập phân) ---
int health = 100;          // máu nhân vật
int score = 0;             // điểm số
Console.WriteLine("Health: " + health);
Console.WriteLine("Score: " + score);


// --- 2. SỐ THỰC: float (có phần thập phân) ---
// Lưu ý: số float trong C# PHẢI có chữ 'f' ở cuối. Đây là đặc trưng quan trọng,
// và trong Unity bạn sẽ dùng float cực nhiều (tốc độ, vị trí, thời gian...).
float moveSpeed = 5.5f;    // tốc độ di chuyển
float deltaTime = 0.016f;  // thời gian mỗi khung hình
Console.WriteLine("Move speed: " + moveSpeed);
Console.WriteLine("Delta time: " + deltaTime);


// --- 3. CHUỖI: string (đoạn văn bản) ---
// Luôn nằm trong dấu nháy kép " "
string playerName = "Han";
Console.WriteLine("Player name: " + playerName);


// --- 4. LUẬN LÝ: bool (chỉ nhận true HOẶC false) ---
// Dùng cho các trạng thái đúng/sai: còn sống? đã mở khóa? đang nhảy?
// Quy ước: tên biến bool thường bắt đầu bằng "is", "has", "can"...
bool isAlive = true;
bool hasWonGame = false;
Console.WriteLine("Is alive? " + isAlive);
Console.WriteLine("Has won game? " + hasWonGame);


// --- 5. KÝ TỰ ĐƠN: char (đúng 1 ký tự, dùng nháy ĐƠN ' ') ---
char rank = 'A';
Console.WriteLine("Rank: " + rank);


Console.WriteLine("------------------------------------");


// --- 6. BIẾN CÓ THỂ THAY ĐỔI GIÁ TRỊ ---
// Đã khai báo rồi thì gán lại KHÔNG cần ghi kiểu nữa.
health = health - 30;      // nhân vật bị trừ 30 máu
Console.WriteLine("Bị đánh! Health còn: " + health);   // 70

score = score + 10;        // ăn điểm
Console.WriteLine("Ăn vàng! Score: " + score);         // 10


// --- 7. CÁCH IN ĐẸP HƠN: dùng $ (string nội suy / interpolation) ---
// Đặt chữ $ trước nháy kép, rồi nhét biến vào trong { }. Gọn hơn nhiều dấu +.
Console.WriteLine($"Nhân vật {playerName} có {health} máu và {score} điểm.");


// ============================================
// 🏋️ BÀI TẬP — hãy tự làm rồi chạy "dotnet run":
// (nhớ đặt tên biến bằng tiếng Anh, kiểu camelCase!)
// ============================================
// 1) Tạo biến string tên là "gameName" chứa tên game bạn muốn làm, rồi in ra.
// 2) Tạo biến int "lives" = 3 (số mạng). In ra. Sau đó trừ đi 1 mạng rồi in lại.
// 3) Tạo biến float "damage" = 12.5f. In ra bằng cú pháp $ "...{damage}...".

string gameName = "HanNT";
Console.WriteLine($"Xin chào {gameName}.");
int lives = 3;
Console.WriteLine($"Bạn có: {lives} mạng.");
float damage = 12.5f;
lives = lives - 1;
Console.WriteLine($"Nhân vật {gameName} nhận {damage} damage.Số mạng còn lại: {lives}");