using AppSeed;

namespace AppDomain.Models
{
    /// <summary>
    /// Represents a song
    /// </summary>
    public partial class Song : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get;set; }

        /// <summary>
        /// Gets or sets the artist
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets the buy count
        /// </summary>
        public string BuyCount { get; set; }

        /// <summary>
        /// Gets or sets the time
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the album
        /// </summary>
        public Album Album { get; set; }

        /// <summary>
        /// Represents an album identifer
        /// </summary>
        /// <value></value>
        public int AlbumId { get; set; }
    }
}