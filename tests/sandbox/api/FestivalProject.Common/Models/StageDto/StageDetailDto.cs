﻿using System.Collections.Generic;
using BlazorGenUI.Reflection;
using FestivalProject.BL.Models.FestivalDto;
using FestivalProject.BL.Models.StageInterpretDto;
using FestivalProject.DAL.Entities;

namespace FestivalProject.BL.Models.StageDto
{
    
    public class StageDetailDto : ComplexElement
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public FestivalListDto Festival { get; set; }
        //public IList<StageInterpretBaseDto> StageInterpret { get; set; }
    }
}
