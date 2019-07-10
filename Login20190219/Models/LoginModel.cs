using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Login20190219.Models
{
    public class LoginModel
    {
        string connstr;
        public LoginModel()
        {
            ConnectionModel c = new ConnectionModel();
            connstr = c.mssqlconn();
        }
        public string Verify(string userid,string pwd)
        {
            string result = "";
            //like 
            //避免sql injection
            //string sql = "select * from USerDataTbl where userid = '"+userid+"' and password = @password";
            string chkpwd = "";
            string sql = "select password from UserBasicTbl where userid = @userid";
            //select * from USerDataTbl where userid = :user and password = :password
            using (SqlConnection conn = new SqlConnection(connstr))
            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                conn.Open();
                cmd.Parameters.Add("userid", SqlDbType.VarChar).Value = userid;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chkpwd = (dr["password"] ?? "").ToString();
                }
            }
            if(pwd == chkpwd)
            {
                result = "1";
            }
            return result;
        }
    }
}