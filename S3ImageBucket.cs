using System;
using System.IO;

namespace ImageService
{
    public class S3ImageBucket
    {
        public void Put(string path, Stream imageStream)
        {
            throw new NotImplementedException();
        }

        public void Delete(string path)
        {
            throw new NotImplementedException();
        }

        public byte[] GetImageBytes(int customerId, int imageId)
        {
            throw new NotImplementedException();
        }
    }
}