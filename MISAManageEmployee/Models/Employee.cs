namespace MISAManageEmployee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeCode { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20)]
        public string GenderName { get; set; }

        public int UnitID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(20)]
        public string CMNDNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CMNDDate { get; set; }

        [StringLength(100)]
        public string CMNDAddress { get; set; }

        [StringLength(100)]
        public string TitleProfessional { get; set; }

        [StringLength(100)]
        public string EmployeeAddress { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string PhoneLandline { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string BankAccount { get; set; }

        [StringLength(100)]
        public string BankName { get; set; }

        [StringLength(100)]
        public string BankBranch { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
