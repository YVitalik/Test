using TestTask.DTOs;

namespace TestTask.Interfaces
{
    public interface IRecordService
    {
        void AddNewRecord(CreateRecordDto newRecord);
    }
}
