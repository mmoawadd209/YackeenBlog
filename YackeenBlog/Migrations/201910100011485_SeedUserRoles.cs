namespace YackeenBlog.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c27ca609-a547-407d-9846-ad45b2f8a1fd', N'admin@app.com', 0, N'AFmXuQo8kKyvFfFdB5BSkVLM297+pWzk90szgR/8D7G4WP78sDeFQtfX0p3qJ6iPXg==', N'f25c008e-2bab-4841-a04d-50c0a17b402c', NULL, 0, 0, NULL, 1, 0, N'admin@app.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1', N'Admin')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c27ca609-a547-407d-9846-ad45b2f8a1fd', N'1')");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [dbo].[AspNetUserRoles]");
            Sql(@"DELETE FROM [dbo].[AspNetRoles]");
            Sql(@"DELETE FROM [dbo].[AspNetUsers]");
        }
    }
}
