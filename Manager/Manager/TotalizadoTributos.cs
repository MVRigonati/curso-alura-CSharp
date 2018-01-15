using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Manager.Model;

namespace Manager {
    class TotalizadoTributos {

        public double Total { get; private set; }

        public void Acumula(InterfaceTributavel conta) {
            this.Total += conta.CalculaTributo();
        }

    }
}
