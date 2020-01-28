using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurninirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Koje je mjesto osvojila ekipa
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Kako ce se zvati svako mjesto(pobjednik,luzer,...)
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Koliki ce biti iznos nagrade za svako osvojeno mjesto
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Koliko ce biti postotak nagrade za svako osvojeno mjesto
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
