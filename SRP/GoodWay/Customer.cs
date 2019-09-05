using System;
using SOLID.MockClass;

namespace SOLID.SRP.GoodWay
{
    class Customer
    {
        private FileLogger m_fileLogger = new FileLogger ();

        /// <summary>
        /// This doesn't violate the single responsibility principle by abstracting the logger for the actual writing.
        /// </summary>
        /// <param name="database"></param>
        void Add (Database database)
        {
            try
            {
                database.Add ();
            }
            catch (Exception ex)
            {

                m_fileLogger.Handle (ex.ToString ());
            }
        }
    }
}
