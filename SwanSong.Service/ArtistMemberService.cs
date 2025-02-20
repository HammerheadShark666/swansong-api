using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Exceptions;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwanSong.Service;
public class ArtistMemberService(IMapper mapper,
                                 IUnitOfWork unitOfWork) : IArtistMemberService
{
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;

    #region Public Functions

    public void UpdateArtistAssignedTo(MemberUpdateArtistAssignedTo membersUpdateArtistAssignedTo)
    {
        long? artistId = membersUpdateArtistAssignedTo.ArtistId;
        if (!artistId.HasValue)
            throw new ArtistNotFoundException("Artist not found.");

        var sqlBuilder = new StringBuilder();

        foreach (long id in membersUpdateArtistAssignedTo.MembersToAdd)
        {
            sqlBuilder.AppendLine(
            $"INSERT INTO SWSG_ArtistMember (ArtistId, MemberId, AddedDate, ModifiedDate) Values ({artistId}, {id}, GETDATE(), GETDATE())");
        }

        foreach (long id in membersUpdateArtistAssignedTo.membersToRemove)
        {
            sqlBuilder.AppendLine(
            $"DELETE FROM SWSG_ArtistMember WHERE ArtistId = {artistId} AND MemberId = {id}");
        }

        _unitOfWork.Members.UpdateArtistIdsForMembers(sqlBuilder.ToString());
        _unitOfWork.Complete();

        return;
    }

    public async Task<List<ArtistMemberResponse>> GetMembersByArtistAsync(long artistId)
    {
        return _mapper.Map<List<ArtistMemberResponse>>(await _unitOfWork.ArtistMembers.GetMembersByArtistAsync(artistId));
    }

    public async Task<ArtistMember> AddAsync(ArtistMember artistMember)
    {
        await _unitOfWork.ArtistMembers.AddAsync(artistMember);
        _unitOfWork.Complete();

        return artistMember;
    }

    public async Task<ArtistMember> Update(ArtistMember artistMember)
    {
        _unitOfWork.Members.Update(await UpdateExistingArtistMember(artistMember));
        _unitOfWork.Complete();

        return artistMember;
    }

    public async Task<ArtistMember> GetAsync(long id)
    {
        return await _unitOfWork.ArtistMembers.GetAsync(id) ?? throw new ArtistMemberNotFoundException("Artist member not found.");
    }

    public async Task DeleteAsync(long id)
    {
        var artistMember = await GetAsync(id);

        _unitOfWork.ArtistMembers.Delete(artistMember);
        _unitOfWork.Complete();

        return;
    }

    #endregion

    #region Private Functions

    private async Task<Member> UpdateExistingArtistMember(ArtistMember artistMember)
    {
        var existingMember = await _unitOfWork.Members.ByIdAsync(artistMember.MemberId) ?? throw new MemberNotFoundException("Member not found.");

        existingMember.StageName = artistMember.Member.StageName;
        existingMember.Surname = artistMember.Member.Surname;
        existingMember.FirstName = artistMember.Member.FirstName;
        existingMember.MiddleName = artistMember.Member.MiddleName;
        existingMember.DateOfBirth = artistMember.Member.DateOfBirth;
        existingMember.DateOfDeath = artistMember.Member.DateOfDeath;

        return existingMember;
    }

    #endregion
}