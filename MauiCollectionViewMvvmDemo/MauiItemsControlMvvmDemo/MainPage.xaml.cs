using MauiCollectionViewMvvmDemo.Model;
using MauiCollectionViewMvvmDemo.ViewModel;

namespace MauiCollectionViewMvvmDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        this.BindingContext = this;
        InitializeComponent();
        foreach(var l in GetLands()
                .Select(land => new LandViewModel(land)))
        {
            LandList.Lands.Add(l);
        }
    }

    private Land[] GetLands()
    {
        var Budapest = new City() { Name = "Budapest", IsCapital = true };
        var Debrecen = new City() { Name = "Debrecen", IsCapital = false };
        var Miskolc = new City() { Name = "Miskolc", IsCapital = false };
        var Sopron = new City() { Name = "Sopron", IsCapital = false };
        var Magyarorszag = new Land()
        {
            Cities = new[] { Budapest, Debrecen, Miskolc, Sopron },
            Currency = "HUF",
            Name = "Magyarország",
            Population = 9798000
        };
        var Frankfurt = new City() { Name = "Frankfurt", IsCapital = false };
        var Berlin = new City() { Name = "Berlin", IsCapital = true };
        var Nemetorszag = new Land()
        {
            Cities = new[] { Frankfurt, Berlin },
            Currency = "EUR",
            Name = "Németország",
            Population = 83000000
        };

        return new[] { Magyarorszag, Nemetorszag };
    }

}

