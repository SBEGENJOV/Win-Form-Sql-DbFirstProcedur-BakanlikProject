﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bakanlik
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class bakanEntities3 : DbContext
    {
        public bakanEntities3()
            : base("name=bakanEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bakanlik> bakanlik { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<vatandas> vatandas { get; set; }
        public virtual DbSet<vergiler> vergiler { get; set; }
        public virtual DbSet<EmpLogin> EmpLogin { get; set; }
    
        public virtual int bakanAdd(string bakanlikAdi, string daireBaskani, Nullable<decimal> bakanlikCiro, string bakanlikMerkez)
        {
            var bakanlikAdiParameter = bakanlikAdi != null ?
                new ObjectParameter("bakanlikAdi", bakanlikAdi) :
                new ObjectParameter("bakanlikAdi", typeof(string));
    
            var daireBaskaniParameter = daireBaskani != null ?
                new ObjectParameter("daireBaskani", daireBaskani) :
                new ObjectParameter("daireBaskani", typeof(string));
    
            var bakanlikCiroParameter = bakanlikCiro.HasValue ?
                new ObjectParameter("bakanlikCiro", bakanlikCiro) :
                new ObjectParameter("bakanlikCiro", typeof(decimal));
    
            var bakanlikMerkezParameter = bakanlikMerkez != null ?
                new ObjectParameter("BakanlikMerkez", bakanlikMerkez) :
                new ObjectParameter("BakanlikMerkez", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("bakanAdd", bakanlikAdiParameter, daireBaskaniParameter, bakanlikCiroParameter, bakanlikMerkezParameter);
        }
    
        public virtual int bakanDelete(Nullable<int> bakanlikID)
        {
            var bakanlikIDParameter = bakanlikID.HasValue ?
                new ObjectParameter("bakanlikID", bakanlikID) :
                new ObjectParameter("bakanlikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("bakanDelete", bakanlikIDParameter);
        }
    
        public virtual ObjectResult<bakanList_Result> bakanList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bakanList_Result>("bakanList");
        }
    
        public virtual int bakanUpdate(Nullable<int> bakanlikID, string bakanlikAdi, string daireBaskani, Nullable<decimal> bakanlikCiro, string bakanlikMerkez)
        {
            var bakanlikIDParameter = bakanlikID.HasValue ?
                new ObjectParameter("bakanlikID", bakanlikID) :
                new ObjectParameter("bakanlikID", typeof(int));
    
            var bakanlikAdiParameter = bakanlikAdi != null ?
                new ObjectParameter("bakanlikAdi", bakanlikAdi) :
                new ObjectParameter("bakanlikAdi", typeof(string));
    
            var daireBaskaniParameter = daireBaskani != null ?
                new ObjectParameter("daireBaskani", daireBaskani) :
                new ObjectParameter("daireBaskani", typeof(string));
    
            var bakanlikCiroParameter = bakanlikCiro.HasValue ?
                new ObjectParameter("bakanlikCiro", bakanlikCiro) :
                new ObjectParameter("bakanlikCiro", typeof(decimal));
    
            var bakanlikMerkezParameter = bakanlikMerkez != null ?
                new ObjectParameter("BakanlikMerkez", bakanlikMerkez) :
                new ObjectParameter("BakanlikMerkez", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("bakanUpdate", bakanlikIDParameter, bakanlikAdiParameter, daireBaskaniParameter, bakanlikCiroParameter, bakanlikMerkezParameter);
        }
    
        public virtual ObjectResult<bakanVergi_Result> bakanVergi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bakanVergi_Result>("bakanVergi");
        }
    
        public virtual ObjectResult<bakver_Result> bakver()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bakver_Result>("bakver");
        }
    
        public virtual ObjectResult<Nullable<decimal>> bavgciro()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("bavgciro");
        }
    
        public virtual ObjectResult<Nullable<decimal>> bcirosira()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("bcirosira");
        }
    
        public virtual ObjectResult<bmaxciro_Result> bmaxciro()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bmaxciro_Result>("bmaxciro");
        }
    
        public virtual ObjectResult<bmersay_Result> bmersay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bmersay_Result>("bmersay");
        }
    
        public virtual ObjectResult<bminciro_Result> bminciro()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bminciro_Result>("bminciro");
        }
    
        public virtual ObjectResult<Nullable<decimal>> bsumciro()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("bsumciro");
        }
    
        public virtual ObjectResult<Nullable<decimal>> ciroBilgi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ciroBilgi");
        }
    
        public virtual ObjectResult<cLogin_Result> cLogin(string employeeUser, string employeePassword)
        {
            var employeeUserParameter = employeeUser != null ?
                new ObjectParameter("employeeUser", employeeUser) :
                new ObjectParameter("employeeUser", typeof(string));
    
            var employeePasswordParameter = employeePassword != null ?
                new ObjectParameter("employeePassword", employeePassword) :
                new ObjectParameter("employeePassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cLogin_Result>("cLogin", employeeUserParameter, employeePasswordParameter);
        }
    
        public virtual ObjectResult<kLogin_Result> kLogin(string kisiTelefon, string kisiTC)
        {
            var kisiTelefonParameter = kisiTelefon != null ?
                new ObjectParameter("KisiTelefon", kisiTelefon) :
                new ObjectParameter("KisiTelefon", typeof(string));
    
            var kisiTCParameter = kisiTC != null ?
                new ObjectParameter("kisiTC", kisiTC) :
                new ObjectParameter("kisiTC", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kLogin_Result>("kLogin", kisiTelefonParameter, kisiTCParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int vatandasAdd(string kisiTC, string kisiMeslek, string kisiAdres, string kisiTelefon, string kisiMail, Nullable<int> vergiID)
        {
            var kisiTCParameter = kisiTC != null ?
                new ObjectParameter("kisiTC", kisiTC) :
                new ObjectParameter("kisiTC", typeof(string));
    
            var kisiMeslekParameter = kisiMeslek != null ?
                new ObjectParameter("KisiMeslek", kisiMeslek) :
                new ObjectParameter("KisiMeslek", typeof(string));
    
            var kisiAdresParameter = kisiAdres != null ?
                new ObjectParameter("KisiAdres", kisiAdres) :
                new ObjectParameter("KisiAdres", typeof(string));
    
            var kisiTelefonParameter = kisiTelefon != null ?
                new ObjectParameter("KisiTelefon", kisiTelefon) :
                new ObjectParameter("KisiTelefon", typeof(string));
    
            var kisiMailParameter = kisiMail != null ?
                new ObjectParameter("KisiMail", kisiMail) :
                new ObjectParameter("KisiMail", typeof(string));
    
            var vergiIDParameter = vergiID.HasValue ?
                new ObjectParameter("vergiID", vergiID) :
                new ObjectParameter("vergiID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vatandasAdd", kisiTCParameter, kisiMeslekParameter, kisiAdresParameter, kisiTelefonParameter, kisiMailParameter, vergiIDParameter);
        }
    
        public virtual int vatandasDelete(Nullable<int> kisiNo)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("kisiNo", kisiNo) :
                new ObjectParameter("kisiNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vatandasDelete", kisiNoParameter);
        }
    
        public virtual ObjectResult<vatandasList_Result> vatandasList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vatandasList_Result>("vatandasList");
        }
    
        public virtual int vatandasUpdate(Nullable<int> kisiNo, string kisiTC, string kisiMeslek, string kisiAdres, string kisiTelefon, string kisiMail, Nullable<int> vergiID)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("kisiNo", kisiNo) :
                new ObjectParameter("kisiNo", typeof(int));
    
            var kisiTCParameter = kisiTC != null ?
                new ObjectParameter("kisiTC", kisiTC) :
                new ObjectParameter("kisiTC", typeof(string));
    
            var kisiMeslekParameter = kisiMeslek != null ?
                new ObjectParameter("KisiMeslek", kisiMeslek) :
                new ObjectParameter("KisiMeslek", typeof(string));
    
            var kisiAdresParameter = kisiAdres != null ?
                new ObjectParameter("KisiAdres", kisiAdres) :
                new ObjectParameter("KisiAdres", typeof(string));
    
            var kisiTelefonParameter = kisiTelefon != null ?
                new ObjectParameter("KisiTelefon", kisiTelefon) :
                new ObjectParameter("KisiTelefon", typeof(string));
    
            var kisiMailParameter = kisiMail != null ?
                new ObjectParameter("KisiMail", kisiMail) :
                new ObjectParameter("KisiMail", typeof(string));
    
            var vergiIDParameter = vergiID.HasValue ?
                new ObjectParameter("vergiID", vergiID) :
                new ObjectParameter("vergiID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vatandasUpdate", kisiNoParameter, kisiTCParameter, kisiMeslekParameter, kisiAdresParameter, kisiTelefonParameter, kisiMailParameter, vergiIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> vavg()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("vavg");
        }
    
        public virtual ObjectResult<vb_Result> vb()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vb_Result>("vb");
        }
    
        public virtual int vergiDelete(Nullable<int> vergiID)
        {
            var vergiIDParameter = vergiID.HasValue ?
                new ObjectParameter("vergiID", vergiID) :
                new ObjectParameter("vergiID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vergiDelete", vergiIDParameter);
        }
    
        public virtual int vergilerAdd(string vergiAdi, string vergiTipi, Nullable<decimal> vergiTutar, Nullable<decimal> vergiFaiz, Nullable<int> bakanlikID)
        {
            var vergiAdiParameter = vergiAdi != null ?
                new ObjectParameter("vergiAdi", vergiAdi) :
                new ObjectParameter("vergiAdi", typeof(string));
    
            var vergiTipiParameter = vergiTipi != null ?
                new ObjectParameter("vergiTipi", vergiTipi) :
                new ObjectParameter("vergiTipi", typeof(string));
    
            var vergiTutarParameter = vergiTutar.HasValue ?
                new ObjectParameter("vergiTutar", vergiTutar) :
                new ObjectParameter("vergiTutar", typeof(decimal));
    
            var vergiFaizParameter = vergiFaiz.HasValue ?
                new ObjectParameter("vergiFaiz", vergiFaiz) :
                new ObjectParameter("vergiFaiz", typeof(decimal));
    
            var bakanlikIDParameter = bakanlikID.HasValue ?
                new ObjectParameter("bakanlikID", bakanlikID) :
                new ObjectParameter("bakanlikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vergilerAdd", vergiAdiParameter, vergiTipiParameter, vergiTutarParameter, vergiFaizParameter, bakanlikIDParameter);
        }
    
        public virtual ObjectResult<vergilerList_Result> vergilerList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vergilerList_Result>("vergilerList");
        }
    
        public virtual int vergilerUpdate(Nullable<int> vergiID, string vergiAdi, string vergiTipi, Nullable<decimal> vergiTutar, Nullable<decimal> vergiFaiz, Nullable<int> bakanlikID)
        {
            var vergiIDParameter = vergiID.HasValue ?
                new ObjectParameter("vergiID", vergiID) :
                new ObjectParameter("vergiID", typeof(int));
    
            var vergiAdiParameter = vergiAdi != null ?
                new ObjectParameter("vergiAdi", vergiAdi) :
                new ObjectParameter("vergiAdi", typeof(string));
    
            var vergiTipiParameter = vergiTipi != null ?
                new ObjectParameter("vergiTipi", vergiTipi) :
                new ObjectParameter("vergiTipi", typeof(string));
    
            var vergiTutarParameter = vergiTutar.HasValue ?
                new ObjectParameter("vergiTutar", vergiTutar) :
                new ObjectParameter("vergiTutar", typeof(decimal));
    
            var vergiFaizParameter = vergiFaiz.HasValue ?
                new ObjectParameter("vergiFaiz", vergiFaiz) :
                new ObjectParameter("vergiFaiz", typeof(decimal));
    
            var bakanlikIDParameter = bakanlikID.HasValue ?
                new ObjectParameter("bakanlikID", bakanlikID) :
                new ObjectParameter("bakanlikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vergilerUpdate", vergiIDParameter, vergiAdiParameter, vergiTipiParameter, vergiTutarParameter, vergiFaizParameter, bakanlikIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> vfavg()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("vfavg");
        }
    
        public virtual ObjectResult<vfmax_Result> vfmax()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vfmax_Result>("vfmax");
        }
    
        public virtual ObjectResult<vfmin_Result> vfmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vfmin_Result>("vfmin");
        }
    
        public virtual ObjectResult<Nullable<decimal>> vfsum()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("vfsum");
        }
    
        public virtual ObjectResult<vil_Result> vil()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vil_Result>("vil");
        }
    
        public virtual ObjectResult<vList_Result> vList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vList_Result>("vList");
        }
    
        public virtual ObjectResult<vmax_Result> vmax()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vmax_Result>("vmax");
        }
    
        public virtual ObjectResult<vmes_Result> vmes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vmes_Result>("vmes");
        }
    
        public virtual ObjectResult<vmin_Result> vmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vmin_Result>("vmin");
        }
    
        public virtual ObjectResult<Nullable<decimal>> vsum()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("vsum");
        }
    
        public virtual ObjectResult<vv_Result> vv()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vv_Result>("vv");
        }
    
        public virtual ObjectResult<vwv_Result> vwv()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<vwv_Result>("vwv");
        }
    }
}
