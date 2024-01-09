using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TODOList.ViewModel;

[QueryProperty("Text", "Text")] // Usado para poder acessar os argumentos passado pelo metodo tap();
[QueryProperty("Descricao", "Descricao")]
[QueryProperty("Foto", "Foto")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack() => await Shell.Current.GoToAsync(".."); // Os dois pontinhos diz que vai voltar para a página anterior


    }

