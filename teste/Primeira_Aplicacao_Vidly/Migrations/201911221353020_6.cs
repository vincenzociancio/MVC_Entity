namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "membershipType_Id", c => c.Int());
            CreateIndex("dbo.Customers", "membershipType_Id");
            AddForeignKey("dbo.Customers", "membershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "membershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershipType_Id" });
            DropColumn("dbo.Customers", "membershipType_Id");
            DropTable("dbo.MembershipTypes");
        }
    }
}
