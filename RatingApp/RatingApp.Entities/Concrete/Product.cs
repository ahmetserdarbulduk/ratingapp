using General.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace RatingApp.Entities.Concrete{
    public class Product:IEntity{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}