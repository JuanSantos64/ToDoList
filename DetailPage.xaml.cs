using TODOList.ViewModel;

namespace TODOList;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm) //Conectando ela a outra pagina atravez do argumento
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}