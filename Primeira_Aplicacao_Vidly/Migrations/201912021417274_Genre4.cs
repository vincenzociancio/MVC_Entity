namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "genre_id" });
            AlterColumn("dbo.Genres", "genre", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Movies", "genre_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "genre_Id" });
            AlterColumn("dbo.Genres", "genre", c => c.String(nullable: false));
            CreateIndex("dbo.Movies", "genre_id");
        }
    }
}
