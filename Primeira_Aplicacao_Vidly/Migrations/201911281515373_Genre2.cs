namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "releaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "addDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "stock", c => c.Int(nullable: false));
            DropColumn("dbo.Genres", "releaseDate");
            DropColumn("dbo.Genres", "addDate");
            DropColumn("dbo.Genres", "stock");

            Sql("INSERT INTO  Genres VALUES('Drama')");
            Sql("update movies set genre_id = 1"); // Sem where mesmo kkk

        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "stock", c => c.Int(nullable: false));
            AddColumn("dbo.Genres", "addDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "releaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "stock");
            DropColumn("dbo.Movies", "addDate");
            DropColumn("dbo.Movies", "releaseDate");
            Sql("INSERT INTO  Genres VALUES('Drama')");
            Sql("update movies set genre_id = 1"); // Sem where mesmo kkk
        }
    }
}
