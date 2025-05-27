using PKWalks.API.Models.Domain;

namespace PKWalks.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
