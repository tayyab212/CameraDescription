using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameraDesription.Models
{
    public class CameraDetail
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Index { get; set; }
    }

    public class CameraDetailList
    {
        public List<CameraDetail> CameraDetail { get; set; }
    }
}
