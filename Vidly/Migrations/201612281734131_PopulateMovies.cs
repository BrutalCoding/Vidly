namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Shrek', 'Family', 28-12-2016, 27-12-2016, 15)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Terminator', 'Action', 28-12-2016, 27-12-2016, 9)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Forest Gump', 'Drama', 28-12-2016, 27-12-2016, 21)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('Spider Man 2', 'Drama/Action', 28-12-2016, 27-12-2016, 36)");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Movies WHERE Name= 'Shrek'");
            Sql("DELETE FROM Movies WHERE Name= 'Terminator'");
            Sql("DELETE FROM Movies WHERE Name= 'Forest Gump'");
            Sql("DELETE FROM Movies WHERE Name= 'Spider Man 2'");
        }
    }
}
