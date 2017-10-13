namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "SeniorCustomerApprove", c => c.Boolean(nullable: false));
            AddColumn("dbo.Events", "AdministrativeManagerApprove", c => c.Boolean(nullable: false));
            AddColumn("dbo.Events", "FinancialManagerComments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "FinancialManagerComments");
            DropColumn("dbo.Events", "AdministrativeManagerApprove");
            DropColumn("dbo.Events", "SeniorCustomerApprove");
        }
    }
}
