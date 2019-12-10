﻿using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Shadow.Blog.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BlogHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BlogConsoleApiClientModule : AbpModule
    {
        
    }
}
