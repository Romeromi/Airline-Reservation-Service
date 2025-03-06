using System;
using System.Linq;

public partial class ReservationClient : System.Web.UI.Page
{
    private TicketsDataContext db = new TicketsDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Any initialization code if needed
        }
    }

    protected void reserveButton_Click(object sender, EventArgs e)
    {
        string selectedType = seatList.SelectedValue;
        string selectedClass = classList.SelectedValue;

        var availableSeat = db.Seats.FirstOrDefault(s => s.Type == selectedType && s.Class == selectedClass && s.Taken == false);

        if (availableSeat != null)
        {
            availableSeat.Taken = true;
            db.SubmitChanges();
            errorlabel.Text = "Seat reserved successfully!";
        }
        else
        {
            errorlabel.Text = "No available seats of the selected type and class.";
        }
    }
}
