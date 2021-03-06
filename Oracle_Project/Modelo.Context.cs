﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oracle_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntidadesLibreria : DbContext
    {
        public EntidadesLibreria()
            : base("name=EntidadesLibreria")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TBL_LIBRO> TBL_LIBRO { get; set; }
        public DbSet<TBL_LOG> TBL_LOG { get; set; }
        public DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
    
        public virtual int INSERTAR_LIBRO(string l_NOMBRE_LIBRO, string l_NOMBRE_AUTOR)
        {
            var l_NOMBRE_LIBROParameter = l_NOMBRE_LIBRO != null ?
                new ObjectParameter("L_NOMBRE_LIBRO", l_NOMBRE_LIBRO) :
                new ObjectParameter("L_NOMBRE_LIBRO", typeof(string));
    
            var l_NOMBRE_AUTORParameter = l_NOMBRE_AUTOR != null ?
                new ObjectParameter("L_NOMBRE_AUTOR", l_NOMBRE_AUTOR) :
                new ObjectParameter("L_NOMBRE_AUTOR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTAR_LIBRO", l_NOMBRE_LIBROParameter, l_NOMBRE_AUTORParameter);
        }
    
        public virtual int INSERTAR_USUARIO(string u_CEDULA, string u_NOMBRE, string u_APELLIDO, string u_DIRECCION, Nullable<decimal> u_CELULAR, Nullable<decimal> u_L_LIBRO)
        {
            var u_CEDULAParameter = u_CEDULA != null ?
                new ObjectParameter("U_CEDULA", u_CEDULA) :
                new ObjectParameter("U_CEDULA", typeof(string));
    
            var u_NOMBREParameter = u_NOMBRE != null ?
                new ObjectParameter("U_NOMBRE", u_NOMBRE) :
                new ObjectParameter("U_NOMBRE", typeof(string));
    
            var u_APELLIDOParameter = u_APELLIDO != null ?
                new ObjectParameter("U_APELLIDO", u_APELLIDO) :
                new ObjectParameter("U_APELLIDO", typeof(string));
    
            var u_DIRECCIONParameter = u_DIRECCION != null ?
                new ObjectParameter("U_DIRECCION", u_DIRECCION) :
                new ObjectParameter("U_DIRECCION", typeof(string));
    
            var u_CELULARParameter = u_CELULAR.HasValue ?
                new ObjectParameter("U_CELULAR", u_CELULAR) :
                new ObjectParameter("U_CELULAR", typeof(decimal));
    
            var u_L_LIBROParameter = u_L_LIBRO.HasValue ?
                new ObjectParameter("U_L_LIBRO", u_L_LIBRO) :
                new ObjectParameter("U_L_LIBRO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTAR_USUARIO", u_CEDULAParameter, u_NOMBREParameter, u_APELLIDOParameter, u_DIRECCIONParameter, u_CELULARParameter, u_L_LIBROParameter);
        }
    
        public virtual int FUN_OBTENER_USUARIOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FUN_OBTENER_USUARIOS");
        }
    }
}
