﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPlayer
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public int DogumTarihi { get; set; }
    }
}
