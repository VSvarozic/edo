namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNullableFromDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Business", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Business", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Office", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Office", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserPositions", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserPositions", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserProfile", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserProfile", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.UserProfile", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.UserPositions", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.UserPositions", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Office", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Office", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Business", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Business", "CreatedDate", c => c.DateTime());
        }
    }
}
