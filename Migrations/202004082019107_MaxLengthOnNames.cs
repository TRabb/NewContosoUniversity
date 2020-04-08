namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudentInfo", newName: "Student");
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "FirstMidName");
            RenameColumn(table: "dbo.Student", name: "DateEnrolled", newName: "EnrollmentDate");
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 50));
            DropColumn("dbo.Student", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Phone", c => c.String());
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 30));
            RenameColumn(table: "dbo.Student", name: "EnrollmentDate", newName: "DateEnrolled");
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "FirstName");
            RenameTable(name: "dbo.Student", newName: "StudentInfo");
        }
    }
}
