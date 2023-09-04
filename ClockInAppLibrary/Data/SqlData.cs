﻿using ClockInAppLibrary.Database;
using ClockInAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInAppLibrary.Data
{
    public class SqlData
    {
        private readonly ISqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public List<EmployeeModel> GetEmployees()
        {
            return _db.LoadData<EmployeeModel, dynamic>("dbo.spEmployees_GetAll",
                                                new { },
                                                connectionStringName,
                                                true);
        }

        //// Create a new booking
        //public void BookGuest(string firstName,
        //                      string lastName,
        //                      DateTime startDate,
        //                      DateTime endDate,
        //                      int roomTypeId)
        //{

        //    GuestModel guest = _db.LoadData<GuestModel, dynamic>("dbo.spGuests_Insert",
        //        new { firstName, lastName },
        //        connectionStringName,
        //        true).First();

        //    // Getting the total cost
        //    RoomTypeModel roomType = _db.LoadData<RoomTypeModel, dynamic>("select * from dbo.RoomTypes where Id = @Id",
        //        new { Id = roomTypeId },
        //        connectionStringName,
        //        false).First();

        //    TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date);


        //    List<RoomModel> availableRooms = _db.LoadData<RoomModel, dynamic>("dbo.spRooms_GetAvailableRooms",
        //        new { startDate, endDate, roomTypeId },
        //                    connectionStringName,
        //                    true);

        //    _db.SaveData("dbo.spBookings_Insert",
        //        new
        //        {
        //            roomId = availableRooms.First().Id,
        //            guestId = guest.Id,
        //            startDate,
        //            endDate,
        //            totalCost = (timeStaying.Days * roomType.Price)
        //        },
        //        connectionStringName,
        //        true);
        //}

        //public List<BookingFullModel> SearchBookings(string lastName)
        //{
        //    return _db.LoadData<BookingFullModel, dynamic>("dbo.spBookings_Search",
        //        new { lastName, startDate = DateTime.Now.Date },
        //        connectionStringName,
        //        true);
        //}

        //public void CheckInGuest(int bookingId)
        //{
        //    _db.SaveData("dbo.spBookings_CheckIn",
        //        new { Id = bookingId },
        //        connectionStringName,
        //        true);
        //}

        //public RoomTypeModel GetRoomTypeById(int id)
        //{
        //    return _db.LoadData<RoomTypeModel, dynamic>("dbo.spRoomTypes_GetById",
        //        new { id },
        //        connectionStringName,
        //        true).FirstOrDefault();
        //}
    }
}
