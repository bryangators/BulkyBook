using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Categorycs
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        #endregion

    }
}
