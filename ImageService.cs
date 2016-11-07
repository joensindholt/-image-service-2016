using System.IO;

namespace ImageService
{
    public class ImageService
    {
        private S3ImageBucket _s3ImageBucket;

        public ImageService(S3ImageBucket s3ImageBucket)
        {
            _s3ImageBucket = s3ImageBucket;
        }

        public void AddImage(int customerId, int imageId, Stream imageStream)
        {
            string path = GetImagePath(customerId, imageId);
            _s3ImageBucket.Put(path, imageStream);
        }

        public void DeleteImage(int customerId, int imageId)
        {
            string path = GetImagePath(customerId, imageId);
            _s3ImageBucket.Delete(path);
        }

        public string GetImageUrl(int customerId, int imageId)
        {
            CustomerImageUrl imageUrl = new CustomerImageUrl(customerId, imageId);
            return imageUrl.Url;
        }

        private string GetImagePath(int customerId, int imageId)
        {
            return $"/{customerId}/{imageId}";
        }
    }
}