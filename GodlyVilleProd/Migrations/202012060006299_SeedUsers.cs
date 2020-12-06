namespace GodlyVilleProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1acd130d-05f8-41fa-bdc7-cfa627147aaa', N'admin@godlyville.com', 0, N'ABj5XV2nOYzyZQf+LBQuXMZv1lLo3EJyWwXRXYOPcFKnKzMkRNEKAkjp2/dTGHSKyA==', N'06310ca5-69eb-4098-bd89-acb4c245ce08', NULL, 0, 0, NULL, 1, 0, N'admin@godlyville.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20e7ea8c-c749-4cda-814f-3f47e334bc4b', N'user1@godlyville.com', 0, N'AF+AcVwy31/Pg6pM2vRJlF8outl3T7GOczRhSk0W0Nq7GDy1yLowodvHhv+7R2R8PA==', N'de9844b3-97bb-4a62-886d-8bfb990981b3', NULL, 0, 0, NULL, 1, 0, N'user1@godlyville.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'656df414-8887-408b-9f6e-6217d4000594', N'guest@godlyville.com', 0, N'AKyGTDIWsqBaCZDIgUEjU3KcOVXlDzqOaanDa2QMxKNqwplSjdDQ4LLrYTdMJyJ67g==', N'7a614488-2a38-4679-86f4-94aca2c6f5e5', NULL, 0, 0, NULL, 1, 0, N'guest@godlyville.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'52ed7639-11ef-4fa8-9e1b-7a3538e72014', N'CanManagePlays')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1acd130d-05f8-41fa-bdc7-cfa627147aaa', N'52ed7639-11ef-4fa8-9e1b-7a3538e72014')
             ");
        }
        
        public override void Down()
        {
        }
    }
}
