﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace управление_проектами
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class БД_производстваEntities : DbContext
    {
        public БД_производстваEntities()
            : base("name=БД_производстваEntities")
        {
        }

        private static БД_производстваEntities _context;

        public static БД_производстваEntities GetContext()
        {
            if (_context == null)
            {
                _context = new БД_производстваEntities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ассортимент> ассортимент { get; set; }
        public virtual DbSet<заказ> заказ { get; set; }
        public virtual DbSet<запас_пряжи> запас_пряжи { get; set; }
        public virtual DbSet<запас_ткани> запас_ткани { get; set; }
        public virtual DbSet<клиенты> клиенты { get; set; }
        public virtual DbSet<работники> работники { get; set; }
    }
}
