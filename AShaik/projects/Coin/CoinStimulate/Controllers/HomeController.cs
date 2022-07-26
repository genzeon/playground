using CoinStimulates.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;


namespace CoinStimulates.Controllers
{
    public class HomeController : Controller
    {

       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        coin coin;
        public IActionResult Index()

        {
            
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        coin c;
        public IActionResult flip()

        {


            SqlConnection con2 = new SqlConnection("server=HYD-AShaik; database=coinado; integrated security = true");

            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(DISTINCT Toss)FROM coinflips;", con2);


            SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 facevalue FROM coinflips ORDER BY Toss DESC", con2);
            //   SqlCommand cmd4 = new SqlCommand("SELECT COUNT(DISTINCT Toss)FROM coinflips;", con2);


            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(facevalue)FROM coinflips WHERE facevalue = 'heads';", con2);
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(facevalue)FROM coinflips WHERE facevalue = 'tails';", con2);

            con2.Open();
            int v = (int)cmd2.ExecuteScalar();
            object w = cmd3.ExecuteScalar();
            // int x = (int)cmd4.ExecuteScalar();
            int y = (int)cmd5.ExecuteScalar();
            int z = (int)cmd6.ExecuteScalar();

            con2.Close();

            if (v == 0)
            {
                c = coin.Instance;
            }

            if (v != 0)
            {
                c = coin.Instance;

                c.Toss = v;
                if (w == "heads")
                {
                    c.Up = (Coinface)1;
                    c.Down = (Coinface)2;
                }
                else
                {
                    c.Up = (Coinface)2;
                    c.Down = (Coinface)1;
                }


                c.Headcount = y;
                c.Tailcount = z;

            }
            c.flip();






            int a = c.Toss;
            string b = c.ToString();
            SqlConnection con = new SqlConnection("server=HYD-ASHAIK; database=coinado; integrated security = true");
            SqlCommand cmd = new SqlCommand($"insert into coinflips(Toss,facevalue) values('{a}','{b}')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("one", "Home");

        }
        public IActionResult one()
        {

            SqlConnection con2 = new SqlConnection("server=HYD-ASHAIK; database=coinado; integrated security = true");

            SqlCommand cmd2 = new SqlCommand("select *from dbo.coinflips", con2);


            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(DISTINCT Toss)FROM coinflips;", con2);

            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(facevalue)FROM coinflips WHERE facevalue = 'heads';", con2);
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(facevalue)FROM coinflips WHERE facevalue = 'tails';", con2);

            con2.Open();
            int x = (int)cmd4.ExecuteScalar();
            int y = (int)cmd5.ExecuteScalar();
            int z = (int)cmd6.ExecuteScalar();
            SqlDataReader dr = cmd2.ExecuteReader();
            List<string> av = new List<string>();
            while (dr.Read())
            {
                string s = null;
                s += "Flip:" + " ";
                s += dr[0] + "Position:" + "\t";
                s += dr[1];
                av.Add(s);
            }
            dr.Close();

            con2.Close();

            ViewData["aka"] = av;
            ViewBag.xx = x;
            ViewBag.yy = y;
            ViewBag.zz = z;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}