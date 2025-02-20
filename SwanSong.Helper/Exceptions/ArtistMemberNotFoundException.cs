using System;

namespace SwanSong.Helper.Exceptions;

public class ArtistMemberNotFoundException : Exception
{
    public ArtistMemberNotFoundException()
    {
    }

    public ArtistMemberNotFoundException(string message)
        : base(message)
    {
    }

    public ArtistMemberNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}