namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAddd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DateAddd", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAdd");
        }
    }
}
