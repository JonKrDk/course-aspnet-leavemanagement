using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d40a123d-ca01-4491-a093-c9ddd483595A",
                    UserId = "d40a123d-ca01-4491-a093-c9ddd4835959"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "d40a123d-ca01-4491-a093-c9ddd483595B",
                    UserId = "d40a123d-ca01-4491-a093-c9ddd483595C"
                }
            );
        }
    }
}
