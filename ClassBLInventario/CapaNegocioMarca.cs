using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using ClassAccesoDatosSQL22;
using ClassCapaEntidad;

namespace ClassBLInventario
{
    public class CapaNegocioMarca
    {
        private AccesoSQL operacion = null;

        public CapaNegocioMarca(string cadConx)
        {
            operacion = new AccesoSQL(cadConx);
        }

        public Boolean InsertarMarca(EntidadMarca nuevo, ref string m)
        {
<<<<<<< HEAD
            string sentencia = "insert into Marca(Marca, Extra) values(@ma,  @ext);";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("ma",SqlDbType.VarChar,50),
                
                new SqlParameter("ext",SqlDbType.VarChar, 50)
            };
            coleccion[0].Value = nuevo.Marca;
           
            coleccion[1].Value = nuevo.Extra;
=======
            string sentencia = "insert into Marca(Marca, Id_Componente, Extra) values(@ma, @id_co, @ext);";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("ma",SqlDbType.VarChar,50),
                new SqlParameter("id_co",SqlDbType.SmallInt),
                new SqlParameter("ext",SqlDbType.VarChar, 50)
            };
            coleccion[0].Value = nuevo.Marca;
            coleccion[1].Value = nuevo.Id_Componente;
            coleccion[2].Value = nuevo.Extra;
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean ModificarMarca(EntidadMarca nuevo, ref string m)
        {
<<<<<<< HEAD
            string sentencia = "UPDATE Marca set Marca = @ma, Extra = @ext WHERE id_Marca =@id";
=======
            string sentencia = "UPDATE Marca set Marca = @ma, Id_Componente = @id_co, Extra = @ext WHERE id_Marca =@id";
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("id",SqlDbType.Int),
                 new SqlParameter("ma",SqlDbType.VarChar,50),
<<<<<<< HEAD
                
=======
                new SqlParameter("id_co",SqlDbType.SmallInt),
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
                new SqlParameter("ext",SqlDbType.VarChar, 50)
            };
            coleccion[0].Value = nuevo.Id_Marca;
            coleccion[1].Value = nuevo.Marca;
<<<<<<< HEAD
            
            coleccion[2].Value = nuevo.Extra;
=======
            coleccion[2].Value = nuevo.Id_Componente;
            coleccion[3].Value = nuevo.Extra;
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }

        public List<EntidadMarca> DevuelveInfoMarca(ref string mensaje)
        {
            List<EntidadMarca> lista = new List<EntidadMarca>();
            SqlDataReader atrapa = null;
            SqlConnection cn = null;
            cn = operacion.AbrirConexion(ref mensaje);
            string consulta = "select * from Marca";
            atrapa = operacion.ConsultaDR(consulta, cn, ref mensaje);
            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new EntidadMarca()
                    {
                        Marca = atrapa[1].ToString(),
<<<<<<< HEAD
                        
                        Extra = atrapa[2].ToString()
=======
                        Id_Componente = atrapa[2].ToString(),
                        Extra = atrapa[3].ToString()
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
                    }
                    );
                }
            }
            cn.Close();
            cn.Dispose();
            return lista;
        }

        public List<EntidadMarca> DevuelveIDMarca(ref string mensaje)
        {
            List<EntidadMarca> lista = new List<EntidadMarca>();
            SqlDataReader atrapa = null;
            SqlConnection cn = null;
            cn = operacion.AbrirConexion(ref mensaje);
            string consulta = "select * from Marca";
            atrapa = operacion.ConsultaDR(consulta, cn, ref mensaje);
            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new EntidadMarca()
                    {
<<<<<<< HEAD
                        Id_Marca = Convert.ToInt16(atrapa[0]),
                        Marca = atrapa[1].ToString(),
                        
                        Extra = atrapa[2].ToString()
=======
                        Id_Marca = Convert.ToInt16(atrapa[0])
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
                    }
                    );
                }
            }
            cn.Close();
            cn.Dispose();
            return lista;
        }

        public DataTable ObtenTodasMarcas(ref string mensaje)
        {
            string consulta = "Select * from Marca";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.AbrirConexion(ref mensaje), ref mensaje);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public Boolean EliminarMarca(EntidadMarca nuevo, ref string m)
        {
<<<<<<< HEAD
            string sentencia = "DELETE FROM Marca WHERE Id_Marca = @id";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("id",SqlDbType.Int),
            };
            coleccion[0].Value = nuevo.Id_Marca;
=======
            string sentencia = "DELETE FROM Marca WHERE Marca = @mar";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("mar",SqlDbType.VarChar,50),
            };
            coleccion[0].Value = nuevo.Marca;
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }
<<<<<<< HEAD
=======

       

        

        public DataTable ObtenTodasMarcasIDMarc(ref string mensaje)
        {
            string consulta = "select Id_Marca, Marca from marca";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.AbrirConexion(ref mensaje), ref mensaje);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
>>>>>>> f4fc620c5058dd19b73c7de5c19e64153380c7b0
    }
}
