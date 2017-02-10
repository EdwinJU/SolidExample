using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example
{
    public class VideoGames : AbstractVideo
    {

        
        public VideoGames(string nom, string cate, double pre)
        {
            nombre = nom;
            categoria = cate;
            precio = pre;
        }

       
            public string nombre { get; set; }

        public string categoria { get; set; }

        public double precio { get; set; }


    }
}

