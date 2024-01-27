using System;
using System.Windows;

namespace Bomba
{
    public partial class Virus : Window
    {
        public Virus()
        {
            InitializeComponent();
        }

        private void LoadHtmlContent()
        {
            string html = @"
                <!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Document</title>
                </head>
                <body style=""background: url(https://i.pinimg.com/originals/3f/7c/2e/3f7c2e51d5f75beabec6e5803551dc80.gif);
                   background-size: 50% 1000%;"">
                    <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/9ZwR07T-aIs?autoplay=1&loop=1"" title=""YouTube video player""
                            frameborder=""0"" allow=""accelerometer; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                            allowfullscreen></iframe>
                </body>
                </html>";

            webBrowser.NavigateToString(html);
        }

        private void PirmasStulpelisframe_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            // Uncomment and provide a valid URL for PirmasStulpelisframe
            // PirmasStulpelisframe.Source = new Uri("https://www.google.com", UriKind.Absolute);
        }

        private void IRaudona(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("You Are an Idiot?", "My Box", MessageBoxButton.YesNo);
            BegalinisPaleidimas begalinisPaleidimas = new BegalinisPaleidimas();

            switch (messageBoxResult)
            {
                case MessageBoxResult.No:
                    // Uncomment and provide a valid URL for PirmasStulpelisframe
                    // PirmasStulpelisframe.Source = new Uri("http://127.0.0.1:5500/VIRUSSUPER.html", UriKind.Absolute);
                    LoadHtmlContent();
                    begalinisPaleidimas.Show();
                    begalinisPaleidimas.Focus();
                    break;
                case MessageBoxResult.Yes:
                    // Uncomment and provide a valid URL for PirmasStulpelisframe
                    // PirmasStulpelisframe.Source = new Uri("http://127.0.0.1:5500/VIRUSSUPER.html", UriKind.Absolute);
                    LoadHtmlContent();
                    begalinisPaleidimas.Show();
                    begalinisPaleidimas.Focus();
                    break;
            }
        }
    }
}
