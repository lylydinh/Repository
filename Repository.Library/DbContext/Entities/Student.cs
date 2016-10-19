namespace Repository.Library.DbContext.Entities
{
    public class Student
    {
        ///<summary>
        /// Ma sinh vien
        ///</summary>
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
        public System.DateTime? DateOfBirth { get; set; } // DateOfBirth

        public string Email { get; set; }
        // Email (length: 500) 
        ///<summary>
        /// Ngay khoi tao
        ///</summary>
        public System.DateTime? CreateDate { get; set; } // CreateDate

        ///<summary>
        /// Ngay chinh sua
        ///</summary>
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public bool? IsDelete { get; set; } // IsDelete

        public Student()
        {
            DateOfBirth = System.DateTime.Now;
            IsDelete = false;
            CreateDate = System.DateTime.Now;
            UpdateDate = System.DateTime.Now;
        }
    }
}