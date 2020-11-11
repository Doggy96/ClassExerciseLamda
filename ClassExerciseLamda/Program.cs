using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseLamda
{
	class Program
	{
		static void Main(string[] args)
		{
			Home home = new Home();
			home.Address = "ieremiou";
			home.Name = "kostas";
			PrintHome printHome;
			printHome = name => Console.WriteLine(home.Name + home.Address); ;


		}

		public delegate void PrintHome(Home home);
	}
}
