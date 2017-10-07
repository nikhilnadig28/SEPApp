namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class financeRecruitment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Financials",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        ExpectedBudgetIncrease = c.Int(nullable: false),
                        Justification = c.String(),
                    })
                .PrimaryKey(t => t.RequestId);
            
            CreateTable(
                "dbo.Recruitments",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        RequestName = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        SkillSet = c.String(),
                    })
                .PrimaryKey(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recruitments");
            DropTable("dbo.Financials");
        }
    }
}
