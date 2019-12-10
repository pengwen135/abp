using Shadow.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Shadow.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}