using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A04LayoutXF.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
        NavigationPage nav;

		public Menu ()
		{
			InitializeComponent ();
            nav = new NavigationPage();
            Detail = nav;
            nav.PushAsync(new Pages.Perfil());
        }

        private void GoPaginaPerfil(object sender, EventArgs args)
        {
            nav.Navigation.InsertPageBefore(new Pages.Perfil(), nav.Navigation.NavigationStack[0]);
            nav.PopToRootAsync();
            IsPresented = false;
        }

            private void GoPaginaXamarin(object sender, EventArgs args)
        {
            nav.Navigation.InsertPageBefore(new Pages.Xamarin(), nav.Navigation.NavigationStack[0]);
            nav.PopToRootAsync();
            IsPresented = false;
        }
	}
}