namespace Pro_Events.Api.Models
{
    public class Event
    {

        public Guid Id { get; private set; }
        public string Place { get; private set;}
        public string DateEvent { get; private set;}
        public string Theme { get; private set;}
        public int AmountOfPeople { get; private set; }
        public string Lot { get; private set; }
        public string ImageUrl { get; private set; }

        public Event(string place, string dateEvent, string theme, int amountOfPeople, string lot, string imageUrl)
        {
            Id = Guid.NewGuid();
            Place = place;
            DateEvent = dateEvent;
            Theme = theme;
            AmountOfPeople = amountOfPeople;
            Lot = lot;
            ImageUrl = imageUrl;
        }
    }
}
