using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppApi.Factories;
using AppApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        #region Fields

        private readonly IAlbumFactory _albumFactory;
        private readonly ILogger<AlbumController> _logger; 
        
        #endregion

        #region Ctor

        public AlbumController(IAlbumFactory albumFactory,
        ILogger<AlbumController> logger)
        {
            this._albumFactory = albumFactory;
            this._logger = logger;
        }

        #endregion

        #region Methods

        [HttpPost]
        public void CreateAlbum(AlbumModel albumModel)
        {
            _albumFactory.CreateAlbum(albumModel);
            _logger.LogInformation("[0] album created", albumModel.Name);
        }

        [HttpGet("{id}")]
        public AlbumModel GetAlbum(int id)
        {
            var album = _albumFactory.GetAlbumById(id);

            if (album != null)
            {
                _logger.LogInformation("[0] album found", album.Name);
            }

            return album;
        }


        #endregion
    }
}