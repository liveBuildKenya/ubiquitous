using System;
using System.Collections.Generic;
using System.Linq;
using AppDomain.Models;
using AppSeed.Infrastructure.Data;

namespace AppServices
{
    public partial class AlbumService : IAlbumService
    {
        #region Fields

        private readonly IRepository<Album> _albumRepository;
        private readonly IRepository<Song> _songRepository;
        
        #endregion

        #region Ctor

        public AlbumService(IRepository<Album> albumRepository,
        IRepository<Song> songRepository)
        {
            this._albumRepository = albumRepository;
            this._songRepository = songRepository;
        }

        #endregion

        #region Albums

        /// <summary>
        /// Deletes an album
        /// </summary>
        /// <param name="album">Album</param>
        public virtual void DeleteAlbum(Album album)
        {
            if (album == null)
                throw new ArgumentNullException(nameof(album));
            
            _albumRepository.Delete(album);
        }

        /// <summary>
        /// Gets an album by identifier
        /// </summary>
        /// <param name="albumId">Album identifier</param>
        /// <returns>Album</returns>
        public virtual Album GetAlbumById(int albumId)
        {
            if (albumId == 0)
                return null;

            return _albumRepository.GetById(albumId);
        }        

        /// <summary>
        /// Deletes a song
        /// </summary>
        /// <param name="song">Song</param>
        public virtual void DeleteSong(Song song)
        {
            if (song == null)
                throw new ArgumentNullException(nameof(song));

            _songRepository.Delete(song);
        }

        /// <summary>
        /// Gets albums by identifiers
        /// </summary>
        /// <param name="albumIds">Album identifiers</param>
        /// <returns>Albums</returns>
        public virtual IList<Album> GetAlbumsByIds(int[] albumIds)
        {
            if (albumIds == null || albumIds.Length == 0)
                return new List<Album>();

            var query = from a in _albumRepository.Table
                        where albumIds.Contains(a.Id)
                        select a;
            
            var albums = query.ToList();

            var sortedAlbums = new List<Album>();
            foreach (var id in albumIds)
            {
                var album = albums.Find(x => x.Id == id);
                if (album != null)
                    sortedAlbums.Add(album);
            }

            return sortedAlbums;
        }

        /// <summary>
        /// Gets all albums
        /// </summary>
        /// <returns>Albums list</returns>
        public virtual IList<Album> GetAllAlbums()
        {
            var query = _albumRepository.Table;
            return query.ToList();
        }

        /// <summary>
        /// Inserts an album
        /// </summary>
        /// <param name="album">Album</param>
        public virtual void InsertAlbum(Album album)
        {
            if (album == null)
                throw new ArgumentNullException(nameof(album));

            _albumRepository.Insert(album);
        }

        /// <summary>
        /// Updates an album
        /// </summary>
        /// <param name="album">Album</param>
        public virtual void UpdateAlbum(Album album)
        {
            if (album == null)
                throw new ArgumentNullException(nameof(album));

            _albumRepository.Update(album);
        }

        #endregion

        #region Song

        /// <summary>
        /// Gets all songs in an album
        /// </summary>
        /// <param name="albumId">Album identifier</param>
        /// <returns></returns>
        public virtual IList<Song> GetAllSongs(int albumId)
        {
            var query = _songRepository.Table;

            query = query.Where(song => song.AlbumId == albumId);

            return query.ToList();
        }
        /// <summary>
        /// Gets a song by identifier
        /// </summary>
        /// <param name="songId">Song identifier</param>
        /// <returns>Song</returns>
        public virtual Song GetSongById(int songId)
        {
            if (songId == 0)
                return null;

            return _songRepository.GetById(songId);
        }

        /// <summary>
        /// Get songs by identifiers
        /// </summary>
        /// <param name="songIds"></param>
        /// <returns></returns>
        public IList<Song> GetSongsByIds(int[] songIds)
        {
            if (songIds == null || songIds.Length == 0)
                return new List<Song>();

            var query = from nc in _songRepository.Table
                        where songIds.Contains(nc.Id)
                        select nc;
            var songs = query.ToList();
            //sort by passed identifiers
            var sortedSongs = new List<Song>();
            foreach (var id in songIds)
            {
                var song = songs.Find(x => x.Id == id);
                if (song != null)
                    sortedSongs.Add(song);
            }

            return sortedSongs;
        }

        #endregion
    }
}