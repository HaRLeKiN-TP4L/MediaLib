namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairMovie4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropForeignKey("dbo.Movies", "Medium_Id", "dbo.Media");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Movies", new[] { "Medium_Id" });
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "MediumId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.Movies", name: "Medium_Id", newName: "MediumId");
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "MediumId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "MediumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreId");
            CreateIndex("dbo.Movies", "MediumId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.MovieGenres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "MediumId", "dbo.Media", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MediumId", "dbo.Media");
            DropForeignKey("dbo.Movies", "GenreId", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MediumId" });
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Movies", "MediumId", c => c.Int());
            AlterColumn("dbo.Movies", "GenreId", c => c.Int());
            AlterColumn("dbo.Movies", "MediumId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "MediumId", newName: "Medium_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.Movies", "MediumId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Medium_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Medium_Id", "dbo.Media", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres", "Id");
        }
    }
}
