namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieActors : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieActors (Name) VALUES('Johnny Depp')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Samuel L. Jackson')");
            Sql("INSERT INTO MovieActors (Name) VALUES('John Travolta')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Bruce Willis')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Jude Law')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Robert Downey Jr.')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Brad Pitt')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Angelina Jolie')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Charlie Hunnam')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Julia Roberts')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Mila Kunis')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Emma Watson')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Emma Stone')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Seth Rogen')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Jonah Hill')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Jason Statham')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Channing Tatum')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Ice Cube')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Helena Bonham Carter')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Tom Holland')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Chris Hemsworth')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Marc Ruffalo')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Tom Hiddleston')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Anne Hathaway')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Hugh Jackman')");
            Sql("INSERT INTO MovieActors (Name) VALUES('Zac Efron')");
        }
        
        public override void Down()
        {
        }
    }
}
