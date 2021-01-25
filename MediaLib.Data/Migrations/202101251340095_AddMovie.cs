namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, Medium_Id) VALUES ('Pulp Fiction', 6, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
