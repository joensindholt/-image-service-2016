using System;
using System.IO;

namespace ImageService
{
    public class PageService
    {
        private ImageService _imageService;
        private ImageMetaInformationService _imageMetaInformationService;

        public PageService(ImageService imageService, ImageMetaInformationService imageMetaInformationService)
        {
            _imageService = imageService;
            _imageMetaInformationService = imageMetaInformationService;
        }

        public void AddImageToPage(int customerId, int pageId, Guid imageContainerId, Stream imageStream)
        {
            try
            {
                int imageId = _imageMetaInformationService.RegisterNewImage(customerId);
                UpdateContainerImageId(customerId, pageId, imageContainerId, imageId);
                _imageService.AddImage(customerId, imageId, imageStream);
            }
            catch
            {
                // rollback changes and throw exception for UI
            }
        }

        private void UpdateContainerImageId(int customerId, int pageId, Guid imageContainerId, int imageId)
        {
            // updates page xml with the image id in the corresponding container id
            // and stores it in the database
        }
    }
}