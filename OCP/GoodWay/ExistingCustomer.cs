using SOLID.MockClass;

namespace SOLID.OCP.GoodWay
{
    class ExistingCustomer : CustomerBase
    {
        protected sealed override void Add (Database db)
        {
            db.AddExistingCustomer ();
        }
    }
}
