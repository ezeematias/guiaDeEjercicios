using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper
{
    public class Usuario
    {
        string lastName;
        string name;
        long dni;
        string[] formasPago;
        string medioDePago;
        string provincia;

        public Usuario(string lastName, string name, long dni, string[] formasPago, string medioDePago, string provincia)
        {
            this.lastName = lastName;
            this.name = name;
            this.dni = dni;
            this.formasPago = formasPago;
            this.medioDePago = medioDePago;
            this.provincia = provincia;
        }

        private string mostrarNombres()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.name);
            sb.Append(this.lastName);
            sb.Append(this.dni);
            foreach (string item in this.formasPago)
            {
                sb.AppendFormat(" {0} ", item);
            }
            sb.Append(this.medioDePago);
            sb.Append(this.provincia);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.mostrarNombres();
        }
    }
}
