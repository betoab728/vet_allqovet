using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;



namespace AllqovetDAO
{
    public class MarcaDAO : IMarca
    {
        string cnx = Conexion.ObtenerConexion();

        public int Agregar(Marca marca)
        {
            using (MySqlConnection cn = new MySqlConnection (cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_RegistrarMarca", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pNombre", marca.Nombre);

                    int r = cmd.ExecuteNonQuery();

                    return r;
                }
            }
        }   
            
        public int Editar(Marca marca)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarMarca(Marca marca)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_BuscarMarca", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pBuscar",marca.Nombre);

                    cn.Open();
                    using (MySqlDataAdapter da=new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }

        }
    }

         
            


    }

