using TrailersApp.Core.Enums;

namespace TrailersApp.Application.DTOs.Trailer
{
    public class TrailersListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverSrc { get; set; }
        public Category Catetgory { get; set; }
    }
}