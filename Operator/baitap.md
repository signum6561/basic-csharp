# Bài tập về toán tử
---
**1.** Nhập vào bán kính `r`. Tính `chu vi`, `diện tích` của hình tròn.

**2.** Nhập vào 2 số thực `a`, `b`. Tính `a + b`, `a - b`, `a * b`, `a / b`, `a % b`.

**3.** Nhập `tên sản phẩm`, `số lượng`, `đơn giá`. Tính `tiền` và `thuế giá trị gia tăng`. Biết:
- tiền = số lượng * đơn giá
- thuế giá trị gia tăng = 10% tiền

**4.** Nhập điểm thi 3 môn Toán, Lý, Hóa của một. Tính `điểm trung bình` của sinh viên đó.

**5.** Nhập vào `cạnh kề` và `cạnh đối`. Tính cạnh huyền của tam giác vuông.

**6.** Nhập vào thứ `t` và `k` ngày. Hãy cho biết sau `k` ngày là thứ mấy?
```
Input
2 7 
Output
2

// Giải thích
// Thứ 2, sau 7 ngày thì sẽ là thứ 2
```
**7.** Nhập vào một `góc` bất kỳ. Cho biết nó thuộc phần tư thứ mấy.
```
92 => 2
37 => 1
187 => 3
365 => 1
```
**8.** Làm tròn số. Nhập vào một số thực `n` bất kì. Hãy in ra màn hình `n` sau khi được làm tròn. Không được dùng Math.Round
```
0.5 => 1
2.7 => 3
12.3 => 12
```
**9.** Nhập vào `m` tiền. Hãy qui đổi ra tờ `50`, `20`, `10`, `5`, `2`, `1`.
```
Input
197
Ouput
3 2 0 1 1 0

// Giải thích
// 197 đổi ra 3 tờ 50, 2 tờ 20, 0 tờ 10, 1 tờ 5, 1 tờ 2, 0 tờ 1
// 197 = 50 * 3 + 20 * 2 + 5 * 1 + 2 * 1
```
**10.** Nhập vào giờ `h`, phút `m`, giây `s`. Tiếp theo nhập vào `k` giây. Sau `k` giây thì giờ phút giây là bao nhiêu?
```
VD1:
Input
6 10 5
9
Ouput
6 10 14

VD2:
Input
8 7 59
1
Ouput
8 8 0

VD3:
Input
23 59 59
5
Ouput
0 0 4
```
**11.** Nhập vào dung tích `l` của chai nước và `k` ml nước. Cần bao nhiêu chai nước để chứa hết `k` ml nước? Hãy cho biết thể tích của chai cuối cùng?
```
VD1:
Input
400 1500 
Output
3 300

VD2:
Input
100 50
Ouput
1 50
```

**12.** Một nhà máy muốn phân loại thịt. Tổng khối lượng số thịt là `m` kg. Từ `m` kg đó, có thể chia thành bao nhiêu sản phẩm thịt mỗi loại?.
| Loại  | Khối lượng |
| :---: | :--------: |
|   1   |   0.25kg   |
|   2   |   0.5kg    |
|   3   |    1kg     |
|   4   |    2kg     |
|   5   |    5kg     |
```
Input
26.75
Output
1 1 1 0 5

// Giải thích
// 26.75kg phân thành 1 loại 1, 1 loại 2, 1 loại 3, 0 loại 4, 5 loại 5
// 26.75 = 5 * 5 + 1 * 3 + 1 * 0.5 + 1 * 0.25
```
**13.** Một lớp có 32 bạn. Mỗi tuần sẽ có 1 bạn được phân công trực lớp theo danh sách STT tăng dần. Giả sử tuần này bạn STT `t` trực lớp. Vậy sau `k` tuần thì người trực lớp có STT là mấy?
```
VD1:
Input
12
3
Ouput
16

Input
31
5
Output
5
```
