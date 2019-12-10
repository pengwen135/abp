using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shadow.Blog.Data;
using Volo.Abp.DependencyInjection;

namespace Shadow.Blog.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreBlogDbSchemaMigrator 
        : IBlogDbSchemaMigrator, ITransientDependency
    {
        private readonly BlogMigrationsDbContext _dbContext;

        public EntityFrameworkCoreBlogDbSchemaMigrator(BlogMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}