﻿using Microsoft.AspNetCore.Http;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IMemberService
{
    Task<List<Member>> SearchByNameAsync(string criteria);
    Task<List<Member>> SearchByLetterAsync(string letter);
    Task<long> CountAsync();
    Task<List<Member>> GetAllAsync(PaginationFilter filter);
    Task<List<Member>> GetRandomAsync(int numberOfMembers);
    Task<Member> GetAsync(long id);
    Task<string> UpdateMemberPhotoAsync(long id, IFormFile file);
    Task DeleteAsync(Member member);
    Task<Member> AddAsync(Member member);
    Task Update(Member member);
    void UpdateArtistAssignedTo(MemberUpdateArtistAssignedTo membersUpdateArtistAssignedTo);
    Task UpdateDescriptionAsync(long id, string description);
}