namespace TimeSculpting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitProjet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
