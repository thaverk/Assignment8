using ShoppingCart.Models;
using ShoppingCart.Services;
using System.Collections.ObjectModel;

namespace ShoppingCart;

public partial class HeadphonesPage : ContentPage
{
    private AppDataBase appdata;
    private ObservableCollection<GamingHeadphones> _headphones;
    public ObservableCollection<GamingHeadphones> Headphones
    { get { return _headphones; } set { _headphones = value; OnPropertyChanged(); } }
    public HeadphonesPage()
	{
		InitializeComponent();
        appdata = new AppDataBase();
        BindingContext = this;
        OnPropertyChanged();
        LoadData();
    }
    private void LoadData()
    {
       
        Headphones = new ObservableCollection<GamingHeadphones>(appdata.GetGamingHeadphones());

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }

   
}