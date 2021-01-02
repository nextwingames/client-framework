﻿namespace Nextwin.Protocol
{
    public interface ISerializer
    {
        byte[] Serialize<T>(T data);

        T Deserialize<T>(byte[] bytes);
    }
}
