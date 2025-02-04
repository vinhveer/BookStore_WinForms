using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    internal class CategoryDTO
    {
        [DisplayName("Mã danh mục")]
        public long CategoryId { get; set; }

        [DisplayName("Tên danh mục")]
        public string CategoryName { get; set; } = null!;
    }
}
