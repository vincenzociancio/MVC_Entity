namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testeXXX : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set BirthDate = '05/03/1988' where id = 2");
            Sql("update Customers set BirthDate = '02/12/2000' where id = 3");
            Sql("update Customers set BirthDate = '01/01/2019' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
