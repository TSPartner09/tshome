namespace TimeSculpting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequstConsultation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsultationRequests",
                c => new
                    {
                        ConsultationRequestId = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(nullable: false),
                        DateOfRequest = c.DateTime(nullable: false),
                        Description = c.String(),
                        IPAddress = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ConsultationRequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConsultationRequests");
        }
    }
}
