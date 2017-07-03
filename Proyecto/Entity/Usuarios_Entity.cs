using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuarios_Entity
    {
        private string _iCodUsuario;
        private string _iRol;
        private string _strUsuario;
        private string _strPassword;
        private string _iStatus;
        private string _strPregunta;

        public string iCodUsuario
        {
            get { return _iCodUsuario; }
            set { _iCodUsuario = value; }
        }

        public string iRol
        {
            get { return _iRol; }
            set { _iRol = value; }
        }

        public string strUsuario
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }

        public string strPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        public string iStatus
        {
            get { return _iStatus; }
            set { _iStatus = value; }
        }

        public string strPregunta
        {
            get { return _strPregunta; }
            set { _strPregunta = value; }
        }
    }
}
