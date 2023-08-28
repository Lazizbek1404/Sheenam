//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use For Comfort and Peace 
//==================================================

using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public interface IGuestService
    {
        ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
