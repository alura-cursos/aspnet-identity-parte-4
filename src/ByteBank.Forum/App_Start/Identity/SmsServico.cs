using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ByteBank.Forum.App_Start.Identity
{
    public class SmsServico : IIdentityMessageService
    {
        private readonly string TWILIO_SID =
            ConfigurationManager.AppSettings["twilio:SID"];

        private readonly string TWILIO_AUTH_TOKEN =
                    ConfigurationManager.AppSettings["twilio:auth_token"];

        private readonly string TWILIO_FROM_NUMBER =
                    ConfigurationManager.AppSettings["twilio:from_number"];

        public async Task SendAsync(IdentityMessage message)
        {
            TwilioClient.Init(TWILIO_SID, TWILIO_AUTH_TOKEN);

            await MessageResource.CreateAsync(
                    new PhoneNumber(message.Destination),
                    from: TWILIO_FROM_NUMBER,
                    body: message.Body
                );
        }
    }
}