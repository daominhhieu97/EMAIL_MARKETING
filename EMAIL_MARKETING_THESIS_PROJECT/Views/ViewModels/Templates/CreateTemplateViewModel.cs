using Microsoft.AspNetCore.Http;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Templates
{
    public class CreateTemplateViewModel
    {
        public string Name { get; set; }

        public IFormFile File { get; set; }
    }
}