using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Application.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal preco { get; set; }
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }
        public int Quantidade { get; set; }
        public int EventoId { get; set; }
        public EventoDto Evento { get; set; }
    }
}