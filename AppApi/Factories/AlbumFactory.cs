using AppApi.Models;
using AppDomain.Models;
using AppServices.Service;
using AutoMapper;

namespace AppApi.Factories
{
    public class AlbumFactory : IAlbumFactory
    {
        #region Fields

        private readonly IAlbumService _albumService;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public AlbumFactory(IAlbumService albumService,
        IMapper mapper)
        {
            this._albumService = albumService;
            this._mapper = mapper;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an album by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AlbumModel GetAlbumById(int id)
        {
            var album = _albumService.GetAlbumById(id);
            var albumModel = _mapper.Map<AlbumModel>(album);
            return albumModel;
        }

        /// <summary>
        /// Creates an album
        /// </summary>
        /// <param name="albumModel"></param>
        public void CreateAlbum(AlbumModel albumModel)
        {
            var album = _mapper.Map<Album>(albumModel);
            _albumService.InsertAlbum(album);
        }

        #endregion
    }
}