namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedia : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Media (Name) VALUES ('Blu-Ray')");
            Sql("INSERT INTO Media (Name) VALUES ('DVD')");
            Sql("INSERT INTO Media (Name) VALUES ('CD')");
            Sql("INSERT INTO Media (Name) VALUES ('Digital-Microsoft')");
            Sql("INSERT INTO Media (Name) VALUES ('Digital')");
            Sql("INSERT INTO Media (Name) VALUES ('Book')");
            Sql("INSERT INTO Media (Name) VALUES ('E-Book')");
            Sql("INSERT INTO Media (Name) VALUES ('Cassette')");
        }
        
        public override void Down()
        {
        }
    }
}
