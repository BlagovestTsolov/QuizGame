using Microsoft.AspNetCore.Identity;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.UnitTests.Seed
{
    public static class DatabaseSeeder
    {
        private static IdentityUser AuthorUser { get; set; }

        private static IdentityUser GuestUser { get; set; }

        private static IdentityUser AdminUser { get; set; }

        public static void SeedDatabase(IRepository repository)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AuthorUser = new IdentityUser()
            {
                Id = "c2aa4952-07e9-42ee-8cfa-ce20eb0e4044",
                UserName = "author@mail.com",
                NormalizedUserName = "author@mail.com",
                Email = "author@mail.com",
                NormalizedEmail = "author@mail.com"
            };
            AuthorUser.PasswordHash =
                 hasher.HashPassword(AuthorUser, "author123");

            GuestUser = new IdentityUser()
            {
                Id = "443da613-361c-4e62-93e1-c814615610e4",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(AuthorUser, "guest123");

            AdminUser = new IdentityUser()
            {
                Id = "82a170cc-bd28-46f5-aab0-b48f36d228c1",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "admin123");

            repository.AddAsync(AuthorUser);
            repository.AddAsync(GuestUser);
            repository.AddAsync(AdminUser);
        }
    }
}
