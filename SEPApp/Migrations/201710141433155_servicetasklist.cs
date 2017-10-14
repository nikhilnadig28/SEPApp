namespace SEPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class servicetasklist : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TaskLists", name: "Id", newName: "EmployeeId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TaskLists", name: "EmployeeId", newName: "Id");
        }
    }
}
