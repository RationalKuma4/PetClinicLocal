using SQLite.Net;

namespace PetClinicLocal.Contracts
{
    public interface ISqLite
    {
        SQLiteConnection GetConnection();
    }
}
