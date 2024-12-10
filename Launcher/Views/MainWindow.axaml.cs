using Avalonia.Controls;
using System;
using System.Diagnostics;
using System.IO;

namespace NightbirdLauncher.Views;

public partial class MainWindow : Window
{
    Messagebox box = new Messagebox();

    public MainWindow()
    {
        Width = 800;
        Height = 600;
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var githubToken = "[token]";
        var url = "https://github.com/NightbirdEngine/Nightbird/releases";
        var path = @"D:\s4107473";
        box.Show();


        /*try
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", githubToken);
                credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                var contents = client.GetByteArrayAsync(url).Result;
                System.IO.File.WriteAllBytes(path, contents);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        

        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });*/
    }
}