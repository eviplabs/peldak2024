using MauiCollectionViewMvvmDemo.Model;

namespace MauiCollectionViewMvvmDemo.ViewModel
{
    public class LandViewModel
    {
        private readonly Land land;

        public LandViewModel(Land land)
        {
            this.land = land;
        }

        public string LandNameAndCapital =>
            $"{land.Name} ({land.Cities.Single(c=>c.IsCapital).Name})";

        public string HufOrOther =>
            (land.Currency == "HUF") ? "HUF" : "Other";
    }
}
