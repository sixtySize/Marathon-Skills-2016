using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Marathon
{
	/// <summary>
	/// Логика взаимодействия для runner__page.xaml
	/// </summary>
	public partial class runner__page : Page
	{
		DateTime voteTime = new DateTime(2016, 11, 24, 6, 0, 0);
		public runner__page()
		{
			InitializeComponent();

			btn__back.Click += (s, e) => { NavigationService.Navigate(new main_page()); };

			DispatcherTimer timer = new DispatcherTimer();
			timer.Tick += new EventHandler(timer_Tick);
			timer.Interval = new TimeSpan(0, 0, 1);
			timer.Start();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			TimeSpan TimeRemaining = voteTime - DateTime.Now;
			tbTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов и " + TimeRemaining.Minutes + " минут до старта марафона!";
		}
	}
}
