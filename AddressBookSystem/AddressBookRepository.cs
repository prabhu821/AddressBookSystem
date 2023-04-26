using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookRepository
    {
        public static string connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=AddressBook; integrated security=true";
        SqlConnection sqlconnection = new SqlConnection(connectionString);
        public int GetPerson()
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<Contact> PersonList = new List<Contact>();
                    SqlCommand command = new SqlCommand("spGetPerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new Contact
                        {
                            FName = Convert.ToString(dr["FirstName"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Zip = Convert.ToString(dr["ZipCode"]),
                            PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                            Email = Convert.ToString(dr["Email"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int UpdatePresoninAddressBook(Contact model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand("spUpdatePerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", model.Id);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    int result = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Person Updated Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetPersonDate(Contact model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<Contact> PersonList = new List<Contact>();
                    SqlCommand command = new SqlCommand("spGetPersonDate", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DateAdded", model.DateAdded);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new Contact
                        {
                            FName = Convert.ToString(dr["FirstName"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            Zip = Convert.ToString(dr["ZipCode"]),
                            Email = Convert.ToString(dr["Email"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
