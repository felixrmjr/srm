using SRM.Domain.Entities;
using System.Collections.Generic;

namespace SRM.Domain.Dtos
{
    public class ArquivoLido<TEntity> where TEntity : EntityBase
    {
        public List<TEntity> Dados { get; set; }
        public int Sucessos { get; set; }
        public int Falhas { get; set; }

        public ArquivoLido(List<TEntity> dados, int sucessos, int falhas)
        {
            Dados = dados;
            Sucessos = sucessos;
            Falhas = falhas;
        }
    }
}
