﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class СonferenceEntities3 : DbContext
    {
        public СonferenceEntities3()
            : base("name=СonferenceEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<EquipAndPerf> EquipAndPerfs { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<PerfAndSpeaker> PerfAndSpeakers { get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
    }
}
