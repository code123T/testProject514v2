using System;
using System.Globalization;

namespace HumanResourcesManagmentSystem.Services
{
    public static class TimeResultService
    {
        public static string TimeResult()
        {
            DateTime dateTime = new DateTime();
            CultureInfo cultureInfo = new CultureInfo("az-AZ");
            dateTime = DateTime.Now;
            var timeResult=dateTime.ToString("dddd, dd MMMM yyyy HH:mm",cultureInfo);
            return timeResult.ToUpper();
        }
    }
}
