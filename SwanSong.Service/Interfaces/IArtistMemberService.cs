using SwanSong.Domain;
using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IArtistMemberService
{
    void UpdateArtistAssignedTo(MemberUpdateArtistAssignedTo membersUpdateArtistAssignedTo);
    Task<List<ArtistMemberResponse>> GetMembersByArtistAsync(long artistId);
    Task<ArtistMember> AddAsync(ArtistMember artistMember);
    Task<ArtistMember> Update(ArtistMember artistMember);
    Task DeleteAsync(long id);
}