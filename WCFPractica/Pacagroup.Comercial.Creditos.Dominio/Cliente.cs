using System;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; } = 0;
        [DataMember]
        public string Nombre { get; set; } = string.Empty;
        [DataMember]
        public string ApellidoPaterno { get; set; } = string.Empty;
        [DataMember]
        public string ApellidoMaterno { get; set; } = string.Empty;
        [DataMember]
        public string TipoDocumento { get; set; } = string.Empty;
        [DataMember]
        public string NumeroDocumento { get; set; } = string.Empty;
        [DataMember]
        public string Sexo { get; set; } = string.Empty;
        [DataMember]
        public DateTime FechaNac { get; set; } = DateTime.Now;
        [DataMember]
        public string Direccion { get; set; } = string.Empty;
        [DataMember]
        public string CodigoPostal { get; set; } = string.Empty;
        [DataMember]
        public string EstadoCivil { get; set; } = string.Empty;
    }
}
