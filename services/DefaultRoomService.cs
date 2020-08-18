using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetCoreRESTfulAPI.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace dotNetCoreRESTfulAPI.Services
{
    public class DefaultRoomService : IRoomService
    {
        private readonly HotelApiDbContext _context;
        private readonly IMapper _mapper;
        public DefaultRoomService(HotelApiDbContext context,
                                  IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Room> GetRoomAsync(Guid id)
        {
            var entity = await _context.Rooms
                .SingleOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return null;
            }

            return _mapper.Map<Room>(entity);
        }
    }
}
