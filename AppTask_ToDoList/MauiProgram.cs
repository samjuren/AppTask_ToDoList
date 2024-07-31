using AppTask_ToDoList.DbContext;
using Microsoft.Extensions.Logging;

namespace AppTask_ToDoList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            CreateDatabase();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static void CreateDatabase()
        {
            Database.Init();
        }
    }
}
