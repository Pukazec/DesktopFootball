﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public interface IImageRepo
    {
        void SaveImage(string name, string file);
        string LoadImage(string name);
    }
}
