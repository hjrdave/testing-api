using Microsoft.EntityFrameworkCore;
using testing_api.Models;

namespace testing_api.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }

    }
}