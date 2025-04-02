using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedVine.Areas.Identity.Data;
using RedVine.Models;

namespace RedVine.Data;

public class RedVineContext : IdentityDbContext<RedVineUser>
{
    public RedVineContext(DbContextOptions<RedVineContext> options)
        : base(options)
    {
    }

    public DbSet<Tags> Tags { get; set; }
    public DbSet<UserPost> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<GroupChat> GroupChats { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
