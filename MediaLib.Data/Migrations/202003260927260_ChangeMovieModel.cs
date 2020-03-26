namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMovieModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropForeignKey("dbo.Movies", "Medium_Id", "dbo.Media");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Movies", new[] { "Medium_Id" });
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Medium_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            CreateIndex("dbo.Movies", "Medium_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "Medium_Id", "dbo.Media", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Medium_Id", "dbo.Media");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "Medium_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            AlterColumn("dbo.Movies", "Medium_Id", c => c.Int());
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            CreateIndex("dbo.Movies", "Medium_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Medium_Id", "dbo.Media", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres", "Id");
        }
    }
}
