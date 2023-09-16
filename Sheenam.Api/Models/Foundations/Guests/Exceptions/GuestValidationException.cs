//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use For Comfort and Peace 
//==================================================

using Azure.Messaging;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class GuestValidationException: Xeption
    {
        public GuestValidationException(Xeption innerException)
            :base(message: "Guest Validation error occured, fix the errors and try again",
                 innerException) 
        { }     
        
    }
}
