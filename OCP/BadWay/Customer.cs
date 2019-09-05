using SOLID.MockClass;

namespace SOLID.OCP.BadWay
{
    class Customer
    {
        int Type;

        /// <summary>
        /// Violating the Open Closed Principle This is bad, because at the moment, there are 2 types of customer,
        /// if we want to add another customer type we have to add a if else below. So Modifying the existing code
        /// </summary>
        /// <param name="db"></param>
        void Add (Database db)
        {
            if (Type == 0)
            {
                db.Add ();
            }
            else
            {
                db.AddExistingCustomer ();
            }
        }
    }
}
