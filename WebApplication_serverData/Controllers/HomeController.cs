using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_serverData.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace WebApplication_serverData.Controllers
{
	public class HomeController : Controller
	{
		// создаем контекст данных
		DefaultConnection db = new DefaultConnection();
		int count=3;
		bool first = true;

		public ActionResult Index()
		{
			if (first==true)
			{ 
			// получаем из бд все объекты Book
			IEnumerable<Interval> intervals= db.Intervals;
			// передаем все объекты в динамическое свойство Books в ViewBag
			ViewBag.Intervals = intervals;
				// возвращаем представление
			}
			first = false;

			return View();
		}

		[HttpGet]
		public ActionResult AddData()
		{
			
			
			return View();
		}
		
		[HttpPost]
		public string AddData(Interval temp)
		{
			
			db.Intervals.Add(new Interval { Id=count, start=temp.start, end = temp.end });
			count++;
			// сохраняем в бд все изменения
			IEnumerable<Interval> intervals = db.Intervals;
			// передаем все объекты в динамическое свойство Books в ViewBag
			ViewBag.Intervals = intervals;
			// возвращаем представление
			db.SaveChanges();
			//
			return "The Data was created!";
		}


		/*
		[HttpPost]
		public async Task<string> AddInfo(string temp)
		{
			Interval objectTemp = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<Interval>(temp));


			db.Intervals.Add(new Interval { Id = count, start = objectTemp.start, end = objectTemp.end });
			count++;
			// сохраняем в бд все изменения
			db.SaveChanges();

			return //await Task.Factory.StartNew(()=>JsonConvert.SerializeObject(String.Format(He);
		}*/
	

		/*
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		*/
	}
}