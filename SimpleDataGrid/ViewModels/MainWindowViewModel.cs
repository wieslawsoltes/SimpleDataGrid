using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleDataGrid.ViewModels;

public class ItemViewModel : ViewModelBase
{
    public string Item0 { get; set; }
    public string Item1 { get; set; }
    public string Item2 { get; set; }
    public string Item3 { get; set; }
}

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        // var rand = new Random();
        Items = new ObservableCollection<ItemViewModel>(
            Enumerable
                .Range(0, 1_000_000)
                .Select(x => new ItemViewModel()
                {
                    Item0 = $"Item0_{x}",
                    Item1 = $"Item1_{x}",
                    Item2 = $"Item2_{x}",
                    Item3 = $"Item3_{x}",
                    // Item3 = string.Join(Environment.NewLine, Enumerable.Repeat($"Item3_{x}", rand.Next(1, 10))),
                }));
    }
    
    public ObservableCollection<ItemViewModel> Items { get; set; }
}
