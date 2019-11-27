namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terceira : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Movies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
