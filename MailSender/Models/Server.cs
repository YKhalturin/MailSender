﻿using System;

namespace WpfTestMailSender.Models
{
    public class Server
    {
        public string Address { get; set; }

        private int _port = 25;
        public int Port
        {
            get => _port;
            set
            {
                if(value < 0 || value>= 65535)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Номер порта должен быть в диапазоне от 0 до 65534");
            }
        }
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}