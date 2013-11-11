namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDateFieldsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Business", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Business", "Modified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Office", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Office", "Modified", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserPositions", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserPositions", "Modified", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Modified", c => c.DateTime(nullable: false));
            DropColumn("dbo.Business", "CreatedDate");
            DropColumn("dbo.Business", "ModifiedDate");
            DropColumn("dbo.Office", "CreatedDate");
            DropColumn("dbo.Office", "ModifiedDate");
            DropColumn("dbo.UserPositions", "CreatedDate");
            DropColumn("dbo.UserPositions", "ModifiedDate");
            DropColumn("dbo.UserProfile", "CreatedDate");
            DropColumn("dbo.UserProfile", "ModifiedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserPositions", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserPositions", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Office", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Office", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Business", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Business", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserProfile", "Modified");
            DropColumn("dbo.UserProfile", "Created");
            DropColumn("dbo.UserPositions", "Modified");
            DropColumn("dbo.UserPositions", "Created");
            DropColumn("dbo.Office", "Modified");
            DropColumn("dbo.Office", "Created");
            DropColumn("dbo.Business", "Modified");
            DropColumn("dbo.Business", "Created");
        }
    }
}
