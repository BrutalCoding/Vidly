namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'918e93d8-d6fd-416a-b5d0-a07d0e386bd8', N'guest@vidly.com', 0, N'AGqBaW1UiPHj3VgrDdo67Tz6CmxZnVli0s95kz9/SJSVUK4qZNR85uW9M4sk50gkqg==', N'43720931-1c18-4df7-ade5-eef54a93a4bb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ed05172e-3ab2-4227-b833-98a050ec6f17', N'admin@vidly.com', 0, N'AN75OjTuukQEXlx9FP+XJv1Zm+2IMlyIZ7MUkWPvoidcn+348Vsl1szhsxv1U7cOEA==', N'dab44ab1-7974-4164-857b-a97c0f4abda6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0a9dd6f4-ccdd-4d38-8d10-486082609bed', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ed05172e-3ab2-4227-b833-98a050ec6f17', N'0a9dd6f4-ccdd-4d38-8d10-486082609bed')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
