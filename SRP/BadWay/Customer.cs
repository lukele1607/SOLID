using System.IO;
using SOLID.MockClass;

namespace SOLID.SRP.BadWay
{
    class Customer
    {
        /// <summary>
        /// This Add method does to much, it shouldn't know how to write to the log and how to add a customer.
        /// </summary>
        /// <param name="database"></param>
        void Add(Database database)
        {
            try
            {
                database.Add ();
            }
            catch (System.Exception ex)
            {

                File.WriteAllText (@"C:\SOLID.txt", ex.ToString ());
            }
        }
    }
}
