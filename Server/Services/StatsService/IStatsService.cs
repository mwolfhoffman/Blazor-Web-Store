using System;
namespace BlazingShop.Server.Services
{
	public interface IStatsService
	{
		Task<int> GetVisits();
		Task IncrementVisits();
	}
}

