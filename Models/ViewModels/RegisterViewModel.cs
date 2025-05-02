namespace PhuongNVT.Models.ViewModels
{
    public class RegisterViewModel
    {
        public string FullName { get; set; } // Nếu bạn cần thêm thông tin này
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; } // "Admin" hoặc "User"
    }
}