using MauiCollectionViewMvvmDemo.ViewModel;
using System.Collections.ObjectModel;

namespace MauiCollectionViewMvvmDemo.View
{
    public sealed partial class LandListing : ContentView
    {
        public ObservableCollection<LandViewModel> Lands { get; set; } = new();

        public LandListing()
        {
            this.BindingContext = this;
            this.InitializeComponent();
        }

        private void AddLandClicked(object sender, EventArgs e)
        {
            Lands.Add(new LandViewModel(
                new Model.Land()
                {
                    Name = "Spanyolország",
                    Cities = new Model.City[]
                    {
                        new Model.City() { Name="Madrid", IsCapital=true}
                    },
                    Currency="EUR"
                }));
        }
    }
}
