using SOLID.MockClass;

namespace SOLID.OCP.GoodWay
{
    class AnotherCustomer : CustomerBase
    {
        protected sealed override void Add (Database db)
        {
            db.AnotherExtension ();
        }
    }
}
