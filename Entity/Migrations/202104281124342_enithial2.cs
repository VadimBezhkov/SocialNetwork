namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enithial2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Photos", new[] { "AlbumId" });
            DropIndex("dbo.LikePhotoes", new[] { "PhotoId" });
            DropIndex("dbo.LikePhotoes", new[] { "UserId" });
            DropIndex("dbo.Avatars", new[] { "UserId" });
            DropIndex("dbo.LikeAvatar", new[] { "AvatarId" });
            DropIndex("dbo.LikeAvatar", new[] { "UserId" });
            DropIndex("dbo.MessageAvatars", new[] { "AvatarId" });
            DropIndex("dbo.MessageAvatars", new[] { "MessageId" });
            DropIndex("dbo.Messages", new[] { "DialogId" });
            DropIndex("dbo.UserDialogs", new[] { "UserId" });
            DropIndex("dbo.UserDialogs", new[] { "DialogId" });
            DropIndex("dbo.Friends", new[] { "User1Id" });
            DropIndex("dbo.Friends", new[] { "User2Id" });
            DropIndex("dbo.PhotoMessages", new[] { "PhotoId" });
            DropIndex("dbo.PhotoMessages", new[] { "MessageId" });
            AlterColumn("dbo.Photos", "AlbumId", c => c.Int());
            AlterColumn("dbo.LikePhotoes", "PhotoId", c => c.Int());
            AlterColumn("dbo.LikePhotoes", "UserId", c => c.Int());
            AlterColumn("dbo.Avatars", "UserId", c => c.Int());
            AlterColumn("dbo.LikeAvatar", "AvatarId", c => c.Int());
            AlterColumn("dbo.LikeAvatar", "UserId", c => c.Int());
            AlterColumn("dbo.MessageAvatars", "AvatarId", c => c.Int());
            AlterColumn("dbo.MessageAvatars", "MessageId", c => c.Int());
            AlterColumn("dbo.Messages", "DialogId", c => c.Int());
            AlterColumn("dbo.UserDialogs", "UserId", c => c.Int());
            AlterColumn("dbo.UserDialogs", "DialogId", c => c.Int());
            AlterColumn("dbo.Friends", "User1Id", c => c.Int());
            AlterColumn("dbo.Friends", "User2Id", c => c.Int());
            AlterColumn("dbo.PhotoMessages", "PhotoId", c => c.Int());
            AlterColumn("dbo.PhotoMessages", "MessageId", c => c.Int());
            CreateIndex("dbo.Photos", "AlbumId");
            CreateIndex("dbo.LikePhotoes", "PhotoId");
            CreateIndex("dbo.LikePhotoes", "UserId");
            CreateIndex("dbo.Avatars", "UserId");
            CreateIndex("dbo.LikeAvatar", "AvatarId");
            CreateIndex("dbo.LikeAvatar", "UserId");
            CreateIndex("dbo.MessageAvatars", "AvatarId");
            CreateIndex("dbo.MessageAvatars", "MessageId");
            CreateIndex("dbo.Messages", "DialogId");
            CreateIndex("dbo.UserDialogs", "UserId");
            CreateIndex("dbo.UserDialogs", "DialogId");
            CreateIndex("dbo.Friends", "User1Id");
            CreateIndex("dbo.Friends", "User2Id");
            CreateIndex("dbo.PhotoMessages", "PhotoId");
            CreateIndex("dbo.PhotoMessages", "MessageId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhotoMessages", new[] { "MessageId" });
            DropIndex("dbo.PhotoMessages", new[] { "PhotoId" });
            DropIndex("dbo.Friends", new[] { "User2Id" });
            DropIndex("dbo.Friends", new[] { "User1Id" });
            DropIndex("dbo.UserDialogs", new[] { "DialogId" });
            DropIndex("dbo.UserDialogs", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "DialogId" });
            DropIndex("dbo.MessageAvatars", new[] { "MessageId" });
            DropIndex("dbo.MessageAvatars", new[] { "AvatarId" });
            DropIndex("dbo.LikeAvatar", new[] { "UserId" });
            DropIndex("dbo.LikeAvatar", new[] { "AvatarId" });
            DropIndex("dbo.Avatars", new[] { "UserId" });
            DropIndex("dbo.LikePhotoes", new[] { "UserId" });
            DropIndex("dbo.LikePhotoes", new[] { "PhotoId" });
            DropIndex("dbo.Photos", new[] { "AlbumId" });
            AlterColumn("dbo.PhotoMessages", "MessageId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhotoMessages", "PhotoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Friends", "User2Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Friends", "User1Id", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDialogs", "DialogId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDialogs", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Messages", "DialogId", c => c.Int(nullable: false));
            AlterColumn("dbo.MessageAvatars", "MessageId", c => c.Int(nullable: false));
            AlterColumn("dbo.MessageAvatars", "AvatarId", c => c.Int(nullable: false));
            AlterColumn("dbo.LikeAvatar", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.LikeAvatar", "AvatarId", c => c.Int(nullable: false));
            AlterColumn("dbo.Avatars", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.LikePhotoes", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.LikePhotoes", "PhotoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Photos", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.PhotoMessages", "MessageId");
            CreateIndex("dbo.PhotoMessages", "PhotoId");
            CreateIndex("dbo.Friends", "User2Id");
            CreateIndex("dbo.Friends", "User1Id");
            CreateIndex("dbo.UserDialogs", "DialogId");
            CreateIndex("dbo.UserDialogs", "UserId");
            CreateIndex("dbo.Messages", "DialogId");
            CreateIndex("dbo.MessageAvatars", "MessageId");
            CreateIndex("dbo.MessageAvatars", "AvatarId");
            CreateIndex("dbo.LikeAvatar", "UserId");
            CreateIndex("dbo.LikeAvatar", "AvatarId");
            CreateIndex("dbo.Avatars", "UserId");
            CreateIndex("dbo.LikePhotoes", "UserId");
            CreateIndex("dbo.LikePhotoes", "PhotoId");
            CreateIndex("dbo.Photos", "AlbumId");
        }
    }
}
