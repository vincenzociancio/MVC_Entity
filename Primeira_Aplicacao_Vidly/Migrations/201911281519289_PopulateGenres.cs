namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO  Genres VALUES('Drama')");
            Sql("update movies set genre_id = 1"); // Sem where mesmo kkk
        }
        
        public override void Down()
        {
        }
    }
}
