using ListViewM01.model;
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
    public partial class ListView03xaml : ContentPage
    {
        public ListView03xaml()
        {
            InitializeComponent();
            List<Produto> listaProduto = new List<Produto>
            {
                new Produto{
                   img = "jureg.jpg",
                    nome = "Cafeteira Wallita",
                    valor = 299.90
              },
                new Produto
                {
                    img = "jureg.jpg",
                    nome = "Celular Moto G6",
                    valor = 999.90
                },
                new Produto
                {
                img = "jureg.jpg",
                nome = "Sofá",
                valor = 800.00
                },

            };
            listView1.ItemsSource = listaProduto;
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }
        }
}