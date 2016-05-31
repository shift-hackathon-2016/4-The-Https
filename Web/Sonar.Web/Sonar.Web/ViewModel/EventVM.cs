using Sonar.Web.Model;

namespace Sonar.ViewModels
{
    public class EventVM
    {
        public float? Longitude;
        public float? Latitude;
        public string Name;
        public string Description;
        public string AuthorName;
        public EventType EventType;
    }

    public enum EventType
    {
        Neformalno = 1,
        Rekreativno = 2,
        Zabavno = 3,
        Piknik = 4,
        Edukativno = 5,
        Kulturno = 6,
        Ostalo = 7
    }
}