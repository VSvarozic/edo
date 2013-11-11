namespace EDO.Data.EFModelCommon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesBusOffPos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Office",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        Business_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .Index(t => t.Business_Id);
            
            CreateTable(
                "dbo.UserPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_Id)
                .Index(t => t.UserProfile_Id);
            
            AddColumn("dbo.UserProfile", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Business_Id", c => c.Int());
            AddColumn("dbo.UserProfile", "Office_Id", c => c.Int());
            CreateIndex("dbo.UserProfile", "Business_Id");
            CreateIndex("dbo.UserProfile", "Office_Id");
            AddForeignKey("dbo.UserProfile", "Business_Id", "dbo.Business", "Id");
            AddForeignKey("dbo.UserProfile", "Office_Id", "dbo.Office", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPositions", "UserProfile_Id", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfile", "Office_Id", "dbo.Office");
            DropForeignKey("dbo.UserProfile", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Office", "Business_Id", "dbo.Business");
            DropIndex("dbo.UserPositions", new[] { "UserProfile_Id" });
            DropIndex("dbo.UserProfile", new[] { "Office_Id" });
            DropIndex("dbo.UserProfile", new[] { "Business_Id" });
            DropIndex("dbo.Office", new[] { "Business_Id" });
            DropColumn("dbo.UserProfile", "Office_Id");
            DropColumn("dbo.UserProfile", "Business_Id");
            DropColumn("dbo.UserProfile", "Birthday");
            DropTable("dbo.UserPositions");
            DropTable("dbo.Office");
            DropTable("dbo.Business");
        }
    }
}
