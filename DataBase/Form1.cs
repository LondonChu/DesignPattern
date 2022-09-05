using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectString = $"Data Source = c219951\\SQLEXPRESS; Initial Catalog = DataDB; Integrated Security = SSPI";

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connectString);

                ConnectType(_connectType.Open, connect);

                string output = "";
                SqlCommand command;
                SqlDataReader dataReader;

                if (((Button)sender).Name == b_GetData.Name)
                {
                    command = new SqlCommand("SELECT [Region_Name], [Store_Name] FROM [DataDB].[dbo].[Geography]", connect);
                    dataReader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);

                    //DataView dataView = dataTable.DefaultView;//=>直接用的話，若 DataView 改了任何東西 DataTable 也會跟著改，雙方會互相影響更新
                    DataView dataView = dataTable.Copy().DefaultView;
                    dataView.Sort = "Store_Name";

                    DataRowView dataRowView = dataView.AddNew();
                    dataRowView["Region_Name"] = "ABCDE";
                    dataRowView["Store_Name"] = "ABCCCCCD";
                    dataRowView.EndEdit();

                    dataGridView1.DataSource = dataTable;

                    dataGridView2.DataSource = dataView;

                }
                else if(((Button)sender).Name == b_執行預存程序.Name)
                { 
                    //command = new SqlCommand("EXEC [dbo].[ProcedureTable] 'Boston'", connect);
                    command = new SqlCommand("ProcedureTable", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Store_Name ", "Boston");

                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        output += dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
                    }
                    MessageBox.Show(output);
                }

                ConnectType(_connectType.Close, connect);

                ConnectType(_connectType.Dispose, connect);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There's an error connecting to the database!\n" + ex.Message);
            }

            Console.ReadLine();
        }

        private enum _connectType { Open, Close, Dispose }

        private void ConnectType(_connectType connectType, SqlConnection connect)
        {
            switch (connectType)
            {
                case _connectType.Open:
                    connect.Open();
                    break;
                case _connectType.Close:
                    connect.Close();
                    break;
                case _connectType.Dispose:
                    connect.Dispose();
                    break;
                default:
                    break;
            }
            
            Console.WriteLine($"The database has been {connectType.ToString()}!");
            Console.WriteLine("Connection State: " + connect.State.ToString());
        }




        protected DataSet DataSet1;
        protected DataGrid dataGrid1;

        private void DemonstrateDataView()
        {
            // Create one DataTable with one column.
            DataTable table = new DataTable("table");
            DataColumn colItem = new DataColumn("item", Type.GetType("System.String"));
            table.Columns.Add(colItem);

            // Add five items.
            DataRow NewRow;
            for (int i = 0; i < 5; i++)
            {
                NewRow = table.NewRow();
                NewRow["item"] = "Item " + i;
                table.Rows.Add(NewRow);
            }
            // Change the values in the table.
            table.AcceptChanges();

            table.Rows[0]["item"] = "cat";
            table.Rows[1]["item"] = "dog";

            // Create two DataView objects with the same table.
            DataView firstView = new DataView(table);
            DataView secondView = new DataView(table);

            // Print current table values.
            PrintTableOrView(table, "Current Values in Table");

            // Set first DataView to show only modified versions of original rows. (將第一個資料檢視設置為僅顯示已修改原始行的版本。)
            firstView.RowStateFilter = DataViewRowState.ModifiedOriginal;

            // Print values.
            PrintTableOrView(firstView, "First DataView: ModifiedOriginal");

            // Add one New row to the second view.
            DataRowView rowView;
            rowView = secondView.AddNew();
            rowView["item"] = "fish";

            // Set second DataView to show modified versions of
            // current rows, or New rows.
            secondView.RowStateFilter = DataViewRowState.ModifiedCurrent | DataViewRowState.Added;
            // Print modified and Added rows.
            PrintTableOrView(secondView,"Second DataView: ModifiedCurrent | Added");

            table.AcceptChanges();
            table.Rows[3]["item"] = "SHIT";

            PrintTableOrView(table, "Current Values in Table");
            PrintTableOrView(firstView, "First DataView: ModifiedOriginal");
            PrintTableOrView(secondView, "Second DataView: ModifiedCurrent | Added");
            
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);
            DataView dataView = new DataView(dataSet.Tables["table"],
                "Item like 'Item%'",//String filter
                "Item DESC",//String sort
                DataViewRowState.CurrentRows);
            PrintTableOrView(dataView, "DataView:");

            dataView.Sort = "Item ASC";
            DataTable sortedDT = dataView.ToTable();
            PrintTableOrView(sortedDT, "DataTable sorted:");
        }

        private void PrintTableOrView(DataTable table, string label)
        {
            // This function prints values in the table or DataView.
            Console.WriteLine("\n" + label);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Console.WriteLine("table " + table.Rows[i]["item"]);
            }
            Console.WriteLine();
        }

        private void PrintTableOrView(DataView view, string label)
        {
            // This overload prints values in the table or DataView.
            Console.WriteLine("\n" + label);
            for (int i = 0; i < view.Count; i++)
            {
                Console.WriteLine("table " + view[i]["item"]);
            }
            Console.WriteLine();
        }

        private void b_MSDNEX_Click(object sender, EventArgs e)
        {
            DemonstrateDataView();
        }


        string strCmd = "SELECT [Region_Name], [Store_Name] FROM [DataDB].[dbo].[Geography] WHERE Store_Name = @Store_Name";
        private void b_DataSet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCmd, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Store_Name", "Boston");
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                //return dataSet;                
            }
        }

        private void b_DataReader_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(strCmd, connection);
                command.Parameters.AddWithValue("@Store_Name", "Boston");
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    //return dataTable;
                }
            }
        }

        static void Function(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM table1;", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
            }

            

        }
    }
}
