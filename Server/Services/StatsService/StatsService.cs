﻿using System;
using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services
{
	public class StatsService : IStatsService
	{
        private readonly DataContext _context;

		public StatsService(DataContext context)
		{
            _context = context;
		}

        public async Task<int> GetVisits()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync()
;
            if(stats == null)
            {
                return 0;
            }
            return stats.Visits;
        }

        public async Task IncrementVisits()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync();

            if (stats == null)
            {
                _context.Stats.Add(new Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                    stats.LastVisit = DateTime.Now;
            }
            await _context.SaveChangesAsync();
        }
    }
}

