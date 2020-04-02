using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_serverData.Models
{
	public class DefaultConnection: DbContext
	{
		public DbSet<Interval> Intervals { get; set; }
		public DbSet<LogRecord> LogRecords { get; set; }
	}
}