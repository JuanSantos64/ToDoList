
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace TODOList.ViewModel
{ 
    public partial class MainViewModel : ObservableObject //Herdando da classe que instalamos o Nuget
{
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

    [ObservableProperty]
    ObservableCollection<string> items;
        [ObservableProperty]
        string text;




        [RelayCommand]
    async void Add() // Adiciona item na lista
    {


        if (string.IsNullOrEmpty(text)) // Verifica se quando vc clicou no botao add há uma string realmente
            {
                await Shell.Current.DisplayAlert("Ixi, tem erro aqui!", "Você não digitou nada", "Perdão, vou digitar agr");
                //    Sheel.Current.DisplayAlert("Nome da Aba", "Mensagem da Aba", "Mensagem do botão de sair");
            return;
            }
        if(connectivity.NetworkAccess != NetworkAccess.Internet) // Ve se tem conexão com a internet
            {
                await Shell.Current.DisplayAlert("Uh Oh!", "No Internet", "OK");
                return;
            }
            
        Items.Add(text); // Adiciona o item após as verificações
        Text = string.Empty; // Limpa o campo da mensagem
    }

    [RelayCommand]
    void Delete(string s) // Deleta item na lista
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }

    }
    [RelayCommand]
    async Task Tap(string s)
    {
            

            //    Shell.Current.GoToAsync($"{nameof(Pagina que vai ir)}?NomeNoQuery={Argumento que será passado}&NomeNoQuery={Argumento}");
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}"); //Muda de Página        
            //                                                  ^        ^
            //                                                  |        |
            //           (Separa o nome da pagina dos argumentos)        (Separa um argumento do outro)
            //
        }
    }
}
        

        
        
        