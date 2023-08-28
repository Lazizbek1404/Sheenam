//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use For Comfort and Peace 
//==================================================

using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly StorageBroker storageBroker;

        public GuestService(StorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Guest> AddGuestAsync(Guest guest) =>
            await this.storageBroker.InsertGuestSync(guest);
               
    }
}
