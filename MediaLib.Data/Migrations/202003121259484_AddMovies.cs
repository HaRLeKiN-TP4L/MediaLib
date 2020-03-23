namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdd, Genre_Id, Medium_Id) VALUES ('Pulp Fiction', '03/11/1994', GETDATE(), 6, 2)");
            
        }
        
        public override void Down()
        {
        }
    }
}
