using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EasyStudyJapanese
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void OnPracticeButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PracticePage());
        }

        void OnWordSetButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MakeWordSetPage());
        }
    }
}
