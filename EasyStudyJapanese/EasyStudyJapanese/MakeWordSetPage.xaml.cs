using EasyStudyJapanese.WordListPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EasyStudyJapanese
{
    public partial class MakeWordSetPage : ContentPage
    {
        public MakeWordSetPage()
        {
            InitializeComponent();
        }


        void OnCreateListButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateListPage());
        }

        void OnEditListButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditListPage());
        }

        void OnDeleteListButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeleteListPage());
        }
    }
}
