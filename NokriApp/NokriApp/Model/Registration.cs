using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NokriApp.Model
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string Name { get; set; } = "";

        [Column(TypeName = "nvarchar(80)")]
        public string Email { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; } = "";

        public string UserType { get; set; } = ""; // "Employer" or "Candidate"

        //[NotMapped]
        public bool AgreementChecked { get; set; }
    }
}
