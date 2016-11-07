namespace ImageService
{
    public class CloudFront
    {
        private CloudFrontCache _cloudFrontCache;
        private ImageRequestService _imageRequestService;

        public CloudFront(ImageRequestService imageRequestService, CloudFrontCache cloudFrontCache)
        {
            _imageRequestService = imageRequestService;
            _cloudFrontCache = cloudFrontCache;
        }

        public byte[] RequestImage(string url)
        {
            var cachedEntry = _cloudFrontCache.Get(url);

            if (cachedEntry != null)
            {
                return cachedEntry;
            }

            var imageFromImageService = _imageRequestService.GetImageBytes(url);

            _cloudFrontCache.Put(url, imageFromImageService);

            return imageFromImageService;
        }
    }
}