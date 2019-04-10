using System;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Fitness.models
{
    public class EmailMsg
    {

        public async Task SesndEmail(string subject, string body, List<string> to)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = to

                };

                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbs)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
