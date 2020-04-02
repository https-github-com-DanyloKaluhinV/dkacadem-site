using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_serverData.Models
{
	public class Interval
	{

        // ID даты
        public int Id { get; set; }
        // начальная дата 
        public DateTime start { get; set; }
        // конечная дата
        public DateTime end { get; set; }

    }
}