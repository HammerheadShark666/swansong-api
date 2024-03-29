﻿using System;

namespace SwanSong.Helper.Exceptions;

public class SongNotFoundException : Exception
{
    public SongNotFoundException()
    {
    }

    public SongNotFoundException(string message)
        : base(message)
    {
    }

    public SongNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}