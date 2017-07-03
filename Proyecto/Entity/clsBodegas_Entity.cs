using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class clsBodegas_Entity
    {
        private string _strNombreBodega;
        private string _strNombreEncargado;
        private string _iStockMinimo;
        private string _iStockMaximo;
        private string _iIdBodega;
        private string _bEstadoBodega;
        private string _iIdEmpresa;

        public string strNombreBodega {
            get { return _strNombreBodega; }
            set { _strNombreBodega = value; }
        }

        public string strNombreEncargado
        {
            get { return _strNombreEncargado; }
            set { _strNombreEncargado = value; }
        }

        public string iStockMinimo
        {
            get { return _iStockMinimo; }
            set { _iStockMinimo = value; }
        }

        public string iStockMaximo
        {
            get { return _iStockMaximo; }
            set { _iStockMaximo = value; }
        }

        public string iIdBodega
        {
            get { return _iIdBodega; }
            set { _iIdBodega = value; }
        }

        public string iIdEmpresa
        {
            get { return _iIdEmpresa; }
            set { _iIdEmpresa = value; }
        }

        public string bEstadoBodega
        {
            get { return _bEstadoBodega; }
            set { _bEstadoBodega = value; }
        }

        


    }
}
