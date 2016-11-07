using System;
using System.Web;

namespace ImageService
{
    public class WebsiteBuilder
    {
        private PageService _pageService;

        public WebsiteBuilder(PageService pageService)
        {
            _pageService = pageService;
        }

        public void UploadImage(int customerId, int pageId, Guid imageContainerId, HttpPostedFile file)
        {
            _pageService.AddImageToPage(customerId, pageId, imageContainerId, file.InputStream);
        }
    }
}