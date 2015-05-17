﻿using System.Data.Entity;
using WebTextEditor.DAL.Configurations;
using WebTextEditor.DAL.Models;

namespace WebTextEditor.DAL
{
    /// <summary>
    ///     Database context.
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        ///     Collection of documents.
        /// </summary>
        public DbSet<DocumentEntity> Documents { get; set; }

        /// <summary>
        ///     Collection of document content.
        /// </summary>
        public DbSet<DocumentContentEntity> DocumentContents { get; set; }

        /// <summary>
        ///     Collection of document collaborators state.
        /// </summary>
        public DbSet<DocumentCollaboratorEntity> DocumentCollaborators { get; set; }

        /// <summary>
        ///     Configure entity mappings.
        /// </summary>
        /// <param name="modelBuilder">Database model metadata.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DocumentEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentContentEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentCollaboratorEntityConfiguration());
        }
    }
}