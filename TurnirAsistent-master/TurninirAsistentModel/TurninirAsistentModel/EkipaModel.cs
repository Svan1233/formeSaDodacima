using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurninirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Clanovi koji se nalaze u nekoj odredenoj ekipi
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Naziv ekipe
        /// </summary>
        public string ImeEkipe { get; set; }

    }
}
