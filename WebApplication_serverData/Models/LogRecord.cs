using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_serverData.Models
{
	public class LogRecord
	{


        // ID даты
        public int Id { get; set; }
       
        public DateTime datetime { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public int isRequest  { get; set; }
    }
}