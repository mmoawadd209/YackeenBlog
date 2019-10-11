namespace YackeenBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimplifyModelProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "CreatedBy", c => c.String());
            AlterColumn("dbo.Categories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Comments", "CreatedBy", c => c.String());
            DropColumn("dbo.Articles", "LastEditedOn");
            DropColumn("dbo.Articles", "IsDeleted");
            DropColumn("dbo.Categories", "LastEditedOn");
            DropColumn("dbo.Categories", "IsDeleted");
            DropColumn("dbo.Comments", "LastEditedOn");
            DropColumn("dbo.Comments", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Comments", "LastEditedOn", c => c.DateTime());
            AddColumn("dbo.Categories", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "LastEditedOn", c => c.DateTime());
            AddColumn("dbo.Articles", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Articles", "LastEditedOn", c => c.DateTime());
            AlterColumn("dbo.Comments", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "CreatedBy", c => c.String(nullable: false));
        }
    }
}
