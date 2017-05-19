using SQLite.Net;

namespace PetClinicLocal.Contracts
{
    public interface IData
    {
        SQLiteConnection GetConnection();
    }
}