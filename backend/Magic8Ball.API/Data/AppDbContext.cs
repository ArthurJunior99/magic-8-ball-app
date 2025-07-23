using Microsoft.EntityFrameworkCore;
using Magic8Ball.API.models;
using Microsoft.Identity.Client;

namespace Magic8Ball.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MagicAnswer> MagicAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MagicAnswer>().HasData(
                new MagicAnswer { Id = 1, Text = "It is certain.", Type = "Affirmative" },
                new MagicAnswer { Id = 2, Text = "It is decidedly so.", Type = "Affirmative" },
                new MagicAnswer { Id = 3, Text = "Without a doubt.", Type = "Affirmative" },
                new MagicAnswer { Id = 4, Text = "Yes definitely.", Type = "Affirmative" },
                new MagicAnswer { Id = 5, Text = "You may rely on it.", Type = "Affirmative" },
                new MagicAnswer { Id = 6, Text = "As I see it, yes.", Type = "Affirmative" },
                new MagicAnswer { Id = 7, Text = "Most likely.", Type = "Affirmative" },
                new MagicAnswer { Id = 8, Text = "Outlook good.", Type = "Affirmative" },
                new MagicAnswer { Id = 9, Text = "Yes.", Type = "Affirmative" },
                new MagicAnswer { Id = 10, Text = "Signs point to yes.", Type = "Affirmative" },

                new MagicAnswer { Id = 11, Text = "Don't count on it.", Type = "Negative" },
                new MagicAnswer { Id = 12, Text = "My reply is no.", Type = "Negative" },
                new MagicAnswer { Id = 13, Text = "My sources say no.", Type = "Negative" },
                new MagicAnswer { Id = 14, Text = "Outlook not so good.", Type = "Negative" },
                new MagicAnswer { Id = 15, Text = "Very doubtful.", Type = "Negative" },

                new MagicAnswer { Id = 16, Text = "Ask again later.", Type = "Non-committal" },
                new MagicAnswer { Id = 17, Text = "Concentrate and ask again.", Type = "Non-committal" },
                new MagicAnswer { Id = 18, Text = "Cannot predict now.", Type = "Non-committal" },
                new MagicAnswer { Id = 19, Text = "Reply hazy, try again.", Type = "Non-committal" }
            );
        }
    }
}
