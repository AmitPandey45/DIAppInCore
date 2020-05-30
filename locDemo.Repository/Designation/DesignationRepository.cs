using CommonUtil.DataAccess;
using Microsoft.Extensions.Configuration;
//using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;

namespace locDemo.Repository.Designation
{
    public class DesignationRepository : IDesignationRepository
    {
        private const string connectionString = "User ID=ASTMADMIN;Password=astm30;Data Source=MCS_11T2";
        //private readonly Database db = DatabaseFactory.CreateDatabase(connectionString);

        //IConfiguration configuration { get; }

        public DesignationRepository()
        {
            //DatabaseProviderFactory _Factory = new DatabaseProviderFactory();
            //string dbConnection = @"data source=.\MSSQLSERVER16;initial catalog=TestDB;user id=sa;password=abc@123;";
            //Database _DB = _Factory.Create(dbConnection);

            //// First way  
            //string value1 = configuration.GetSection("AllowedHosts").Value;
            //// Second way  
            //string value2 = configuration.GetValue<string>("Logging:LogLevel:Default");

        }

        public DesignationEntity GetDesignation(string name)
        {
            var dsDesignation = OracleHelper.ExecuteDataset(connectionString, CommandType.Text,
                                    QueryToGetDesignation);
            //dsDesignation = db.ExecuteDataSet(CommandType.Text, QueryToGetDesignation);
            DataTable dtDesignation = dsDesignation.Tables[0];
            DataRow designationDetails = dtDesignation.AsEnumerable()
                           .Where(s => s.Field<string>("designation") == name)
                           .FirstOrDefault();
            DesignationEntity designation = new DesignationEntity();
            designation.Designation = Convert.ToString(designationDetails["designation"]);
            designation.IsConsulted = string.IsNullOrEmpty(Convert.ToString(designationDetails["consulted"])) ? false : true;
            designation.IsReferencedInRegulation = string.IsNullOrEmpty(Convert.ToString(designationDetails["referenced"])) ? false : true;
            designation.IsNormativeReference = string.IsNullOrEmpty(Convert.ToString(designationDetails["normative_ref"])) ? false : true;
            designation.IsUsedAsBasisForNationalStandard = string.IsNullOrEmpty(Convert.ToString(designationDetails["used"])) ? false : true;
            designation.IsAdoption = string.IsNullOrEmpty(Convert.ToString(designationDetails["adoption"])) ? false : true;
            designation.QuantitySold = string.IsNullOrEmpty(Convert.ToString(designationDetails["sold"])) ? 0 : Convert.ToInt32(designationDetails["sold"]);

            return designation;
        }

        public IEnumerable<DesignationEntity> GetDesignations()
        {
            var dsDesignation = OracleHelper.ExecuteDataset(connectionString, CommandType.Text,
                                   QueryToGetDesignation);

            DataTable dtDesignation = dsDesignation.Tables[0];

            IList<DesignationEntity> designations = new List<DesignationEntity>();
            DesignationEntity designation;

            foreach (DataRow row in dtDesignation.Rows)
            {
                designation = new DesignationEntity();
                designation.Designation = Convert.ToString(row["designation"]);
                designation.IsConsulted = string.IsNullOrEmpty(Convert.ToString(row["consulted"])) ? false : true;
                designation.IsReferencedInRegulation = string.IsNullOrEmpty(Convert.ToString(row["referenced"])) ? false : true;
                designation.IsNormativeReference = string.IsNullOrEmpty(Convert.ToString(row["normative_ref"])) ? false : true;
                designation.IsUsedAsBasisForNationalStandard = string.IsNullOrEmpty(Convert.ToString(row["used"])) ? false : true;
                designation.IsAdoption = string.IsNullOrEmpty(Convert.ToString(row["adoption"])) ? false : true;
                designation.QuantitySold = string.IsNullOrEmpty(Convert.ToString(row["sold"])) ? 0 : Convert.ToInt32(row["sold"]);

                designations.Add(designation);
            }

            return designations;
        }

        private DataRow GetData(string query, OracleParameter[] parameters = null)
        {
            DataTable dtData = OracleHelper.ExecuteDataset(connectionString, CommandType.Text, query, parameters).Tables[0];
            DataRow rowDetails = GetRandomData(dtData);
            return rowDetails;
        }

        public static DataRow GetRandomData(DataTable dtData)
        {
            int rowNumber = 0;
            int? rowsCount = dtData?.Rows.Count;
            if (rowsCount > 1)
            {
                Random random = new Random();
                rowNumber = random.Next(1, Convert.ToInt32(rowsCount));
                return dtData.Rows[rowNumber];
            }
            else if (rowsCount == 1)
                return dtData.Rows[rowNumber];
            return null;
        }

        private string QueryToGetDesignation => @"SELECT
                                designation,
                                adoption,
                                consulted,
                                normative_ref,
                                referenced,
                                used,
                                sold
                            FROM
                                nsb_designation_saved";
    }
}
