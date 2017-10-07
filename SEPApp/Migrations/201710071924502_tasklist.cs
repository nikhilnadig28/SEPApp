namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tasklist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskLists",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        TaskName = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        TaskDetails = c.String(),
                        TaskFeedback = c.String(),
                    })
                .PrimaryKey(t => t.TaskId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskLists");
        }
    }
}
