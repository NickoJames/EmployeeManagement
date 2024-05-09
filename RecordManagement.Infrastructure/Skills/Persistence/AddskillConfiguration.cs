using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RecordManagement.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.Skills.Persistence 
{
    public class AddskillConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
            builder.HasMany(e => e.Skills)
                             .WithOne()
                             .HasForeignKey(sk => sk.EmployeeId);
        }
}
}
