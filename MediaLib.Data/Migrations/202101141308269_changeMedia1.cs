namespace MediaLib.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeMedia1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Media_Id", newName: "Medium_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Media_Id", newName: "IX_Medium_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Medium_Id", newName: "IX_Media_Id");
            RenameColumn(table: "dbo.Movies", name: "Medium_Id", newName: "Media_Id");
        }
    }
}
