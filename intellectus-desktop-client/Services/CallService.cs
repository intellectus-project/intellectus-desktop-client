using intellectus_desktop_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_client.Services
{
    public static class CallService
    {
        public static bool CanStartCall()
        {
            var callAndBreak = Domain.CurrentUser.Call == null || Domain.CurrentUser.Call.BreakAssigned == false;
            if (!callAndBreak)
            {
                var endTime = Domain.CurrentUser.Call.EndTime;
                var minutes = Domain.CurrentUser.Call.MinutesDuration;
                var breakEndTime = endTime.AddMinutes(minutes);
                return DateTime.UtcNow > breakEndTime;
            }
            else
                return true;


        }
    }

}
