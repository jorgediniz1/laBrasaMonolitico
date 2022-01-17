using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Entities.Enums
{
    enum StatusPedido : int
    {
        Entregue = 0,
        Produzindo = 1,
        Pronto = 2,
        Cancelado = 3,       
    }
}
