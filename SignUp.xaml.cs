
using ShoppingCart.Models;
using ShoppingCart.Services;
namespace ShoppingCart;

public partial class SignUp : ContentPage
{
    private AppDataBase _appData;
    private Client _client;
    public Client CurrentClient
    {

        get { return _client; }
        set { _client = value; OnPropertyChanged(); }
    }
    public SignUp()
	{
		InitializeComponent();
        _appData= new AppDataBase();
        BindingContext = this;
        OnPropertyChanged();
        
        LoadData();
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }
    private void LoadData()
    {
        Client client = _appData.GetClientById(1);

        CurrentClient = client;
    }

    private void DisableButton()
    {
        Editlabel.IsVisible = false;

        SaveButton.IsEnabled = false;
        SaveButton.IsVisible = false;
        
        NameLabel.IsVisible = false;
        NameLabel.IsEnabled = false;
        NameEntry.IsVisible = false;
        NameEntry.IsEnabled = false;

        SurnameLabel.IsEnabled = false;
        SurnameLabel.IsVisible = false;
        SurnameEntry.IsVisible = false;
        SurnameEntry.IsEnabled= false;

        EmailLabel.IsEnabled = false;
        EmailLabel.IsVisible = false;
        EmailEntry.IsEnabled= false;
        EmailEntry.IsVisible= false;

        ProfileNameLabel.IsVisible = true;
        ProfileNameLabel.IsEnabled = true;
        ProfileNameEntry.IsVisible = true;
        ProfileNameEntry.IsEnabled = true;

        ProfileSurnameLabel.IsEnabled = true;
        ProfileSurnameLabel.IsVisible = true;
        ProfileSurnameEntry.IsVisible = true;
        ProfileSurnameEntry.IsEnabled = true;

        ProfileEmailLabel.IsEnabled = true;
        ProfileEmailLabel.IsVisible = true;
        ProfileEmailEntry.IsEnabled = true;
        ProfileEmailEntry.IsVisible = true;

        EditButton.IsVisible = true;
        EditButton.IsEnabled = true;
    }

    private void edit_profile(object sender, EventArgs e)
    {
        Editlabel.IsVisible = true;

        SaveButton.IsEnabled = true;
        SaveButton.IsVisible = true;

        NameLabel.IsVisible = true;
        NameLabel.IsEnabled = true;
        NameEntry.IsVisible = true;
        NameEntry.IsEnabled = true;

        SurnameLabel.IsEnabled = true;
        SurnameLabel.IsVisible = true;
        SurnameEntry.IsVisible = true;
        SurnameEntry.IsEnabled = true;

        EmailLabel.IsEnabled = true;
        EmailLabel.IsVisible = true;
        EmailEntry.IsEnabled = true;
        EmailEntry.IsVisible = true;

        ProfileNameLabel.IsVisible = false;
        ProfileNameLabel.IsEnabled = false;
        ProfileNameEntry.IsVisible = false;
        ProfileNameEntry.IsEnabled = false;

        ProfileSurnameLabel.IsEnabled = false;
        ProfileSurnameLabel.IsVisible = false;
        ProfileSurnameEntry.IsVisible = false;
        ProfileSurnameEntry.IsEnabled = false;

        ProfileEmailLabel.IsEnabled = false;
        ProfileEmailLabel.IsVisible = false;
        ProfileEmailEntry.IsEnabled = false;
        ProfileEmailEntry.IsVisible = false;

        EditButton.IsVisible = false;
        EditButton.IsEnabled= false;
    }
    private async void SavePage(object sender, EventArgs e)
    {


        _appData.UpdateClient(CurrentClient);

        await DisplayAlert("Success", "Client saved successfully.", "OK");
        DisableButton();
        LoadData();

    }
  

    

    
}