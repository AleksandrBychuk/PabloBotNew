using Microsoft.EntityFrameworkCore;

namespace Admin.Models
{
    public class BotContext : DbContext
    {
        public BotContext(DbContextOptions options) : base(options)
        {
        }
    }
}
