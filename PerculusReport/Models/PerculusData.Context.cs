﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerculusReport.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PerculusData : DbContext
    {
        public PerculusData()
            : base("name=PerculusData")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Reports_RoomParticipants_Result> Reports_RoomParticipants(Nullable<int> roomId)
        {
            var roomIdParameter = roomId.HasValue ?
                new ObjectParameter("RoomId", roomId) :
                new ObjectParameter("RoomId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reports_RoomParticipants_Result>("Reports_RoomParticipants", roomIdParameter);
        }
    
        public virtual ObjectResult<Reports_RoomStats_Result> Reports_RoomStats(Nullable<int> roomId)
        {
            var roomIdParameter = roomId.HasValue ?
                new ObjectParameter("RoomId", roomId) :
                new ObjectParameter("RoomId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reports_RoomStats_Result>("Reports_RoomStats", roomIdParameter);
        }
    
        public virtual ObjectResult<Reports_RoomUserStats_Result> Reports_RoomUserStats(Nullable<int> rOOMID)
        {
            var rOOMIDParameter = rOOMID.HasValue ?
                new ObjectParameter("ROOMID", rOOMID) :
                new ObjectParameter("ROOMID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reports_RoomUserStats_Result>("Reports_RoomUserStats", rOOMIDParameter);
        }
    
        public virtual ObjectResult<Reports_UserList_Result> Reports_UserList(Nullable<int> rOOMID)
        {
            var rOOMIDParameter = rOOMID.HasValue ?
                new ObjectParameter("ROOMID", rOOMID) :
                new ObjectParameter("ROOMID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reports_UserList_Result>("Reports_UserList", rOOMIDParameter);
        }
    }
}
