using HotelReservations.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Test
{
	public class Tests
	{
		[Test]
		public void Test1a()
		{
			HotelLogic hotel = new HotelLogic(1, 365);

			var result = hotel.addReservation(-4, 2);

			if (!result)
				Assert.Pass("Reservation declined");
			else
				Assert.Fail("Reservation accepted");
		}

		[Test]
		public void Test1b()
		{
			HotelLogic hotel = new HotelLogic(1, 365);

			var result = hotel.addReservation(200, 400);

			if (!result)
				Assert.Pass("Reservation declined");
			else
				Assert.Fail("Reservation accepted");
		}

		[Test]
		public void Test2()
		{
			HotelLogic hotel = new HotelLogic(3, 15);

			bool result = true;

			var dates = new List<Tuple<int, int>>(6);

			dates.Add(new Tuple<int, int>(0, 5));
			dates.Add(new Tuple<int, int>(7, 13));
			dates.Add(new Tuple<int, int>(3, 9));
			dates.Add(new Tuple<int, int>(5, 7));
			dates.Add(new Tuple<int, int>(6, 6));
			dates.Add(new Tuple<int, int>(0, 4));

			for (int i = 0; i < dates.Count; i++)
			{
				result = hotel.addReservation(dates[i].Item1, dates[i].Item2);

				if (!result)
					break;
			}

			if (result)
				Assert.Pass("All reservation accepted");
			else
				Assert.Fail("Not all reservations accepted");
		}

		[Test]
		public void Test3()
		{
			HotelLogic hotel = new HotelLogic(3, 365);

			bool result = true;

			var dates = new List<Tuple<int, int>>(6);

			dates.Add(new Tuple<int, int>(1, 3));
			dates.Add(new Tuple<int, int>(2, 5));
			dates.Add(new Tuple<int, int>(1, 9));
			dates.Add(new Tuple<int, int>(0, 15));

			for (int i = 0; i < dates.Count; i++)
			{
				result = hotel.addReservation(dates[i].Item1, dates[i].Item2);

				if (!result)
					break;
			}

			if (result)
				Assert.Fail("All reservation accepted");
			else
				Assert.Pass("Not all reservations accepted");
		}

		[Test]
		public void Test4()
		{
			HotelLogic hotel = new HotelLogic(3, 365);

			bool result = true;

			var dates = new List<Tuple<int, int>>(6);

			dates.Add(new Tuple<int, int>(1, 3));
			dates.Add(new Tuple<int, int>(0, 15));
			dates.Add(new Tuple<int, int>(1, 9));
			dates.Add(new Tuple<int, int>(2, 5));
			dates.Add(new Tuple<int, int>(4, 9));

			for (int i = 0; i < dates.Count; i++)
			{
				result = hotel.addReservation(dates[i].Item1, dates[i].Item2);
			}

			if (!result)
				Assert.Fail("All reservation accepted");
			else
				Assert.Pass("Not all reservations accepted");
		}

		[Test]
		public void Test5()
		{
			HotelLogic hotel = new HotelLogic(2, 16);

			bool result = true;

			var dates = new List<Tuple<int, int>>(6);

			dates.Add(new Tuple<int, int>(1, 3));
			dates.Add(new Tuple<int, int>(0, 4));
			dates.Add(new Tuple<int, int>(2, 3));
			dates.Add(new Tuple<int, int>(5, 5));
			dates.Add(new Tuple<int, int>(4, 10));
			dates.Add(new Tuple<int, int>(10, 10));
			dates.Add(new Tuple<int, int>(6, 7));
			dates.Add(new Tuple<int, int>(8, 10));
			dates.Add(new Tuple<int, int>(8, 9));

			for (int i = 0; i < dates.Count; i++)
			{
				result = hotel.addReservation(dates[i].Item1, dates[i].Item2);
			}

			if (!result)
				Assert.Fail("All reservation accepted");
			else
				Assert.Pass("Not all reservations accepted");
		}
	}
}