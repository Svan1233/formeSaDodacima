using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurninirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Kako ce se turnir zvati
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Koliko treba svaka ekipa platiti za ulazak u turnir
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Koji su se timovi prijavili da sudjeluju u turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Kakva ce biti vrsta nagrade za pobjednicke ekipe
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Runda sama po sebi je jedna lista a  cijeli turnir je  lista u kojoj se nalaze runde
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>();

    }
}
