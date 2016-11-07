namespace ImageService
{
    public class Client
    {
        private WebsiteBuilder _websiteBuilder;
        private WebsiteRenderer _websiteRenderer;
        private CloudFront _cloudFront;

        public Client(WebsiteBuilder websiteBuilder, WebsiteRenderer websiteRenderer, CloudFront cloudFront)
        {
            _websiteBuilder = websiteBuilder;
            _websiteRenderer = websiteRenderer;
            _cloudFront = cloudFront;
        }
    }
}