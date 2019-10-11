namespace YackeenBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAllCreatedByTypeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "CreatedBy", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CreatedBy", c => c.Int(nullable: false));
        }
    }
}
