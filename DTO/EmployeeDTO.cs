using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    internal class EmployeeDTO
    {
        [DisplayName("Mã NV")]
        public long EmployeeId { get; set; }

        [DisplayName("Tên")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Họ")]
        public string LastName { get; set; } = null!;

        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Giới tính")]
        public string Gender { get; set; } = null!;

        [DisplayName("Email")]
        public string EmployeeEmail { get; set; } = null!;

        [DisplayName("Số điện thoại")]
        public string EmployeePhone { get; set; } = null!;

        [DisplayName("Địa chỉ")]
        public string EmployeeAddress { get; set; } = null!;

        [DisplayName("Chức vụ")]
        public string RoleName { get; set; } = null!;

        [DisplayName("Ngày vào làm")]
        public DateTime HireDate { get; set; }
    }
}
