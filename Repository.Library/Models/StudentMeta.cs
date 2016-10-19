using System;

namespace Repository.Library.Models
{
    public class StudentMeta
    {
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// Ten sinh vien
        ///</summary>
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Dia chi
        ///</summary>
        public string Address { get; set; } // Address (length: 500)

        ///<summary>
        /// So dien thoai
        ///</summary>
        public string Phone { get; set; } // Phone (length: 50)

        ///<summary>
        /// Ngay sinh
        ///</summary>
        public DateTime? DateOfBirth { get; set; } // DateOfBirth

        public string Email { get; set; } // Email (length: 500)
    }
}