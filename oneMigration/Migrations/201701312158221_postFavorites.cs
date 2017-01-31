namespace oneMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postFavorites : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Favorites", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Favorites");
        }
    }
}
