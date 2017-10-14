namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class financialupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Financials", "Approval", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Financials", "Approval");
        }
    }
}
