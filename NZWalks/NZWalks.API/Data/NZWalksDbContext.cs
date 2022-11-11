using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksDBContext: DbContext
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options) : base(options)
        {

        }

    }
}
