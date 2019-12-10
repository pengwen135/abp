using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Shadow.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Shadow.Blog.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Shadow.Blog.Web.Pages.BlogPage
     */
    public abstract class BlogPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<BlogResource> L { get; set; }
    }
}
