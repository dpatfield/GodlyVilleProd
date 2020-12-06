namespace GodlyVilleProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayDomainModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        DurationInMinutes = c.Byte(),
                        NumberOfActs = c.Byte(nullable: false),
                        IsMusical = c.Boolean(nullable: false),
                        Description = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plays");
        }
    }
}
