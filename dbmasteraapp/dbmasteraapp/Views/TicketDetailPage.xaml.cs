using dbmasteraapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TicketDetailPage : ContentPage
	{

		public TicketDetailPage ()
		{            
            InitializeComponent ();
            Ticket t = new Ticket();
            t.Id = 209405;
            t.Title = "JOB 682 IN BROKEN";
            t.DateInclusion = new DateTime(2019, 1, 29, 8, 30, 0);
            t.DateChange = new DateTime(2019, 2, 7, 13, 41, 0);
            t.Category = "Jobs em Broken";
            t.Closed = false;
            t.Status = 1;
            this.BindingContext = t;
		}
	}
}