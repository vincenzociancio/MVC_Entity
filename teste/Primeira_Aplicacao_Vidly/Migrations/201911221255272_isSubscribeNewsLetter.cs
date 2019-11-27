namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isSubscribeNewsLetter : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieCustomers", "Movie_id", "dbo.Movies");
            DropForeignKey("dbo.MovieCustomers", "Customer_id", "dbo.Customers");
            DropIndex("dbo.MovieCustomers", new[] { "Movie_id" });
            DropIndex("dbo.MovieCustomers", new[] { "Customer_id" });
            AddColumn("dbo.Customers", "isSubscribeNewsLetter", c => c.Boolean(nullable: false));
            DropTable("dbo.MovieCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MovieCustomers",
                c => new
                    {
                        Movie_id = c.Int(nullable: false),
                        Customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_id, t.Customer_id });
            
            DropColumn("dbo.Customers", "isSubscribeNewsLetter");
            CreateIndex("dbo.MovieCustomers", "Customer_id");
            CreateIndex("dbo.MovieCustomers", "Movie_id");
            AddForeignKey("dbo.MovieCustomers", "Customer_id", "dbo.Customers", "id", cascadeDelete: true);
            AddForeignKey("dbo.MovieCustomers", "Movie_id", "dbo.Movies", "id", cascadeDelete: true);
        }
    }
}
