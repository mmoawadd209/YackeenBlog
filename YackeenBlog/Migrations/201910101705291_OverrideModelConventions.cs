namespace YackeenBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideModelConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Articles", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "LastEditedOn", c => c.DateTime());
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Categories", "LastEditedOn", c => c.DateTime());
            AlterColumn("dbo.Comments", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "LastEditedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "LastEditedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Comments", "Content", c => c.String());
            AlterColumn("dbo.Categories", "LastEditedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Articles", "LastEditedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Articles", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Articles", "Content", c => c.String());
            AlterColumn("dbo.Articles", "Title", c => c.String());
        }
    }
}
