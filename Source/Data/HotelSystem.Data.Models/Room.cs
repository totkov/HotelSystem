﻿namespace HotelSystem.Data.Models
{
    using System.Collections.Generic;


    public class Room
    {
        private ICollection<Reservation> reservations;

        public Room()
        {
            this.reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        public int Price { get; set; }

        public int NumberOfPeople { get; set; }

        public string Description { get; set; }

        Hotel Hotel { get; set; }
        public int HotelId { get; set; }

        RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }

        public virtual ICollection<Reservation> Reservations
        {
            get { return this.reservations; }
            set { this.reservations = value; }
        }
    }
}
