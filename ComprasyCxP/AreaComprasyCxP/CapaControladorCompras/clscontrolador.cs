using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloCompras;

namespace CapaControladorCompras
{
    public class clscontrolador
    {
        //Instanciamos la clase sentencias

        clssentencias sn = new clssentencias();
                public OdbcDataReader insertar_bodegas(string[] dato)
                {
                    return sn.insertar_bodegas(dato);
                }
                public OdbcDataReader insertar_linea(string[] dato)
                {
                    return sn.insertar_linea(dato);
                }
                public OdbcDataReader insertar_marca(string[] dato)
                {
                    return sn.insertar_marca(dato);
                }

        //fernando biggs
        public OdbcDataReader insertar_OrdenC(string[] dato)
        {
            return sn.insertar_OrdenCompra(dato);
        }


        public OdbcDataReader llenarcboProv()
        {
            return sn.llenarcboprovCompras();
        }

       
        public OdbcDataReader llenarcboOrdenC()
        {
            return sn.llenarcboIDorden();
        }

   

        public OdbcDataReader llenarProducto()
        {
            return sn.llenarPr();
        }

        public DataTable llenarDvgOrdenCompra(string condicion)
        {
            OdbcDataAdapter dt = sn.llenardvgor(condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        
        public DataTable actualizar()
        {
            OdbcDataAdapter dt = sn.llenardvgORNOR();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
      

        public OdbcDataReader llenarProv()
        {
            return sn.llenarPrOr();
        }

      

        public OdbcDataReader consultar(string tabla)
        {
            return sn.consulta(tabla);
        }

        public OdbcDataReader insertar_traslado(string[] dato)
        {
            return sn.insertar_traslado(dato);

        }

        public OdbcDataReader llenarbodega()
        {
            return sn.bodega();

        }

        public OdbcDataReader llenarproducto()
        {
            return sn.productos();

        }

      

    }


}
