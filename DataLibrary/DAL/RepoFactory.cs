﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public static class RepoFactory
    {
        public static IRepo GetRepo() => new FileRepo();
        public static ISettingsRepo GetSettingsRepo() => new FileSettingsRepo();
        public static IImageRepo GetImageRepo() => new FileImageRepo();
    }
}
