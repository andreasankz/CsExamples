using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract_2.Models
{
    class TempSensor : Device
    {

        public override string CreateFromConnectionString(string connectionstring)
        {
            var respons = base.CreateFromConnectionString(connectionstring);
            respons += " - Device Connected";
            return respons; 
        }




        public override string ReceiveMessage()
        {
            // JSON = {"command": "get"}
            var message = JsonConvert.DeserializeObject<dynamic>("{ \"command\": \"get\" }");
            return message.command;
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload}");
        }
    }
}
