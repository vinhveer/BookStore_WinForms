using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    internal class ProductDTO
    {
        [DisplayName("Mã sách")]
        public long BookId { get; set; }

        [DisplayName("Tên sách")]
        public string BookName { get; set; } = null!;

        [DisplayName("Đơn vị")]
        public string Unit { get; set; } = null!;

        [DisplayName("Số lượng tồn")]
        public int StockQuantity { get; set; }

        [DisplayName("Giá")]
        public decimal Price { get; set; }

        [DisplayName("Ngày xuất bản")]
        public DateTime PublicationDate { get; set; }

        [DisplayName("Hình ảnh")]
        public string BookImage { get; set; } = null!;

        [DisplayName("Tác giả")]
        public string AuthorName { get; set; } = null!;

        [DisplayName("Nhà cung cấp")]
        public string SupplierName { get; set; } = null!;

        [DisplayName("Danh mục")]
        public string CategoryName { get; set; } = null!;
    }
}
