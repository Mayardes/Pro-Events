using Microsoft.EntityFrameworkCore;
using Pro_Events.Api.Models;

namespace Pro_Events.Api.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Event> Events { get; set; }
    }
}
