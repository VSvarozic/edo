namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserBusinessPositionFixMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountTypes", newName: "AccountType");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AccountType", newName: "AccountTypes");
        }
    }
}
