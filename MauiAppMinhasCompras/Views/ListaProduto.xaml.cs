namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private async void Adicionar_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Shell.Current.GoToAsync(nameof(NovoProduto));
		}
		catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}