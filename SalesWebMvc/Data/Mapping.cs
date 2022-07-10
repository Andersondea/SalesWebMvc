using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data.Models
{
    #region Departments
    public class MapDepartment : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            // Chave primária
            builder.HasKey(department => department.Id);

            // Propriedades          
            builder.Property(department => department.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(department => department.Name).HasColumnName("Name").HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
    #endregion
}
