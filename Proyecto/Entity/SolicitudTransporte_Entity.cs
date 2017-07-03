using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SolicitudTransporte_Entity
    {
        #region Atributos
        public int idSolicitud { get; set; }
        public string Notas { get; set; }
        public string FechaSolicitud { get; set; }
        public string FechaSalida { get; set; }
        public string FechaRegreso { get; set; }
        public decimal CostoEstimado { get; set; }
        public int idTipoSolicitud { get; set; }
        public int idEstado { get; set; }
        public int idTipoCarga { get; set; }
        public int idEmpresa { get; set; }
        public int idEmpleado { get; set; }
        public int idUsuario { get; set; }
        public string NombreEstado { get; set; }
        #endregion

        public SolicitudTransporte_Entity()
        {

        }

        public SolicitudTransporte_Entity(int pidSoliciutd, string pNotas, 
            string pFechaSolicitud, string pFechaSalida, string pFechaRegreso, 
            decimal pCostoEstimado, int pidTipoSolicitud, int pidEstado, int pidTipoCarga, 
            int pidEmpresa, int pidEmpleado, int pidUsuario, string pNombreEstado)
        {
            this.idSolicitud = pidSoliciutd;
            this.Notas = pNotas;
            this.FechaSolicitud = pFechaSolicitud;
            this.FechaSalida = pFechaSalida;
            this.FechaRegreso = pFechaRegreso;
            this.CostoEstimado = pCostoEstimado;
            this.idTipoSolicitud = pidTipoSolicitud;
            this.idEstado = pidEstado;
            this.idTipoCarga = pidTipoCarga;
            this.idEmpresa = pidEmpresa;
            this.idEmpleado = pidEmpleado;
            this.idUsuario = pidUsuario;
            this.NombreEstado = pNombreEstado;
        }
    }
}
