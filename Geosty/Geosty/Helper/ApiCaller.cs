namespace Geosty.Helper
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="ApiCaller" />
    /// </summary>
    public class ApiCaller
    {
        /// <summary>
        /// The Get
        /// </summary>
        /// <param name="url">The url<see cref="string"/></param>
        /// <param name="authId">The authId<see cref="string"/></param>
        /// <returns>The <see cref="Task{ApiResponse}"/></returns>
        public static async Task<ApiResponse> Get(string url, string authId = null)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(authId))
                    client.DefaultRequestHeaders.Add("Authorization", authId);

                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                {
                    return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
                }
                else
                    return new ApiResponse { ErrorMessage = request.ReasonPhrase };
            }
        }
    }

    /// <summary>
    /// Defines the <see cref="ApiResponse" />
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Gets a value indicating whether Successful
        /// </summary>
        public bool Successful => ErrorMessage == null;

        /// <summary>
        /// Gets or sets the ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the Response
        /// </summary>
        public string Response { get; set; }
    }
}