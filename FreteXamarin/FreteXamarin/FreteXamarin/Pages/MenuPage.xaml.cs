using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreteXamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";

            this.Children.Add(new HomePage
            {
                Title = "Home"
            });
            this.Children.Add(new CidadesPage
            {
                Title = "Cidades"
            });
            this.Children.Add(new FretePage
            {
                Title = "Frete"
            });
            InitializeComponent();
        }
    }
}