﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramTestBot.BL
{
    public static class BaseOfUsers
    {
        public static Dictionary<long, UserModel> DataBase { get; set; } = new Dictionary<long, UserModel>();
        public static Dictionary<long, UserModel> IdBase { get; set; } = new Dictionary<long, UserModel>();
        public static Dictionary<long, string> NameBase { get; set; } = new Dictionary<long, string>();
        public static Dictionary<long, bool> RegBase { get; set; } = new Dictionary<long, bool>();
    }
}