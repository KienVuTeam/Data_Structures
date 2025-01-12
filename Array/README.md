# Array

## DN: (Key: cùng kiểu + nhanh + liền kề)
    `Là một Data Structure tuyến tính, dùng để lưu một tập các phần tử cùng kiểu dữ liệu,
    lưu ở vị trí bộ nhớ liên tiếp nhau! .... việc truy cập phần tử thông qua chỉ số "index"`

## Nguyên lý
- Các phần tử được lưu liên tiếp trong vị trí bộ nhớ
- Mỗi phần tử được truy cập thông qua index bắt đầu từ 0.
- Công thức truy cập phần tử: `địa chỉ = địa chỉ ban đầu + vị trí(index) * Kích thước(độ rộng của phần tử)`

## Cách hoạt động (CRUD)
Tự mò đi :>

## Ưu nhược điểm của Array
### Ưu điểm:
- Truy cập nhanh: Truy cập bất kỳ phần tử nào với thời gian O(1).
- Dễ sử dụng: Cách tổ chức đơn giản và được hỗ trợ rộng rãi trong các ngôn ngữ lập trình.
### Nhược điểm:
- Kích thước cố định: Không thể thay đổi kích thước sau khi khởi tạo (với mảng tĩnh).
- Chèn và xóa kém hiệu quả:
    + Chèn phần tử ở giữa hoặc đầu: O(n) vì cần dời các phần tử khác.
    + Xóa phần tử cũng tốn O(n).
- Tốn bộ nhớ: Bộ nhớ phải được cấp phát liên tiếp, khó sử dụng trong bộ nhớ phân mảnh.

## Ứng dụng của mảng
* Lưu trữ dữ liệu: Dùng trong các bài toán đơn giản.
* Xây dựng các cấu trúc dữ liệu khác: Dùng làm nền tảng cho danh sách liên kết, hàng đợi, ngăn xếp.
* Thuật toán xử lý dữ liệu: Như sắp xếp (sort), tìm kiếm (search).