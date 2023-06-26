using System;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio
{
    [DataContract]
    public class Credito
    {
        [DataMember]
        public int IdCredito { get; set; } = 0;
        [DataMember]
        public int TipoCredito { get; set; } = 0;
        [DataMember]
        public int IdCliente { get; set; } = 0;
        [DataMember]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [DataMember]
        public DateTime DiaPago { get; set; } = DateTime.Now;
        [DataMember]
        public decimal Monto { get; set; } = 0;
        [DataMember]
        public decimal Tasa { get; set; } = 0;
        [DataMember]
        public decimal Comision { get; set; } = 0;
    }
}
