using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_serverData.Models
{
	public class DataDbInitializer : DropCreateDatabaseAlways<DefaultConnection>
	{
        protected override void Seed(DefaultConnection db)
        {
            db.Intervals.Add(new Interval { start = new DateTime(2018,1,1), end = new DateTime(2018,01,03) });
            db.Intervals.Add(new Interval { start = new DateTime(2018,01,01), end = new DateTime(2018,01,03) });
            db.Intervals.Add(new Interval { start = new DateTime(2018,01,01), end = new DateTime(2018,01,03) });

            base.Seed(db);
        }
    }
}