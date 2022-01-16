using General.Core.Entities;

namespace RatingApp.Entities.Dtos{
    public class ProductDetailDto:IDto{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}