namespace Primeira_Aplicacao_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate)  VALUES (1,0,0,'PayPerView')");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate)  VALUES (0,6,10,'Monthly')");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate)  VALUES (0,12,20,'Anual')");
        }      
        public override void Down()
        {
        }
    }
}
