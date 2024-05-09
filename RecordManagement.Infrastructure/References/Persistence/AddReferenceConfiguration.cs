using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RecordManagement.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordManagement.Infrastructure.References.Persistence 
{
      public class AddReferenceConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {

            builder.HasMany(e => e.References)
                  .WithOne()
                  .HasForeignKey(rf => rf.Id);
        }
}
}
