using RestuarantReservationSystem.Models;

namespace RestuarantReservationSystem.Repositories.Abstract
{
    public interface IReservationService
    {
        bool Add(Reservation model);

        bool Update (Reservation model);
        Object Delete(int id);
        Reservation FindById(int id);

        IEnumerable<Reservation> GetAll();
    }
 
}
