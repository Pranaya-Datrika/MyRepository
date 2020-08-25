
using System.Collections;
using System.Collections.Generic;

namespace TimeSheet.Models
{
    public interface ITimeEntryRepository 
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Find(long id);
        bool Contains(long id);
        IEnumerable<TimeEntry> GetTimeEntry();
        TimeEntry Update(long id, TimeEntry timeEntry);
        void Delete(long id);
    }
}
