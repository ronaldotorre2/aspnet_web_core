using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.model.People
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdAddress", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo", AutoGenerateFilter = false)]
        [Column("TypeId", TypeName = "int")]
        public int Type { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Endereço", AutoGenerateFilter = false)]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(6)]
        [Display(Name = "Número", AutoGenerateFilter = false)]
        [Column("Number")]
        public string Number { get; set; }

        [MaxLength(100)]
        [Display(Name = "Complemento", AutoGenerateFilter = false)]
        [Column("Complement")]
        public string Complement { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Bairro", AutoGenerateFilter = false)]
        [Column("District")]
        public string District { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Cidade", AutoGenerateFilter = false)]
        [Column("City")]
        public string City { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Estado", AutoGenerateFilter = false)]
        [Column("State")]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "CEP", AutoGenerateFilter = false)]
        [Column("ZipCode")]
        public string ZipCode { get; set; }

        [Required]
        [Column("AddDate", TypeName = "datetime")]
        public DateTime AddDate { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("AddUser")]
        public string AddUser { get; set; }

        [Column("UpdateDate", TypeName = "datetime")]
        public DateTime? EditDate { get; set; }

        [Column("UpdateUser")]
        public string EditUser { get; set; }

        public Address() { }

    }
}