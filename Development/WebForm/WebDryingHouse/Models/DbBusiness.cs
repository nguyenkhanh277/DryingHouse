using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebDryingHouse.Models
{
    public class DbBusiness
    {
        #region User
        public bool ExistOperator(string username, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = @"SELECT Username, Password, Salt FROM Users WHERE Username = N'" + username + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }

        public bool CheckAuthorization(string username, string programName, string functionName, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = @"SELECT UserAuthorities.UserId
                                FROM UserAuthorities LEFT JOIN 
                                     ProgramFunctionAuthorities ON UserAuthorities.Id = ProgramFunctionAuthorities.AuthorityGroupID
                                WHERE UserAuthorities.UserId = N'" + username + "' AND ProgramFunctionAuthorities.ProgramName = N'" + programName + "' AND ProgramFunctionAuthorities.FunctionName = N'" + functionName + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }
        #endregion

        #region ScanBarcode
        public float GetDungSai(SqlConnection cn)
        {
            float result = 5;
            DataTable tbl = new DataTable();
            try
            {
                string query = "SELECT DungSai FROM Settings";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                adp.Fill(tbl);
                adp.Dispose();
                result = (tbl.Rows.Count > 0 ? float.Parse(tbl.Rows[0][0].ToString()) : 5);
            }
            catch (Exception ex)
            { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }

        public DataTable GetProduct(string barcode, SqlConnection cn)
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = "SELECT PartNumber FROM RegistBarcodes WHERE Barcode = N'" + barcode + "'";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return tbl;
        }

        public DataTable GetCurrentStep(string barcode, SqlConnection cn)
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = @"SELECT TOP 1 Id, StepNo, ScanIn, ScanOut FROM ScanBarcodes
                                WHERE Barcode = N'" + barcode + @"'
                                ORDER BY StepNo DESC";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return tbl;
        }

        public DataTable GetProductMatrix(string partNumber, string stepNo, SqlConnection cn)
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = @"SELECT Steps.StepNo, ProductMatrices.DryingTime 
                                FROM Steps LEFT JOIN ProductMatrices ON Steps.StepNo = ProductMatrices.StepNo
                                WHERE ProductMatrices.PartNumber = N'" + partNumber + @"' AND Steps.StepNo = N'" + stepNo + @"'
                                ORDER BY Steps.StepNo";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return tbl;
        }

        public bool ScanIn(string barcode, string partNumber, string stepNo, float dryingTime, int resultStatus, int completedStatus, int status, string username, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = "INSERT INTO ScanBarcodes(Id, Barcode, PartNumber, StepNo, ScanIn, Limit, DryingTime, ResultStatus, CompletedStatus, Status, CreatedAt, CreatedBy) VALUES(N'" +
                    Guid.NewGuid().ToString() + "', N'" +
                    barcode + "', N'" +
                    partNumber + "', N'" +
                    stepNo + "', N'" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" +
                    DateTime.Now.AddMinutes(dryingTime).ToString("yyyy-MM-dd HH:mm:ss") + "', N'" +
                    0 + "', N'" +
                    resultStatus + "', N'" +
                    completedStatus + "', N'" +
                    status + "', N'" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" +
                    username + "');";
                SqlCommand command = new SqlCommand(query);
                command.Connection = cn;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }

        public bool ScanOut(string id, DateTime timeEnd, float dryingTime, int resultStatus, int completedStatus, string reason, string username, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = "UPDATE ScanBarcodes SET " +
                    "ScanOut = N'" + timeEnd.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    "DryingTime = N'" + dryingTime.ToString("N0") + "'," +
                    "ResultStatus = N'" + resultStatus + "'," +
                    "CompletedStatus = N'" + completedStatus + "'," +
                    "Reason = N'" + reason + "'," +
                    "EditedAt = N'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    "EditedBy = N'" + username + "'" +
                    " WHERE Id = N'" + id + "';";
                SqlCommand command = new SqlCommand(query);
                command.Connection = cn;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }
        #endregion
    }
}