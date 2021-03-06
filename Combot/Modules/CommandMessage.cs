﻿using System;
using System.Collections.Generic;
using Combot.IRCServices;

namespace Combot.Modules
{
    public class CommandMessage
    {
        public string Location { get; set; }
        public MessageType MessageType { get; set; }
        public Nick Nick { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Command { get; set; }
        public Dictionary<string, dynamic> Arguments { get; set; }
        public List<AccessType> Access { get; set; }

        public CommandMessage()
        {
            Location = string.Empty;
            MessageType = MessageType.Channel;
            Nick = new Nick();
            TimeStamp = DateTime.Now;
            Command = string.Empty;
            Arguments = new Dictionary<string, dynamic>();
            Access = new List<AccessType>();
        }
    }
}