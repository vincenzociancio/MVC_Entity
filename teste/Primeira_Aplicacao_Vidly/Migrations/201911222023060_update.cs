namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set name = 'PayPerView' where id = 1 ");
            Sql("update MembershipTypes set name = 'Monthtly' where id = 2 ");
            Sql("update MembershipTypes set name = 'Anualy' where id = 3 ");
        }
        
        public override void Down()
        {
        }
    }
}
