namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        UserId = c.Int(nullable: false),
                        TimeCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 50),
                        AlbumId = c.Int(nullable: false),
                        TimeCreation = c.DateTime(nullable: false),
                        Message_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Messages", t => t.Message_Id)
                .Index(t => t.AlbumId)
                .Index(t => t.Message_Id);
            
            CreateTable(
                "dbo.LikePhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Сondition = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SecondName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 30),
                        Login = c.String(nullable: false, maxLength: 30),
                        DateBirth = c.DateTime(),
                        TimeRegistration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Avatars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        path = c.String(nullable: false, maxLength: 50),
                        Active = c.Boolean(nullable: false),
                        Message_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Messages", t => t.Message_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Message_Id);
            
            CreateTable(
                "dbo.LikeAvatar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AvatarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Сondition = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Avatars", t => t.AvatarId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.AvatarId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.MessageAvatars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AvatarId = c.Int(nullable: false),
                        MessageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Avatars", t => t.AvatarId, cascadeDelete: true)
                .ForeignKey("dbo.Messages", t => t.MessageId, cascadeDelete: true)
                .Index(t => t.AvatarId)
                .Index(t => t.MessageId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DialogId = c.Int(nullable: false),
                        Text = c.String(nullable: false, unicode: false, storeType: "text"),
                        TextChanged = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dialogs", t => t.DialogId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.DialogId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Dialogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TimeCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserDialogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DialogId = c.Int(nullable: false),
                        TimeCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dialogs", t => t.DialogId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.DialogId);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User1Id = c.Int(nullable: false),
                        User2Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User1Id, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.User2Id, cascadeDelete: false)
                .Index(t => t.User1Id)
                .Index(t => t.User2Id);
            
            CreateTable(
                "dbo.PhotoMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoId = c.Int(nullable: false),
                        MessageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Messages", t => t.MessageId, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .Index(t => t.PhotoId)
                .Index(t => t.MessageId);
            
            CreateTable(
                "dbo.LikePhotoPhotoes",
                c => new
                    {
                        LikePhoto_Id = c.Int(nullable: false),
                        Photo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LikePhoto_Id, t.Photo_Id })
                .ForeignKey("dbo.LikePhotoes", t => t.LikePhoto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.Photo_Id, cascadeDelete: true)
                .Index(t => t.LikePhoto_Id)
                .Index(t => t.Photo_Id);
            
            CreateTable(
                "dbo.UserLikePhotoes",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        LikePhoto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.LikePhoto_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.LikePhotoes", t => t.LikePhoto_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.LikePhoto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhotoMessages", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.PhotoMessages", "MessageId", "dbo.Messages");
            DropForeignKey("dbo.Messages", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserLikePhotoes", "LikePhoto_Id", "dbo.LikePhotoes");
            DropForeignKey("dbo.UserLikePhotoes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Friends", "User2Id", "dbo.Users");
            DropForeignKey("dbo.Friends", "User1Id", "dbo.Users");
            DropForeignKey("dbo.Avatars", "UserId", "dbo.Users");
            DropForeignKey("dbo.MessageAvatars", "MessageId", "dbo.Messages");
            DropForeignKey("dbo.Photos", "Message_Id", "dbo.Messages");
            DropForeignKey("dbo.UserDialogs", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserDialogs", "DialogId", "dbo.Dialogs");
            DropForeignKey("dbo.Messages", "DialogId", "dbo.Dialogs");
            DropForeignKey("dbo.Avatars", "Message_Id", "dbo.Messages");
            DropForeignKey("dbo.MessageAvatars", "AvatarId", "dbo.Avatars");
            DropForeignKey("dbo.LikeAvatar", "UserId", "dbo.Users");
            DropForeignKey("dbo.LikeAvatar", "AvatarId", "dbo.Avatars");
            DropForeignKey("dbo.Albums", "UserId", "dbo.Users");
            DropForeignKey("dbo.LikePhotoPhotoes", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.LikePhotoPhotoes", "LikePhoto_Id", "dbo.LikePhotoes");
            DropForeignKey("dbo.Photos", "AlbumId", "dbo.Albums");
            DropIndex("dbo.UserLikePhotoes", new[] { "LikePhoto_Id" });
            DropIndex("dbo.UserLikePhotoes", new[] { "User_Id" });
            DropIndex("dbo.LikePhotoPhotoes", new[] { "Photo_Id" });
            DropIndex("dbo.LikePhotoPhotoes", new[] { "LikePhoto_Id" });
            DropIndex("dbo.PhotoMessages", new[] { "MessageId" });
            DropIndex("dbo.PhotoMessages", new[] { "PhotoId" });
            DropIndex("dbo.Friends", new[] { "User2Id" });
            DropIndex("dbo.Friends", new[] { "User1Id" });
            DropIndex("dbo.UserDialogs", new[] { "DialogId" });
            DropIndex("dbo.UserDialogs", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "User_Id" });
            DropIndex("dbo.Messages", new[] { "DialogId" });
            DropIndex("dbo.MessageAvatars", new[] { "MessageId" });
            DropIndex("dbo.MessageAvatars", new[] { "AvatarId" });
            DropIndex("dbo.LikeAvatar", new[] { "UserId" });
            DropIndex("dbo.LikeAvatar", new[] { "AvatarId" });
            DropIndex("dbo.Avatars", new[] { "Message_Id" });
            DropIndex("dbo.Avatars", new[] { "UserId" });
            DropIndex("dbo.Photos", new[] { "Message_Id" });
            DropIndex("dbo.Photos", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "UserId" });
            DropTable("dbo.UserLikePhotoes");
            DropTable("dbo.LikePhotoPhotoes");
            DropTable("dbo.PhotoMessages");
            DropTable("dbo.Friends");
            DropTable("dbo.UserDialogs");
            DropTable("dbo.Dialogs");
            DropTable("dbo.Messages");
            DropTable("dbo.MessageAvatars");
            DropTable("dbo.LikeAvatar");
            DropTable("dbo.Avatars");
            DropTable("dbo.Users");
            DropTable("dbo.LikePhotoes");
            DropTable("dbo.Photos");
            DropTable("dbo.Albums");
        }
    }
}
