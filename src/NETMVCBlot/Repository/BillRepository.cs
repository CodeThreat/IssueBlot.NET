using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NETMVCBlot.Repository
{
    public class BillRepository
    {
        public Bill GetBill(int id)
        {
            // CTSECISSUE: UnsafeDatabaseResourceRelease
            SqlConnection conn = new SqlConnection("");
            // CTSECISSUE: UnsafeDatabaseResourceRelease
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = conn;

            sqlComm.CommandText = "SELECT * FROM bills WHERE ( id = @id)";
            sqlComm.Parameters.Add("@id", SqlDbType.Int);
            // CTSECISSUE: InsecureDirectObjectReference
            sqlComm.Parameters["@id"].Value = id;

            conn.Open();
            SqlDataReader DR = sqlComm.ExecuteReader();

            // read the data and return
            return null;
        }

        public string GetBillDescription(int id)
        {
            // CTSECISSUE: UnsafeDatabaseResourceRelease
            SqlConnection conn = new SqlConnection("");
            // CTSECISSUE: UnsafeDatabaseResourceRelease
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = conn;

            sqlComm.CommandText = "SELECT description FROM bills WHERE ( id = @id)";
            sqlComm.Parameters.Add("@id", SqlDbType.Int);
            // CTSECISSUE: InsecureDirectObjectReference
            sqlComm.Parameters["@id"].Value = id;

            conn.Open();
            SqlDataReader DR = sqlComm.ExecuteReader();
            // read the data and return
            return DR.GetString(1);
        }

        public Bill GetBillEF(int billid)
        {
            using (var context = new BillContext())
            {
                // CTSECISSUE: InsecureDirectObjectReference
                return context.Bills.Where(b => b.Id == billid).FirstOrDefault();
            }
        }

        public void AddBillEF(Bill bill)
        {
            using (var context = new BillContext())
            {
                // CTSECISSUE: MassAssignment
                context.Bills.Add(bill);
            }
        }

    }

    public class BillContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
    }

    public class Bill
    {
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string Description { get; set; }
    }

}