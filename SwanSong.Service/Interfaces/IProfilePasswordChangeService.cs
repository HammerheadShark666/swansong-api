﻿using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IProfilePasswordChangeService
{
    Task UpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest);
}