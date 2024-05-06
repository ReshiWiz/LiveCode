using LiveCode.Models;
using LiveCode.Models.FormUploads;
using Microsoft.EntityFrameworkCore;

namespace LiveCode.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<PowerRangres> PowerRangres { get; set; }
		public DbSet<Country> Country { get; set; }
		public DbSet<State> State { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<FormList> formLists { get; set; }
		public DbSet<UserModel> UserModels { get; set; }

	}
}
