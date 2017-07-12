using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TrayectoST_Entity
    {
        public int idSolicitud { get; set; }
        public int idMovimiento { get; set; }
        public string fechasalida { get; set; }
        public string fechallegada { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public decimal kms { get; set; }
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idTrayecto { get; set; }
        
        public TrayectoST_Entity() { }
        public TrayectoST_Entity(int pidSolicitud, int pidMovimiento, string pfechasalida, string pfechallegada, string porigen,
           string pdestino, decimal pkms, int pidEmpresa, int pidUsuario, int pidTrayecto)
        {
            this.idSolicitud = pidSolicitud;
            this.idMovimiento = pidMovimiento;
            this.fechallegada = pfechallegada;
            this.fechasalida = pfechasalida;
            this.origen = porigen;
            this.destino = pdestino;
            this.kms = pkms;
            this.idEmpresa = pidEmpresa;
            this.idUsuario = pidUsuario;
            this.idTrayecto = pidTrayecto;
            
        }


    }
}
