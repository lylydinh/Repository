// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace GencodeFromDatabase
{

    // Student
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
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
        public string Email { get; set; } // Email (length: 500)

        public Student()
        {
            DateOfBirth = System.DateTime.Now;
        }
    }

}
// </auto-generated>