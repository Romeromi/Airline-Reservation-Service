using System;
using System.Linq;

public class ReservationService : IReservationService
{
    private TicketsDataContext ticketsDB = new TicketsDataContext();

    public bool Reserve(string seatType, string classType)
    {
        var result = from seat in ticketsDB.Seats
                     where (seat.Taken == false) && (seat.Type == seatType) && (seat.Class == classType)
                     select seat;

        Seat firstAvailableSeat = result.FirstOrDefault();

        if ( firstAvailableSeat != null )
        {
            firstAvailableSeat.Taken = true;
            ticketsDB.SubmitChanges();
            return true;
        }
        return false;
    }
}