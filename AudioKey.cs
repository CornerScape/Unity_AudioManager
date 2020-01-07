﻿using System.Collections.Generic;

namespace Szn.Framework.Audio
{
    public enum AudioKey
    {
        A,
        B,
        C,
        D,
        Max    
    }
    
    public class AudioKeyEqualityComparer : IEqualityComparer<AudioKey>
    {

        public bool Equals(AudioKey InX, AudioKey InY)
        {
            return (int) InX == (int) InY;
        }

        public int GetHashCode(AudioKey InAudioKey)
        {
            return (int) InAudioKey;
        }
    }
}

