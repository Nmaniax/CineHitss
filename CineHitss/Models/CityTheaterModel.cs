using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineHitss.Models
{
    public class CityTheaterModel
    {
        public List<Ciudad> ciudadesList { get; set; }
        public List<Cine> cineList { get; set; }

        public CityTheaterModel() { }

        public CityTheaterModel(List<Ciudad> Lcity, List<Cine> Ltheater)
        {
            this.ciudadesList = Lcity;
            this.cineList = Ltheater;
        }
    }
}