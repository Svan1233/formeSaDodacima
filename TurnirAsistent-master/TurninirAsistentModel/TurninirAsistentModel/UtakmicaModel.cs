using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurninirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Natjecatelji koji igraju utakmicu
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobjednik utakmice
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// Broj runde u kojoj se trenutno nalazimo
        /// </summary>
        public int BrojRunde { get; set; }
    }
}
