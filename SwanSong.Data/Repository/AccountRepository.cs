﻿using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Data.Repository;

public class AccountRepository(SwanSongContext context) : IAccountRepository
{
    private readonly SwanSongContext _context = context;

    public async Task<Account> GetAsync(string email)
    {
        return await _context.Accounts
                                .Where(a => a.Email.Equals(email))
                                .FirstOrDefaultAsync();
    }

    public async Task<Account> GetByResetTokenAsync(string resetToken)
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .SingleOrDefaultAsync(u => u.ResetToken.Equals(resetToken));
    }

    public async Task<Account> GetByVerificationTokenAsync(string verificationToken)
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .SingleOrDefaultAsync(u => u.VerificationToken.Equals(verificationToken));
    }

    public async Task<Account> GetByRefreshTokenAsync(string token)
    {
        return await _context.Accounts
                                .Where(p => p.RefreshTokens.Any(c => c.Token.Equals(token)))
                                .AsNoTracking()
                                .FirstOrDefaultAsync();
    }

    public async Task<bool> AccountExistsAsync(string email)
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .AnyAsync(x => x.Email.Equals(email));
    }

    public async Task<bool> AccountExistsAsync(string email, int id)
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .AnyAsync(x => x.Email.Equals(email) && x.Id != id);
    }

    public async Task<bool> AnyAccountExistAsync()
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .AnyAsync();
    }

    public async Task<bool> ValidResetTokenAsync(string token)
    {
        return await _context.Accounts
                                .AsNoTracking()
                                .AnyAsync(x => x.ResetToken.Equals(token) && x.ResetTokenExpires > DateTime.Now);
    }

    public async Task<Account> ByIdAsync(int id)
    {
        return await _context.Accounts.FindAsync(id);
    }

    public void Add(Account account)
    {
        _context.Accounts.Add(account);
    }

    public void Update(Account account)
    {
        _context.Accounts.Update(account);
    }

    public void Delete(Account account)
    {
        _context.Accounts.Remove(account);
    }

    public async Task<bool> ValidResetTokenEmailCurrentPasswordAsync(string token, string email, string currentPassword)
    {
        Account account = await _context.Accounts
                                .Where(x => x.Email.Equals(email) && x.ResetToken.Equals(token) && x.ResetTokenExpires > DateTime.Now)
                                .AsNoTracking()
                                .FirstOrDefaultAsync();

        if (account == null)
            return false;

        return BC.Verify(currentPassword, account.PasswordHash);
    }
}