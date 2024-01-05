using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Utils.AudioPlayerManager.Obj
{
    public class AudioDevice
    {
        public required string Guid { get; set; }

        public required string Name { get; set; }
    }
}
