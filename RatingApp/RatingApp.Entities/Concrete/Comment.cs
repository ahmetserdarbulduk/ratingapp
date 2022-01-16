using General.Core.Entities;

namespace RatingApp.Entities.Concrete{
    public class Comment:IEntity{
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}