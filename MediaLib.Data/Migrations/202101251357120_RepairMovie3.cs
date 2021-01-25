namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairMovie3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, MediumId) VALUES ('Pulp Fiction', 6, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
