namespace TimeSculpting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequestConsultationAddressLines : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConsultationRequests", "Address1", c => c.String());
            AddColumn("dbo.ConsultationRequests", "Address2", c => c.String());
            AlterColumn("dbo.ConsultationRequests", "EmailAddress", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ConsultationRequests", "EmailAddress", c => c.String(nullable: false));
            DropColumn("dbo.ConsultationRequests", "Address2");
            DropColumn("dbo.ConsultationRequests", "Address1");
        }
    }
}
