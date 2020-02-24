namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPdfs0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pdfs",
                c => new
                    {
                        PdfId = c.Int(nullable: false, identity: true),
                        PdfName = c.String(),
                        Coefficient = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PdfId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pdfs");
        }
    }
}
