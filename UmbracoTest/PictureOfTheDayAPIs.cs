namespace UmbracoTest
{
    public class Root
    {
        public string copyright { get; set; }
        public string date { get; set; }
        public string explanation { get; set; }
        public string hdurl { get; set; }
        public string media_type { get; set; }
        public string service_version { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
    public class PictureOfTheDayAPIs
    {
        public async Task<Root> GetDailyPictureAsync()
        {
            HttpClient client = new HttpClient();
            Root? root = await client.GetFromJsonAsync<Root>("https://api.nasa.gov/planetary/apod?api_key=6XjrL3sPzhM0mLNEor0Xxcr3n4CBI0g3W3gWDTqD");

            return root;
        }
    }
}