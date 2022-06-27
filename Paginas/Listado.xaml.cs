using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinSQlite.ViewModel;

namespace XamarinSQlite.Paginas
{
    public partial class Listado : ContentPage
    {
        public Listado()
        {
            InitializeComponent();
            this.BindingContext = new ListadoViewModel();
        }
    }
}
