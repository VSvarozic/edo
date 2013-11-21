namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Address", "Created", c => c.DateTime());
            AlterColumn("dbo.Business", "Created", c => c.DateTime());
            AlterColumn("dbo.Office", "Created", c => c.DateTime());
            AlterColumn("dbo.UserProfile", "Created", c => c.DateTime());
            AlterColumn("dbo.UserPosition", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserPosition", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserProfile", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Office", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Business", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Address", "Created", c => c.DateTime(nullable: false));
        }
    }
}
