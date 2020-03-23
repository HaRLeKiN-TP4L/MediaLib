namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Action')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Action-Comedy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Drama')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('LoveMovie')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Crime')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Trash')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Family')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Teenie')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Sci-Fi')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Documentation')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('History')");
        }
        
        public override void Down()
        {
        }
    }
}
