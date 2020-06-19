namespace HotelReservations.Web.Models
{
	public class Both
	{
		public Hotel Hotel { get; set; }

		public Reservation Reservation { get; set; }

		public Both(int size, int days)
		{
			Hotel = new Hotel(size, days)
			{
				Size = size,
				Days = days
			};
			Reservation = new Reservation();
		}
	}
}