using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class ArtistMembers
{
    public static List<ArtistMember> GetArtistMembersDefaultData()
    {
        return new List<ArtistMember>()
        {
            new() { Id = 2, ArtistId = 1, MemberId = 1 },
            new() { Id = 3, ArtistId = 1, MemberId = 2 },
            new() { Id = 4, ArtistId = 1, MemberId = 3 },
            new() { Id = 5, ArtistId = 1, MemberId = 4 },
            new() { Id = 14, ArtistId = 15, MemberId = 47 },
            new() { Id = 15, ArtistId = 14, MemberId = 28 },
            new() { Id = 16, ArtistId = 14, MemberId = 29 },
            new() { Id = 17, ArtistId = 14, MemberId = 30 },
            new() { Id = 18, ArtistId = 14, MemberId = 31 },
            new() { Id = 19, ArtistId = 14, MemberId = 32 },
            new() { Id = 20, ArtistId = 3, MemberId = 6 },
            new() { Id = 21, ArtistId = 7, MemberId = 10 },
            new() { Id = 22, ArtistId = 12, MemberId = 24 },
            new() { Id = 23, ArtistId = 12, MemberId = 22 },
            new() { Id = 24, ArtistId = 12, MemberId = 23 },
            new() { Id = 25, ArtistId = 5, MemberId = 8 },
            new() { Id = 26, ArtistId = 16, MemberId = 34 },
            new() { Id = 27, ArtistId = 16, MemberId = 33 },
            new() { Id = 28, ArtistId = 16, MemberId = 36 },
            new() { Id = 29, ArtistId = 16, MemberId = 35 },
            new() { Id = 30, ArtistId = 16, MemberId = 37 },
            new() { Id = 31, ArtistId = 4, MemberId = 7 },
            new() { Id = 32, ArtistId = 6, MemberId = 9 },
            new() { Id = 33, ArtistId = 18, MemberId = 41 },
            new() { Id = 34, ArtistId = 8, MemberId = 11 },
            new() { Id = 35, ArtistId = 8, MemberId = 12 },
            new() { Id = 36, ArtistId = 8, MemberId = 13 },
            new() { Id = 37, ArtistId = 13, MemberId = 25 },
            new() { Id = 38, ArtistId = 13, MemberId = 26 },
            new() { Id = 39, ArtistId = 17, MemberId = 38 },
            new() { Id = 40, ArtistId = 17, MemberId = 40 },
            new() { Id = 41, ArtistId = 17, MemberId = 39 },
            new() { Id = 42, ArtistId = 9, MemberId = 14 },
            new() { Id = 43, ArtistId = 38, MemberId = 69 },
            new() { Id = 44, ArtistId = 38, MemberId = 67 },
            new() { Id = 45, ArtistId = 38, MemberId = 70 },
            new() { Id = 46, ArtistId = 38, MemberId = 68 },
            new() { Id = 47, ArtistId = 38, MemberId = 65 },
            new() { Id = 48, ArtistId = 2, MemberId = 5 },
            new() { Id = 49, ArtistId = 11, MemberId = 19 },
            new() { Id = 50, ArtistId = 11, MemberId = 20 },
            new() { Id = 51, ArtistId = 11, MemberId = 21 },
            new() { Id = 52, ArtistId = 10, MemberId = 18 },
            new() { Id = 53, ArtistId = 10, MemberId = 16 },
            new() { Id = 54, ArtistId = 10, MemberId = 17 },
            new() { Id = 55, ArtistId = 10, MemberId = 15 },
            new() { Id = 56, ArtistId = 19, MemberId = 42 },
            new() { Id = 57, ArtistId = 20, MemberId = 43 },
            new() { Id = 58, ArtistId = 20, MemberId = 44 },
            new() { Id = 59, ArtistId = 20, MemberId = 45 },
            new() { Id = 60, ArtistId = 20, MemberId = 46 }
        };
    }
}