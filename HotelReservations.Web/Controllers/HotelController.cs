using HotelReservations.Logic;
using HotelReservations.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace HotelReservations.Web.Controllers
{
	public class HotelController : Controller
	{
		public Hotel hotel = new Hotel(5, 15);
		private HotelLogic hotelLogic;

		public HotelController(HotelLogic hotelLogic)
		{
			this.hotelLogic = hotelLogic;
		}

		public IActionResult Hotel()
		{
			return PartialView(hotel);
		}

		public IActionResult Reset()
		{
			hotelLogic = new HotelLogic();

			Both both = new Both(5, 15);
			hotel.Bookings = hotelLogic.bookings;
			hotel.Size = hotelLogic.size;
			hotel.Days = hotelLogic.days;

			both.Reservation = new Reservation();
			both.Hotel = hotel;

			return View("~/Views/Home/Index.cshtml", both);
		}

		public IActionResult Form(Reservation reservation)
		{
			Both both = new Both(5, 15);

			reservation.Accepted = hotelLogic.addReservation(reservation.StartDate, reservation.EndDate);

			hotel.Bookings = hotelLogic.bookings;
			hotel.Size = hotelLogic.size;
			hotel.Days = hotelLogic.days;

			both.Reservation = reservation;
			both.Hotel = hotel;

			return View("~/Views/Home/Index.cshtml", both);
		}
	}
}