using System;
using System.Collections.Generic;
using System.Text;
using DataModel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EndToEnd.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<FileModel> Files { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
			//i dont know need i this or not
			Database.EnsureCreated();
		}
	}
}
