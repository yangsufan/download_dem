using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace DownLoad
{
   public class DbOperator
    {

        public DbOperator(string host, string username, string password, string dbname)
        {
            ConnectStr=GetConnectStr(host, username, password, dbname);
            GetConnection();
        }
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private string ConnectStr = string.Empty;
        NpgsqlConnection m_MainCon;
        private string GetConnectStr(string host,string username,string password,string dbname)
        {
            return string.Format("Host={0};Username={1};Password={2};Database={3}",host,username,password,dbname);
        }
        private bool GetConnection()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(ConnectStr))
            {
                return flag;
            }
            m_MainCon = new NpgsqlConnection(ConnectStr);
            try
            {
                m_MainCon.Open();
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            finally
            {
                m_MainCon.Close();
            }
            return flag;
        }
        public DataTable GetTable(string tableName, string whereCase)
        {
            DataTable retTable = new DataTable(tableName);
            if (m_MainCon == null)
            {
                return retTable;
            }
            try
            {
                if (m_MainCon.State != ConnectionState.Open)
                {
                    m_MainCon.Open();
                }
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = m_MainCon;
                string commandStr = string.Empty;
                if (string.IsNullOrEmpty(whereCase))
                {
                    commandStr = string.Format("select * from {0}", tableName);
                }
                else
                {
                    commandStr = string.Format("select * from {0} where {1}", tableName, whereCase);
                }
                comm.CommandText = commandStr;
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(comm);
                dataAdapter.Fill(retTable);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                m_MainCon.Close();
            }
                return retTable;
        }
        public bool InsertData(DataTable newTable,string tableName)
        {
            bool flag = false;
            try
            {
                if (m_MainCon.State != ConnectionState.Open)
                {
                    m_MainCon.Open();
                }
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = m_MainCon;
                int columnCount = newTable.Columns.Count;
                string columnStr = string.Empty;
                string valueStr = string.Empty;
                for (int i = 0; i < columnCount; i++)
                {
                    columnStr += string.Format("{0},", newTable.Columns[i].ColumnName);
                }
                if (columnStr.EndsWith(",")) columnStr = columnStr.Substring(0, columnStr.LastIndexOf(","));
                for (int j = 0; j < newTable.Rows.Count; j++)
                {
                    for (int k = 0; k < columnCount; k++)
                    {
                        valueStr += string.Format("'{0}',", newTable.Rows[j][k].ToString());
                    }
                    if (valueStr.EndsWith(",")) valueStr = valueStr.Substring(0, valueStr.LastIndexOf(","));
                    comm.CommandText = string.Format("insert into {0} ({1}) values ({2})", tableName, columnStr, valueStr);
                    comm.ExecuteNonQuery();
                    valueStr = string.Empty;
                }
                flag = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                m_MainCon.Close();
            }
            return flag;
        }

        public bool UpdateData(string tableName,string keyColumnName,string keyValue,params string[] updatestr)
        {
            bool flag = false;
            try
            {
                if (m_MainCon.State != ConnectionState.Open)
                {
                    m_MainCon.Open();
                }
                if (updatestr.Length <= 0) return flag;
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = m_MainCon;
                string whereCase = string.Format("{0}='{1}'", keyColumnName, keyValue);
                string setStr = string.Empty;
                for (int i = 0; i < updatestr.Length; i++)
                {
                    setStr += string.Format("{0},",updatestr[i]);
                }
                if (setStr.EndsWith(",")) setStr = setStr.Substring(0, setStr.LastIndexOf(","));
                comm.CommandText = string.Format("update {0} set {1} where {2}", tableName, setStr, whereCase);
                comm.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
                if(m_MainCon.FullState==ConnectionState.Open)
                {
                    m_MainCon.Close();
                }
               
            }
            return flag;
        }

        public bool CreateTable(string tableName, Dictionary<string,string> dicColumn)
        {
            bool flag = false;
            try
            {
                if (IsTableExits(tableName))
                {
                    return flag;
                }
                else
                {
                    string ColStr = string.Empty;
                    foreach (string key in dicColumn.Keys)
                    {
                        ColStr += string.Format("{0} {1} ,", key, dicColumn[key]);
                    }
                    if (ColStr.EndsWith(",")) ColStr = ColStr.Substring(0, ColStr.LastIndexOf(","));
                    if (m_MainCon.State != ConnectionState.Open)
                    {
                        m_MainCon.Open();
                    }
                    NpgsqlCommand comm = new NpgsqlCommand();
                    comm.Connection = m_MainCon;
                    comm.CommandText = string.Format("create table {0} ({1})", tableName, ColStr);
                    comm.ExecuteNonQuery();
                    flag = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                m_MainCon.Close();
            }
            return flag;
        }
        public bool IsTableExits(string tableName)
        {
            bool flag = false;
            try
            {
                if (m_MainCon.State != ConnectionState.Open)
                {
                    m_MainCon.Open();
                }
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = m_MainCon;
                comm.CommandText = string.Format("SELECT to_regclass('{0}') is not null", tableName);
                NpgsqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    flag=reader.GetBoolean(0);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                m_MainCon.Close();
            }
            return flag;
        }
    }
}
