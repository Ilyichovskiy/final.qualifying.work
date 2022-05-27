namespace ContactCenter.Service;

public interface IStatisticsService
{
    public void GetStatisticsByDay(string day);
    
    public void GetStatisticsByPeriod(string day);
    
    public void GetAllStatistics(string day);
}