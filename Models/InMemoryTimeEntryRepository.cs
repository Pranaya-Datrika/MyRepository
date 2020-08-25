using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeSheet.Models
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private readonly Dictionary<long, TimeEntry> _timeEntry = new Dictionary<long, TimeEntry>();
        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id = _timeEntry.Count + 1;
            timeEntry.Id = id;
            _timeEntry.Add(id, timeEntry);

            return timeEntry;
        }
        public bool Contains(long id)
        {
            return _timeEntry.ContainsKey(id);
        }

        public void Delete(long id)
        {
            _timeEntry.Remove(id);
        }

        public TimeEntry Find(long id)
        {
           return _timeEntry[id];
        }

        public IEnumerable<TimeEntry> GetTimeEntry()
        {
            return _timeEntry.Values.ToList();
        }

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            timeEntry.Id = id;
            _timeEntry[id] = timeEntry;
            return timeEntry;
        }
    }
}
