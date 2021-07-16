using System;
using System.Collections.Generic;
using System.Text;

namespace AtEnumeraçao.Entities.enuns
{
    enum OrderStatus : int
    {
        PendingPayament = 0,
        Processing =1,
        Shipped =2,
        Deliverd = 3,
    };
}
