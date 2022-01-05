using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public List<Settings> settings { get; set; }
        
        public List<ExpertPosition> expertsp { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Carusel> carusels { get; set; }

    }
}
