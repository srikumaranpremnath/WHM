using BusinessObjects.DTO.Common;

namespace BusinessObjects.DTO
{
    public class UserDto : Audit
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public bool IsDeleted { get; set; }
    }
}
