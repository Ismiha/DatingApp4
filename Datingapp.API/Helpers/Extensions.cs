using System;
using Microsoft.AspNetCore.Http;

namespace Datingapp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
                response.Headers.Add("Application-Error", message);
                response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
                response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime thisDateTime)
        {
            var age = DateTime.Now.Year - thisDateTime.Year;

            if (thisDateTime.AddYears(age) > DateTime.Now)
                age--;

            return age;
        }
    }
}