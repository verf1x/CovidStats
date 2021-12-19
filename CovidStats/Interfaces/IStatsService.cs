using System.Threading.Tasks;
using CovidStats.Models;

namespace CovidStats.Interfaces
{
    internal interface IStatsService
    {
        Task<SummaryModel> GetData();
    }
}
