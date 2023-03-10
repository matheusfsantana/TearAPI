using System;
using System.Collections.Generic;

namespace LoomAPI.Models
{
    public class Tear
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Eficiencia { get; set; }

        public List<Erro> Erros { get; set; }

        public string TempoParado { get; set; }

        public string TempoLigado { get; set; }

        public string TempoInicial { get; set; }

        public string TempoFinal { get; set; }

        public string TempoDecorrido { get; set; }

        public string HoraDeLigacao { get; set; }
    }
}
