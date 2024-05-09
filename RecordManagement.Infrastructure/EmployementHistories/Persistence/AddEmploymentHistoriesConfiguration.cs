using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee = RecordManagement.Domain.Employees.Employee;

namespace RecordManagement.Infrastructure.EmployementHistories.Persistence
{
    public class AddEmploymentHistoriesConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasMany(e => e.EmploymentHistories)
                       .WithOne()
                       .HasForeignKey(eh => eh.EmployeeId);
        }
    }
}
