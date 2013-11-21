namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Address", "Modified", c => c.DateTime());
            AlterColumn("dbo.Business", "Modified", c => c.DateTime());
            AlterColumn("dbo.Office", "Modified", c => c.DateTime());
            AlterColumn("dbo.UserProfile", "Modified", c => c.DateTime());
            AlterColumn("dbo.UserPosition", "Modified", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserPosition", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserProfile", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Office", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Business", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Address", "Modified", c => c.DateTime(nullable: false));
        }
    }
}
