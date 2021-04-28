namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enithial3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avatars", "Message_Id", "dbo.Messages");
            DropForeignKey("dbo.Photos", "Message_Id", "dbo.Messages");
            DropIndex("dbo.Photos", new[] { "Message_Id" });
            DropIndex("dbo.Avatars", new[] { "Message_Id" });
            DropColumn("dbo.Photos", "Message_Id");
            DropColumn("dbo.Avatars", "Message_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Avatars", "Message_Id", c => c.Int());
            AddColumn("dbo.Photos", "Message_Id", c => c.Int());
            CreateIndex("dbo.Avatars", "Message_Id");
            CreateIndex("dbo.Photos", "Message_Id");
            AddForeignKey("dbo.Photos", "Message_Id", "dbo.Messages", "Id");
            AddForeignKey("dbo.Avatars", "Message_Id", "dbo.Messages", "Id");
        }
    }
}
