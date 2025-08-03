namespace BoltCargo.WebUI.Dtos
{
    public class ResetPasswordDto
    {
        public string? Email { get; set; }
        public string? NewPassword { get; set; }
        public string? ConfirmNewPassword { get; set; }
        public string? Token { get; set; }
        public string? Username { get; set; }
        // Additional properties can be added as needed
        // For example, you might want to include a UserId if necessary
    }
}
