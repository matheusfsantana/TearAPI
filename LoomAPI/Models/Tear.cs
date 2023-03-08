using System;

namespace LoomAPI.Models
{
    public class Tear
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Eficiencia { get; set; }

        public int QuebraDeUrdume { get; set; }

        public int QuebraDeTrama { get; set; }

        public int FimDeTrama { get; set; }
        public DateTime TempoLigado { get; set; }

        public DateTime TempoParado { get; set; }

    }
}
