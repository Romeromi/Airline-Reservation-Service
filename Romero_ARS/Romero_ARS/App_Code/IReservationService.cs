using System.ServiceModel;

[ServiceContract]
public interface IReservationService
{
    //reserves a seat
    [OperationContract]
    bool Reserve(string seatType, string classType);
}
// end interface IReservation