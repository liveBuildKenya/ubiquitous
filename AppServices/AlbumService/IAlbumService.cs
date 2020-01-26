using System.Collections.Generic;
using AppDomain.Models;

namespace AppServices.AlbumService
{
    /// <summary>
    /// Represent the album service interface
    /// </summary>
    public interface IAlbumService
    {
        #region Album

        /// <summary>
        /// Deletes an album
        /// </summary>
        /// <param name="album">Album</param>
        void DeleteAlbum(Album album);

        /// <summary>
        /// Gets an album by identifier
        /// </summary>
        /// <param name="albumId">Album identifier</param>
        /// <returns>Album</returns>
        Album GetAlbumById(int albumId);

        /// <summary>
        /// Gets albums by identifiers
        /// </summary>
        /// <param name="albumIds">Album identifiers array</param>
        /// <returns>Album list</returns>
        IList<Album> GetAlbumsByIds(int[] albumIds);

        /// <summary>
        /// Gets albums
        /// </summary>
        /// <returns>Album list</returns>
        IList<Album> GetAllAlbums();

        /// <summary>
        /// Inserts an album
        /// </summary>
        /// <param name="album">Album</param>
        void InsertAlbum(Album album);

        /// <summary>
        /// Updates an album
        /// </summary>
        /// <param name="album"></param>
        void UpdateAlbum(Album album);

        #endregion

        #region Song

        /// <summary>
        /// Gets all songs from an album
        /// </summary>
        /// <param name="albumId">Album identifier</param>
        /// <returns>Song</returns>
        IList<Song> GetAllSongs(int albumId);

        /// <summary>
        /// Gets a song by identifier
        /// </summary>
        /// <param name="songId">Song identifier</param>
        /// <returns></returns>
        Song GetSongById(int songId);

        /// <summary>
        /// Gets songs by identifiers
        /// </summary>
        /// <param name="songIds">Song identifiers array</param>
        /// <returns></returns>
        IList<Song> GetSongsByIds(int[] songIds);

        /// <summary>
        /// Deletes a song
        /// </summary>
        /// <param name="song">Song</param>
        void DeleteSong(Song song);

        #endregion
    }
}