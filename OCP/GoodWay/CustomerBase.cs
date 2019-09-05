using SOLID.MockClass;

namespace SOLID.OCP.GoodWay
{
    class CustomerBase
    {
        protected virtual void Add (Database db)
        {
            db.Add ();
        }
    }
}
