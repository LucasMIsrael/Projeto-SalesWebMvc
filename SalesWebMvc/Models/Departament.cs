using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    [Table("AppDepartament")]
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
