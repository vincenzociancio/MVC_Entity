namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quinta : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Movies", new[] { "Customer_id" });
            CreateTable(
                "dbo.MovieCustomers",
                c => new
                    {
                        Movie_id = c.Int(nullable: false),
                        Customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_id, t.Customer_id })
                .ForeignKey("dbo.Movies", t => t.Movie_id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_id, cascadeDelete: true)
                .Index(t => t.Movie_id)
                .Index(t => t.Customer_id);
            
            DropColumn("dbo.Movies", "Customer_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Customer_id", c => c.Int());
            DropForeignKey("dbo.MovieCustomers", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.MovieCustomers", "Movie_id", "dbo.Movies");
            DropIndex("dbo.MovieCustomers", new[] { "Customer_id" });
            DropIndex("dbo.MovieCustomers", new[] { "Movie_id" });
            DropTable("dbo.MovieCustomers");
            CreateIndex("dbo.Movies", "Customer_id");
            AddForeignKey("dbo.Movies", "Customer_id", "dbo.Customers", "id");
        }
    }
}
