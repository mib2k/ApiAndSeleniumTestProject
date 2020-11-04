using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models.Requests
{
   public class AuthenticationKeyRequest
    {
        private string paymentMethod;
        private string channel;
        private string channelType;


        public string PaymentMethod { get => this.paymentMethod; set => this.paymentMethod = value; }

        public string Channel { get => this.channel; set => this.channel = value; }

        public string ChannelType { get => this.channelType; set => this.channelType = value; }
    }
}
