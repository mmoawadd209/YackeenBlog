namespace YackeenBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedInitialCategories : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Categories] ([Name],[CreatedBy],[CreatedOn],[IsDeleted]) VALUES (N'Sports',N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000',N'False')");
            Sql(@"INSERT INTO [dbo].[Categories] ([Name],[CreatedBy],[CreatedOn],[IsDeleted]) VALUES (N'News',N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000',N'False')");
            Sql(@"INSERT INTO [dbo].[Categories] ([Name],[CreatedBy],[CreatedOn],[IsDeleted]) VALUES (N'Art',N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000',N'False')");
           
        }

        public override void Down()
        {
            Sql(@"DELETE FROM [dbo].[Categories]");
          
        }
    }
}
