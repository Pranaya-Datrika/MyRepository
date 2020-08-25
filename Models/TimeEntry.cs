using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.Models
{
    public class TimeEntry
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        
        public TimeEntry()
        {

        }
        public TimeEntry(long id,long projId,long userId,DateTime date,int hours)
        {
            this.Id = id;
            this.ProjectId = projId;
            this.UserId = userId;
            this.Date = date;
            this.Hours = hours;
        }
        public TimeEntry(long projId, long userId, DateTime date, int hours)
        {
            this.ProjectId = projId;
            this.UserId = userId;
            this.Date = date;
            this.Hours = hours;
        }
    }
}
