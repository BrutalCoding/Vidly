namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesWithGenres : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre_Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
