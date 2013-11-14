namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldCodeToAccountTypeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountTypes", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountTypes", "Code");
        }
    }
}
