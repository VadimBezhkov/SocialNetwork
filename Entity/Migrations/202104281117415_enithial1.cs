namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enithial1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Albums", new[] { "UserId" });
            AlterColumn("dbo.Albums", "UserId", c => c.Int());
            CreateIndex("dbo.Albums", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Albums", new[] { "UserId" });
            AlterColumn("dbo.Albums", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Albums", "UserId");
        }
    }
}
