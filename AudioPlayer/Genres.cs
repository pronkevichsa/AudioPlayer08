﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    [Flags]
    public enum Genres
    {
        None = 0,       //0000
        Pop = 1,        //0001
        Rock = 2,       //0010
        Metal = 4,      //0100
        Alternative = 8 //1000
    }
}
