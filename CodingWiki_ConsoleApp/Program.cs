using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

await using ApplicationDbContext context = new ApplicationDbContext();
await context.Database.EnsureCreatedAsync();
if (context.Database.GetPendingMigrations().Any())
{
    await context.Database.MigrateAsync();
}