//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DvtForm
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class SignUp
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }


        public partial class UserEntities2 : DbContext
        {
            public UserEntities2()
                : base("name=UserEntities2")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                throw new UnintentionalCodeFirstException();
            }

            public DbSet<SignUp> Registrations { get; set; }
        }
    }




}
