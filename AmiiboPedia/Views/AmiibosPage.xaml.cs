using AmiiboPedia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmiiboPedia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmiibosPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }
        public AmiibosPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new MainPageViewModel();
            await ViewModel.LoadCharacters();
            this.BindingContext = ViewModel;
        }
        private async void ViewCell_Appearing(object sender, EventArgs e)
        {
            var cell = sender as ViewCell;
            var view = cell.View;
            view.TranslationX = -100;
            view.Opacity = 0;
            await Task.WhenAny<bool>
                (
                    view.TranslateTo(0, 0, 250, Easing.SinIn),
                    view.FadeTo(1, 500, Easing.BounceIn)
                );
        }
    }
}