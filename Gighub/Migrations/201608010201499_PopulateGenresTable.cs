namespace Gighub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rocks')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("DELET FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
