using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurninirAsistentModel
{
    public class OsobaModel
    {
        /// <summary>
        /// Ime igraca
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// Prezime igraca
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// E-mail igraca preko kojega cemo mu slati obavjesti
        /// </summary>
        public string EmailAdresa { get; set; }
        /// <summary>
        /// Broj mobitela igraca na koji cemo mu slati obavjesti
        /// </summary>
        public string BrojMobitela { get; set; }
    }
}
