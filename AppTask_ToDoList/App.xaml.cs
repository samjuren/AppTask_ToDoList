
using AppTask_ToDoList.Views;
using Microsoft.Maui.Platform;

namespace AppTask_ToDoList
{
    public partial class App : Application
    {
        public App()
        {
            CustomHandler();

            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }

        private void CustomHandler()
        {
            Microsoft.Maui.Handlers.EntryHandler
                .Mapper.AppendToMapping
                ("NoBorder", (handler, view) =>
                {
#if ANDROID
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#elif IOS || MACCATALYST
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                    handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
                });
        }
    }
}
