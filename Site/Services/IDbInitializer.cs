using Site.Data;
using System.Threading.Tasks;

namespace Site.Services
{
    public interface IDbInitializer
    {
        Task Initialize(ApplicationDbContext context);
    }
}
