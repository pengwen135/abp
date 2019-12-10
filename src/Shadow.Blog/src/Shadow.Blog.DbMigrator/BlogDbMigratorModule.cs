﻿using Shadow.Blog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Shadow.Blog.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BlogEntityFrameworkCoreDbMigrationsModule),
        typeof(BlogApplicationContractsModule)
        )]
    public class BlogDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
