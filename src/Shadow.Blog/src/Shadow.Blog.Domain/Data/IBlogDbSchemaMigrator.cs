using System.Threading.Tasks;

namespace Shadow.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
