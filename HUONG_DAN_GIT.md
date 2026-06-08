# 📘 Hướng dẫn Git cơ bản (cho người mới)

> Git = công cụ "lưu lịch sử code". Mỗi lần lưu gọi là 1 **commit** (như 1 mốc save game).
> GitHub = nơi cất các commit đó lên mạng (sao lưu + chia sẻ).
>
> Repo của bạn: https://github.com/nguyenthehan-learn/Learn-CSharp

---

## 🔁 Việc làm thường xuyên nhất: Lưu code lên GitHub

Mỗi khi học xong 1 bài / sửa xong code, mở Terminal trong thư mục `C#` rồi gõ 3 lệnh:

```bash
git add .
git commit -m "Mô tả ngắn việc vừa làm"
git push
```

| Lệnh                  | Ý nghĩa dễ hiểu                                                |
| --------------------- | -------------------------------------------------------------- |
| `git add .`           | Chọn **tất cả** thay đổi để chuẩn bị lưu (dấu `.` = "mọi thứ") |
| `git commit -m "..."` | Đóng gói thành 1 mốc lưu, kèm lời nhắn mô tả                   |
| `git push`            | Đẩy mốc lưu đó lên GitHub                                      |

---

## 🔍 Các lệnh xem thông tin (an toàn, không thay đổi gì)

```bash
git status        # Xem file nào đã sửa / đã add / chưa add
git log --oneline # Xem lịch sử các commit (mỗi dòng 1 commit)
git diff          # Xem chi tiết mình đã sửa gì so với lần lưu trước
```

> 💡 Khi bối rối "không biết git đang ở đâu", cứ gõ `git status` đầu tiên. Nó luôn gợi ý bước tiếp theo.

---

## ↩️ Lỡ tay? Cách hoàn tác

| Tình huống                                      | Lệnh cứu                        | Giải thích                                                    |
| ----------------------------------------------- | ------------------------------- | ------------------------------------------------------------- |
| Lỡ sửa 1 file, muốn vứt bỏ thay đổi chưa commit | `git restore tên-file`          | Quay file đó về bản đã commit gần nhất                        |
| Lỡ `git add` file mà chưa muốn lưu              | `git restore --staged tên-file` | Bỏ file ra khỏi "danh sách chuẩn bị lưu" (KHÔNG mất nội dung) |
| Muốn vứt bỏ thay đổi của TẤT CẢ file            | `git restore .`                 | ⚠️ Cẩn thận: mất hết sửa đổi chưa commit                      |

> ⚠️ Các lệnh `restore` làm **mất thay đổi chưa commit** và không lấy lại được.
> Còn những gì đã `commit` rồi thì luôn an toàn — luôn tìm lại được qua `git log`.

---

## 🧠 Phân biệt 3 "khu vực" của Git (hiểu cái này là hiểu Git)

```
   [ Thư mục làm việc ]      [ Staging (chờ lưu) ]      [ Repo (đã lưu) ]
        file bạn sửa   --add-->    git add .     --commit-->   git commit
                                                                   |
                                                                 push
                                                                   v
                                                              [ GitHub ]
```

1. Bạn **sửa file** → nó nằm ở "Thư mục làm việc".
2. `git add` → đưa file vào "Staging" (vùng chờ, đã chọn để lưu).
3. `git commit` → chính thức lưu thành 1 mốc trong lịch sử.
4. `git push` → gửi các mốc đó lên GitHub.

---

## ✅ Mẹo cho người mới

- Cứ **commit thường xuyên** (mỗi khi xong 1 việc nhỏ), đừng đợi gom 1 lúc.
- Lời nhắn commit nên **ngắn gọn, rõ ràng**: "Hoc xong bai 2", "Sua loi vong lap"...
- Khi rối → gõ `git status`, đọc gợi ý của nó.
- Đã `commit` thì gần như không bao giờ mất code. Yên tâm thử nghiệm!
