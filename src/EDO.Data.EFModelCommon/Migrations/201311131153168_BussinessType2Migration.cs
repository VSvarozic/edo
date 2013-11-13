namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BussinessType2Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BussinessTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BussinessTypes");
        }
    }
}
