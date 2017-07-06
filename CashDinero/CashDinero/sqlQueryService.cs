using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CashDinero
{
    class sqlQueryService : constants
    {

        private SqlConnection openConection()
        {
            SqlConnection conexion = new SqlConnection(conectionServer);
            return conexion;
        }

        private void closeConection(SqlConnection conection)
        {
            conection.Close();
        }

        private SqlCommand createCommand(string query, SqlConnection conection)
        {
            SqlCommand command = new SqlCommand(query, conection);
            return command;
        }

        private void insertData(string table, List<String> columnsArray, List<String> valuesArray)
        { 
            string columns = "";
            string values = "";

            //Obtenemos todos las columnas en las que queremos insertar datos
            for (int i = 0; i < columnsArray.Count(); i++)
            {
                columns += columnsArray[i] + ", ";
                values += "@" + columnsArray[i] + ", ";
            }

            //Creamos el query ya con las columnas y valores
            string query = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ")";

            //Abrimos una conexion
            var conection = openConection();

            //Creamos el comando ya con el query y la conexion creada
            var insert = createCommand(query, conection);

            //Añadimos todos los valores de las columnas
            for (int i = 0; i < valuesArray.Count(); i++)
            {
                insert.Parameters.AddWithValue("@" + columnsArray[i], valuesArray[i]);
            }

            //Insertamos los datos
            insert.ExecuteNonQuery();

            //Cerramos la conexion
            closeConection(conection);

        }

        private DataTable selectData(string table, List<String> columnsArray, List<String> columnsOfCondictions, List<valuesWhere> valuesOfCondictions)
        {
            string columns = "";
            string condictions = "";

            //Añadimos todas las columnas que queremos consultar
            for (int i = 0; i < columnsArray.Count(); i++)
            {
                columns += columnsArray[i] + " "; 
            }

            //En el caso de tener condiciones las guardamos para despues agregarla a la consulta
            for (int i = 0; i < columnsOfCondictions.Count(); i++)
            {
                if (i == 0)
                {
                    condictions += "WHERE ";
                }
                if(valuesOfCondictions[i].typeString)
                {
                    condictions += columnsOfCondictions[i] + "= '" + valuesOfCondictions[i].value + "' " + valuesOfCondictions[i].operationBool;
                }
                else
                {
                    condictions += columnsOfCondictions[i] + "= " + valuesOfCondictions[i].value + " " + valuesOfCondictions[i].operationBool;
                }
            }

            //Creamos la consulta
            string query = "SELECT " + columns + "FROM " + table + condictions;

            //Abrimos una conexion
            var conection = openConection();

            //Creamos el adaptador para guardar los datos
            SqlDataAdapter select = new SqlDataAdapter(query, conectionServer);

            //Pasamos la informacion en un tabla 
            DataSet data = new DataSet();
            DataTable selectInformation = new DataTable();
            select.Fill(data);

            selectInformation = data.Tables[0];

            //Cerramos la conexion
            closeConection(conection);

            return selectInformation;
        }

        private int selectCountData(string table, string column, List<valuesWhere> valuesCondictionsArray)
        {
            int count = 0;
            string condictions = "";

            //En el caso de tener condiciones las guardamos para despues agregarla a la consulta
            for (int i = 0; i < valuesCondictionsArray.Count(); i++)
            {
                if (i == 0)
                {
                    condictions += "WHERE ";
                }
                if (valuesCondictionsArray[i].typeString)
                {
                    condictions += valuesCondictionsArray[i] + "= '" + valuesCondictionsArray[i].value + "' " + valuesCondictionsArray[i].operationBool;
                }
                else
                {
                    condictions += valuesCondictionsArray[i] + "= " + valuesCondictionsArray[i].value + " " + valuesCondictionsArray[i].operationBool;
                }
            }

            //Creamos la consulta
            string query = "SELECT COUNT(" + column + ")" + "FROM " + table + condictions;

            //Abrimos una conexion
            var conection = openConection();

            //Creamos el comando ya con el query
            var selectCount = createCommand(query, conection);

            //Ejecutamos la consulta
            count = selectCount.ExecuteNonQuery();

            return count;
        }

        private void updateData()
        {

        }

        /*
         
            string select = "SELECT COUNT(fecha) FROM FECHA WHERE fecha= '" + fecha + "'";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            try
            {
                string compro = (cmd.ExecuteScalar()).ToString();

                if (Convert.ToInt32(compro) != 0)
                {
                    DialogResult resultado = MessageBox.Show("Ya existe un historial del dia de hoy\n\n      Desea continuar el dia de hoy?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        Pantalla2 form = new Pantalla2(fecha, ds, band, operador);
                        form.Show();
                        this.Close();
                    }
                   
                }
                else
                {
                    string insertar = "INSERT INTO FECHA (fecha, id) VALUES (@fecha, @id)";
                    OleDbCommand cmd1 = new OleDbCommand(insertar, conexion);
                    cmd1.Parameters.AddWithValue("@fecha", fecha);
                    cmd1.Parameters.AddWithValue("@id", fechanum);

                    cmd1.ExecuteNonQuery();
                    
                    Pantalla2 form = new Pantalla2(fecha, ds, band, operador);
                    form.Show();
                    this.Close();
                }
            }
         */
    }
}
