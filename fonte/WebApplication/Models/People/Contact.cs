using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.model.People
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdContact", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pessoa Id", AutoGenerateFilter = false)]
        [Column("PersonId", TypeName = "int")]
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "Tipo", AutoGenerateFilter = false)]
        [Column("TypeId", TypeName = "int")]
        public int Type { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descrição", AutoGenerateFilter = false)]
        [Column("Description")]
        public string Description { get; set; }

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

        public Contact() { }

    }
}