namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LikePhotoPhotoes", "LikePhoto_Id", "dbo.LikePhotoes");
            DropForeignKey("dbo.LikePhotoPhotoes", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.UserLikePhotoes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserLikePhotoes", "LikePhoto_Id", "dbo.LikePhotoes");
            DropIndex("dbo.LikePhotoPhotoes", new[] { "LikePhoto_Id" });
            DropIndex("dbo.LikePhotoPhotoes", new[] { "Photo_Id" });
            DropIndex("dbo.UserLikePhotoes", new[] { "User_Id" });
            DropIndex("dbo.UserLikePhotoes", new[] { "LikePhoto_Id" });
            CreateIndex("dbo.LikePhotoes", "PhotoId");
            CreateIndex("dbo.LikePhotoes", "UserId");
            AddForeignKey("dbo.LikePhotoes", "PhotoId", "dbo.Photos", "Id", cascadeDelete: false);
            AddForeignKey("dbo.LikePhotoes", "UserId", "dbo.Users", "Id", cascadeDelete: false);
            DropTable("dbo.LikePhotoPhotoes");
            DropTable("dbo.UserLikePhotoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserLikePhotoes",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        LikePhoto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.LikePhoto_Id });
            
            CreateTable(
                "dbo.LikePhotoPhotoes",
                c => new
                    {
                        LikePhoto_Id = c.Int(nullable: false),
                        Photo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LikePhoto_Id, t.Photo_Id });
            
            DropForeignKey("dbo.LikePhotoes", "UserId", "dbo.Users");
            DropForeignKey("dbo.LikePhotoes", "PhotoId", "dbo.Photos");
            DropIndex("dbo.LikePhotoes", new[] { "UserId" });
            DropIndex("dbo.LikePhotoes", new[] { "PhotoId" });
            CreateIndex("dbo.UserLikePhotoes", "LikePhoto_Id");
            CreateIndex("dbo.UserLikePhotoes", "User_Id");
            CreateIndex("dbo.LikePhotoPhotoes", "Photo_Id");
            CreateIndex("dbo.LikePhotoPhotoes", "LikePhoto_Id");
            AddForeignKey("dbo.UserLikePhotoes", "LikePhoto_Id", "dbo.LikePhotoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserLikePhotoes", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LikePhotoPhotoes", "Photo_Id", "dbo.Photos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LikePhotoPhotoes", "LikePhoto_Id", "dbo.LikePhotoes", "Id", cascadeDelete: true);
        }
    }
}
