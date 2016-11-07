using System;
using System.Text.RegularExpressions;

namespace ImageService
{
    /// <summary>
    /// Image urls a in the format '/images/{customerId}/{imageId}'
    /// </summary>
    public class CustomerImageUrl
    {
        private static Regex _urlRegex = new Regex("http://cdn.simplesite.com/images/(?<customerId>)/(?<imageId>)");

        public string Url { get; private set; }

        public int CustomerId { get; private set; }

        public int ImageId { get; private set; }

        public CustomerImageUrl(string url)
        {
            Url = url;
            ParseUrl(url);
        }

        public CustomerImageUrl(int customerId, int imageId)
        {
            CustomerId = customerId;
            ImageId = imageId;

            Url = $"http://cdn.simplesite.com/images/{customerId}/{imageId}";
        }

        private void ParseUrl(string url)
        {
            var match = _urlRegex.Match(url);

            if (!match.Success)
            {
                throw new Exception("Parsing customer image url was not possible. Check the url. Url was: " + url);
            }

            CustomerId = int.Parse(match.Groups["customerId"].Value);
            ImageId = int.Parse(match.Groups["imageId"].Value);
        }
    }
}