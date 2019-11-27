namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quarta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Customer_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .Index(t => t.Customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Movies", new[] { "Customer_id" });
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}
