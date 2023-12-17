using RestuarantReservationSystem.Models;
using RestuarantReservationSystem.Repositories.Abstract;

namespace RestuarantReservationSystem.Repositories.Implementation
{
    public class ReservationService : IReservationService
    {
        private readonly DatabaseContext context;
        private int id;

        public ReservationService(DatabaseContext context)
        {
            this.context = context;            
        }
        public bool Add(Reservation model)
        {
            try
            {
                context.Reservation.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Reservation FindById(int id)
        {
            return context.Reservation.Find(id);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return context.Reservation.ToList();
        }

        public bool Update(Reservation model)
        {
            try
            {
                context.Reservation.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;

                context.Reservation.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
