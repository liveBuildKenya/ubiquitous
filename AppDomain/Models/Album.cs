using System;
using System.Collections.Generic;
using AppSeed;

namespace AppDomain.Models
{
    /// <summary>
    /// Represents an album
    /// </summary>
    public partial class Album : BaseEntity
    {
        private ICollection<Song> _songs;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the artist
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets the itunes reviews
        /// </summary>
        public string ITunesReview { get; set;}

        /// <summary>
        /// Gets or sets the album picture url
        /// </summary>
        public string AlbumPicUrl { get; set; }

        public string Producer { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the release date and time
        /// </summary>
        public DateTimeOffset ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the songs
        /// </summary>
        public virtual ICollection<Song> Songs
        {
            get => _songs ?? (_songs = new List<Song>());
            protected set => _songs = value;
        }
    }
}