namespace ImageService
{
    public class WebsiteRenderer
    {
        private ImageService _imageService;
        private PageService _pageService;

        public WebsiteRenderer(ImageService imageService, PageService pageService)
        {
            _imageService = imageService;
            _pageService = pageService;
        }

        public string Render(int customerId, int pageId)
        {
            // page contains an id - get the url
            int imageId = 123;

            var imageUrl = _imageService.GetImageUrl(customerId, imageId);

            return imageUrl;
        }
    }
}