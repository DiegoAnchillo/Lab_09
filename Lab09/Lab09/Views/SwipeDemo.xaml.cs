using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab09.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            _Label.Text = $"You swiped: {e.Direction.ToString()}";
        }

    }
}