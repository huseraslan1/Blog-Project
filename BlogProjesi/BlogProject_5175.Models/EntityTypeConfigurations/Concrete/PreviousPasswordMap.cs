using BlogProject_5175.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175.Models.EntityTypeConfigurations.Concrete
{
    public class PreviousPasswordMap : IEntityTypeConfiguration<PreviousPassword>
    {
        public void Configure(EntityTypeBuilder<PreviousPassword> builder)
        {
            builder.HasKey(a => new { a.AppuserID, a.PPassword });
        }
    }
}
