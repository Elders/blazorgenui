﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorGenUI.Reflection;
using BlazorGenUI.Reflection.Attributes;
using BlazorGenUI.Reflection.Enums;
using BlazorGenUI.Reflection.Interfaces;
using FestivalProject.DAL.Enums;

namespace BlazorGenUI.Tests.testdtos
{
    public class TestPrimitiveDto 
    {
        public string Name { get; set; }
        public bool IsFestival {get; set;}
        public DateTime Date { get; set; }
        public DateTimeOffset DateOffset { get; set; }
        public Single SingleNumber { get; set; }
        public float FloatNumber { get; set; }
        public double DoubleNumber { get; set; }
        public decimal DecimalNumber { get; set; }
        public int IntNumber { get; set; }
        public EnumType MyEnum { get; set; }

        
    }
}
