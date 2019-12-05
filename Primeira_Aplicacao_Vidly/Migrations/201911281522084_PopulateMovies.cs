namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(name, genre_id, releaseDate, addDate, stock) VALUES('Catch Me If You Can', 1, '10/10/2001', '2/12/2001', 10)");
            Sql("INSERT INTO Movies(name, genre_id, releaseDate, addDate, stock) VALUES('The Wolf of WallStreet', 1, '10/10/2001', '2/12/2001', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
