using System.ComponentModel.DataAnnotations;

namespace ApiSQLPlatzi.Models
{
    public class Contacts
    {
        [Key]
        public int Identificador { get; set; }  
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

    }
}