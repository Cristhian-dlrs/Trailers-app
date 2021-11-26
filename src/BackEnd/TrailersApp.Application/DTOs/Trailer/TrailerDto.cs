using TrailersApp.Core.Enums;

namespace TrailersApp.Application.DTOs.Trailer
{
    public class TrailerDto : ITrailerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverSrc { get; set; }
        public string ReleaseYear { get; set; }
        public string Duration { get; set; }
        public Category Catetgory { get; set; }
        public string Descrioption { get; set; }
        public string Url { get; set; }
    }
}