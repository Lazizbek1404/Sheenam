//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use For Comfort and Peace 
//==================================================

using FluentAssertions;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            //given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest = returningGuest;

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest))
                    .ReturnsAsync(returningGuest);

            //when
            Guest actualGuest =
                await this.guestService.AddGuestAsync(inputGuest);

            //then
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest),
                    Times.Once());

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
