using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class vehiculo_Entity
    {
        #region Atributos y Encapsulamiento
        public int _cod_vehiculo { get; set; }
        public string _marca { get; set; }
        public string _linea { get; set; }
        public string _motor { get; set; }
        public string _color { get; set; }
        public string _chasis { get; set; }
        public string _placa { get; set; }
        public string _modelo { get; set; }
        public int _tipovehiculo { get; set; }
        #endregion

        #region Constructor
        public  vehiculo_Entity()
        {
        }

        public vehiculo_Entity(int pcodVehiculo, string pMarca, string pLinea, string pMotor, string pColor, string pChasis, string pPlaca, string pModelo, int ptipovhc) 
        {
            this._cod_vehiculo = pcodVehiculo;
            this._marca = pMarca;
            this._linea = pLinea;
            this._motor = pMotor;
            this._color = pColor;
            this._chasis = pChasis;
            this._placa = pPlaca;
            this._modelo = pModelo;
            this._tipovehiculo = ptipovhc;
        }
        #endregion

    }
}
