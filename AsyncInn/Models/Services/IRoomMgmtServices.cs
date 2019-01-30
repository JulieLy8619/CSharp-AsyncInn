﻿using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class IRoomMgmtServices : IRoomMgmt
    {
        private HotelMgmtDBContext _context { get; }
        public IRoomMgmtServices(HotelMgmtDBContext context)
        {
            _context = context;
        }
        public async Task CreateRoom(Room room)
        {
            _context.RoomTable.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> DeleteRoom(int id)
        {
            Room room = _context.RoomTable.FirstOrDefault(rm => rm.ID == id);
            _context.RoomTable.Remove(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.RoomTable.FirstOrDefaultAsync(rm => rm.ID == id);
        }

        public async Task<IEnumerable<Room>> GetRoom()
        {
            return await _context.RoomTable.ToListAsync();
        }

        public void UpdateRoom(Room room)
        {
            _context.RoomTable.Update(room);
        }
    }
}