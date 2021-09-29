using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView02 : ContentPage
    {
        public ListView02()
        {
            InitializeComponent();

            List<string> lista = new List<string>
            {
                "Domingo", "Segunda-Feita", "Terça-Feira",
                "Quarta-Feira", "Quinta-Feira", "Sexta-Feira",
                "Sábado"
            };
            listView1.ItemsSource = lista;
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}