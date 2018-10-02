using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.model.People
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPerson", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo", AutoGenerateFilter = false)]
        [Column("TypePerson", TypeName = "int")]
        public int Type { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nome", AutoGenerateFilter = false)]
        [Column("Name")]
        public string Name { get; set; }

        [MaxLength(100)]
        [Display(Name = "Razão Social", AutoGenerateFilter = false)]
        [Column("SocialName")]
        public string SocialName { get; set; }

        [Display(Name = "Gênero", AutoGenerateFilter = false)]
        [Column("Gender", TypeName = "int")]
        public int Gender { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Nascimento", AutoGenerateFilter = false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Column("BirthDate", TypeName = "date")]
        public DateTime? Birthdate { get; set; }

        [Required]
        [MaxLength(25)]
        [Display(Name = "CPF/CNPJ", AutoGenerateFilter = false)]
        [Column("Document1")]
        public string Document1 { get; set; }

        [MaxLength(25)]
        [Display(Name = "RG / IE.", AutoGenerateFilter = false)]
        [Column("Document2")]
        public string Document2 { get; set; }

        [MaxLength(25)]
        [Display(Name = "Insc.Mun.", AutoGenerateFilter = false)]
        [Column("Document3")]
        public string Document3 { get; set; }

        [Display(Name = "Nome da Mãe", AutoGenerateFilter = false)]
        [Column("MotherName")]
        public string MotherName { get; set; }

        [Display(Name = "Nome do Pai", AutoGenerateFilter = false)]
        [Column("FatherName")]
        public string FatherName { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [Required]
        [Column("AddressId", TypeName = "int")]
        public int AddressId { get; set; }

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

        public virtual List<Contact> Contacts { get; set; }

        public Person() { }

    }
}