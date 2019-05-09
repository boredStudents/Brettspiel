using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;

namespace BrettspielClient
{
    public static class MessageManager
    {
        
        public static string MakeTotalMessage(params string[] messages)
        {
            return messages.Aggregate("[", (a, b) => a + b + ",").TrimEnd(',') + "]";
        }

        public static string LoginMessage(Player p)
        {
            string output = JsonConvert.SerializeObject(new { messageType = "doLogin", messageContent = new { name = p.Name,bDay = p.BirthDay.ToShortDateString()} });
            return output;
        }

        public static string GetPlayersMessage(LocalPlayer p)
        {
            return JsonConvert.SerializeObject(new { messageType = "getPlayers", messageContent = new { guid = p.Guid } });
        }

        public static string GetBoardMessage(LocalPlayer p)
        {
            return JsonConvert.SerializeObject(new { messageType = "getBoard", messageContent = new { guid = p.Guid } });
        }

        public static string DoRollMessage(LocalPlayer p)
        {
            return JsonConvert.SerializeObject(new { messageType = "doRoll", messageContent = new { guid = p.Guid } });
        }

        public static List<string> ExtractDistinctMessages(string messages)
        {
            return messages.Trim('[', ']').Split(',').ToList();
        }

        public static MessageType GetMessageTypeFromMessage(string message)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string,object>>(message);

            MessageType g = (MessageType)Enum.Parse(typeof(MessageType), data["messageType"].ToString());

            return g;
        }







    }
}
