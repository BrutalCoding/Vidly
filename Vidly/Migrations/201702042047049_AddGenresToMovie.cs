namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenresToMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Title) VALUES ('Action')");
            Sql("INSERT INTO Genres (Title) VALUES ('Family')");
            Sql("INSERT INTO Genres (Title) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Title) VALUES ('Drama')");
        }

        public override void Down()
        {
            Sql("DELETE * FROM Genres");
        }
    }
}
