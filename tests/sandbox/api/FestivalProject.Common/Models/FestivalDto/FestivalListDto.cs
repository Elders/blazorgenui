﻿using System;
using BlazorGenUI.Reflection.Attributes;
using BlazorGenUI.Reflection.Enums;
using FestivalProject.DAL.Enums;

namespace FestivalProject.BL.Models.FestivalDto 
{
    [Container(LayoutTypes.Wrap)]
    public class FestivalListDto 
    {
        [RenderIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [AttributeName("Zaner")]
        [RadioButtonsEnum]
        public MusicGenre Genre { get; set; }
        public string Country { get; set; }
        [RenderIgnore]
        public string LogoUri { get; set; }
        public string City { get; set; }
        public bool IsFestival { get; set; }

        [Date(DateTypes.DateTime)]
        public DateTime DateTimeVar { get; set; }

        [Date(DateTypes.Date)]
        public DateTime Date { get; set; }

        [Date(DateTypes.TimeOfDay)]
        public DateTime TimeOfDay { get; set; }
        public DateTimeOffset DatOffset { get; set; }

    }
}
