USE [SAD2017]
GO
/****** Object:  Table [dbo].[AJUSTECONSILIACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AJUSTECONSILIACION](
	[idAjuste] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [char](100) NULL,
	[monto] [numeric](10, 2) NULL,
	[status] [char](100) NULL,
	[fecha] [date] NULL,
	[idconciliacion] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ASIGNACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ASIGNACION](
	[idasignacion] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[asigfecha] [date] NOT NULL,
	[fechainicio] [date] NOT NULL,
	[fechafin] [date] NOT NULL,
	[horario] [varchar](25) NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ASIGNACIONPERSONAL]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNACIONPERSONAL](
	[idasigpersonal] [int] IDENTITY(1,1) NOT NULL,
	[idtransporte] [int] NULL,
	[idsolicitud] [int] NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ASIGNACIONTAREAS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNACIONTAREAS](
	[idasignaciontareas] [int] IDENTITY(1,1) NOT NULL,
	[horasunidad] [decimal](10, 4) NULL,
	[iddetalletarea] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AUTORIZACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUTORIZACION](
	[idAutorizacion] [int] IDENTITY(1,1) NOT NULL,
	[serieDocumento] [char](25) NULL,
	[descripcion] [char](200) NULL,
	[fecha] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bitacora_Autorizacion_Orden]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora_Autorizacion_Orden](
	[id_bitacora_orden] [int] IDENTITY(1,1) NOT NULL,
	[usuario_autorizador] [varchar](100) NULL,
	[autoriza] [bit] NULL,
	[fecha_autoriza] [datetime] NULL,
	[idordencompra] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BITACORATRANSPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BITACORATRANSPORTE](
	[idbitacora] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[idsolicitud] [int] NOT NULL,
	[nota] [char](10) NULL,
	[idestadost] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[descripcion] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BODEGA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BODEGA](
	[idbodega] [int] IDENTITY(1,1) NOT NULL,
	[nombre_bodega] [varchar](100) NULL,
	[encargado] [varchar](100) NULL,
	[stock_minimo] [int] NULL,
	[stock_maximo] [int] NULL,
	[activo] [bit] NULL,
	[idempresa] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BONIFICACIONES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BONIFICACIONES](
	[idbonificacion] [numeric](18, 0) NOT NULL,
	[idtipobonificacion] [numeric](18, 0) NOT NULL,
	[idtipopago] [numeric](18, 0) NOT NULL,
	[id] [numeric](18, 0) NOT NULL,
	[id_sede] [int] NOT NULL,
	[descripcion] [varchar](40) NULL,
	[porcentaje] [numeric](5, 2) NULL,
	[defaultt] [numeric](2, 0) NULL,
	[estado] [numeric](3, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CAJA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA](
	[idcaja] [int] IDENTITY(1,1) NOT NULL,
	[idestado] [int] NOT NULL,
	[idcuentaporcobrar] [int] NOT NULL,
	[idtransaccion] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CALCULODEVACACIONES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALCULODEVACACIONES](
	[codcalculo] [int] NOT NULL,
	[diacalculados] [decimal](5, 2) NULL,
	[codperiodo] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAMPANIA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAMPANIA](
	[idcampania] [int] IDENTITY(1,1) NOT NULL,
	[idtipocampania] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](50) NULL,
	[fechainicial] [datetime] NULL,
	[fechafinal] [datetime] NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CAMPANIA_CLIENTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPANIA_CLIENTE](
	[idcliente] [int] NOT NULL,
	[idcampania] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAMPANIA_VENTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPANIA_VENTA](
	[iddetalle] [int] IDENTITY(1,1) NOT NULL,
	[idcampania] [int] NOT NULL,
	[idfactura] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CANCELACIONCXC]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CANCELACIONCXC](
	[idcancelacion] [int] IDENTITY(1,1) NOT NULL,
	[idcuentaporcobrar] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CANDIDATO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CANDIDATO](
	[idcandidato] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idestadocandidato] [numeric](18, 0) NOT NULL,
	[idestadocivil] [numeric](18, 0) NOT NULL,
	[idsexo] [numeric](18, 0) NOT NULL,
	[idnacionalidad] [numeric](18, 0) NOT NULL,
	[nombre1] [varchar](100) NULL,
	[nombre2] [varchar](100) NULL,
	[apellido1] [varchar](100) NULL,
	[apellido2] [varchar](100) NULL,
	[apellido3] [varchar](100) NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [int] NULL,
	[dpi] [varchar](30) NULL,
	[fechanacimiento] [date] NULL,
	[fotografia] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CANDIDATOPLAZA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CANDIDATOPLAZA](
	[idplazacandidato] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idpuestodetrabajo] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAPACITACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAPACITACION](
	[idcapacitacion] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[fechapago] [date] NOT NULL,
	[costo] [float] NOT NULL,
	[nombre] [varchar](75) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[status] [int] NOT NULL,
	[idempresa] [int] NOT NULL,
	[idAutorizacion] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CENTROCOSTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CENTROCOSTO](
	[idcentro] [int] IDENTITY(1,1) NOT NULL,
	[nombre_centro] [varchar](100) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[idestado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [int] NULL,
	[direccion] [varchar](100) NULL,
	[email] [varchar](20) NULL,
	[saldo] [numeric](10, 2) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTE_VENDEDOR]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE_VENDEDOR](
	[idcliente] [int] NOT NULL,
	[idvendedor] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COMISION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMISION](
	[idcomision] [int] IDENTITY(1,1) NOT NULL,
	[idvendedor] [int] NOT NULL,
	[idestado] [int] NOT NULL,
	[porcentajecomosion] [numeric](10, 2) NULL,
	[idempresa] [int] NOT NULL,
	[idmarca] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONCILIACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONCILIACION](
	[idconciliacion] [int] IDENTITY(1,1) NOT NULL,
	[status] [char](10) NULL,
	[conciliado] [char](10) NULL,
	[fecha] [date] NULL,
	[mes_ref] [char](10) NULL,
	[idtransaccion] [int] NOT NULL,
	[idestado] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONTRASENA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTRASENA](
	[idcontrasena] [int] IDENTITY(1,1) NOT NULL,
	[idproveedor] [int] NOT NULL,
	[idsede] [int] NOT NULL,
	[idestadocontrasena] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONTRATO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONTRATO](
	[id] [numeric](18, 0) NOT NULL,
	[idpuestodetrabajo] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idjornada] [numeric](18, 0) NOT NULL,
	[id_empleado] [char](10) NULL,
	[salario_ordinario] [char](10) NULL,
	[f_ingreso] [char](10) NULL,
	[f_egreso] [char](10) NULL,
	[estado] [char](10) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONVERSION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONVERSION](
	[idconversion] [int] IDENTITY(1,1) NOT NULL,
	[factorconversion] [decimal](10, 4) NULL,
	[unidadorigen] [int] NOT NULL,
	[unidaddestino] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COTIZACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COTIZACION](
	[idcotizacion] [int] IDENTITY(1,1) NOT NULL,
	[idestado] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idvendedor] [int] NOT NULL,
	[idcomision] [int] NOT NULL,
	[total] [numeric](10, 2) NULL,
	[subtotal] [numeric](10, 2) NULL,
	[idmoneda] [int] NOT NULL,
	[impuesto] [numeric](10, 2) NULL,
	[fechacotizacion] [datetime] NULL,
	[fechavencimiento] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUENTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUENTA](
	[idcuenta] [int] IDENTITY(1,1) NOT NULL,
	[status] [char](10) NULL,
	[saldo] [numeric](10, 2) NULL,
	[nombre_cuenta] [char](30) NULL,
	[numero_cuenta] [char](30) NULL,
	[banco] [char](10) NULL,
	[activo] [char](30) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUENTACONTABLE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUENTACONTABLE](
	[idCuenta] [int] IDENTITY(1,1) NOT NULL,
	[idCuentaMadre] [int] NOT NULL,
	[nombre] [char](100) NULL,
	[nomenclatura] [char](10) NULL,
	[estadofinanciero] [char](20) NULL,
	[clasificacion] [char](30) NULL,
	[saldoAnterior] [decimal](10, 2) NULL,
	[saldoActual] [decimal](10, 2) NULL,
	[cargosMes] [decimal](10, 2) NULL,
	[abonosMes] [decimal](10, 2) NULL,
	[cargosAcumulados] [decimal](10, 2) NULL,
	[abonosAcumulados] [decimal](10, 2) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUENTAS_POR_COBRAR]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTAS_POR_COBRAR](
	[idcuentaporcobrar] [int] IDENTITY(1,1) NOT NULL,
	[idtipocxc] [int] NOT NULL,
	[idvendedor] [int] NOT NULL,
	[idfactura] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[idmoneda] [int] NOT NULL,
	[total] [numeric](10, 2) NULL,
	[subtotal] [numeric](10, 2) NULL,
	[idcliente] [int] NOT NULL,
	[idestado] [int] NOT NULL,
	[iddetallepago] [int] NOT NULL,
	[iddevolucion] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DEPARTAMENTOEMPRESA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEPARTAMENTOEMPRESA](
	[iddepartamentoempresa] [numeric](18, 0) NOT NULL,
	[nombredeptoempresa] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DESCUENTOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DESCUENTOS](
	[iddescuento] [numeric](18, 0) NOT NULL,
	[idtipodescuento] [numeric](18, 0) NOT NULL,
	[idtipopago] [numeric](18, 0) NOT NULL,
	[id] [numeric](18, 0) NOT NULL,
	[id_sede] [int] NOT NULL,
	[descripcion] [varchar](40) NULL,
	[porcentaje] [decimal](5, 2) NULL,
	[defaultt] [numeric](2, 0) NULL,
	[estado] [numeric](3, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLE_COTIZACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_COTIZACION](
	[iddetallecotizacion] [int] IDENTITY(1,1) NOT NULL,
	[idcotizacion] [int] NOT NULL,
	[idlistaprecio] [int] NOT NULL,
	[cantidad] [int] NULL,
	[idbodega] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[impuesto] [numeric](10, 2) NULL,
	[comision] [numeric](10, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_DEVOLUCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_DEVOLUCION](
	[iddetalledevolucion] [int] IDENTITY(1,1) NOT NULL,
	[iddevolucion] [int] NOT NULL,
	[idbodega] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[impuesto] [numeric](10, 2) NULL,
	[idlistaprecio] [int] NOT NULL,
	[cantidad] [int] NULL,
	[comision] [numeric](10, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_FACTURA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA](
	[iddetallefactura] [int] IDENTITY(1,1) NOT NULL,
	[idfactura] [int] NOT NULL,
	[cantidad] [int] NULL,
	[idbodega] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[idlistaprecio] [int] NOT NULL,
	[comision] [numeric](10, 2) NULL,
	[impuesto] [numeric](10, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_PAGOCXC]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLE_PAGOCXC](
	[iddetallepago] [int] IDENTITY(1,1) NOT NULL,
	[cuotas] [varchar](10) NULL,
	[valorcuotas] [numeric](10, 2) NULL,
	[noTarjeta] [varchar](20) NULL,
	[idtipopago] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLE_SOLIC_TRANSPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE](
	[idproducto] [int] NOT NULL,
	[idsolicitud] [int] NOT NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEASIGNACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEASIGNACION](
	[iddetalle] [numeric](10, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[asistencia] [int] NULL,
	[idasignacion] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEBONEMP]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEBONEMP](
	[iddetallebonemp] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idbonificacion] [numeric](18, 0) NOT NULL,
	[monto] [numeric](10, 2) NULL,
	[estado] [numeric](3, 0) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLECAPACITACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLECAPACITACION](
	[iddetalle] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[expositor] [varchar](100) NOT NULL,
	[idtipo] [numeric](18, 0) NOT NULL,
	[idcapacitacion] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLECONTRASENA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLECONTRASENA](
	[idfactura] [int] NOT NULL,
	[idcontrasena] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[monto] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEDESCEMP]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEDESCEMP](
	[iddetalledescemp] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[iddescuento] [numeric](18, 0) NOT NULL,
	[monto] [decimal](10, 2) NULL,
	[estado] [numeric](3, 0) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEENTREVISTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLEENTREVISTA](
	[iddetalleentrevista] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[identrevista] [numeric](18, 0) NOT NULL,
	[comentario] [char](10) NULL,
	[resultado1] [char](10) NULL,
	[resultado2] [char](10) NULL,
	[resultado3] [char](10) NULL,
	[total] [char](10) NULL,
	[ideresultadoentrevista] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEEVALUACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEEVALUACION](
	[iddetalle] [numeric](18, 0) NOT NULL,
	[comenhr] [text] NULL,
	[totalmetrica] [int] NULL,
	[comenempleado] [text] NOT NULL,
	[comensupervisor] [text] NOT NULL,
	[idmetrica] [numeric](18, 0) NOT NULL,
	[idevaluacion] [numeric](18, 0) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEFINANCIERO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEFINANCIERO](
	[idestadofinanciero] [int] NOT NULL,
	[idCuenta] [int] NOT NULL,
	[saldoTotal] [numeric](10, 2) NULL,
	[cargosMes] [numeric](10, 2) NULL,
	[abonosMes] [numeric](10, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEGASTOTRANSPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLEGASTOTRANSPORTE](
	[idetallegasto] [int] IDENTITY(1,1) NOT NULL,
	[facturaasociada] [varchar](50) NULL,
	[montototal] [numeric](10, 4) NULL,
	[fechafactura] [datetime] NULL,
	[notafactura] [varchar](75) NULL,
	[idgastotransporte] [int] NOT NULL,
	[idtransporte] [int] NOT NULL,
	[idsolicitud] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEINVENTARIOFISICO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEINVENTARIOFISICO](
	[idbodega] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[idinventariofisico] [int] NOT NULL,
	[existencia_congelada] [int] NOT NULL,
	[existencia_fisica] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleLaboral]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleLaboral](
	[idempleado] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL,
	[sueldo] [decimal](10, 2) NULL,
	[aumento] [decimal](10, 2) NULL,
	[puesto] [varchar](20) NULL,
	[jornada] [varchar](100) NULL,
	[departamento] [varchar](100) NULL,
	[feciniciolaboral] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEMODOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLEMODOS](
	[iddetallemodos] [int] IDENTITY(1,1) NOT NULL,
	[horas] [decimal](10, 4) NULL,
	[producto] [varchar](150) NULL,
	[empleado] [varchar](150) NULL,
	[tarea] [varchar](150) NULL,
	[iddetallemouno] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEMOUNO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEMOUNO](
	[iddetallemouno] [int] IDENTITY(1,1) NOT NULL,
	[horasrequeridas] [decimal](10, 4) NULL,
	[totalmo] [decimal](10, 4) NULL,
	[costo] [decimal](10, 4) NULL,
	[fecha] [datetime] NULL,
	[cantidad] [decimal](10, 4) NULL,
	[idmanoobra] [int] NOT NULL,
	[idordenproduccion] [int] NOT NULL,
	[idrecetario] [int] NOT NULL,
	[idasignaciontareas] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEMOVIMIENTOINVENTARIO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO](
	[idbodega] [int] NOT NULL,
	[idmovimiento] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[costo] [decimal](18, 2) NULL,
	[precio] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEORDENCOMPRA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEORDENCOMPRA](
	[iddetalleorden] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[idordencompra] [int] NULL,
	[idproducto] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetallePersonal]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallePersonal](
	[idempleado] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL,
	[nombre1] [varchar](100) NULL,
	[nombre2] [varchar](100) NULL,
	[apellido1] [varchar](100) NULL,
	[apellido2] [varchar](100) NULL,
	[apellido3] [varchar](100) NULL,
	[nacionalidad] [varchar](100) NULL,
	[sexo] [varchar](10) NULL,
	[fechanacimiento] [date] NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [int] NULL,
	[identificacion] [varchar](30) NULL,
	[idestudios] [numeric](10, 0) NOT NULL,
	[idexperencialaboral] [numeric](10, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEPLANILLA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEPLANILLA](
	[iddetalleplanilla] [numeric](18, 0) NOT NULL,
	[total] [decimal](18, 2) NULL,
	[idplanilla] [numeric](18, 0) NOT NULL,
	[idhoraextra] [numeric](18, 0) NOT NULL,
	[codvacaciones] [int] NOT NULL,
	[idcomision] [int] NOT NULL,
	[idAutorizacion] [int] NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL,
	[idtipopago] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEPOLIZA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLEPOLIZA](
	[idPoliza] [int] NOT NULL,
	[idCuenta] [int] NOT NULL,
	[clasificacion] [char](10) NULL,
	[valor] [decimal](10, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLEPOLIZAPLANILLA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEPOLIZAPLANILLA](
	[iddetallepoliza] [numeric](18, 0) NOT NULL,
	[idpolizaplanilla] [numeric](18, 0) NOT NULL,
	[idplanilla] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLEPOLIZAPROD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLEPOLIZAPROD](
	[iddetallepoliza] [int] IDENTITY(1,1) NOT NULL,
	[idpolizaproduccion] [int] NOT NULL,
	[idPoliza] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLERECETARIO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLERECETARIO](
	[iddetallerecetario] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](10, 4) NULL,
	[idrecetario] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLESOLICITUDMP]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLESOLICITUDMP](
	[iddetallesolicitudmp] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](10, 4) NULL,
	[idsolicitudmp] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLETAREA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLETAREA](
	[iddetalletarea] [int] IDENTITY(1,1) NOT NULL,
	[correlativofase] [int] NULL,
	[costoporfase] [decimal](10, 4) NULL,
	[idtarea] [int] NOT NULL,
	[idfase] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLETRANSACCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLETRANSACCION](
	[idCuenta] [int] NOT NULL,
	[idtransaccion] [int] NOT NULL,
	[valor] [numeric](10, 2) NULL,
	[nombre] [char](10) NULL,
	[clasificacion] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETINVENTARIOSPROD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETINVENTARIOSPROD](
	[idproducto] [int] NOT NULL,
	[valoractual] [decimal](10, 4) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETLABORAL]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETLABORAL](
	[coddetlaboral] [numeric](18, 0) NOT NULL,
	[id] [int] NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idpuestodetrabajo] [numeric](18, 0) NOT NULL,
	[fecfinlaboral] [date] NULL,
	[feciniciolaboral] [date] NULL,
	[comentario] [varchar](100) NULL,
	[eficiencia] [numeric](10, 0) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETORDENPROD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETORDENPROD](
	[iddetordenprod] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](10, 4) NULL,
	[idordenproduccion] [int] NOT NULL,
	[idrecetario] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETPLANIFICACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETPLANIFICACION](
	[iddetplanificacion] [int] IDENTITY(1,1) NOT NULL,
	[idplanificacion] [int] NOT NULL,
	[idordenproduccion] [int] NOT NULL,
	[iddetallemouno] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DEVOLUCIONES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEVOLUCIONES](
	[iddevolucion] [int] IDENTITY(1,1) NOT NULL,
	[fechadevolucion] [datetime] NULL,
	[descripcion] [varchar](50) NULL,
	[idtipodevolucion] [int] NOT NULL,
	[tipodocumento] [varchar](10) NULL,
	[idcliente] [int] NOT NULL,
	[idmoneda] [int] NOT NULL,
	[idvendedor] [int] NOT NULL,
	[idfactura] [int] NULL,
	[idestado] [int] NOT NULL,
	[idproveedor] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIASFESTIVOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIASFESTIVOS](
	[codfestivo] [int] NOT NULL,
	[fecha] [date] NULL,
	[descripcion] [varchar](20) NULL,
	[codperiodo] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DIASLABORALES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIASLABORALES](
	[id] [numeric](18, 0) NOT NULL,
	[idtipopago] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[idempresa] [int] NOT NULL,
	[cantidad] [numeric](3, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOCUMENTOREQUERIDO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCUMENTOREQUERIDO](
	[iddoctrans] [int] IDENTITY(1,1) NOT NULL,
	[idtiposolict] [int] NOT NULL,
	[nombredocumento] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCUMENTOSOPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCUMENTOSOPORTE](
	[idsolicitud] [int] NOT NULL,
	[documento] [varchar](50) NULL,
	[iddoctrans] [int] NOT NULL,
	[idtiposolict] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[idempleado] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idempresa] [int] NOT NULL,
	[estado] [varchar](100) NULL,
	[codusuario] [int] NULL,
	[idrol] [numeric](10, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[idempresa] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa] [char](10) NULL,
	[activo] [bit] NULL,
	[idsede] [int] NULL,
	[idmoneda] [int] NULL,
	[razonsocial] [varchar](100) NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](12) NULL,
	[identificaciontributaria] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ENTREVISTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENTREVISTA](
	[identrevista] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idcandidato] [numeric](18, 0) NULL,
	[idempleado] [numeric](18, 0) NULL,
	[idpuestodetrabajo] [numeric](18, 0) NOT NULL,
	[idetapaentrevista] [numeric](18, 0) NOT NULL,
	[fecha] [date] NULL,
	[horario] [time](7) NULL,
	[idempresa] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADO](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOCANDIDATO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOCANDIDATO](
	[idestadocandidato] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descipcion] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOCIVIL]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOCIVIL](
	[idestadocivil] [numeric](18, 0) NOT NULL,
	[descipcion] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOCONTRASENA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOCONTRASENA](
	[idestadocontrasena] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOCUENTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOCUENTA](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[status] [char](10) NULL,
	[fecha] [date] NULL,
	[docref] [char](100) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOFINANCIERO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOFINANCIERO](
	[idestadofinanciero] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](100) NULL,
	[descripcion] [char](200) NULL,
	[periodo] [char](100) NULL,
	[ciclo] [char](10) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOORDEN]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOORDEN](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOORDENPLA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOORDENPLA](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOPUESTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOPUESTO](
	[idestadopuesto] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTADOSOLICITUDTRANS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADOSOLICITUDTRANS](
	[idestadost] [int] IDENTITY(1,1) NOT NULL,
	[nombreestadost] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTUDIOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTUDIOS](
	[idestudios] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[tipodeestudio] [varchar](30) NULL,
	[lugar] [varchar](100) NULL,
	[idcandidato] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ETAPAENTREVISTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ETAPAENTREVISTA](
	[idetapaentrevista] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EVALUACIONDESEMPEÑO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EVALUACIONDESEMPEÑO](
	[idevaluacion] [numeric](18, 0) NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[totalevaluacion] [numeric](10, 0) NULL,
	[fechainicio] [date] NOT NULL,
	[fechafin] [date] NOT NULL,
	[idperiodo] [char](10) NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EXISTENCIA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXISTENCIA](
	[idbodega] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EXPERIENCIALABORAL]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EXPERIENCIALABORAL](
	[idexperencialaboral] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[lugar] [varchar](100) NULL,
	[anos] [int] NULL,
	[idcandidato] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FACTURA](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idvendedor] [int] NOT NULL,
	[idmoneda] [int] NOT NULL,
	[total] [numeric](10, 2) NULL,
	[subtotal] [numeric](10, 2) NULL,
	[impuesto] [numeric](10, 2) NULL,
	[fechafactura] [datetime] NULL,
	[tipodocumento] [varchar](30) NULL,
	[idestado] [int] NOT NULL,
	[idtipopago] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FACTURAPROVEEDORES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FACTURAPROVEEDORES](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[corrfactura] [varchar](30) NOT NULL,
	[idserie] [int] NULL,
	[total] [numeric](18, 2) NULL,
	[saldo] [numeric](18, 2) NULL,
	[fecha] [datetime] NULL,
	[idproveedor] [int] NOT NULL,
	[idbodega] [int] NOT NULL,
	[idmovimiento] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FASESPLANIFICACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FASESPLANIFICACION](
	[idfaseplanificacion] [int] IDENTITY(1,1) NOT NULL,
	[iniciado] [bit] NULL,
	[fechainicio] [datetime] NULL,
	[finalizado] [bit] NULL,
	[fechafinalizado] [datetime] NULL,
	[costoporfase] [decimal](10, 4) NULL,
	[costototalmo] [decimal](10, 4) NULL,
	[iddetplanificacion] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FASETAREA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FASETAREA](
	[idfase] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[estado] [varchar](150) NULL,
	[nombre] [varchar](150) NULL,
	[totalcantidadpersonas] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GASTO_CAMPANIA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GASTO_CAMPANIA](
	[idgastocampania] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[total] [numeric](10, 2) NULL,
	[idcampania] [int] NOT NULL,
	[idPoliza] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GASTOSCOMPLETOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GASTOSCOMPLETOS](
	[idordenproduccion] [int] NOT NULL,
	[iddetallemouno] [int] NOT NULL,
	[idrecetario] [int] NOT NULL,
	[idmateriaprimausada] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HORASEXTRA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORASEXTRA](
	[idhoraextra] [numeric](18, 0) NOT NULL,
	[cantidad] [numeric](2, 0) NULL,
	[id] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVENTARIOFISICO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIOFISICO](
	[idinventariofisico] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[codusuario] [int] NOT NULL,
	[idrol] [numeric](10, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVENTARIOSPROD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIOSPROD](
	[idproducto] [int] NOT NULL,
	[existencia] [decimal](10, 4) NULL,
	[idunidadmedida] [int] NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JORNADA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JORNADA](
	[idjornada] [numeric](18, 0) NOT NULL,
	[descripcion] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINEA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINEA](
	[idlinea] [int] IDENTITY(1,1) NOT NULL,
	[condicion] [bit] NULL,
	[estado] [char](10) NULL,
	[descripcion] [char](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LISTAPRECIOS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LISTAPRECIOS](
	[idlistaprecio] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](40) NULL,
	[preciounitario] [numeric](10, 2) NULL,
	[idproducto] [int] NOT NULL,
	[idtipolistaprecio] [int] NOT NULL,
	[idestado] [int] NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[M_GASTOTRANSPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[M_GASTOTRANSPORTE](
	[idgastotransporte] [int] IDENTITY(1,1) NOT NULL,
	[idtransporte] [int] NOT NULL,
	[idsolicitud] [int] NOT NULL,
	[gastotoal] [numeric](10, 4) NULL,
	[justificacion] [varchar](250) NULL,
	[fechagasto] [datetime] NULL,
	[idAutorizacion] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANOOBRA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANOOBRA](
	[idmanoobra] [int] IDENTITY(1,1) NOT NULL,
	[codprodmo] [varchar](10) NULL,
	[horas] [decimal](10, 4) NULL,
	[salario] [decimal](10, 4) NULL,
	[iddetalletarea] [int] NOT NULL,
	[id] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MARCA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCA](
	[idmarca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[METODOCOSTEO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[METODOCOSTEO](
	[idmetodo] [int] IDENTITY(1,1) NOT NULL,
	[nommetodo] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[METRICA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[METRICA](
	[idmetrica] [numeric](18, 0) NOT NULL,
	[nommetrica] [varchar](75) NOT NULL,
	[descripmetrica] [varchar](150) NOT NULL,
	[idempresa] [int] NOT NULL,
	[status] [int] NOT NULL,
	[iddepartamentoempresa] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONEDA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONEDA](
	[idmoneda] [int] IDENTITY(1,1) NOT NULL,
	[nombre_moneda] [varchar](10) NULL,
	[simbolo_moneda] [varchar](10) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MORDENSERVICIOV]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MORDENSERVICIOV](
	[idtransporte] [int] NOT NULL,
	[idordenserv] [int] IDENTITY(1,1) NOT NULL,
	[facturataller] [varchar](50) NULL,
	[fechaservicio] [datetime] NULL,
	[fechaproximoservicio] [datetime] NULL,
	[kmsactuales] [numeric](10, 3) NULL,
	[kmsproximoservicio] [numeric](10, 3) NULL,
	[monto] [decimal](10, 2) NULL,
	[idAutorizacion] [int] NOT NULL,
	[idtiposerviciovh] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOTIVO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOTIVO](
	[codmotivo] [numeric](18, 0) NOT NULL,
	[motivo] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOVIMIENTOSINVENTARIO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOSINVENTARIO](
	[idbodega] [int] NOT NULL,
	[idmovimiento] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[idtipomovimiento] [int] NOT NULL,
	[idmoneda] [int] NOT NULL,
	[idrefmovimiento] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NACIONALIDAD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NACIONALIDAD](
	[idnacionalidad] [numeric](18, 0) NOT NULL,
	[descripcion] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORDENCOMPRA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORDENCOMPRA](
	[idordencompra] [int] IDENTITY(1,1) NOT NULL,
	[observacion] [varchar](500) NULL,
	[total] [decimal](18, 2) NULL,
	[usuario_registro] [varchar](100) NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_vencimiento] [datetime] NULL,
	[idsede] [int] NULL,
	[idcentro] [int] NULL,
	[idproveedor] [int] NULL,
	[idmoneda] [int] NULL,
	[idestado] [int] NULL,
	[idtipooc] [int] NOT NULL,
	[idAutorizacion] [int] NOT NULL,
	[idCuenta] [int] NOT NULL,
	[idempresa] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORDENPRODUCCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORDENPRODUCCION](
	[idordenproduccion] [int] IDENTITY(1,1) NOT NULL,
	[fechacreacion] [datetime] NULL,
	[fechasolicitud] [datetime] NULL,
	[fechaenvio] [datetime] NULL,
	[descripcion] [varchar](150) NULL,
	[totalcantidad] [decimal](10, 4) NULL,
	[referencia] [varchar](150) NULL,
	[idestado] [int] NOT NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERIODO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERIODO](
	[idperiodo] [char](10) NOT NULL,
	[periodo] [varchar](40) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERIODOPLANILLA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERIODOPLANILLA](
	[id] [numeric](18, 0) NOT NULL,
	[mes] [char](10) NULL,
	[year] [char](10) NULL,
	[dias_pago] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERIODOV]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERIODOV](
	[codperiodo] [int] NOT NULL,
	[perdescripcion] [varchar](50) NULL,
	[perestatus] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PLANIFICACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PLANIFICACION](
	[idplanificacion] [int] IDENTITY(1,1) NOT NULL,
	[fechacreacionpl] [datetime] NULL,
	[fechaestimada] [datetime] NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL,
	[totalordenesprod] [decimal](10, 4) NULL,
	[costototalfases] [decimal](10, 4) NULL,
	[costototalmo] [decimal](10, 4) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PLANILLAS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLANILLAS](
	[idplanilla] [numeric](18, 0) NOT NULL,
	[id] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NULL,
	[total] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[POLIZA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POLIZA](
	[idPoliza] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](100) NULL,
	[descripcion] [char](100) NULL,
	[fecha] [date] NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POLIZAPLANILLA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POLIZAPLANILLA](
	[idpolizaplanilla] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NULL,
	[estado] [numeric](2, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[POLIZAPRODUCCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POLIZAPRODUCCION](
	[idpolizaproduccion] [int] IDENTITY(1,1) NOT NULL,
	[fechapolizaproduccion] [datetime] NULL,
	[inventarioinicialmateriaprima] [decimal](10, 4) NULL,
	[mascompras] [decimal](10, 4) NULL,
	[menosdevoluciondecompras] [decimal](10, 4) NULL,
	[comprasnetas] [decimal](10, 4) NULL,
	[mercanciadisponible] [decimal](10, 4) NULL,
	[menosinventariofinaldemateriaprima] [decimal](10, 4) NULL,
	[costodelmaterialllevadoaproduccion] [decimal](10, 4) NULL,
	[manodeobradelperiodo] [decimal](10, 4) NULL,
	[cargafabril] [decimal](10, 4) NULL,
	[costosdemanufactura] [decimal](10, 4) NULL,
	[inventarioinicialproductosenproceso] [decimal](10, 4) NULL,
	[productosenprocesodetransformacion] [decimal](10, 4) NULL,
	[menosinventariofinalproductosenproceso] [decimal](10, 4) NULL,
	[costodeproductosterminadosytransferidos] [decimal](10, 4) NULL,
	[idordenproduccion] [int] NOT NULL,
	[idproducto] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[stockminimo] [int] NULL,
	[stockmaximo] [int] NULL,
	[cantidad] [int] NULL,
	[activo] [bit] NULL,
	[idproveedor] [int] NULL,
	[idtipoproducto] [int] NULL,
	[idmarca] [int] NOT NULL,
	[fechacreacion] [datetime] NULL,
	[idmetodo] [int] NOT NULL,
	[idlinea] [int] NOT NULL,
	[tamano] [numeric](10, 3) NULL,
	[peso] [numeric](10, 3) NULL,
	[precio] [numeric](10, 3) NULL,
	[costo] [numeric](10, 3) NULL,
	[idempresa] [int] NOT NULL,
	[unidadpeso] [int] NOT NULL,
	[unidadtamano] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRORRATERO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRORRATERO](
	[fechaprorrateo] [datetime] NULL,
	[materiaprimadirecta] [varchar](150) NULL,
	[manodeobradirecta] [varchar](150) NULL,
	[costoprimo] [decimal](10, 4) NULL,
	[factor] [decimal](10, 4) NULL,
	[gastosindirectosprorrateados] [decimal](10, 4) NULL,
	[cantidadproducida] [decimal](10, 4) NULL,
	[costounitario] [decimal](10, 4) NULL,
	[costototal] [decimal](10, 4) NULL,
	[idordenproduccion] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_proveedor] [varchar](100) NULL,
	[direccion] [varchar](300) NULL,
	[telefono] [int] NULL,
	[nit] [varchar](50) NULL,
	[activo] [bit] NULL,
	[idsede] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PUESTODETRABAJO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PUESTODETRABAJO](
	[idpuestodetrabajo] [numeric](18, 0) NOT NULL,
	[iddepartamentoempresa] [numeric](18, 0) NOT NULL,
	[idestadopuesto] [numeric](18, 0) NOT NULL,
	[nombrepuesto] [varchar](30) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RECETARIO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RECETARIO](
	[idrecetario] [int] IDENTITY(1,1) NOT NULL,
	[fechacreacion] [datetime] NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL,
	[totalcantidad] [decimal](10, 4) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RECETARIOGASTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECETARIOGASTO](
	[idrecetario] [int] NOT NULL,
	[idgasto] [int] NOT NULL,
	[gastofabricacion] [decimal](10, 4) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RECETARIOMATERIA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECETARIOMATERIA](
	[idmateriaprimausada] [int] IDENTITY(1,1) NOT NULL,
	[idordenproduccion] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[gasto] [decimal](10, 4) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[REFERENCIAMOVIMIENTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REFERENCIAMOVIMIENTO](
	[idrefmovimiento] [int] IDENTITY(1,1) NOT NULL,
	[idordencompra] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RESULTADOENTREVISTA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RESULTADOENTREVISTA](
	[ideresultadoentrevista] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROL](
	[idrol] [numeric](10, 0) NOT NULL,
	[rol] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEDE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEDE](
	[idsede] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sede] [varchar](100) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEXO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEXO](
	[idsexo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUDMP]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUDMP](
	[idsolicitudmp] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[descripcion] [varchar](150) NULL,
	[totalcantidad] [decimal](10, 4) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUDPRODUCCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUDPRODUCCION](
	[idsolicitudproduccion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](50) NULL,
	[idbodega] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUDTRANSPORTE]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUDTRANSPORTE](
	[idsolicitud] [int] IDENTITY(1,1) NOT NULL,
	[notas] [varchar](200) NULL,
	[fechasolicitud] [datetime] NULL,
	[fechadesalida] [datetime] NULL,
	[fecharegreso] [datetime] NULL,
	[costoestimado] [decimal](10, 3) NULL,
	[idtiposolict] [int] NOT NULL,
	[idestadost] [int] NOT NULL,
	[idempleado] [numeric](18, 0) NOT NULL,
	[codusuario] [int] NOT NULL,
	[idrol] [numeric](10, 0) NOT NULL,
	[idempresa] [int] NOT NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUDVACACIONES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUDVACACIONES](
	[codsolicitud] [int] NOT NULL,
	[codmotivo] [numeric](18, 0) NOT NULL,
	[codvacaciones] [int] NULL,
	[fecinicial] [date] NULL,
	[fecfinal] [date] NULL,
	[candias] [varchar](10) NULL,
	[fecsolicitud] [date] NULL,
	[fecdecision] [date] NULL,
	[decision] [varchar](50) NULL,
	[descomentario] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAREA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAREA](
	[idtarea] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL,
	[estado] [varchar](150) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPO](
	[idtipo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[status] [int] NOT NULL,
	[tipo] [varchar](74) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPO_CXC]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPO_CXC](
	[idtipocxc] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOBONIFICACION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOBONIFICACION](
	[idtipobonificacion] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOCAMPANIA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOCAMPANIA](
	[idtipocampania] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOCONTRATO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOCONTRATO](
	[id] [numeric](18, 0) NOT NULL,
	[descripcion] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPODESCUENTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPODESCUENTO](
	[idtipodescuento] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPODEVOLUCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPODEVOLUCION](
	[idtipodevolucion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOGASTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOGASTO](
	[idgasto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOLISTAPRECIO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOLISTAPRECIO](
	[idtipolistaprecio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOMOVIMIENTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOMOVIMIENTO](
	[idtipomovimiento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[activo] [bit] NULL,
	[operacion] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOOC]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOOC](
	[idtipooc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOPAGO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOPAGO](
	[idtipopago] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOPAGOFACTURA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOPAGOFACTURA](
	[idtipopago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOPRODUCTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOPRODUCTO](
	[idtipoproducto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOSERVICIOVH]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOSERVICIOVH](
	[idtiposerviciovh] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](75) NULL,
	[kmrecorridos] [decimal](10, 3) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOSOLICTRANS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOSOLICTRANS](
	[idtiposolict] [int] IDENTITY(1,1) NOT NULL,
	[nombretipost] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOTRANS]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOTRANS](
	[status] [char](10) NULL,
	[nombre] [char](100) NULL,
	[accion] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOUNIDAD]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOUNIDAD](
	[idtipounidad] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[simbolo] [varchar](20) NULL,
	[tipo] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOVEHICULO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOVEHICULO](
	[idtipotrans] [int] IDENTITY(1,1) NOT NULL,
	[nombretipotrans] [varchar](75) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRANSACCION]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRANSACCION](
	[idtransaccion] [int] IDENTITY(1,1) NOT NULL,
	[beneficiario] [char](100) NULL,
	[status] [char](10) NULL,
	[docref] [char](80) NULL,
	[saldo] [numeric](10, 2) NULL,
	[fecha] [datetime] NULL,
	[idcuenta] [int] NOT NULL,
	[idempresa] [int] NOT NULL,
	[idAutorizacion] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRAYECTO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRAYECTO](
	[idtrayecto] [int] IDENTITY(1,1) NOT NULL,
	[idsolicitud] [int] NOT NULL,
	[fechasalida] [datetime] NULL,
	[fechallegada] [datetime] NULL,
	[origen] [varchar](100) NULL,
	[destino] [varchar](100) NULL,
	[kilometraje] [numeric](10, 3) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UNIDADMEDIDA]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNIDADMEDIDA](
	[idunidadmedida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL,
	[idtipounidad] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO_1]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO_1](
	[codusuario] [int] IDENTITY(1,1) NOT NULL,
	[idrol] [numeric](10, 0) NOT NULL,
	[usuario] [varchar](20) NULL,
	[password] [varchar](200) NULL,
	[rol] [varchar](20) NULL,
	[status] [int] NULL,
	[preguntasecreta] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VACACIONES]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VACACIONES](
	[codvacaciones] [int] NOT NULL,
	[vacdistribuidas] [varchar](10) NULL,
	[idempleado] [numeric](18, 0) NULL,
	[codcalculo] [int] NOT NULL,
	[codfestivo] [int] NOT NULL,
	[idempresa] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VEHICULO]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VEHICULO](
	[idtransporte] [int] IDENTITY(1,1) NOT NULL,
	[idtipotrans] [int] NULL,
	[placa] [varchar](15) NULL,
	[modelo] [varchar](50) NOT NULL,
	[chasis] [varchar](50) NOT NULL,
	[linea] [varchar](20) NULL,
	[motor] [varchar](20) NULL,
	[color] [varchar](20) NULL,
	[marca] [varchar](40) NOT NULL,
	[kilometraje] [numeric](10, 3) NULL,
	[idempresa] [int] NOT NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 3/07/2017 1:20:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDEDOR](
	[idvendedor] [int] IDENTITY(1,1) NOT NULL,
	[idestado] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[telefono] [int] NULL,
	[direccion] [varchar](50) NULL,
	[email] [varchar](20) NULL,
	[idempresa] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BODEGA] ON 

INSERT [dbo].[BODEGA] ([idbodega], [nombre_bodega], [encargado], [stock_minimo], [stock_maximo], [activo], [idempresa]) VALUES (1, N'Bodega 1', N'Pamela ', 12, 34, 1, 1)
INSERT [dbo].[BODEGA] ([idbodega], [nombre_bodega], [encargado], [stock_minimo], [stock_maximo], [activo], [idempresa]) VALUES (2, N'Bodega 2', N'Pamela Selman', 12, 223, 0, 1)
INSERT [dbo].[BODEGA] ([idbodega], [nombre_bodega], [encargado], [stock_minimo], [stock_maximo], [activo], [idempresa]) VALUES (3, N'Bodega 2', N'Pamela', 11, 130, 1, 1)
SET IDENTITY_INSERT [dbo].[BODEGA] OFF
SET IDENTITY_INSERT [dbo].[CONTRASENA] ON 

INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (1, 1, 1, 3)
INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (2, 1, 1, 1)
INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (3, 1, 1, 1)
INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (4, 1, 1, 1)
INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (5, 1, 1, 1)
INSERT [dbo].[CONTRASENA] ([idcontrasena], [idproveedor], [idsede], [idestadocontrasena]) VALUES (6, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[CONTRASENA] OFF
INSERT [dbo].[DETALLECONTRASENA] ([idfactura], [idcontrasena], [fecha], [monto]) VALUES (2, 6, CAST(N'2017-07-03 00:50:12.423' AS DateTime), CAST(2300.00 AS Decimal(18, 2)))
INSERT [dbo].[DETALLEMOVIMIENTOINVENTARIO] ([idbodega], [idmovimiento], [idproducto], [cantidad], [costo], [precio]) VALUES (1, 3, 1, 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2300.00 AS Decimal(18, 2)))
INSERT [dbo].[DETALLEMOVIMIENTOINVENTARIO] ([idbodega], [idmovimiento], [idproducto], [cantidad], [costo], [precio]) VALUES (1, 5, 1, 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2300.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[EMPLEADO] ON 

INSERT [dbo].[EMPLEADO] ([idempleado], [idempresa], [estado], [codusuario], [idrol]) VALUES (CAST(1 AS Numeric(18, 0)), 1, N'1', 1, CAST(1 AS Numeric(10, 0)))
SET IDENTITY_INSERT [dbo].[EMPLEADO] OFF
SET IDENTITY_INSERT [dbo].[EMPRESA] ON 

INSERT [dbo].[EMPRESA] ([idempresa], [nombre_empresa], [activo], [idsede], [idmoneda], [razonsocial], [direccion], [telefono], [identificaciontributaria]) VALUES (1, N'Empresa 1 ', 1, 1, 1, N'Empresa 1', N'Guatemala', N'22222222', N'prueba')
INSERT [dbo].[EMPRESA] ([idempresa], [nombre_empresa], [activo], [idsede], [idmoneda], [razonsocial], [direccion], [telefono], [identificaciontributaria]) VALUES (2, N'Prueba    ', 1, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[EMPRESA] OFF
SET IDENTITY_INSERT [dbo].[ESTADOCONTRASENA] ON 

INSERT [dbo].[ESTADOCONTRASENA] ([idestadocontrasena], [descripcion], [activo]) VALUES (1, N'Ingresada', 1)
INSERT [dbo].[ESTADOCONTRASENA] ([idestadocontrasena], [descripcion], [activo]) VALUES (2, N'Autorizada', 1)
INSERT [dbo].[ESTADOCONTRASENA] ([idestadocontrasena], [descripcion], [activo]) VALUES (3, N'Pagada', 1)
SET IDENTITY_INSERT [dbo].[ESTADOCONTRASENA] OFF
SET IDENTITY_INSERT [dbo].[ESTADOSOLICITUDTRANS] ON 

INSERT [dbo].[ESTADOSOLICITUDTRANS] ([idestadost], [nombreestadost]) VALUES (1, N'Enviado')
INSERT [dbo].[ESTADOSOLICITUDTRANS] ([idestadost], [nombreestadost]) VALUES (2, N'Aprobado')
INSERT [dbo].[ESTADOSOLICITUDTRANS] ([idestadost], [nombreestadost]) VALUES (3, N'Rechazado')
INSERT [dbo].[ESTADOSOLICITUDTRANS] ([idestadost], [nombreestadost]) VALUES (4, N'En Camino')
INSERT [dbo].[ESTADOSOLICITUDTRANS] ([idestadost], [nombreestadost]) VALUES (5, N'END')
SET IDENTITY_INSERT [dbo].[ESTADOSOLICITUDTRANS] OFF
SET IDENTITY_INSERT [dbo].[FACTURAPROVEEDORES] ON 

INSERT [dbo].[FACTURAPROVEEDORES] ([idfactura], [corrfactura], [idserie], [total], [saldo], [fecha], [idproveedor], [idbodega], [idmovimiento]) VALUES (2, N'2345', 1, CAST(2300.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(N'2017-07-02 00:00:00.000' AS DateTime), 1, 1, 3)
INSERT [dbo].[FACTURAPROVEEDORES] ([idfactura], [corrfactura], [idserie], [total], [saldo], [fecha], [idproveedor], [idbodega], [idmovimiento]) VALUES (3, N'2346', 1, CAST(2300.00 AS Numeric(18, 2)), CAST(2300.00 AS Numeric(18, 2)), CAST(N'2017-07-02 00:00:00.000' AS DateTime), 1, 1, 5)
SET IDENTITY_INSERT [dbo].[FACTURAPROVEEDORES] OFF
SET IDENTITY_INSERT [dbo].[LINEA] ON 

INSERT [dbo].[LINEA] ([idlinea], [condicion], [estado], [descripcion]) VALUES (1, 1, N'Activo    ', N'Linea 1                                                                                             ')
SET IDENTITY_INSERT [dbo].[LINEA] OFF
SET IDENTITY_INSERT [dbo].[MARCA] ON 

INSERT [dbo].[MARCA] ([idmarca], [descripcion]) VALUES (1, N'Marca 1')
INSERT [dbo].[MARCA] ([idmarca], [descripcion]) VALUES (2, N'Marca 2')
INSERT [dbo].[MARCA] ([idmarca], [descripcion]) VALUES (3, N'Marca 3')
INSERT [dbo].[MARCA] ([idmarca], [descripcion]) VALUES (4, N'Prueba Marca')
SET IDENTITY_INSERT [dbo].[MARCA] OFF
SET IDENTITY_INSERT [dbo].[METODOCOSTEO] ON 

INSERT [dbo].[METODOCOSTEO] ([idmetodo], [nommetodo]) VALUES (1, N'Prueba Metodo')
SET IDENTITY_INSERT [dbo].[METODOCOSTEO] OFF
SET IDENTITY_INSERT [dbo].[MONEDA] ON 

INSERT [dbo].[MONEDA] ([idmoneda], [nombre_moneda], [simbolo_moneda], [activo]) VALUES (1, N'Quetzal', N'Q', NULL)
SET IDENTITY_INSERT [dbo].[MONEDA] OFF
SET IDENTITY_INSERT [dbo].[MOVIMIENTOSINVENTARIO] ON 

INSERT [dbo].[MOVIMIENTOSINVENTARIO] ([idbodega], [idmovimiento], [fecha], [idtipomovimiento], [idmoneda], [idrefmovimiento]) VALUES (1, 3, CAST(N'2017-07-02 00:00:00.000' AS DateTime), 1, 1, NULL)
INSERT [dbo].[MOVIMIENTOSINVENTARIO] ([idbodega], [idmovimiento], [fecha], [idtipomovimiento], [idmoneda], [idrefmovimiento]) VALUES (1, 5, CAST(N'2017-07-03 00:00:00.000' AS DateTime), 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[MOVIMIENTOSINVENTARIO] OFF
SET IDENTITY_INSERT [dbo].[PRODUCTO] ON 

INSERT [dbo].[PRODUCTO] ([idproducto], [descripcion], [stockminimo], [stockmaximo], [cantidad], [activo], [idproveedor], [idtipoproducto], [idmarca], [fechacreacion], [idmetodo], [idlinea], [tamano], [peso], [precio], [costo], [idempresa], [unidadpeso], [unidadtamano]) VALUES (1, N'Producto', 12, 45, NULL, 1, 1, 1, 1, CAST(N'2017-07-02 21:01:26.500' AS DateTime), 1, 1, CAST(50.000 AS Numeric(10, 3)), CAST(100.000 AS Numeric(10, 3)), NULL, NULL, 1, 1, 2)
SET IDENTITY_INSERT [dbo].[PRODUCTO] OFF
SET IDENTITY_INSERT [dbo].[PROVEEDOR] ON 

INSERT [dbo].[PROVEEDOR] ([idproveedor], [nombre_proveedor], [direccion], [telefono], [nit], [activo], [idsede]) VALUES (1, N'Prueba Proveedor', N'Guatemala', 22222222, NULL, 1, 1)
INSERT [dbo].[PROVEEDOR] ([idproveedor], [nombre_proveedor], [direccion], [telefono], [nit], [activo], [idsede]) VALUES (2, N'Proveedor 2', NULL, NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[PROVEEDOR] OFF
INSERT [dbo].[ROL] ([idrol], [rol]) VALUES (CAST(1 AS Numeric(10, 0)), N'Administrador')
SET IDENTITY_INSERT [dbo].[SEDE] ON 

INSERT [dbo].[SEDE] ([idsede], [nombre_sede], [activo]) VALUES (1, N'Guatemala', 1)
INSERT [dbo].[SEDE] ([idsede], [nombre_sede], [activo]) VALUES (2, N'Prueba Sede', 1)
SET IDENTITY_INSERT [dbo].[SEDE] OFF
SET IDENTITY_INSERT [dbo].[TIPOMOVIMIENTO] ON 

INSERT [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento], [descripcion], [activo], [operacion]) VALUES (1, N'Ingreso Inventario por Compra', 1, 1)
INSERT [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento], [descripcion], [activo], [operacion]) VALUES (2, N'Ingreso Inventario por Traslado', 1, 1)
INSERT [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento], [descripcion], [activo], [operacion]) VALUES (3, N'Egreso Inventario para Traslado', 1, 0)
INSERT [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento], [descripcion], [activo], [operacion]) VALUES (4, N'Devolución por Compras', 1, 0)
INSERT [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento], [descripcion], [activo], [operacion]) VALUES (5, N'Devolución por Ventas', 1, 1)
SET IDENTITY_INSERT [dbo].[TIPOMOVIMIENTO] OFF
SET IDENTITY_INSERT [dbo].[TIPOPRODUCTO] ON 

INSERT [dbo].[TIPOPRODUCTO] ([idtipoproducto], [descripcion], [activo]) VALUES (1, N'Final', 1)
INSERT [dbo].[TIPOPRODUCTO] ([idtipoproducto], [descripcion], [activo]) VALUES (2, N'Materia Prima', 1)
SET IDENTITY_INSERT [dbo].[TIPOPRODUCTO] OFF
SET IDENTITY_INSERT [dbo].[TIPOSOLICTRANS] ON 

INSERT [dbo].[TIPOSOLICTRANS] ([idtiposolict], [nombretipost]) VALUES (1, N'Envio a Cliente')
INSERT [dbo].[TIPOSOLICTRANS] ([idtiposolict], [nombretipost]) VALUES (2, N'Traslado entre bodegas')
INSERT [dbo].[TIPOSOLICTRANS] ([idtiposolict], [nombretipost]) VALUES (3, N'Importacion')
INSERT [dbo].[TIPOSOLICTRANS] ([idtiposolict], [nombretipost]) VALUES (4, N'Exportacion')
SET IDENTITY_INSERT [dbo].[TIPOSOLICTRANS] OFF
SET IDENTITY_INSERT [dbo].[TIPOUNIDAD] ON 

INSERT [dbo].[TIPOUNIDAD] ([idtipounidad], [descripcion], [simbolo], [tipo]) VALUES (1, N'Litros', N'L', 2)
INSERT [dbo].[TIPOUNIDAD] ([idtipounidad], [descripcion], [simbolo], [tipo]) VALUES (2, N'Metros', N'm', 1)
INSERT [dbo].[TIPOUNIDAD] ([idtipounidad], [descripcion], [simbolo], [tipo]) VALUES (3, N'Centímetros', N'cm', 1)
INSERT [dbo].[TIPOUNIDAD] ([idtipounidad], [descripcion], [simbolo], [tipo]) VALUES (4, N'Galones', N'G', 2)
INSERT [dbo].[TIPOUNIDAD] ([idtipounidad], [descripcion], [simbolo], [tipo]) VALUES (5, N'Kilogramos', N'Kg', 2)
SET IDENTITY_INSERT [dbo].[TIPOUNIDAD] OFF
SET IDENTITY_INSERT [dbo].[TIPOVEHICULO] ON 

INSERT [dbo].[TIPOVEHICULO] ([idtipotrans], [nombretipotrans]) VALUES (1, N'Automovil')
INSERT [dbo].[TIPOVEHICULO] ([idtipotrans], [nombretipotrans]) VALUES (2, N'Camion')
INSERT [dbo].[TIPOVEHICULO] ([idtipotrans], [nombretipotrans]) VALUES (3, N'Motocicleta')
SET IDENTITY_INSERT [dbo].[TIPOVEHICULO] OFF
SET IDENTITY_INSERT [dbo].[UNIDADMEDIDA] ON 

INSERT [dbo].[UNIDADMEDIDA] ([idunidadmedida], [nombre], [descripcion], [idtipounidad]) VALUES (1, N'LITTROS', NULL, 1)
INSERT [dbo].[UNIDADMEDIDA] ([idunidadmedida], [nombre], [descripcion], [idtipounidad]) VALUES (2, N'MASITA', NULL, 2)
SET IDENTITY_INSERT [dbo].[UNIDADMEDIDA] OFF
SET IDENTITY_INSERT [dbo].[USUARIO_1] ON 

INSERT [dbo].[USUARIO_1] ([codusuario], [idrol], [usuario], [password], [rol], [status], [preguntasecreta]) VALUES (1, CAST(1 AS Numeric(10, 0)), N'admin', N'admin', N'1', 1, N'Si')
INSERT [dbo].[USUARIO_1] ([codusuario], [idrol], [usuario], [password], [rol], [status], [preguntasecreta]) VALUES (2, CAST(1 AS Numeric(10, 0)), N'PRUEBA', N'PRUEBA', N'1', NULL, NULL)
SET IDENTITY_INSERT [dbo].[USUARIO_1] OFF
/****** Object:  Index [PK174]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[AJUSTECONSILIACION] ADD  CONSTRAINT [PK174] PRIMARY KEY NONCLUSTERED 
(
	[idAjuste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK2_1_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ASIGNACION] ADD  CONSTRAINT [PK2_1_3] PRIMARY KEY NONCLUSTERED 
(
	[idasignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK17_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ASIGNACIONPERSONAL] ADD  CONSTRAINT [PK17_1] PRIMARY KEY NONCLUSTERED 
(
	[idasigpersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK331]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ASIGNACIONTAREAS] ADD  CONSTRAINT [PK331] PRIMARY KEY NONCLUSTERED 
(
	[idasignaciontareas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK24]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[AUTORIZACION] ADD  CONSTRAINT [PK24] PRIMARY KEY NONCLUSTERED 
(
	[idAutorizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK8]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[Bitacora_Autorizacion_Orden] ADD  CONSTRAINT [PK8] PRIMARY KEY NONCLUSTERED 
(
	[id_bitacora_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK18]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[BITACORATRANSPORTE] ADD  CONSTRAINT [PK18] PRIMARY KEY NONCLUSTERED 
(
	[idbitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK10]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[BODEGA] ADD  CONSTRAINT [PK10] PRIMARY KEY NONCLUSTERED 
(
	[idbodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK162]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[BONIFICACIONES] ADD  CONSTRAINT [PK162] PRIMARY KEY NONCLUSTERED 
(
	[idbonificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK318]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CAJA] ADD  CONSTRAINT [PK318] PRIMARY KEY NONCLUSTERED 
(
	[idcaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK178]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CALCULODEVACACIONES] ADD  CONSTRAINT [PK178] PRIMARY KEY NONCLUSTERED 
(
	[codcalculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK295]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CAMPANIA] ADD  CONSTRAINT [PK295] PRIMARY KEY NONCLUSTERED 
(
	[idcampania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK308]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CAMPANIA_VENTA] ADD  CONSTRAINT [PK308] PRIMARY KEY NONCLUSTERED 
(
	[iddetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK316]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CANCELACIONCXC] ADD  CONSTRAINT [PK316] PRIMARY KEY NONCLUSTERED 
(
	[idcancelacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK19_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CANDIDATO] ADD  CONSTRAINT [PK19_2] PRIMARY KEY NONCLUSTERED 
(
	[idcandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK24_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CANDIDATOPLAZA] ADD  CONSTRAINT [PK24_2] PRIMARY KEY NONCLUSTERED 
(
	[idplazacandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK1_1_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CAPACITACION] ADD  CONSTRAINT [PK1_1_1] PRIMARY KEY NONCLUSTERED 
(
	[idcapacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK5_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CENTROCOSTO] ADD  CONSTRAINT [PK5_1] PRIMARY KEY NONCLUSTERED 
(
	[idcentro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK288]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CLIENTE] ADD  CONSTRAINT [PK288] PRIMARY KEY NONCLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK293]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[COMISION] ADD  CONSTRAINT [PK293] PRIMARY KEY NONCLUSTERED 
(
	[idcomision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK20]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CONCILIACION] ADD  CONSTRAINT [PK20] PRIMARY KEY NONCLUSTERED 
(
	[idconciliacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK11_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CONTRASENA] ADD  CONSTRAINT [PK11_1] PRIMARY KEY NONCLUSTERED 
(
	[idcontrasena] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK323]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CONVERSION] ADD  CONSTRAINT [PK323] PRIMARY KEY NONCLUSTERED 
(
	[idconversion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK299]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[COTIZACION] ADD  CONSTRAINT [PK299] PRIMARY KEY NONCLUSTERED 
(
	[idcotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CUENTA] ADD  CONSTRAINT [PK1_2] PRIMARY KEY NONCLUSTERED 
(
	[idcuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK23]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CUENTACONTABLE] ADD  CONSTRAINT [PK23] PRIMARY KEY NONCLUSTERED 
(
	[idCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK313]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] ADD  CONSTRAINT [PK313] PRIMARY KEY NONCLUSTERED 
(
	[idcuentaporcobrar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK17_2_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DEPARTAMENTOEMPRESA] ADD  CONSTRAINT [PK17_2_1] PRIMARY KEY NONCLUSTERED 
(
	[iddepartamentoempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK161]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DESCUENTOS] ADD  CONSTRAINT [PK161] PRIMARY KEY NONCLUSTERED 
(
	[iddescuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK300]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLE_COTIZACION] ADD  CONSTRAINT [PK300] PRIMARY KEY NONCLUSTERED 
(
	[iddetallecotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK311]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLE_DEVOLUCION] ADD  CONSTRAINT [PK311] PRIMARY KEY NONCLUSTERED 
(
	[iddetalledevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK307]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLE_FACTURA] ADD  CONSTRAINT [PK307] PRIMARY KEY NONCLUSTERED 
(
	[iddetallefactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK315]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLE_PAGOCXC] ADD  CONSTRAINT [PK315] PRIMARY KEY NONCLUSTERED 
(
	[iddetallepago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK2_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE] ADD  CONSTRAINT [PK2_1] PRIMARY KEY NONCLUSTERED 
(
	[idproducto] ASC,
	[idsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3_1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEASIGNACION] ADD  CONSTRAINT [PK3_1_2] PRIMARY KEY NONCLUSTERED 
(
	[iddetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK171_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEBONEMP] ADD  CONSTRAINT [PK171_1] PRIMARY KEY NONCLUSTERED 
(
	[iddetallebonemp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK4_4]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLECAPACITACION] ADD  CONSTRAINT [PK4_4] PRIMARY KEY NONCLUSTERED 
(
	[iddetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK16]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLECONTRASENA] ADD  CONSTRAINT [PK16] PRIMARY KEY NONCLUSTERED 
(
	[idfactura] ASC,
	[idcontrasena] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK159]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEDESCEMP] ADD  CONSTRAINT [PK159] PRIMARY KEY NONCLUSTERED 
(
	[iddetalledescemp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK278]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEENTREVISTA] ADD  CONSTRAINT [PK278] PRIMARY KEY NONCLUSTERED 
(
	[iddetalleentrevista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK9_1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEEVALUACION] ADD  CONSTRAINT [PK9_1_2] PRIMARY KEY NONCLUSTERED 
(
	[iddetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK173]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEFINANCIERO] ADD  CONSTRAINT [PK173] PRIMARY KEY NONCLUSTERED 
(
	[idestadofinanciero] ASC,
	[idCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK52]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEGASTOTRANSPORTE] ADD  CONSTRAINT [PK52] PRIMARY KEY NONCLUSTERED 
(
	[idetallegasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK173_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEINVENTARIOFISICO] ADD  CONSTRAINT [PK173_1] PRIMARY KEY NONCLUSTERED 
(
	[idbodega] ASC,
	[idproducto] ASC,
	[idinventariofisico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK157]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DetalleLaboral] ADD  CONSTRAINT [PK157] PRIMARY KEY NONCLUSTERED 
(
	[idempleado] ASC,
	[idempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK335]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEMODOS] ADD  CONSTRAINT [PK335] PRIMARY KEY NONCLUSTERED 
(
	[iddetallemodos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK334]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEMOUNO] ADD  CONSTRAINT [PK334] PRIMARY KEY NONCLUSTERED 
(
	[iddetallemouno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK22]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO] ADD  CONSTRAINT [PK22] PRIMARY KEY NONCLUSTERED 
(
	[idbodega] ASC,
	[idmovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK6]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEORDENCOMPRA] ADD  CONSTRAINT [PK6] PRIMARY KEY NONCLUSTERED 
(
	[iddetalleorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK156_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DetallePersonal] ADD  CONSTRAINT [PK156_1] PRIMARY KEY NONCLUSTERED 
(
	[idempleado] ASC,
	[idempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK168]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEPLANILLA] ADD  CONSTRAINT [PK168] PRIMARY KEY NONCLUSTERED 
(
	[iddetalleplanilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK172]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEPOLIZA] ADD  CONSTRAINT [PK172] PRIMARY KEY NONCLUSTERED 
(
	[idPoliza] ASC,
	[idCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK170]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEPOLIZAPLANILLA] ADD  CONSTRAINT [PK170] PRIMARY KEY NONCLUSTERED 
(
	[iddetallepoliza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK346]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLEPOLIZAPROD] ADD  CONSTRAINT [PK346] PRIMARY KEY NONCLUSTERED 
(
	[iddetallepoliza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK322]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLERECETARIO] ADD  CONSTRAINT [PK322] PRIMARY KEY NONCLUSTERED 
(
	[iddetallerecetario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK326]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLESOLICITUDMP] ADD  CONSTRAINT [PK326] PRIMARY KEY NONCLUSTERED 
(
	[iddetallesolicitudmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK330]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLETAREA] ADD  CONSTRAINT [PK330] PRIMARY KEY NONCLUSTERED 
(
	[iddetalletarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK175]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETALLETRANSACCION] ADD  CONSTRAINT [PK175] PRIMARY KEY NONCLUSTERED 
(
	[idCuenta] ASC,
	[idtransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK354]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETINVENTARIOSPROD] ADD  CONSTRAINT [PK354] PRIMARY KEY NONCLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK4_1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETLABORAL] ADD  CONSTRAINT [PK4_1_2] PRIMARY KEY NONCLUSTERED 
(
	[coddetlaboral] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK338]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETORDENPROD] ADD  CONSTRAINT [PK338] PRIMARY KEY NONCLUSTERED 
(
	[iddetordenprod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK340]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DETPLANIFICACION] ADD  CONSTRAINT [PK340] PRIMARY KEY NONCLUSTERED 
(
	[iddetplanificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK309]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DEVOLUCIONES] ADD  CONSTRAINT [PK309] PRIMARY KEY NONCLUSTERED 
(
	[iddevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK179]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DIASFESTIVOS] ADD  CONSTRAINT [PK179] PRIMARY KEY NONCLUSTERED 
(
	[codfestivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK6_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DOCUMENTOREQUERIDO] ADD  CONSTRAINT [PK6_2] PRIMARY KEY NONCLUSTERED 
(
	[iddoctrans] ASC,
	[idtiposolict] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK53]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[DOCUMENTOSOPORTE] ADD  CONSTRAINT [PK53] PRIMARY KEY NONCLUSTERED 
(
	[idsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK1_4]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[EMPLEADO] ADD  CONSTRAINT [PK1_4] PRIMARY KEY NONCLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[EMPRESA] ADD  CONSTRAINT [PK2] PRIMARY KEY NONCLUSTERED 
(
	[idempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK25_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ENTREVISTA] ADD  CONSTRAINT [PK25_1] PRIMARY KEY NONCLUSTERED 
(
	[identrevista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK290]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADO] ADD  CONSTRAINT [PK290] PRIMARY KEY NONCLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK23_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOCANDIDATO] ADD  CONSTRAINT [PK23_3] PRIMARY KEY NONCLUSTERED 
(
	[idestadocandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK21_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOCIVIL] ADD  CONSTRAINT [PK21_2] PRIMARY KEY NONCLUSTERED 
(
	[idestadocivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOCONTRASENA] ADD  CONSTRAINT [PK3_2] PRIMARY KEY NONCLUSTERED 
(
	[idestadocontrasena] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK16_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOCUENTA] ADD  CONSTRAINT [PK16_1] PRIMARY KEY NONCLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK25]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOFINANCIERO] ADD  CONSTRAINT [PK25] PRIMARY KEY NONCLUSTERED 
(
	[idestadofinanciero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOORDEN] ADD  CONSTRAINT [PK3] PRIMARY KEY NONCLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK337]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOORDENPLA] ADD  CONSTRAINT [PK337] PRIMARY KEY NONCLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK18_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOPUESTO] ADD  CONSTRAINT [PK18_3] PRIMARY KEY NONCLUSTERED 
(
	[idestadopuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK4_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTADOSOLICITUDTRANS] ADD  CONSTRAINT [PK4_1] PRIMARY KEY NONCLUSTERED 
(
	[idestadost] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK274]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ESTUDIOS] ADD  CONSTRAINT [PK274] PRIMARY KEY NONCLUSTERED 
(
	[idestudios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK26_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ETAPAENTREVISTA] ADD  CONSTRAINT [PK26_1] PRIMARY KEY NONCLUSTERED 
(
	[idetapaentrevista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK5_1_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[EVALUACIONDESEMPEÑO] ADD  CONSTRAINT [PK5_1_1] PRIMARY KEY NONCLUSTERED 
(
	[idevaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK49]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[EXISTENCIA] ADD  CONSTRAINT [PK49] PRIMARY KEY NONCLUSTERED 
(
	[idbodega] ASC,
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK275]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[EXPERIENCIALABORAL] ADD  CONSTRAINT [PK275] PRIMARY KEY NONCLUSTERED 
(
	[idexperencialaboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK304]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[FACTURA] ADD  CONSTRAINT [PK304] PRIMARY KEY NONCLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK8_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[FACTURAPROVEEDORES] ADD  CONSTRAINT [PK8_1] PRIMARY KEY NONCLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK343]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[FASESPLANIFICACION] ADD  CONSTRAINT [PK343] PRIMARY KEY NONCLUSTERED 
(
	[idfaseplanificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK332]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[FASETAREA] ADD  CONSTRAINT [PK332] PRIMARY KEY NONCLUSTERED 
(
	[idfase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK298]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[GASTO_CAMPANIA] ADD  CONSTRAINT [PK298] PRIMARY KEY NONCLUSTERED 
(
	[idgastocampania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK163]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[HORASEXTRA] ADD  CONSTRAINT [PK163] PRIMARY KEY NONCLUSTERED 
(
	[idhoraextra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK51]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[INVENTARIOFISICO] ADD  CONSTRAINT [PK51] PRIMARY KEY NONCLUSTERED 
(
	[idinventariofisico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK353]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[INVENTARIOSPROD] ADD  CONSTRAINT [PK353] PRIMARY KEY NONCLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK6_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[JORNADA] ADD  CONSTRAINT [PK6_3] PRIMARY KEY NONCLUSTERED 
(
	[idjornada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK73]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[LINEA] ADD  CONSTRAINT [PK73] PRIMARY KEY NONCLUSTERED 
(
	[idlinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK301]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[LISTAPRECIOS] ADD  CONSTRAINT [PK301] PRIMARY KEY NONCLUSTERED 
(
	[idlistaprecio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK12]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[M_GASTOTRANSPORTE] ADD  CONSTRAINT [PK12] PRIMARY KEY NONCLUSTERED 
(
	[idgastotransporte] ASC,
	[idtransporte] ASC,
	[idsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK333]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MANOOBRA] ADD  CONSTRAINT [PK333] PRIMARY KEY NONCLUSTERED 
(
	[idmanoobra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK29]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MARCA] ADD  CONSTRAINT [PK29] PRIMARY KEY NONCLUSTERED 
(
	[idmarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK30]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[METODOCOSTEO] ADD  CONSTRAINT [PK30] PRIMARY KEY NONCLUSTERED 
(
	[idmetodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK7_1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[METRICA] ADD  CONSTRAINT [PK7_1_2] PRIMARY KEY NONCLUSTERED 
(
	[idmetrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK15]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MONEDA] ADD  CONSTRAINT [PK15] PRIMARY KEY NONCLUSTERED 
(
	[idmoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK10_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MORDENSERVICIOV] ADD  CONSTRAINT [PK10_1] PRIMARY KEY NONCLUSTERED 
(
	[idtransporte] ASC,
	[idordenserv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK5_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MOTIVO] ADD  CONSTRAINT [PK5_3] PRIMARY KEY NONCLUSTERED 
(
	[codmotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK7_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO] ADD  CONSTRAINT [PK7_1] PRIMARY KEY NONCLUSTERED 
(
	[idbodega] ASC,
	[idmovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK22_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[NACIONALIDAD] ADD  CONSTRAINT [PK22_2] PRIMARY KEY NONCLUSTERED 
(
	[idnacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK4]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ORDENCOMPRA] ADD  CONSTRAINT [PK4] PRIMARY KEY NONCLUSTERED 
(
	[idordencompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK336]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ORDENPRODUCCION] ADD  CONSTRAINT [PK336] PRIMARY KEY NONCLUSTERED 
(
	[idordenproduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK6_1_4]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PERIODO] ADD  CONSTRAINT [PK6_1_4] PRIMARY KEY NONCLUSTERED 
(
	[idperiodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK15_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PERIODOPLANILLA] ADD  CONSTRAINT [PK15_3] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK4_2_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PERIODOV] ADD  CONSTRAINT [PK4_2_1] PRIMARY KEY NONCLUSTERED 
(
	[codperiodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK339]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PLANIFICACION] ADD  CONSTRAINT [PK339] PRIMARY KEY NONCLUSTERED 
(
	[idplanificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK167]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PLANILLAS] ADD  CONSTRAINT [PK167] PRIMARY KEY NONCLUSTERED 
(
	[idplanilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK171]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[POLIZA] ADD  CONSTRAINT [PK171] PRIMARY KEY NONCLUSTERED 
(
	[idPoliza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK169]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[POLIZAPLANILLA] ADD  CONSTRAINT [PK169] PRIMARY KEY NONCLUSTERED 
(
	[idpolizaplanilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK344]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[POLIZAPRODUCCION] ADD  CONSTRAINT [PK344] PRIMARY KEY NONCLUSTERED 
(
	[idpolizaproduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK9]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PRODUCTO] ADD  CONSTRAINT [PK9] PRIMARY KEY NONCLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK11]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PROVEEDOR] ADD  CONSTRAINT [PK11] PRIMARY KEY NONCLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK16_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[PUESTODETRABAJO] ADD  CONSTRAINT [PK16_3] PRIMARY KEY NONCLUSTERED 
(
	[idpuestodetrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK321]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[RECETARIO] ADD  CONSTRAINT [PK321] PRIMARY KEY NONCLUSTERED 
(
	[idrecetario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK328]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[RECETARIOGASTO] ADD  CONSTRAINT [PK328] PRIMARY KEY NONCLUSTERED 
(
	[idrecetario] ASC,
	[idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK351]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[RECETARIOMATERIA] ADD  CONSTRAINT [PK351] PRIMARY KEY NONCLUSTERED 
(
	[idmateriaprimausada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK25_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[REFERENCIAMOVIMIENTO] ADD  CONSTRAINT [PK25_3] PRIMARY KEY NONCLUSTERED 
(
	[idrefmovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK176]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[RESULTADOENTREVISTA] ADD  CONSTRAINT [PK176] PRIMARY KEY NONCLUSTERED 
(
	[ideresultadoentrevista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK171_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[ROL] ADD  CONSTRAINT [PK171_2] PRIMARY KEY NONCLUSTERED 
(
	[idrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SEDE] ADD  CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[idsede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK20_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SEXO] ADD  CONSTRAINT [PK20_3] PRIMARY KEY NONCLUSTERED 
(
	[idsexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK325]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SOLICITUDMP] ADD  CONSTRAINT [PK325] PRIMARY KEY NONCLUSTERED 
(
	[idsolicitudmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK319]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SOLICITUDPRODUCCION] ADD  CONSTRAINT [PK319] PRIMARY KEY NONCLUSTERED 
(
	[idsolicitudproduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK1_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] ADD  CONSTRAINT [PK1_1] PRIMARY KEY NONCLUSTERED 
(
	[idsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK2_2_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[SOLICITUDVACACIONES] ADD  CONSTRAINT [PK2_2_1] PRIMARY KEY NONCLUSTERED 
(
	[codsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK329]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TAREA] ADD  CONSTRAINT [PK329] PRIMARY KEY NONCLUSTERED 
(
	[idtarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK8_1_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPO] ADD  CONSTRAINT [PK8_1_2] PRIMARY KEY NONCLUSTERED 
(
	[idtipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK314]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPO_CXC] ADD  CONSTRAINT [PK314] PRIMARY KEY NONCLUSTERED 
(
	[idtipocxc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK165]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOBONIFICACION] ADD  CONSTRAINT [PK165] PRIMARY KEY NONCLUSTERED 
(
	[idtipobonificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK296]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOCAMPANIA] ADD  CONSTRAINT [PK296] PRIMARY KEY NONCLUSTERED 
(
	[idtipocampania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK7_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOCONTRATO] ADD  CONSTRAINT [PK7_3] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK164]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPODESCUENTO] ADD  CONSTRAINT [PK164] PRIMARY KEY NONCLUSTERED 
(
	[idtipodescuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK310]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPODEVOLUCION] ADD  CONSTRAINT [PK310] PRIMARY KEY NONCLUSTERED 
(
	[idtipodevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK327]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOGASTO] ADD  CONSTRAINT [PK327] PRIMARY KEY NONCLUSTERED 
(
	[idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK317]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOLISTAPRECIO] ADD  CONSTRAINT [PK317] PRIMARY KEY NONCLUSTERED 
(
	[idtipolistaprecio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3_1_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOMOVIMIENTO] ADD  CONSTRAINT [PK3_1_1] PRIMARY KEY NONCLUSTERED 
(
	[idtipomovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK48]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOOC] ADD  CONSTRAINT [PK48] PRIMARY KEY NONCLUSTERED 
(
	[idtipooc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK158]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOPAGO] ADD  CONSTRAINT [PK158] PRIMARY KEY NONCLUSTERED 
(
	[idtipopago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK306]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOPAGOFACTURA] ADD  CONSTRAINT [PK306] PRIMARY KEY NONCLUSTERED 
(
	[idtipopago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK17]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOPRODUCTO] ADD  CONSTRAINT [PK17] PRIMARY KEY NONCLUSTERED 
(
	[idtipoproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK19_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOSERVICIOVH] ADD  CONSTRAINT [PK19_3] PRIMARY KEY NONCLUSTERED 
(
	[idtiposerviciovh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3_3]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOSOLICTRANS] ADD  CONSTRAINT [PK3_3] PRIMARY KEY NONCLUSTERED 
(
	[idtiposolict] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK355]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOUNIDAD] ADD  CONSTRAINT [PK355] PRIMARY KEY NONCLUSTERED 
(
	[idtipounidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK9_1]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TIPOVEHICULO] ADD  CONSTRAINT [PK9_1] PRIMARY KEY NONCLUSTERED 
(
	[idtipotrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK2_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TRANSACCION] ADD  CONSTRAINT [PK2_2] PRIMARY KEY NONCLUSTERED 
(
	[idtransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK14]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[TRAYECTO] ADD  CONSTRAINT [PK14] PRIMARY KEY NONCLUSTERED 
(
	[idtrayecto] ASC,
	[idsolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK324]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[UNIDADMEDIDA] ADD  CONSTRAINT [PK324] PRIMARY KEY NONCLUSTERED 
(
	[idunidadmedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK5_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[USUARIO_1] ADD  CONSTRAINT [PK5_2] PRIMARY KEY NONCLUSTERED 
(
	[codusuario] ASC,
	[idrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK3_2_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[VACACIONES] ADD  CONSTRAINT [PK3_2_2] PRIMARY KEY NONCLUSTERED 
(
	[codvacaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK8_2]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[VEHICULO] ADD  CONSTRAINT [PK8_2] PRIMARY KEY NONCLUSTERED 
(
	[idtransporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK291]    Script Date: 3/07/2017 1:20:49 a. m. ******/
ALTER TABLE [dbo].[VENDEDOR] ADD  CONSTRAINT [PK291] PRIMARY KEY NONCLUSTERED 
(
	[idvendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BITACORATRANSPORTE] ADD  CONSTRAINT [DFDATE_STBIT]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] ADD  CONSTRAINT [DFDATE1_ST]  DEFAULT (getdate()) FOR [fechasolicitud]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] ADD  CONSTRAINT [DFACTIVO_ST]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[VEHICULO] ADD  CONSTRAINT [DFDACTIVO_VHC]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[AJUSTECONSILIACION]  WITH CHECK ADD  CONSTRAINT [RefCONCILIACION260] FOREIGN KEY([idconciliacion])
REFERENCES [dbo].[CONCILIACION] ([idconciliacion])
GO
ALTER TABLE [dbo].[AJUSTECONSILIACION] CHECK CONSTRAINT [RefCONCILIACION260]
GO
ALTER TABLE [dbo].[ASIGNACION]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO344] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[ASIGNACION] CHECK CONSTRAINT [RefEMPLEADO344]
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO421] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL] CHECK CONSTRAINT [RefEMPLEADO421]
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE53] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE53]
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL]  WITH CHECK ADD  CONSTRAINT [RefVEHICULO52] FOREIGN KEY([idtransporte])
REFERENCES [dbo].[VEHICULO] ([idtransporte])
GO
ALTER TABLE [dbo].[ASIGNACIONPERSONAL] CHECK CONSTRAINT [RefVEHICULO52]
GO
ALTER TABLE [dbo].[ASIGNACIONTAREAS]  WITH CHECK ADD  CONSTRAINT [RefDETALLETAREA526] FOREIGN KEY([iddetalletarea])
REFERENCES [dbo].[DETALLETAREA] ([iddetalletarea])
GO
ALTER TABLE [dbo].[ASIGNACIONTAREAS] CHECK CONSTRAINT [RefDETALLETAREA526]
GO
ALTER TABLE [dbo].[Bitacora_Autorizacion_Orden]  WITH CHECK ADD  CONSTRAINT [RefORDENCOMPRA18] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ORDENCOMPRA] ([idordencompra])
GO
ALTER TABLE [dbo].[Bitacora_Autorizacion_Orden] CHECK CONSTRAINT [RefORDENCOMPRA18]
GO
ALTER TABLE [dbo].[BITACORATRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefESTADOSOLICITUDTRANS55] FOREIGN KEY([idestadost])
REFERENCES [dbo].[ESTADOSOLICITUDTRANS] ([idestadost])
GO
ALTER TABLE [dbo].[BITACORATRANSPORTE] CHECK CONSTRAINT [RefESTADOSOLICITUDTRANS55]
GO
ALTER TABLE [dbo].[BITACORATRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE54] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[BITACORATRANSPORTE] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE54]
GO
ALTER TABLE [dbo].[BODEGA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA3] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[BODEGA] CHECK CONSTRAINT [RefEMPRESA3]
GO
ALTER TABLE [dbo].[BONIFICACIONES]  WITH CHECK ADD  CONSTRAINT [RefPERIODOPLANILLA388] FOREIGN KEY([id])
REFERENCES [dbo].[PERIODOPLANILLA] ([id])
GO
ALTER TABLE [dbo].[BONIFICACIONES] CHECK CONSTRAINT [RefPERIODOPLANILLA388]
GO
ALTER TABLE [dbo].[BONIFICACIONES]  WITH CHECK ADD  CONSTRAINT [RefTIPOBONIFICACION367] FOREIGN KEY([idtipobonificacion])
REFERENCES [dbo].[TIPOBONIFICACION] ([idtipobonificacion])
GO
ALTER TABLE [dbo].[BONIFICACIONES] CHECK CONSTRAINT [RefTIPOBONIFICACION367]
GO
ALTER TABLE [dbo].[BONIFICACIONES]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGO379] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGO] ([idtipopago])
GO
ALTER TABLE [dbo].[BONIFICACIONES] CHECK CONSTRAINT [RefTIPOPAGO379]
GO
ALTER TABLE [dbo].[BONIFICACIONES]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGO382] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGO] ([idtipopago])
GO
ALTER TABLE [dbo].[BONIFICACIONES] CHECK CONSTRAINT [RefTIPOPAGO382]
GO
ALTER TABLE [dbo].[CAJA]  WITH CHECK ADD  CONSTRAINT [RefCUENTAS_POR_COBRAR505] FOREIGN KEY([idcuentaporcobrar])
REFERENCES [dbo].[CUENTAS_POR_COBRAR] ([idcuentaporcobrar])
GO
ALTER TABLE [dbo].[CAJA] CHECK CONSTRAINT [RefCUENTAS_POR_COBRAR505]
GO
ALTER TABLE [dbo].[CAJA]  WITH CHECK ADD  CONSTRAINT [RefESTADO503] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[CAJA] CHECK CONSTRAINT [RefESTADO503]
GO
ALTER TABLE [dbo].[CAJA]  WITH CHECK ADD  CONSTRAINT [RefTRANSACCION588] FOREIGN KEY([idtransaccion])
REFERENCES [dbo].[TRANSACCION] ([idtransaccion])
GO
ALTER TABLE [dbo].[CAJA] CHECK CONSTRAINT [RefTRANSACCION588]
GO
ALTER TABLE [dbo].[CALCULODEVACACIONES]  WITH CHECK ADD  CONSTRAINT [RefPERIODOV400] FOREIGN KEY([codperiodo])
REFERENCES [dbo].[PERIODOV] ([codperiodo])
GO
ALTER TABLE [dbo].[CALCULODEVACACIONES] CHECK CONSTRAINT [RefPERIODOV400]
GO
ALTER TABLE [dbo].[CAMPANIA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA586] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[CAMPANIA] CHECK CONSTRAINT [RefEMPRESA586]
GO
ALTER TABLE [dbo].[CAMPANIA]  WITH CHECK ADD  CONSTRAINT [RefTIPOCAMPANIA450] FOREIGN KEY([idtipocampania])
REFERENCES [dbo].[TIPOCAMPANIA] ([idtipocampania])
GO
ALTER TABLE [dbo].[CAMPANIA] CHECK CONSTRAINT [RefTIPOCAMPANIA450]
GO
ALTER TABLE [dbo].[CAMPANIA_CLIENTE]  WITH CHECK ADD  CONSTRAINT [RefCAMPANIA452] FOREIGN KEY([idcampania])
REFERENCES [dbo].[CAMPANIA] ([idcampania])
GO
ALTER TABLE [dbo].[CAMPANIA_CLIENTE] CHECK CONSTRAINT [RefCAMPANIA452]
GO
ALTER TABLE [dbo].[CAMPANIA_CLIENTE]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE451] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[CAMPANIA_CLIENTE] CHECK CONSTRAINT [RefCLIENTE451]
GO
ALTER TABLE [dbo].[CAMPANIA_VENTA]  WITH CHECK ADD  CONSTRAINT [RefCAMPANIA477] FOREIGN KEY([idcampania])
REFERENCES [dbo].[CAMPANIA] ([idcampania])
GO
ALTER TABLE [dbo].[CAMPANIA_VENTA] CHECK CONSTRAINT [RefCAMPANIA477]
GO
ALTER TABLE [dbo].[CAMPANIA_VENTA]  WITH CHECK ADD  CONSTRAINT [RefFACTURA478] FOREIGN KEY([idfactura])
REFERENCES [dbo].[FACTURA] ([idfactura])
GO
ALTER TABLE [dbo].[CAMPANIA_VENTA] CHECK CONSTRAINT [RefFACTURA478]
GO
ALTER TABLE [dbo].[CANCELACIONCXC]  WITH CHECK ADD  CONSTRAINT [RefCUENTAS_POR_COBRAR500] FOREIGN KEY([idcuentaporcobrar])
REFERENCES [dbo].[CUENTAS_POR_COBRAR] ([idcuentaporcobrar])
GO
ALTER TABLE [dbo].[CANCELACIONCXC] CHECK CONSTRAINT [RefCUENTAS_POR_COBRAR500]
GO
ALTER TABLE [dbo].[CANDIDATO]  WITH CHECK ADD  CONSTRAINT [RefESTADOCANDIDATO392] FOREIGN KEY([idestadocandidato])
REFERENCES [dbo].[ESTADOCANDIDATO] ([idestadocandidato])
GO
ALTER TABLE [dbo].[CANDIDATO] CHECK CONSTRAINT [RefESTADOCANDIDATO392]
GO
ALTER TABLE [dbo].[CANDIDATO]  WITH CHECK ADD  CONSTRAINT [RefESTADOCIVIL390] FOREIGN KEY([idestadocivil])
REFERENCES [dbo].[ESTADOCIVIL] ([idestadocivil])
GO
ALTER TABLE [dbo].[CANDIDATO] CHECK CONSTRAINT [RefESTADOCIVIL390]
GO
ALTER TABLE [dbo].[CANDIDATO]  WITH CHECK ADD  CONSTRAINT [RefNACIONALIDAD387] FOREIGN KEY([idnacionalidad])
REFERENCES [dbo].[NACIONALIDAD] ([idnacionalidad])
GO
ALTER TABLE [dbo].[CANDIDATO] CHECK CONSTRAINT [RefNACIONALIDAD387]
GO
ALTER TABLE [dbo].[CANDIDATO]  WITH CHECK ADD  CONSTRAINT [RefSEXO389] FOREIGN KEY([idsexo])
REFERENCES [dbo].[SEXO] ([idsexo])
GO
ALTER TABLE [dbo].[CANDIDATO] CHECK CONSTRAINT [RefSEXO389]
GO
ALTER TABLE [dbo].[CANDIDATOPLAZA]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO395] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[CANDIDATOPLAZA] CHECK CONSTRAINT [RefEMPLEADO395]
GO
ALTER TABLE [dbo].[CANDIDATOPLAZA]  WITH CHECK ADD  CONSTRAINT [RefPUESTODETRABAJO394] FOREIGN KEY([idpuestodetrabajo])
REFERENCES [dbo].[PUESTODETRABAJO] ([idpuestodetrabajo])
GO
ALTER TABLE [dbo].[CANDIDATOPLAZA] CHECK CONSTRAINT [RefPUESTODETRABAJO394]
GO
ALTER TABLE [dbo].[CAPACITACION]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION414] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[CAPACITACION] CHECK CONSTRAINT [RefAUTORIZACION414]
GO
ALTER TABLE [dbo].[CAPACITACION]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA413] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[CAPACITACION] CHECK CONSTRAINT [RefEMPRESA413]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA581] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [RefEMPRESA581]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [RefESTADO442] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [RefESTADO442]
GO
ALTER TABLE [dbo].[CLIENTE_VENDEDOR]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE446] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[CLIENTE_VENDEDOR] CHECK CONSTRAINT [RefCLIENTE446]
GO
ALTER TABLE [dbo].[CLIENTE_VENDEDOR]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR447] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[CLIENTE_VENDEDOR] CHECK CONSTRAINT [RefVENDEDOR447]
GO
ALTER TABLE [dbo].[COMISION]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA583] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[COMISION] CHECK CONSTRAINT [RefEMPRESA583]
GO
ALTER TABLE [dbo].[COMISION]  WITH CHECK ADD  CONSTRAINT [RefESTADO449] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[COMISION] CHECK CONSTRAINT [RefESTADO449]
GO
ALTER TABLE [dbo].[COMISION]  WITH CHECK ADD  CONSTRAINT [RefMARCA584] FOREIGN KEY([idmarca])
REFERENCES [dbo].[MARCA] ([idmarca])
GO
ALTER TABLE [dbo].[COMISION] CHECK CONSTRAINT [RefMARCA584]
GO
ALTER TABLE [dbo].[COMISION]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO595] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[COMISION] CHECK CONSTRAINT [RefPRODUCTO595]
GO
ALTER TABLE [dbo].[COMISION]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR448] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[COMISION] CHECK CONSTRAINT [RefVENDEDOR448]
GO
ALTER TABLE [dbo].[CONCILIACION]  WITH CHECK ADD  CONSTRAINT [RefESTADOCUENTA76] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADOCUENTA] ([idestado])
GO
ALTER TABLE [dbo].[CONCILIACION] CHECK CONSTRAINT [RefESTADOCUENTA76]
GO
ALTER TABLE [dbo].[CONCILIACION]  WITH CHECK ADD  CONSTRAINT [RefTRANSACCION75] FOREIGN KEY([idtransaccion])
REFERENCES [dbo].[TRANSACCION] ([idtransaccion])
GO
ALTER TABLE [dbo].[CONCILIACION] CHECK CONSTRAINT [RefTRANSACCION75]
GO
ALTER TABLE [dbo].[CONTRASENA]  WITH CHECK ADD  CONSTRAINT [RefESTADOCONTRASENA21] FOREIGN KEY([idestadocontrasena])
REFERENCES [dbo].[ESTADOCONTRASENA] ([idestadocontrasena])
GO
ALTER TABLE [dbo].[CONTRASENA] CHECK CONSTRAINT [RefESTADOCONTRASENA21]
GO
ALTER TABLE [dbo].[CONTRASENA]  WITH CHECK ADD  CONSTRAINT [RefPROVEEDOR64] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[PROVEEDOR] ([idproveedor])
GO
ALTER TABLE [dbo].[CONTRASENA] CHECK CONSTRAINT [RefPROVEEDOR64]
GO
ALTER TABLE [dbo].[CONTRASENA]  WITH CHECK ADD  CONSTRAINT [RefSEDE434] FOREIGN KEY([idsede])
REFERENCES [dbo].[SEDE] ([idsede])
GO
ALTER TABLE [dbo].[CONTRASENA] CHECK CONSTRAINT [RefSEDE434]
GO
ALTER TABLE [dbo].[CONTRATO]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO361] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[CONTRATO] CHECK CONSTRAINT [RefEMPLEADO361]
GO
ALTER TABLE [dbo].[CONTRATO]  WITH CHECK ADD  CONSTRAINT [RefJORNADA362] FOREIGN KEY([idjornada])
REFERENCES [dbo].[JORNADA] ([idjornada])
GO
ALTER TABLE [dbo].[CONTRATO] CHECK CONSTRAINT [RefJORNADA362]
GO
ALTER TABLE [dbo].[CONTRATO]  WITH CHECK ADD  CONSTRAINT [RefPUESTODETRABAJO405] FOREIGN KEY([idpuestodetrabajo])
REFERENCES [dbo].[PUESTODETRABAJO] ([idpuestodetrabajo])
GO
ALTER TABLE [dbo].[CONTRATO] CHECK CONSTRAINT [RefPUESTODETRABAJO405]
GO
ALTER TABLE [dbo].[CONTRATO]  WITH CHECK ADD  CONSTRAINT [RefTIPOCONTRATO409] FOREIGN KEY([id])
REFERENCES [dbo].[TIPOCONTRATO] ([id])
GO
ALTER TABLE [dbo].[CONTRATO] CHECK CONSTRAINT [RefTIPOCONTRATO409]
GO
ALTER TABLE [dbo].[CONVERSION]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO594] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[CONVERSION] CHECK CONSTRAINT [RefPRODUCTO594]
GO
ALTER TABLE [dbo].[CONVERSION]  WITH CHECK ADD  CONSTRAINT [RefUNIDADMEDIDA517] FOREIGN KEY([unidadorigen])
REFERENCES [dbo].[UNIDADMEDIDA] ([idunidadmedida])
GO
ALTER TABLE [dbo].[CONVERSION] CHECK CONSTRAINT [RefUNIDADMEDIDA517]
GO
ALTER TABLE [dbo].[CONVERSION]  WITH CHECK ADD  CONSTRAINT [RefUNIDADMEDIDA519] FOREIGN KEY([unidaddestino])
REFERENCES [dbo].[UNIDADMEDIDA] ([idunidadmedida])
GO
ALTER TABLE [dbo].[CONVERSION] CHECK CONSTRAINT [RefUNIDADMEDIDA519]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE455] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [RefCLIENTE455]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefCOMISION459] FOREIGN KEY([idcomision])
REFERENCES [dbo].[COMISION] ([idcomision])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [RefCOMISION459]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefESTADO458] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [RefESTADO458]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefMONEDA457] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [RefMONEDA457]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR456] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [RefVENDEDOR456]
GO
ALTER TABLE [dbo].[CUENTA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA85] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[CUENTA] CHECK CONSTRAINT [RefEMPRESA85]
GO
ALTER TABLE [dbo].[CUENTACONTABLE]  WITH CHECK ADD  CONSTRAINT [RefCUENTACONTABLE256] FOREIGN KEY([idCuentaMadre])
REFERENCES [dbo].[CUENTACONTABLE] ([idCuenta])
GO
ALTER TABLE [dbo].[CUENTACONTABLE] CHECK CONSTRAINT [RefCUENTACONTABLE256]
GO
ALTER TABLE [dbo].[CUENTACONTABLE]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA269] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[CUENTACONTABLE] CHECK CONSTRAINT [RefEMPRESA269]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE496] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefCLIENTE496]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefDETALLE_PAGOCXC499] FOREIGN KEY([iddetallepago])
REFERENCES [dbo].[DETALLE_PAGOCXC] ([iddetallepago])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefDETALLE_PAGOCXC499]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefDEVOLUCIONES506] FOREIGN KEY([iddevolucion])
REFERENCES [dbo].[DEVOLUCIONES] ([iddevolucion])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefDEVOLUCIONES506]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefESTADO497] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefESTADO497]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefFACTURA491] FOREIGN KEY([idfactura])
REFERENCES [dbo].[FACTURA] ([idfactura])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefFACTURA491]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefMONEDA495] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefMONEDA495]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefTIPO_CXC489] FOREIGN KEY([idtipocxc])
REFERENCES [dbo].[TIPO_CXC] ([idtipocxc])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefTIPO_CXC489]
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR490] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[CUENTAS_POR_COBRAR] CHECK CONSTRAINT [RefVENDEDOR490]
GO
ALTER TABLE [dbo].[DESCUENTOS]  WITH CHECK ADD  CONSTRAINT [RefPERIODOPLANILLA386] FOREIGN KEY([id])
REFERENCES [dbo].[PERIODOPLANILLA] ([id])
GO
ALTER TABLE [dbo].[DESCUENTOS] CHECK CONSTRAINT [RefPERIODOPLANILLA386]
GO
ALTER TABLE [dbo].[DESCUENTOS]  WITH CHECK ADD  CONSTRAINT [RefTIPODESCUENTO364] FOREIGN KEY([idtipodescuento])
REFERENCES [dbo].[TIPODESCUENTO] ([idtipodescuento])
GO
ALTER TABLE [dbo].[DESCUENTOS] CHECK CONSTRAINT [RefTIPODESCUENTO364]
GO
ALTER TABLE [dbo].[DESCUENTOS]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGO384] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGO] ([idtipopago])
GO
ALTER TABLE [dbo].[DESCUENTOS] CHECK CONSTRAINT [RefTIPOPAGO384]
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefBODEGA462] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION] CHECK CONSTRAINT [RefBODEGA462]
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefCOTIZACION460] FOREIGN KEY([idcotizacion])
REFERENCES [dbo].[COTIZACION] ([idcotizacion])
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION] CHECK CONSTRAINT [RefCOTIZACION460]
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefLISTAPRECIOS461] FOREIGN KEY([idlistaprecio])
REFERENCES [dbo].[LISTAPRECIOS] ([idlistaprecio])
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION] CHECK CONSTRAINT [RefLISTAPRECIOS461]
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO463] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLE_COTIZACION] CHECK CONSTRAINT [RefPRODUCTO463]
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [RefBODEGA486] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION] CHECK CONSTRAINT [RefBODEGA486]
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [RefDEVOLUCIONES485] FOREIGN KEY([iddevolucion])
REFERENCES [dbo].[DEVOLUCIONES] ([iddevolucion])
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION] CHECK CONSTRAINT [RefDEVOLUCIONES485]
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [RefLISTAPRECIOS488] FOREIGN KEY([idlistaprecio])
REFERENCES [dbo].[LISTAPRECIOS] ([idlistaprecio])
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION] CHECK CONSTRAINT [RefLISTAPRECIOS488]
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO487] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLE_DEVOLUCION] CHECK CONSTRAINT [RefPRODUCTO487]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [RefBODEGA474] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [RefBODEGA474]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [RefFACTURA473] FOREIGN KEY([idfactura])
REFERENCES [dbo].[FACTURA] ([idfactura])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [RefFACTURA473]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [RefLISTAPRECIOS476] FOREIGN KEY([idlistaprecio])
REFERENCES [dbo].[LISTAPRECIOS] ([idlistaprecio])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [RefLISTAPRECIOS476]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO475] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [RefPRODUCTO475]
GO
ALTER TABLE [dbo].[DETALLE_PAGOCXC]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGOFACTURA498] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGOFACTURA] ([idtipopago])
GO
ALTER TABLE [dbo].[DETALLE_PAGOCXC] CHECK CONSTRAINT [RefTIPOPAGOFACTURA498]
GO
ALTER TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO56] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE] CHECK CONSTRAINT [RefPRODUCTO56]
GO
ALTER TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE39] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[DETALLE_SOLIC_TRANSPORTE] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE39]
GO
ALTER TABLE [dbo].[DETALLEASIGNACION]  WITH CHECK ADD  CONSTRAINT [RefASIGNACION406] FOREIGN KEY([idasignacion])
REFERENCES [dbo].[ASIGNACION] ([idasignacion])
GO
ALTER TABLE [dbo].[DETALLEASIGNACION] CHECK CONSTRAINT [RefASIGNACION406]
GO
ALTER TABLE [dbo].[DETALLEASIGNACION]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO347] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DETALLEASIGNACION] CHECK CONSTRAINT [RefEMPLEADO347]
GO
ALTER TABLE [dbo].[DETALLEBONEMP]  WITH CHECK ADD  CONSTRAINT [RefBONIFICACIONES381] FOREIGN KEY([idbonificacion])
REFERENCES [dbo].[BONIFICACIONES] ([idbonificacion])
GO
ALTER TABLE [dbo].[DETALLEBONEMP] CHECK CONSTRAINT [RefBONIFICACIONES381]
GO
ALTER TABLE [dbo].[DETALLEBONEMP]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO378] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DETALLEBONEMP] CHECK CONSTRAINT [RefEMPLEADO378]
GO
ALTER TABLE [dbo].[DETALLECAPACITACION]  WITH CHECK ADD  CONSTRAINT [RefCAPACITACION408] FOREIGN KEY([idcapacitacion])
REFERENCES [dbo].[CAPACITACION] ([idcapacitacion])
GO
ALTER TABLE [dbo].[DETALLECAPACITACION] CHECK CONSTRAINT [RefCAPACITACION408]
GO
ALTER TABLE [dbo].[DETALLECAPACITACION]  WITH CHECK ADD  CONSTRAINT [RefTIPO407] FOREIGN KEY([idtipo])
REFERENCES [dbo].[TIPO] ([idtipo])
GO
ALTER TABLE [dbo].[DETALLECAPACITACION] CHECK CONSTRAINT [RefTIPO407]
GO
ALTER TABLE [dbo].[DETALLECONTRASENA]  WITH CHECK ADD  CONSTRAINT [RefCONTRASENA435] FOREIGN KEY([idcontrasena])
REFERENCES [dbo].[CONTRASENA] ([idcontrasena])
GO
ALTER TABLE [dbo].[DETALLECONTRASENA] CHECK CONSTRAINT [RefCONTRASENA435]
GO
ALTER TABLE [dbo].[DETALLECONTRASENA]  WITH CHECK ADD  CONSTRAINT [RefFACTURAPROVEEDORES436] FOREIGN KEY([idfactura])
REFERENCES [dbo].[FACTURAPROVEEDORES] ([idfactura])
GO
ALTER TABLE [dbo].[DETALLECONTRASENA] CHECK CONSTRAINT [RefFACTURAPROVEEDORES436]
GO
ALTER TABLE [dbo].[DETALLEDESCEMP]  WITH CHECK ADD  CONSTRAINT [RefDESCUENTOS377] FOREIGN KEY([iddescuento])
REFERENCES [dbo].[DESCUENTOS] ([iddescuento])
GO
ALTER TABLE [dbo].[DETALLEDESCEMP] CHECK CONSTRAINT [RefDESCUENTOS377]
GO
ALTER TABLE [dbo].[DETALLEDESCEMP]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO376] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DETALLEDESCEMP] CHECK CONSTRAINT [RefEMPLEADO376]
GO
ALTER TABLE [dbo].[DETALLEENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefENTREVISTA365] FOREIGN KEY([identrevista])
REFERENCES [dbo].[ENTREVISTA] ([identrevista])
GO
ALTER TABLE [dbo].[DETALLEENTREVISTA] CHECK CONSTRAINT [RefENTREVISTA365]
GO
ALTER TABLE [dbo].[DETALLEENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefRESULTADOENTREVISTA363] FOREIGN KEY([ideresultadoentrevista])
REFERENCES [dbo].[RESULTADOENTREVISTA] ([ideresultadoentrevista])
GO
ALTER TABLE [dbo].[DETALLEENTREVISTA] CHECK CONSTRAINT [RefRESULTADOENTREVISTA363]
GO
ALTER TABLE [dbo].[DETALLEEVALUACION]  WITH CHECK ADD  CONSTRAINT [RefEVALUACIONDESEMPEÑO343] FOREIGN KEY([idevaluacion])
REFERENCES [dbo].[EVALUACIONDESEMPEÑO] ([idevaluacion])
GO
ALTER TABLE [dbo].[DETALLEEVALUACION] CHECK CONSTRAINT [RefEVALUACIONDESEMPEÑO343]
GO
ALTER TABLE [dbo].[DETALLEEVALUACION]  WITH CHECK ADD  CONSTRAINT [RefMETRICA342] FOREIGN KEY([idmetrica])
REFERENCES [dbo].[METRICA] ([idmetrica])
GO
ALTER TABLE [dbo].[DETALLEEVALUACION] CHECK CONSTRAINT [RefMETRICA342]
GO
ALTER TABLE [dbo].[DETALLEFINANCIERO]  WITH CHECK ADD  CONSTRAINT [RefCUENTACONTABLE258] FOREIGN KEY([idCuenta])
REFERENCES [dbo].[CUENTACONTABLE] ([idCuenta])
GO
ALTER TABLE [dbo].[DETALLEFINANCIERO] CHECK CONSTRAINT [RefCUENTACONTABLE258]
GO
ALTER TABLE [dbo].[DETALLEFINANCIERO]  WITH CHECK ADD  CONSTRAINT [RefESTADOFINANCIERO257] FOREIGN KEY([idestadofinanciero])
REFERENCES [dbo].[ESTADOFINANCIERO] ([idestadofinanciero])
GO
ALTER TABLE [dbo].[DETALLEFINANCIERO] CHECK CONSTRAINT [RefESTADOFINANCIERO257]
GO
ALTER TABLE [dbo].[DETALLEGASTOTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefM_GASTOTRANSPORTE69] FOREIGN KEY([idgastotransporte], [idtransporte], [idsolicitud])
REFERENCES [dbo].[M_GASTOTRANSPORTE] ([idgastotransporte], [idtransporte], [idsolicitud])
GO
ALTER TABLE [dbo].[DETALLEGASTOTRANSPORTE] CHECK CONSTRAINT [RefM_GASTOTRANSPORTE69]
GO
ALTER TABLE [dbo].[DETALLEINVENTARIOFISICO]  WITH CHECK ADD  CONSTRAINT [RefEXISTENCIA426] FOREIGN KEY([idbodega], [idproducto])
REFERENCES [dbo].[EXISTENCIA] ([idbodega], [idproducto])
GO
ALTER TABLE [dbo].[DETALLEINVENTARIOFISICO] CHECK CONSTRAINT [RefEXISTENCIA426]
GO
ALTER TABLE [dbo].[DETALLEINVENTARIOFISICO]  WITH CHECK ADD  CONSTRAINT [RefINVENTARIOFISICO425] FOREIGN KEY([idinventariofisico])
REFERENCES [dbo].[INVENTARIOFISICO] ([idinventariofisico])
GO
ALTER TABLE [dbo].[DETALLEINVENTARIOFISICO] CHECK CONSTRAINT [RefINVENTARIOFISICO425]
GO
ALTER TABLE [dbo].[DetalleLaboral]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO351] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DetalleLaboral] CHECK CONSTRAINT [RefEMPLEADO351]
GO
ALTER TABLE [dbo].[DETALLEMODOS]  WITH CHECK ADD  CONSTRAINT [RefDETALLEMOUNO525] FOREIGN KEY([iddetallemouno])
REFERENCES [dbo].[DETALLEMOUNO] ([iddetallemouno])
GO
ALTER TABLE [dbo].[DETALLEMODOS] CHECK CONSTRAINT [RefDETALLEMOUNO525]
GO
ALTER TABLE [dbo].[DETALLEMOUNO]  WITH CHECK ADD  CONSTRAINT [RefASIGNACIONTAREAS549] FOREIGN KEY([idasignaciontareas])
REFERENCES [dbo].[ASIGNACIONTAREAS] ([idasignaciontareas])
GO
ALTER TABLE [dbo].[DETALLEMOUNO] CHECK CONSTRAINT [RefASIGNACIONTAREAS549]
GO
ALTER TABLE [dbo].[DETALLEMOUNO]  WITH CHECK ADD  CONSTRAINT [RefMANOOBRA524] FOREIGN KEY([idmanoobra])
REFERENCES [dbo].[MANOOBRA] ([idmanoobra])
GO
ALTER TABLE [dbo].[DETALLEMOUNO] CHECK CONSTRAINT [RefMANOOBRA524]
GO
ALTER TABLE [dbo].[DETALLEMOUNO]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION528] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[DETALLEMOUNO] CHECK CONSTRAINT [RefORDENPRODUCCION528]
GO
ALTER TABLE [dbo].[DETALLEMOUNO]  WITH CHECK ADD  CONSTRAINT [RefRECETARIO529] FOREIGN KEY([idrecetario])
REFERENCES [dbo].[RECETARIO] ([idrecetario])
GO
ALTER TABLE [dbo].[DETALLEMOUNO] CHECK CONSTRAINT [RefRECETARIO529]
GO
ALTER TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefMOVIMIENTOSINVENTARIO430] FOREIGN KEY([idbodega], [idmovimiento])
REFERENCES [dbo].[MOVIMIENTOSINVENTARIO] ([idbodega], [idmovimiento])
GO
ALTER TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO] CHECK CONSTRAINT [RefMOVIMIENTOSINVENTARIO430]
GO
ALTER TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO433] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLEMOVIMIENTOINVENTARIO] CHECK CONSTRAINT [RefPRODUCTO433]
GO
ALTER TABLE [dbo].[DETALLEORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefORDENCOMPRA14] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ORDENCOMPRA] ([idordencompra])
GO
ALTER TABLE [dbo].[DETALLEORDENCOMPRA] CHECK CONSTRAINT [RefORDENCOMPRA14]
GO
ALTER TABLE [dbo].[DETALLEORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO15] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLEORDENCOMPRA] CHECK CONSTRAINT [RefPRODUCTO15]
GO
ALTER TABLE [dbo].[DetallePersonal]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO353] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DetallePersonal] CHECK CONSTRAINT [RefEMPLEADO353]
GO
ALTER TABLE [dbo].[DetallePersonal]  WITH CHECK ADD  CONSTRAINT [RefESTUDIOS399] FOREIGN KEY([idestudios])
REFERENCES [dbo].[ESTUDIOS] ([idestudios])
GO
ALTER TABLE [dbo].[DetallePersonal] CHECK CONSTRAINT [RefESTUDIOS399]
GO
ALTER TABLE [dbo].[DetallePersonal]  WITH CHECK ADD  CONSTRAINT [RefEXPERIENCIALABORAL398] FOREIGN KEY([idexperencialaboral])
REFERENCES [dbo].[EXPERIENCIALABORAL] ([idexperencialaboral])
GO
ALTER TABLE [dbo].[DetallePersonal] CHECK CONSTRAINT [RefEXPERIENCIALABORAL398]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION415] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefAUTORIZACION415]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO416] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefEMPLEADO416]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefHORASEXTRA375] FOREIGN KEY([idhoraextra])
REFERENCES [dbo].[HORASEXTRA] ([idhoraextra])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefHORASEXTRA375]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefPLANILLAS369] FOREIGN KEY([idplanilla])
REFERENCES [dbo].[PLANILLAS] ([idplanilla])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefPLANILLAS369]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGO417] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGO] ([idtipopago])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefTIPOPAGO417]
GO
ALTER TABLE [dbo].[DETALLEPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefVACACIONES385] FOREIGN KEY([codvacaciones])
REFERENCES [dbo].[VACACIONES] ([codvacaciones])
GO
ALTER TABLE [dbo].[DETALLEPLANILLA] CHECK CONSTRAINT [RefVACACIONES385]
GO
ALTER TABLE [dbo].[DETALLEPOLIZA]  WITH CHECK ADD  CONSTRAINT [RefCUENTACONTABLE254] FOREIGN KEY([idCuenta])
REFERENCES [dbo].[CUENTACONTABLE] ([idCuenta])
GO
ALTER TABLE [dbo].[DETALLEPOLIZA] CHECK CONSTRAINT [RefCUENTACONTABLE254]
GO
ALTER TABLE [dbo].[DETALLEPOLIZA]  WITH CHECK ADD  CONSTRAINT [RefPOLIZA252] FOREIGN KEY([idPoliza])
REFERENCES [dbo].[POLIZA] ([idPoliza])
GO
ALTER TABLE [dbo].[DETALLEPOLIZA] CHECK CONSTRAINT [RefPOLIZA252]
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefPLANILLAS374] FOREIGN KEY([idplanilla])
REFERENCES [dbo].[PLANILLAS] ([idplanilla])
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPLANILLA] CHECK CONSTRAINT [RefPLANILLAS374]
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPLANILLA]  WITH CHECK ADD  CONSTRAINT [RefPOLIZAPLANILLA372] FOREIGN KEY([idpolizaplanilla])
REFERENCES [dbo].[POLIZAPLANILLA] ([idpolizaplanilla])
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPLANILLA] CHECK CONSTRAINT [RefPOLIZAPLANILLA372]
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD]  WITH CHECK ADD  CONSTRAINT [RefPOLIZA548] FOREIGN KEY([idPoliza])
REFERENCES [dbo].[POLIZA] ([idPoliza])
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD] CHECK CONSTRAINT [RefPOLIZA548]
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD]  WITH CHECK ADD  CONSTRAINT [RefPOLIZAPRODUCCION540] FOREIGN KEY([idpolizaproduccion])
REFERENCES [dbo].[POLIZAPRODUCCION] ([idpolizaproduccion])
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD] CHECK CONSTRAINT [RefPOLIZAPRODUCCION540]
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO609] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLEPOLIZAPROD] CHECK CONSTRAINT [RefPRODUCTO609]
GO
ALTER TABLE [dbo].[DETALLERECETARIO]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO593] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLERECETARIO] CHECK CONSTRAINT [RefPRODUCTO593]
GO
ALTER TABLE [dbo].[DETALLERECETARIO]  WITH CHECK ADD  CONSTRAINT [RefRECETARIO510] FOREIGN KEY([idrecetario])
REFERENCES [dbo].[RECETARIO] ([idrecetario])
GO
ALTER TABLE [dbo].[DETALLERECETARIO] CHECK CONSTRAINT [RefRECETARIO510]
GO
ALTER TABLE [dbo].[DETALLESOLICITUDMP]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO591] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETALLESOLICITUDMP] CHECK CONSTRAINT [RefPRODUCTO591]
GO
ALTER TABLE [dbo].[DETALLESOLICITUDMP]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDMP520] FOREIGN KEY([idsolicitudmp])
REFERENCES [dbo].[SOLICITUDMP] ([idsolicitudmp])
GO
ALTER TABLE [dbo].[DETALLESOLICITUDMP] CHECK CONSTRAINT [RefSOLICITUDMP520]
GO
ALTER TABLE [dbo].[DETALLETAREA]  WITH CHECK ADD  CONSTRAINT [RefFASETAREA527] FOREIGN KEY([idfase])
REFERENCES [dbo].[FASETAREA] ([idfase])
GO
ALTER TABLE [dbo].[DETALLETAREA] CHECK CONSTRAINT [RefFASETAREA527]
GO
ALTER TABLE [dbo].[DETALLETAREA]  WITH CHECK ADD  CONSTRAINT [RefTAREA522] FOREIGN KEY([idtarea])
REFERENCES [dbo].[TAREA] ([idtarea])
GO
ALTER TABLE [dbo].[DETALLETAREA] CHECK CONSTRAINT [RefTAREA522]
GO
ALTER TABLE [dbo].[DETALLETRANSACCION]  WITH CHECK ADD  CONSTRAINT [RefCUENTACONTABLE262] FOREIGN KEY([idCuenta])
REFERENCES [dbo].[CUENTACONTABLE] ([idCuenta])
GO
ALTER TABLE [dbo].[DETALLETRANSACCION] CHECK CONSTRAINT [RefCUENTACONTABLE262]
GO
ALTER TABLE [dbo].[DETALLETRANSACCION]  WITH CHECK ADD  CONSTRAINT [RefTRANSACCION265] FOREIGN KEY([idtransaccion])
REFERENCES [dbo].[TRANSACCION] ([idtransaccion])
GO
ALTER TABLE [dbo].[DETALLETRANSACCION] CHECK CONSTRAINT [RefTRANSACCION265]
GO
ALTER TABLE [dbo].[DETINVENTARIOSPROD]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO603] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[DETINVENTARIOSPROD] CHECK CONSTRAINT [RefPRODUCTO603]
GO
ALTER TABLE [dbo].[DETLABORAL]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO348] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DETLABORAL] CHECK CONSTRAINT [RefEMPLEADO348]
GO
ALTER TABLE [dbo].[DETLABORAL]  WITH CHECK ADD  CONSTRAINT [RefPUESTODETRABAJO350] FOREIGN KEY([idpuestodetrabajo])
REFERENCES [dbo].[PUESTODETRABAJO] ([idpuestodetrabajo])
GO
ALTER TABLE [dbo].[DETLABORAL] CHECK CONSTRAINT [RefPUESTODETRABAJO350]
GO
ALTER TABLE [dbo].[DETORDENPROD]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION530] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[DETORDENPROD] CHECK CONSTRAINT [RefORDENPRODUCCION530]
GO
ALTER TABLE [dbo].[DETORDENPROD]  WITH CHECK ADD  CONSTRAINT [RefRECETARIO531] FOREIGN KEY([idrecetario])
REFERENCES [dbo].[RECETARIO] ([idrecetario])
GO
ALTER TABLE [dbo].[DETORDENPROD] CHECK CONSTRAINT [RefRECETARIO531]
GO
ALTER TABLE [dbo].[DETPLANIFICACION]  WITH CHECK ADD  CONSTRAINT [RefDETALLEMOUNO537] FOREIGN KEY([iddetallemouno])
REFERENCES [dbo].[DETALLEMOUNO] ([iddetallemouno])
GO
ALTER TABLE [dbo].[DETPLANIFICACION] CHECK CONSTRAINT [RefDETALLEMOUNO537]
GO
ALTER TABLE [dbo].[DETPLANIFICACION]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION534] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[DETPLANIFICACION] CHECK CONSTRAINT [RefORDENPRODUCCION534]
GO
ALTER TABLE [dbo].[DETPLANIFICACION]  WITH CHECK ADD  CONSTRAINT [RefPLANIFICACION533] FOREIGN KEY([idplanificacion])
REFERENCES [dbo].[PLANIFICACION] ([idplanificacion])
GO
ALTER TABLE [dbo].[DETPLANIFICACION] CHECK CONSTRAINT [RefPLANIFICACION533]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE480] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefCLIENTE480]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefESTADO484] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefESTADO484]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefFACTURA483] FOREIGN KEY([idfactura])
REFERENCES [dbo].[FACTURA] ([idfactura])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefFACTURA483]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefMONEDA481] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefMONEDA481]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefPROVEEDOR590] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[PROVEEDOR] ([idproveedor])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefPROVEEDOR590]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefTIPODEVOLUCION479] FOREIGN KEY([idtipodevolucion])
REFERENCES [dbo].[TIPODEVOLUCION] ([idtipodevolucion])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefTIPODEVOLUCION479]
GO
ALTER TABLE [dbo].[DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR482] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[DEVOLUCIONES] CHECK CONSTRAINT [RefVENDEDOR482]
GO
ALTER TABLE [dbo].[DIASFESTIVOS]  WITH CHECK ADD  CONSTRAINT [RefPERIODOV402] FOREIGN KEY([codperiodo])
REFERENCES [dbo].[PERIODOV] ([codperiodo])
GO
ALTER TABLE [dbo].[DIASFESTIVOS] CHECK CONSTRAINT [RefPERIODOV402]
GO
ALTER TABLE [dbo].[DIASLABORALES]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO393] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[DIASLABORALES] CHECK CONSTRAINT [RefEMPLEADO393]
GO
ALTER TABLE [dbo].[DIASLABORALES]  WITH CHECK ADD  CONSTRAINT [RefPERIODOPLANILLA397] FOREIGN KEY([id])
REFERENCES [dbo].[PERIODOPLANILLA] ([id])
GO
ALTER TABLE [dbo].[DIASLABORALES] CHECK CONSTRAINT [RefPERIODOPLANILLA397]
GO
ALTER TABLE [dbo].[DIASLABORALES]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGO391] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGO] ([idtipopago])
GO
ALTER TABLE [dbo].[DIASLABORALES] CHECK CONSTRAINT [RefTIPOPAGO391]
GO
ALTER TABLE [dbo].[DOCUMENTOREQUERIDO]  WITH CHECK ADD  CONSTRAINT [RefTIPOSOLICTRANS42] FOREIGN KEY([idtiposolict])
REFERENCES [dbo].[TIPOSOLICTRANS] ([idtiposolict])
GO
ALTER TABLE [dbo].[DOCUMENTOREQUERIDO] CHECK CONSTRAINT [RefTIPOSOLICTRANS42]
GO
ALTER TABLE [dbo].[DOCUMENTOSOPORTE]  WITH CHECK ADD  CONSTRAINT [RefDOCUMENTOREQUERIDO71] FOREIGN KEY([iddoctrans], [idtiposolict])
REFERENCES [dbo].[DOCUMENTOREQUERIDO] ([iddoctrans], [idtiposolict])
GO
ALTER TABLE [dbo].[DOCUMENTOSOPORTE] CHECK CONSTRAINT [RefDOCUMENTOREQUERIDO71]
GO
ALTER TABLE [dbo].[DOCUMENTOSOPORTE]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE70] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[DOCUMENTOSOPORTE] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE70]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA412] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [RefEMPRESA412]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [RefUSUARIO_1349] FOREIGN KEY([codusuario], [idrol])
REFERENCES [dbo].[USUARIO_1] ([codusuario], [idrol])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [RefUSUARIO_1349]
GO
ALTER TABLE [dbo].[EMPRESA]  WITH CHECK ADD  CONSTRAINT [RefMONEDA2] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[EMPRESA] CHECK CONSTRAINT [RefMONEDA2]
GO
ALTER TABLE [dbo].[EMPRESA]  WITH CHECK ADD  CONSTRAINT [RefSEDE1] FOREIGN KEY([idsede])
REFERENCES [dbo].[SEDE] ([idsede])
GO
ALTER TABLE [dbo].[EMPRESA] CHECK CONSTRAINT [RefSEDE1]
GO
ALTER TABLE [dbo].[ENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefCANDIDATO366] FOREIGN KEY([idcandidato])
REFERENCES [dbo].[CANDIDATO] ([idcandidato])
GO
ALTER TABLE [dbo].[ENTREVISTA] CHECK CONSTRAINT [RefCANDIDATO366]
GO
ALTER TABLE [dbo].[ENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO368] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[ENTREVISTA] CHECK CONSTRAINT [RefEMPLEADO368]
GO
ALTER TABLE [dbo].[ENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefETAPAENTREVISTA404] FOREIGN KEY([idetapaentrevista])
REFERENCES [dbo].[ETAPAENTREVISTA] ([idetapaentrevista])
GO
ALTER TABLE [dbo].[ENTREVISTA] CHECK CONSTRAINT [RefETAPAENTREVISTA404]
GO
ALTER TABLE [dbo].[ENTREVISTA]  WITH CHECK ADD  CONSTRAINT [RefPUESTODETRABAJO370] FOREIGN KEY([idpuestodetrabajo])
REFERENCES [dbo].[PUESTODETRABAJO] ([idpuestodetrabajo])
GO
ALTER TABLE [dbo].[ENTREVISTA] CHECK CONSTRAINT [RefPUESTODETRABAJO370]
GO
ALTER TABLE [dbo].[ESTADOCUENTA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA271] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[ESTADOCUENTA] CHECK CONSTRAINT [RefEMPRESA271]
GO
ALTER TABLE [dbo].[ESTADOFINANCIERO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA270] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[ESTADOFINANCIERO] CHECK CONSTRAINT [RefEMPRESA270]
GO
ALTER TABLE [dbo].[ESTUDIOS]  WITH CHECK ADD  CONSTRAINT [RefCANDIDATO359] FOREIGN KEY([idcandidato])
REFERENCES [dbo].[CANDIDATO] ([idcandidato])
GO
ALTER TABLE [dbo].[ESTUDIOS] CHECK CONSTRAINT [RefCANDIDATO359]
GO
ALTER TABLE [dbo].[EVALUACIONDESEMPEÑO]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO345] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[EVALUACIONDESEMPEÑO] CHECK CONSTRAINT [RefEMPLEADO345]
GO
ALTER TABLE [dbo].[EVALUACIONDESEMPEÑO]  WITH CHECK ADD  CONSTRAINT [RefPERIODO341] FOREIGN KEY([idperiodo])
REFERENCES [dbo].[PERIODO] ([idperiodo])
GO
ALTER TABLE [dbo].[EVALUACIONDESEMPEÑO] CHECK CONSTRAINT [RefPERIODO341]
GO
ALTER TABLE [dbo].[EXISTENCIA]  WITH CHECK ADD  CONSTRAINT [RefBODEGA66] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[EXISTENCIA] CHECK CONSTRAINT [RefBODEGA66]
GO
ALTER TABLE [dbo].[EXISTENCIA]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO65] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[EXISTENCIA] CHECK CONSTRAINT [RefPRODUCTO65]
GO
ALTER TABLE [dbo].[EXPERIENCIALABORAL]  WITH CHECK ADD  CONSTRAINT [RefCANDIDATO357] FOREIGN KEY([idcandidato])
REFERENCES [dbo].[CANDIDATO] ([idcandidato])
GO
ALTER TABLE [dbo].[EXPERIENCIALABORAL] CHECK CONSTRAINT [RefCANDIDATO357]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [RefCLIENTE466] FOREIGN KEY([idcliente])
REFERENCES [dbo].[CLIENTE] ([idcliente])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [RefCLIENTE466]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [RefESTADO471] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [RefESTADO471]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [RefMONEDA468] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [RefMONEDA468]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [RefTIPOPAGOFACTURA472] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TIPOPAGOFACTURA] ([idtipopago])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [RefTIPOPAGOFACTURA472]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [RefVENDEDOR467] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[VENDEDOR] ([idvendedor])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [RefVENDEDOR467]
GO
ALTER TABLE [dbo].[FACTURAPROVEEDORES]  WITH CHECK ADD  CONSTRAINT [RefMOVIMIENTOSINVENTARIO580] FOREIGN KEY([idbodega], [idmovimiento])
REFERENCES [dbo].[MOVIMIENTOSINVENTARIO] ([idbodega], [idmovimiento])
GO
ALTER TABLE [dbo].[FACTURAPROVEEDORES] CHECK CONSTRAINT [RefMOVIMIENTOSINVENTARIO580]
GO
ALTER TABLE [dbo].[FACTURAPROVEEDORES]  WITH CHECK ADD  CONSTRAINT [RefPROVEEDOR579] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[PROVEEDOR] ([idproveedor])
GO
ALTER TABLE [dbo].[FACTURAPROVEEDORES] CHECK CONSTRAINT [RefPROVEEDOR579]
GO
ALTER TABLE [dbo].[FASESPLANIFICACION]  WITH CHECK ADD  CONSTRAINT [RefDETPLANIFICACION536] FOREIGN KEY([iddetplanificacion])
REFERENCES [dbo].[DETPLANIFICACION] ([iddetplanificacion])
GO
ALTER TABLE [dbo].[FASESPLANIFICACION] CHECK CONSTRAINT [RefDETPLANIFICACION536]
GO
ALTER TABLE [dbo].[GASTO_CAMPANIA]  WITH CHECK ADD  CONSTRAINT [RefCAMPANIA453] FOREIGN KEY([idcampania])
REFERENCES [dbo].[CAMPANIA] ([idcampania])
GO
ALTER TABLE [dbo].[GASTO_CAMPANIA] CHECK CONSTRAINT [RefCAMPANIA453]
GO
ALTER TABLE [dbo].[GASTO_CAMPANIA]  WITH CHECK ADD  CONSTRAINT [RefPOLIZA454] FOREIGN KEY([idPoliza])
REFERENCES [dbo].[POLIZA] ([idPoliza])
GO
ALTER TABLE [dbo].[GASTO_CAMPANIA] CHECK CONSTRAINT [RefPOLIZA454]
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS]  WITH CHECK ADD  CONSTRAINT [RefDETALLEMOUNO599] FOREIGN KEY([iddetallemouno])
REFERENCES [dbo].[DETALLEMOUNO] ([iddetallemouno])
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS] CHECK CONSTRAINT [RefDETALLEMOUNO599]
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION598] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS] CHECK CONSTRAINT [RefORDENPRODUCCION598]
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS]  WITH CHECK ADD  CONSTRAINT [RefRECETARIO600] FOREIGN KEY([idrecetario])
REFERENCES [dbo].[RECETARIO] ([idrecetario])
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS] CHECK CONSTRAINT [RefRECETARIO600]
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS]  WITH CHECK ADD  CONSTRAINT [RefRECETARIOMATERIA601] FOREIGN KEY([idmateriaprimausada])
REFERENCES [dbo].[RECETARIOMATERIA] ([idmateriaprimausada])
GO
ALTER TABLE [dbo].[GASTOSCOMPLETOS] CHECK CONSTRAINT [RefRECETARIOMATERIA601]
GO
ALTER TABLE [dbo].[HORASEXTRA]  WITH CHECK ADD  CONSTRAINT [RefPERIODOPLANILLA371] FOREIGN KEY([id])
REFERENCES [dbo].[PERIODOPLANILLA] ([id])
GO
ALTER TABLE [dbo].[HORASEXTRA] CHECK CONSTRAINT [RefPERIODOPLANILLA371]
GO
ALTER TABLE [dbo].[INVENTARIOFISICO]  WITH CHECK ADD  CONSTRAINT [RefUSUARIO_1423] FOREIGN KEY([codusuario], [idrol])
REFERENCES [dbo].[USUARIO_1] ([codusuario], [idrol])
GO
ALTER TABLE [dbo].[INVENTARIOFISICO] CHECK CONSTRAINT [RefUSUARIO_1423]
GO
ALTER TABLE [dbo].[INVENTARIOSPROD]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA610] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[INVENTARIOSPROD] CHECK CONSTRAINT [RefEMPRESA610]
GO
ALTER TABLE [dbo].[INVENTARIOSPROD]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO602] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[INVENTARIOSPROD] CHECK CONSTRAINT [RefPRODUCTO602]
GO
ALTER TABLE [dbo].[INVENTARIOSPROD]  WITH CHECK ADD  CONSTRAINT [RefUNIDADMEDIDA608] FOREIGN KEY([idunidadmedida])
REFERENCES [dbo].[UNIDADMEDIDA] ([idunidadmedida])
GO
ALTER TABLE [dbo].[INVENTARIOSPROD] CHECK CONSTRAINT [RefUNIDADMEDIDA608]
GO
ALTER TABLE [dbo].[LISTAPRECIOS]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA587] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[LISTAPRECIOS] CHECK CONSTRAINT [RefEMPRESA587]
GO
ALTER TABLE [dbo].[LISTAPRECIOS]  WITH CHECK ADD  CONSTRAINT [RefESTADO504] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[LISTAPRECIOS] CHECK CONSTRAINT [RefESTADO504]
GO
ALTER TABLE [dbo].[LISTAPRECIOS]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO501] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[LISTAPRECIOS] CHECK CONSTRAINT [RefPRODUCTO501]
GO
ALTER TABLE [dbo].[LISTAPRECIOS]  WITH CHECK ADD  CONSTRAINT [RefTIPOLISTAPRECIO502] FOREIGN KEY([idtipolistaprecio])
REFERENCES [dbo].[TIPOLISTAPRECIO] ([idtipolistaprecio])
GO
ALTER TABLE [dbo].[LISTAPRECIOS] CHECK CONSTRAINT [RefTIPOLISTAPRECIO502]
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION420] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE] CHECK CONSTRAINT [RefAUTORIZACION420]
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE48] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE48]
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefVEHICULO47] FOREIGN KEY([idtransporte])
REFERENCES [dbo].[VEHICULO] ([idtransporte])
GO
ALTER TABLE [dbo].[M_GASTOTRANSPORTE] CHECK CONSTRAINT [RefVEHICULO47]
GO
ALTER TABLE [dbo].[MANOOBRA]  WITH CHECK ADD  CONSTRAINT [RefDETALLETAREA523] FOREIGN KEY([iddetalletarea])
REFERENCES [dbo].[DETALLETAREA] ([iddetalletarea])
GO
ALTER TABLE [dbo].[MANOOBRA] CHECK CONSTRAINT [RefDETALLETAREA523]
GO
ALTER TABLE [dbo].[METRICA]  WITH CHECK ADD  CONSTRAINT [RefDEPARTAMENTOEMPRESA346] FOREIGN KEY([iddepartamentoempresa])
REFERENCES [dbo].[DEPARTAMENTOEMPRESA] ([iddepartamentoempresa])
GO
ALTER TABLE [dbo].[METRICA] CHECK CONSTRAINT [RefDEPARTAMENTOEMPRESA346]
GO
ALTER TABLE [dbo].[METRICA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA410] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[METRICA] CHECK CONSTRAINT [RefEMPRESA410]
GO
ALTER TABLE [dbo].[MORDENSERVICIOV]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION139] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[MORDENSERVICIOV] CHECK CONSTRAINT [RefAUTORIZACION139]
GO
ALTER TABLE [dbo].[MORDENSERVICIOV]  WITH CHECK ADD  CONSTRAINT [RefTIPOSERVICIOVH422] FOREIGN KEY([idtiposerviciovh])
REFERENCES [dbo].[TIPOSERVICIOVH] ([idtiposerviciovh])
GO
ALTER TABLE [dbo].[MORDENSERVICIOV] CHECK CONSTRAINT [RefTIPOSERVICIOVH422]
GO
ALTER TABLE [dbo].[MORDENSERVICIOV]  WITH CHECK ADD  CONSTRAINT [RefVEHICULO44] FOREIGN KEY([idtransporte])
REFERENCES [dbo].[VEHICULO] ([idtransporte])
GO
ALTER TABLE [dbo].[MORDENSERVICIOV] CHECK CONSTRAINT [RefVEHICULO44]
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefBODEGA427] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO] CHECK CONSTRAINT [RefBODEGA427]
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefMONEDA429] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO] CHECK CONSTRAINT [RefMONEDA429]
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefREFERENCIAMOVIMIENTO428] FOREIGN KEY([idrefmovimiento])
REFERENCES [dbo].[REFERENCIAMOVIMIENTO] ([idrefmovimiento])
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO] CHECK CONSTRAINT [RefREFERENCIAMOVIMIENTO428]
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO]  WITH CHECK ADD  CONSTRAINT [RefTIPOMOVIMIENTO30] FOREIGN KEY([idtipomovimiento])
REFERENCES [dbo].[TIPOMOVIMIENTO] ([idtipomovimiento])
GO
ALTER TABLE [dbo].[MOVIMIENTOSINVENTARIO] CHECK CONSTRAINT [RefTIPOMOVIMIENTO30]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION142] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefAUTORIZACION142]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefCENTROCOSTO9] FOREIGN KEY([idcentro])
REFERENCES [dbo].[CENTROCOSTO] ([idcentro])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefCENTROCOSTO9]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefCUENTACONTABLE438] FOREIGN KEY([idCuenta])
REFERENCES [dbo].[CUENTACONTABLE] ([idCuenta])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefCUENTACONTABLE438]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA7] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefEMPRESA7]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefESTADOORDEN13] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADOORDEN] ([idestado])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefESTADOORDEN13]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefMONEDA12] FOREIGN KEY([idmoneda])
REFERENCES [dbo].[MONEDA] ([idmoneda])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefMONEDA12]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefPROVEEDOR11] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[PROVEEDOR] ([idproveedor])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefPROVEEDOR11]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefSEDE6] FOREIGN KEY([idsede])
REFERENCES [dbo].[SEDE] ([idsede])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefSEDE6]
GO
ALTER TABLE [dbo].[ORDENCOMPRA]  WITH CHECK ADD  CONSTRAINT [RefTIPOOC60] FOREIGN KEY([idtipooc])
REFERENCES [dbo].[TIPOOC] ([idtipooc])
GO
ALTER TABLE [dbo].[ORDENCOMPRA] CHECK CONSTRAINT [RefTIPOOC60]
GO
ALTER TABLE [dbo].[ORDENPRODUCCION]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA545] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[ORDENPRODUCCION] CHECK CONSTRAINT [RefEMPRESA545]
GO
ALTER TABLE [dbo].[ORDENPRODUCCION]  WITH CHECK ADD  CONSTRAINT [RefESTADOORDENPLA535] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADOORDENPLA] ([idestado])
GO
ALTER TABLE [dbo].[ORDENPRODUCCION] CHECK CONSTRAINT [RefESTADOORDENPLA535]
GO
ALTER TABLE [dbo].[PLANIFICACION]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA544] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[PLANIFICACION] CHECK CONSTRAINT [RefEMPRESA544]
GO
ALTER TABLE [dbo].[PLANILLAS]  WITH CHECK ADD  CONSTRAINT [RefPERIODOPLANILLA356] FOREIGN KEY([id])
REFERENCES [dbo].[PERIODOPLANILLA] ([id])
GO
ALTER TABLE [dbo].[PLANILLAS] CHECK CONSTRAINT [RefPERIODOPLANILLA356]
GO
ALTER TABLE [dbo].[POLIZA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA255] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[POLIZA] CHECK CONSTRAINT [RefEMPRESA255]
GO
ALTER TABLE [dbo].[POLIZAPRODUCCION]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION539] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[POLIZAPRODUCCION] CHECK CONSTRAINT [RefORDENPRODUCCION539]
GO
ALTER TABLE [dbo].[POLIZAPRODUCCION]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO592] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[POLIZAPRODUCCION] CHECK CONSTRAINT [RefPRODUCTO592]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA441] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefEMPRESA441]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefLINEA37] FOREIGN KEY([idlinea])
REFERENCES [dbo].[LINEA] ([idlinea])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefLINEA37]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefMARCA35] FOREIGN KEY([idmarca])
REFERENCES [dbo].[MARCA] ([idmarca])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefMARCA35]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefMETODOCOSTEO36] FOREIGN KEY([idmetodo])
REFERENCES [dbo].[METODOCOSTEO] ([idmetodo])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefMETODOCOSTEO36]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefPROVEEDOR5] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[PROVEEDOR] ([idproveedor])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefPROVEEDOR5]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefTIPOPRODUCTO19] FOREIGN KEY([idtipoproducto])
REFERENCES [dbo].[TIPOPRODUCTO] ([idtipoproducto])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefTIPOPRODUCTO19]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefTIPOUNIDAD605] FOREIGN KEY([unidadpeso])
REFERENCES [dbo].[TIPOUNIDAD] ([idtipounidad])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefTIPOUNIDAD605]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [RefTIPOUNIDAD606] FOREIGN KEY([unidadtamano])
REFERENCES [dbo].[TIPOUNIDAD] ([idtipounidad])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [RefTIPOUNIDAD606]
GO
ALTER TABLE [dbo].[PRORRATERO]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION541] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[PRORRATERO] CHECK CONSTRAINT [RefORDENPRODUCCION541]
GO
ALTER TABLE [dbo].[PROVEEDOR]  WITH CHECK ADD  CONSTRAINT [RefSEDE437] FOREIGN KEY([idsede])
REFERENCES [dbo].[SEDE] ([idsede])
GO
ALTER TABLE [dbo].[PROVEEDOR] CHECK CONSTRAINT [RefSEDE437]
GO
ALTER TABLE [dbo].[PUESTODETRABAJO]  WITH CHECK ADD  CONSTRAINT [RefDEPARTAMENTOEMPRESA383] FOREIGN KEY([iddepartamentoempresa])
REFERENCES [dbo].[DEPARTAMENTOEMPRESA] ([iddepartamentoempresa])
GO
ALTER TABLE [dbo].[PUESTODETRABAJO] CHECK CONSTRAINT [RefDEPARTAMENTOEMPRESA383]
GO
ALTER TABLE [dbo].[PUESTODETRABAJO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA411] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[PUESTODETRABAJO] CHECK CONSTRAINT [RefEMPRESA411]
GO
ALTER TABLE [dbo].[PUESTODETRABAJO]  WITH CHECK ADD  CONSTRAINT [RefESTADOPUESTO380] FOREIGN KEY([idestadopuesto])
REFERENCES [dbo].[ESTADOPUESTO] ([idestadopuesto])
GO
ALTER TABLE [dbo].[PUESTODETRABAJO] CHECK CONSTRAINT [RefESTADOPUESTO380]
GO
ALTER TABLE [dbo].[RECETARIO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA546] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[RECETARIO] CHECK CONSTRAINT [RefEMPRESA546]
GO
ALTER TABLE [dbo].[RECETARIOGASTO]  WITH CHECK ADD  CONSTRAINT [RefRECETARIO513] FOREIGN KEY([idrecetario])
REFERENCES [dbo].[RECETARIO] ([idrecetario])
GO
ALTER TABLE [dbo].[RECETARIOGASTO] CHECK CONSTRAINT [RefRECETARIO513]
GO
ALTER TABLE [dbo].[RECETARIOGASTO]  WITH CHECK ADD  CONSTRAINT [RefTIPOGASTO514] FOREIGN KEY([idgasto])
REFERENCES [dbo].[TIPOGASTO] ([idgasto])
GO
ALTER TABLE [dbo].[RECETARIOGASTO] CHECK CONSTRAINT [RefTIPOGASTO514]
GO
ALTER TABLE [dbo].[RECETARIOMATERIA]  WITH CHECK ADD  CONSTRAINT [RefORDENPRODUCCION596] FOREIGN KEY([idordenproduccion])
REFERENCES [dbo].[ORDENPRODUCCION] ([idordenproduccion])
GO
ALTER TABLE [dbo].[RECETARIOMATERIA] CHECK CONSTRAINT [RefORDENPRODUCCION596]
GO
ALTER TABLE [dbo].[RECETARIOMATERIA]  WITH CHECK ADD  CONSTRAINT [RefPRODUCTO597] FOREIGN KEY([idproducto])
REFERENCES [dbo].[PRODUCTO] ([idproducto])
GO
ALTER TABLE [dbo].[RECETARIOMATERIA] CHECK CONSTRAINT [RefPRODUCTO597]
GO
ALTER TABLE [dbo].[REFERENCIAMOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [RefORDENCOMPRA578] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ORDENCOMPRA] ([idordencompra])
GO
ALTER TABLE [dbo].[REFERENCIAMOVIMIENTO] CHECK CONSTRAINT [RefORDENCOMPRA578]
GO
ALTER TABLE [dbo].[SOLICITUDPRODUCCION]  WITH CHECK ADD  CONSTRAINT [RefBODEGA507] FOREIGN KEY([idbodega])
REFERENCES [dbo].[BODEGA] ([idbodega])
GO
ALTER TABLE [dbo].[SOLICITUDPRODUCCION] CHECK CONSTRAINT [RefBODEGA507]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO418] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] CHECK CONSTRAINT [RefEMPLEADO418]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA58] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] CHECK CONSTRAINT [RefEMPRESA58]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefESTADOSOLICITUDTRANS41] FOREIGN KEY([idestadost])
REFERENCES [dbo].[ESTADOSOLICITUDTRANS] ([idestadost])
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] CHECK CONSTRAINT [RefESTADOSOLICITUDTRANS41]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefTIPOSOLICTRANS40] FOREIGN KEY([idtiposolict])
REFERENCES [dbo].[TIPOSOLICTRANS] ([idtiposolict])
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] CHECK CONSTRAINT [RefTIPOSOLICTRANS40]
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE]  WITH CHECK ADD  CONSTRAINT [RefUSUARIO_1419] FOREIGN KEY([codusuario], [idrol])
REFERENCES [dbo].[USUARIO_1] ([codusuario], [idrol])
GO
ALTER TABLE [dbo].[SOLICITUDTRANSPORTE] CHECK CONSTRAINT [RefUSUARIO_1419]
GO
ALTER TABLE [dbo].[SOLICITUDVACACIONES]  WITH CHECK ADD  CONSTRAINT [RefMOTIVO354] FOREIGN KEY([codmotivo])
REFERENCES [dbo].[MOTIVO] ([codmotivo])
GO
ALTER TABLE [dbo].[SOLICITUDVACACIONES] CHECK CONSTRAINT [RefMOTIVO354]
GO
ALTER TABLE [dbo].[SOLICITUDVACACIONES]  WITH CHECK ADD  CONSTRAINT [RefVACACIONES352] FOREIGN KEY([codvacaciones])
REFERENCES [dbo].[VACACIONES] ([codvacaciones])
GO
ALTER TABLE [dbo].[SOLICITUDVACACIONES] CHECK CONSTRAINT [RefVACACIONES352]
GO
ALTER TABLE [dbo].[TAREA]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA547] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[TAREA] CHECK CONSTRAINT [RefEMPRESA547]
GO
ALTER TABLE [dbo].[TRANSACCION]  WITH CHECK ADD  CONSTRAINT [RefAUTORIZACION253] FOREIGN KEY([idAutorizacion])
REFERENCES [dbo].[AUTORIZACION] ([idAutorizacion])
GO
ALTER TABLE [dbo].[TRANSACCION] CHECK CONSTRAINT [RefAUTORIZACION253]
GO
ALTER TABLE [dbo].[TRANSACCION]  WITH CHECK ADD  CONSTRAINT [RefCUENTA73] FOREIGN KEY([idcuenta])
REFERENCES [dbo].[CUENTA] ([idcuenta])
GO
ALTER TABLE [dbo].[TRANSACCION] CHECK CONSTRAINT [RefCUENTA73]
GO
ALTER TABLE [dbo].[TRANSACCION]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA87] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[TRANSACCION] CHECK CONSTRAINT [RefEMPRESA87]
GO
ALTER TABLE [dbo].[TRAYECTO]  WITH CHECK ADD  CONSTRAINT [RefSOLICITUDTRANSPORTE50] FOREIGN KEY([idsolicitud])
REFERENCES [dbo].[SOLICITUDTRANSPORTE] ([idsolicitud])
GO
ALTER TABLE [dbo].[TRAYECTO] CHECK CONSTRAINT [RefSOLICITUDTRANSPORTE50]
GO
ALTER TABLE [dbo].[UNIDADMEDIDA]  WITH CHECK ADD  CONSTRAINT [RefTIPOUNIDAD604] FOREIGN KEY([idtipounidad])
REFERENCES [dbo].[TIPOUNIDAD] ([idtipounidad])
GO
ALTER TABLE [dbo].[UNIDADMEDIDA] CHECK CONSTRAINT [RefTIPOUNIDAD604]
GO
ALTER TABLE [dbo].[USUARIO_1]  WITH CHECK ADD  CONSTRAINT [RefROL373] FOREIGN KEY([idrol])
REFERENCES [dbo].[ROL] ([idrol])
GO
ALTER TABLE [dbo].[USUARIO_1] CHECK CONSTRAINT [RefROL373]
GO
ALTER TABLE [dbo].[VACACIONES]  WITH CHECK ADD  CONSTRAINT [RefCALCULODEVACACIONES401] FOREIGN KEY([codcalculo])
REFERENCES [dbo].[CALCULODEVACACIONES] ([codcalculo])
GO
ALTER TABLE [dbo].[VACACIONES] CHECK CONSTRAINT [RefCALCULODEVACACIONES401]
GO
ALTER TABLE [dbo].[VACACIONES]  WITH CHECK ADD  CONSTRAINT [RefDIASFESTIVOS403] FOREIGN KEY([codfestivo])
REFERENCES [dbo].[DIASFESTIVOS] ([codfestivo])
GO
ALTER TABLE [dbo].[VACACIONES] CHECK CONSTRAINT [RefDIASFESTIVOS403]
GO
ALTER TABLE [dbo].[VACACIONES]  WITH CHECK ADD  CONSTRAINT [RefEMPLEADO355] FOREIGN KEY([idempleado])
REFERENCES [dbo].[EMPLEADO] ([idempleado])
GO
ALTER TABLE [dbo].[VACACIONES] CHECK CONSTRAINT [RefEMPLEADO355]
GO
ALTER TABLE [dbo].[VEHICULO]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA57] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[VEHICULO] CHECK CONSTRAINT [RefEMPRESA57]
GO
ALTER TABLE [dbo].[VEHICULO]  WITH CHECK ADD  CONSTRAINT [RefTIPOVEHICULO43] FOREIGN KEY([idtipotrans])
REFERENCES [dbo].[TIPOVEHICULO] ([idtipotrans])
GO
ALTER TABLE [dbo].[VEHICULO] CHECK CONSTRAINT [RefTIPOVEHICULO43]
GO
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [RefEMPRESA582] FOREIGN KEY([idempresa])
REFERENCES [dbo].[EMPRESA] ([idempresa])
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [RefEMPRESA582]
GO
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [RefESTADO445] FOREIGN KEY([idestado])
REFERENCES [dbo].[ESTADO] ([idestado])
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [RefESTADO445]
GO
