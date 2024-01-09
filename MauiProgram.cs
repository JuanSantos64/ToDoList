using Microsoft.Extensions.Logging;
using TODOList.ViewModel;

namespace TODOList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => // Adiciona as fontes aqui, primeiro precisa baixar o .ttf delas e colocar em Resources/Fonts,
                                         // dps colocar aqui, primeiro argumento é o local dele e o
                                         // segundo é o nome que vc ira chama-lo no código
                                         // fonts.AddFont("nomedoarquivo.tff", "nomequevcquerpornele");
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Adiciona as páginas que o Aplicativo pode utilizar:
            //AddSingleton são paginas fixas
            // AddTransient são paginas que são utilizadas como a pagina que ira se destinar da pagina fixa
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
            builder.Services.AddSingleton<MainPage>(); // Pagina principal
            builder.Services.AddSingleton<MainViewModel>(); // Pagina da ViewModel
            builder.Services.AddTransient<DetailPage>(); // Pagina dos detalhes
            builder.Services.AddTransient<DetailViewModel>(); // Pagina dos detalhes ViewModel


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
