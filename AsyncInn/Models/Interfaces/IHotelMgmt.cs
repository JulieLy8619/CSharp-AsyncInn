﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelMgmt
    {
        Task CreateHotel(Hotel hotel);
        Task<Hotel> GetHotel(int id);
        Task<IEnumerable<Hotel>> GetHotel();
        void UpdateHotel(Hotel hotel);
        Task<Hotel> DeleteHotel(int id);
    }
}