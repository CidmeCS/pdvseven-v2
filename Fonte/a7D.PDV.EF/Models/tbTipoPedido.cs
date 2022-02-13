using System;
using System.Collections.Generic;

namespace a7D.PDV.EF.Models
{
    public partial class tbTipoPedido : IValueName
    {
        public tbTipoPedido()
        {
            this.tbPedidoes = new List<tbPedido>();
        }

        public int IDTipoPedido { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<tbPedido> tbPedidoes { get; set; }

        public ValueName GetValueName() => new ValueName(IDTipoPedido, Nome);

        public void SetValueName(int value, string name)
        {
            IDTipoPedido = value;
            Nome = name;
        }

    }
}
