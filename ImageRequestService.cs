namespace ImageService
{
    public class ImageRequestService
    {
        private S3ImageBucket _s3ImageBucket;

        public ImageRequestService(S3ImageBucket s3ImageBucket)
        {
            _s3ImageBucket = s3ImageBucket;
        }

        public byte[] GetImageBytes(string url)
        {
            // Using the url convert a typed representation of the url for easy access to customer id and image id
            CustomerImageUrl imageUrl = new CustomerImageUrl(url);

            // Get the image bytes from S3
            byte[] bytes = _s3ImageBucket.GetImageBytes(imageUrl.CustomerId, imageUrl.ImageId);

            // Return the bytes
            return bytes;
        }
    }
}