using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;
using MyCompany.Models;

namespace MyCompany.Rules
{
    public partial class TasksBusinessRules : MyCompany.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view before an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(TasksModel instance)
        {
            if (!String.IsNullOrEmpty(instance.ScheduleDaysOfWeek) && instance.ScheduleWeeks.HasValue && instance.ScheduleWeeks > 0)
            {
                PreventDefault();
                Schedules schedules = new Schedules
                {
                    DaysOfWeek = instance.ScheduleDaysOfWeek,
                    Weeks = instance.ScheduleWeeks.Value,
                };
                schedules.Insert();
                CreateScheduledMeetings(schedules, instance);
            }
        }

        private void CreateScheduledMeetings(Schedules schedules, TasksModel instance)
        {
            string[] daysOfWeek = schedules.DaysOfWeek.Split(',');
            DateTime startOfWeek = instance.StartDate.Value;
            startOfWeek = startOfWeek.AddDays(-(int)startOfWeek.DayOfWeek);
            TimeSpan duration = instance.EndDate.Value - instance.StartDate.Value;

            for (int i = 0; i < schedules.Weeks.Value; i++)
            {
                foreach (string dayOfWeek in daysOfWeek)
                {
                    DayOfWeek dow = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayOfWeek);
                    DateTime date = startOfWeek.AddDays((int)dow);

                    if (date >= instance.StartDate)
                    {
                        Tasks t = new Tasks
                        {
                            Description = instance.Description,
                            Status = instance.Status
                        };
                        t.Insert();
                    }
                }
            }
        }
    }
}
