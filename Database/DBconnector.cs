using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ElevenSeven.Database
{
    class DBconnector
    {
        
        string connetionString = "server=localhost;" +
                "database=elevenseven;" +
                "uid=root;" +
                "pwd=1234;";
        MySqlConnection cnn;

        public DBconnector()
        {
            
        }

        public void connect()
        {
            
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
         public string getConnectionstring()
        {
            return connetionString;
        }

    }
}
