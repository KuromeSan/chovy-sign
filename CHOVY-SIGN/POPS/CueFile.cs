﻿using System.Collections.Generic;

namespace Popstation
{
    public class CueFile
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public List<CueTrack> Tracks { get; set; }
    }
}
