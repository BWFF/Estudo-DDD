using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Entities
{
    public class Aluno
    {
        public int IdtAluno { get; set; }
        public int CodAluno { get; set; }
        public string NomeAluno { get; set; }
        public double CelAluno { get; set; }
        public DateTime DtInicioAluno { get; set; }
        public int DiaVencAluno { get; set; }
        public bool StatusAluno { get; set; }
        public float ValorDescontoAluno { get; set; }
    }
}
