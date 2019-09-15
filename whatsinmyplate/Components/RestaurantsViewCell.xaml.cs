using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace whatsinmyplate.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantsViewCell : ViewCell
    {
        public RestaurantsViewCell()
        {
            InitializeComponent();
        }
    }
}
