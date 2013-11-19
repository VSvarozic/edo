namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommonModelAddRegInfoMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Okato = c.String(),
                        Country = c.String(),
                        Zip = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Punkt = c.String(),
                        Street = c.String(),
                        Building = c.String(),
                        Office = c.String(),
                        RawAddress = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Business", "ShortTitle", c => c.String());
            AddColumn("dbo.Business", "IsAccreditated", c => c.Boolean(nullable: false));
            AddColumn("dbo.Business", "IsInvoiceStatement", c => c.Boolean(nullable: false));
            AddColumn("dbo.Office", "Description", c => c.String());
            AddColumn("dbo.Office", "IsMainOffice", c => c.Boolean(nullable: false));
            AddColumn("dbo.Office", "Inn", c => c.String());
            AddColumn("dbo.Office", "Ogrn", c => c.String());
            AddColumn("dbo.Office", "Kpp", c => c.String());
            AddColumn("dbo.Office", "Phone", c => c.String());
            AddColumn("dbo.Office", "Email", c => c.String());
            AddColumn("dbo.Office", "Fax", c => c.String());
            AddColumn("dbo.Office", "AdditionalContacts", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_Bik", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_PersonalAccount", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_SettlementAccount", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_CorrespondentAccount", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_BankName", c => c.String());
            AddColumn("dbo.Office", "OfficeEssentials_BankAddress", c => c.String());
            AddColumn("dbo.Office", "Address_Id", c => c.Int());
            AddColumn("dbo.UserProfile", "FirstName", c => c.String());
            AddColumn("dbo.UserProfile", "Surname", c => c.String());
            AddColumn("dbo.UserProfile", "LastName", c => c.String());
            AddColumn("dbo.UserProfile", "Phone", c => c.String());
            AddColumn("dbo.UserProfile", "MobilePhone", c => c.String());
            AddColumn("dbo.UserProfile", "Email", c => c.String());
            AddColumn("dbo.UserProfile", "PassPhrase", c => c.String());
            AddColumn("dbo.UserProfile", "AccountType_Id", c => c.Int());
            CreateIndex("dbo.UserProfile", "AccountType_Id");
            CreateIndex("dbo.Office", "Address_Id");
            AddForeignKey("dbo.UserProfile", "AccountType_Id", "dbo.AccountType", "Id");
            AddForeignKey("dbo.Office", "Address_Id", "dbo.Address", "Id");
            DropColumn("dbo.UserProfile", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "Birthday", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Office", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.UserProfile", "AccountType_Id", "dbo.AccountType");
            DropIndex("dbo.Office", new[] { "Address_Id" });
            DropIndex("dbo.UserProfile", new[] { "AccountType_Id" });
            DropColumn("dbo.UserProfile", "AccountType_Id");
            DropColumn("dbo.UserProfile", "PassPhrase");
            DropColumn("dbo.UserProfile", "Email");
            DropColumn("dbo.UserProfile", "MobilePhone");
            DropColumn("dbo.UserProfile", "Phone");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "Surname");
            DropColumn("dbo.UserProfile", "FirstName");
            DropColumn("dbo.Office", "Address_Id");
            DropColumn("dbo.Office", "OfficeEssentials_BankAddress");
            DropColumn("dbo.Office", "OfficeEssentials_BankName");
            DropColumn("dbo.Office", "OfficeEssentials_CorrespondentAccount");
            DropColumn("dbo.Office", "OfficeEssentials_SettlementAccount");
            DropColumn("dbo.Office", "OfficeEssentials_PersonalAccount");
            DropColumn("dbo.Office", "OfficeEssentials_Bik");
            DropColumn("dbo.Office", "AdditionalContacts");
            DropColumn("dbo.Office", "Fax");
            DropColumn("dbo.Office", "Email");
            DropColumn("dbo.Office", "Phone");
            DropColumn("dbo.Office", "Kpp");
            DropColumn("dbo.Office", "Ogrn");
            DropColumn("dbo.Office", "Inn");
            DropColumn("dbo.Office", "IsMainOffice");
            DropColumn("dbo.Office", "Description");
            DropColumn("dbo.Business", "IsInvoiceStatement");
            DropColumn("dbo.Business", "IsAccreditated");
            DropColumn("dbo.Business", "ShortTitle");
            DropTable("dbo.Address");
        }
    }
}
