﻿using System;

namespace Sonar.ViewModels
{
    public class EventVM
    {
        public int Id;
        public float? Longitude;
        public float? Latitude;
        public string Name;
        public string Description;
        public string AuthorName;
        public DateTime? StartDate;
        public DateTime? EndDate;
        public string Town;
        public int TownId;
        public string State;
        public int StateId;
        public string UrlSlike;
        public string ContactNumber;
        public string EventType;
        public int EventTypeID;
    }
}