namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserBusinessPositionFix3Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Position_Id", c => c.Int());
            CreateIndex("dbo.UserProfile", "Position_Id");
            AddForeignKey("dbo.UserProfile", "Position_Id", "dbo.UserPosition", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfile", "Position_Id", "dbo.UserPosition");
            DropIndex("dbo.UserProfile", new[] { "Position_Id" });
            DropColumn("dbo.UserProfile", "Position_Id");
        }
    }
}
