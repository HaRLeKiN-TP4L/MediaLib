namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    ReleaseDate = c.DateTime(nullable: false),
                    DateAddd = c.DateTime(nullable: false),
                    Genre_Id = c.Int(),
                    Medium_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieGenres", t => t.Genre_Id)
                .ForeignKey("dbo.Media", t => t.Medium_Id)
                .Index(t => t.Genre_Id)
                .Index(t => t.Medium_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Medium_Id", "dbo.Media");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropForeignKey("dbo.MovieActors", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Medium_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.MovieActors", new[] { "Movie_Id" });
            DropTable("dbo.Movies");
        }
    }
}
