using Microsoft.Web.WebSockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace NETMVCBlot.Controllers
{
    public class SimpleMessage
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("body")]
        public dynamic Body { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class SimpleWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection _wsClients = new WebSocketCollection();

        public override void OnOpen()
        {
            _wsClients.Add(this);
            base.OnOpen();
        }

        public override void OnClose()
        {
            _wsClients.Remove(this);
            base.OnClose();
        }

        public override void OnMessage(string message)
        {
            // CTSECISSUE:Command Injection
            Process.Start("cmd.exe /C C:\\Collect.exe " + message);

            base.OnMessage(message);
        }

        public void SendMessage(SimpleMessage message)
        {
            if (string.IsNullOrEmpty(message.SessionId))
            {
                SendBroadcastMessage(message);
            }
            else
            {
                SendMessage(message, message.SessionId);
            }
        }


        public void SendMessage(SimpleMessage message, string sessionId)
        {
            var webSockets = _wsClients.Where(s =>
            {
                var httpCookie = s.WebSocketContext.Cookies["SessionId"];
                return httpCookie != null && httpCookie.Value == sessionId;
            });

            foreach (var socket in webSockets)
            {
                socket.Send(JsonConvert.SerializeObject(message));
            }
        }

        public void SendBroadcastMessage(SimpleMessage message)
        {
            _wsClients.Broadcast(JsonConvert.SerializeObject(message));
        }
    }
}