using System;
using AppDomain.Models;
using AppSeed.Infrastructure.Data;
using AppServices.Service;
using Moq;
using Xunit;

namespace Service.Tests
{
    public class AlbumServiceTest
    {
        [Fact]
        public void AlbumService_Given_Album_Id_Should_Get_Album()
        {
            var album = new Album() {
                Id = 1,
                Name = "Name"
            };

            var albumRepositoryMock = new Mock<IRepository<Album>>();
            var songReposistoryMock = new Mock<IRepository<Song>>();

            albumRepositoryMock.Setup(m => m.GetById(1)).Returns(album).Verifiable();

            var albumService = new AlbumService(albumRepositoryMock.Object, songReposistoryMock.Object);

            var actual = albumService.GetAlbumById(1);

            albumRepositoryMock.Verify();
            Assert.NotNull(actual);
            Assert.Equal("Name", actual.Name);
        }
    }
}
