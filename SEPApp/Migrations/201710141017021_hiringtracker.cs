namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hiringtracker : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HiringTrackers",
                c => new
                    {
                        HireId = c.Int(nullable: false, identity: true),
                        SkillSet = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HireId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HiringTrackers");
        }
    }
}
