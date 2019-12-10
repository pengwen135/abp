using System;
using System.Collections.Generic;
using System.Text;
using Shadow.Blog.Localization;
using Volo.Abp.Application.Services;

namespace Shadow.Blog
{
    /* Inherit your application services from this class.
     */
    public abstract class BlogAppService : ApplicationService
    {
        protected BlogAppService()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}
