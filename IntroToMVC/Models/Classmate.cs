using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace IntroToMVC
{
    public class Classmate
    {
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        
        public Classmate(string name, string hair, int feet, int inches)
        {
            Name = name;
            HairColor = hair;
            HeightFeet = feet;
            HeightInches = inches;
        }
    }
}