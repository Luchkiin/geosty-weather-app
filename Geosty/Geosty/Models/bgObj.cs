namespace Geosty.Models
{
    /// <summary>
    /// Defines the <see cref="BackgroundInfo" />
    /// </summary>
    public class BackgroundInfo
    {
        /// <summary>
        /// Gets or sets the total_results
        /// </summary>
        public int total_results { get; set; }

        /// <summary>
        /// Gets or sets the page
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// Gets or sets the per_page
        /// </summary>
        public int per_page { get; set; }

        /// <summary>
        /// Gets or sets the photos
        /// </summary>
        public Photo[] photos { get; set; }

        /// <summary>
        /// Gets or sets the next_page
        /// </summary>
        public string next_page { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Photo" />
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the width
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Gets or sets the height
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Gets or sets the url
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Gets or sets the photographer
        /// </summary>
        public string photographer { get; set; }

        /// <summary>
        /// Gets or sets the photographer_url
        /// </summary>
        public string photographer_url { get; set; }

        /// <summary>
        /// Gets or sets the photographer_id
        /// </summary>
        public string photographer_id { get; set; }

        /// <summary>
        /// Gets or sets the src
        /// </summary>
        public Src src { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether liked
        /// </summary>
        public bool liked { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Src" />
    /// </summary>
    public class Src
    {
        /// <summary>
        /// Gets or sets the original
        /// </summary>
        public string original { get; set; }

        /// <summary>
        /// Gets or sets the large2x
        /// </summary>
        public string large2x { get; set; }

        /// <summary>
        /// Gets or sets the large
        /// </summary>
        public string large { get; set; }

        /// <summary>
        /// Gets or sets the medium
        /// </summary>
        public string medium { get; set; }

        /// <summary>
        /// Gets or sets the small
        /// </summary>
        public string small { get; set; }

        /// <summary>
        /// Gets or sets the portrait
        /// </summary>
        public string portrait { get; set; }

        /// <summary>
        /// Gets or sets the landscape
        /// </summary>
        public string landscape { get; set; }

        /// <summary>
        /// Gets or sets the tiny
        /// </summary>
        public string tiny { get; set; }
    }
}