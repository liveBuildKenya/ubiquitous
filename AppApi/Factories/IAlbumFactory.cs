using AppApi.Models;

namespace AppApi.Factories
{
    public interface IAlbumFactory
    {
        /// <summary>
        /// Gets an album by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Album</returns>
        AlbumModel GetAlbumById(int id);

        /// <summary>
        /// Creates an album
        /// </summary>
        /// <param name="albumModel">Album</param>
        void CreateAlbum(AlbumModel albumModel);
    }
}