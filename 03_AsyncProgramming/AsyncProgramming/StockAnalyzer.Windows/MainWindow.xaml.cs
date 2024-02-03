using System;
using Newtonsoft.Json;
using StockAnalyzer.Core.Domain;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using StockAnalyzer.Core;

namespace StockAnalyzer.Windows;

public partial class MainWindow : Window
{
    private static string API_URL = "https://ps-async.fekberg.com/api/stocks";
    private Stopwatch stopwatch = new Stopwatch();

    public MainWindow()
    {
        InitializeComponent();
    }


    private async void Search_Click(object sender, RoutedEventArgs e)
    {
        BeforeLoadingStockData();

        // using var client = new HttpClient();
        // var response = await client.GetAsync($"{API_URL}/{StockIdentifier.Text}");
        //
        // var content = await response.Content.ReadAsStringAsync();
        //
        // var data = JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(content);
        //
        // Stocks.ItemsSource = data;

        try
        {
            // read store data from DataStore
            Stocks.ItemsSource = await GetStocks();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            Notes.Text = exception.Message;
        }
       

        AfterLoadingStockData();
    }

    private async Task<IEnumerable<StockPrice>> GetStocks()
    {
        var store = new DataStore();
        var data = await store.GetStockPrices(StockIdentifier.Text);
        return data;
    }


    private void BeforeLoadingStockData()
    {
        stopwatch.Restart();
        StockProgress.Visibility = Visibility.Visible;
        StockProgress.IsIndeterminate = true;
    }

    private void AfterLoadingStockData()
    {
        StocksStatus.Text = $"Loaded stocks for {StockIdentifier.Text} in {stopwatch.ElapsedMilliseconds}ms";
        StockProgress.Visibility = Visibility.Hidden;
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true });

        e.Handled = true;
    }

    private void Close_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}