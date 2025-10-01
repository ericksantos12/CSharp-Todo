using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Infrastructure.Persistence.Configuration
{
    public class TodoCardConfiguration : IEntityTypeConfiguration<TodoCard>
    {
        public void Configure(EntityTypeBuilder<TodoCard> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(t => t.IsCompleted)
                   .IsRequired();
        }
    }
}
