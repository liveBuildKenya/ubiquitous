using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppApi.Factories;
using AppApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        #region Fields

        private readonly IAlbumFactory _albumFactory;
        
        #endregion

        #region Ctor

        public AlbumController(IAlbumFactory albumFactory)
        {
            this._albumFactory = albumFactory;
        }

        #endregion

        #region Methods

        [HttpPost]
        public void CreateAlbum(AlbumModel albumModel)
        {
            _albumFactory.CreateAlbum(albumModel);
        }

        [HttpGet("{id}")]
        public AlbumModel GetAlbum(int id)
        {
            var album = _albumFactory.GetAlbumById(id);

            return album;
        }


        #endregion
    }
}