﻿namespace BandCommunity.Domain.DTO.Auth;

public class ResetPasswordRequest
{
    public string Token { get; set; }
    public string NewPassword { get; set; }
    public string ConfirmPassword { get; set; }
}