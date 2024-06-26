﻿using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class UsuariosMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.UsuarioId);
            builder.Property(x => x.UsuarioNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UsuarioEmail).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UsuarioSenha).IsRequired().HasMaxLength(255);
        }
    }
}
