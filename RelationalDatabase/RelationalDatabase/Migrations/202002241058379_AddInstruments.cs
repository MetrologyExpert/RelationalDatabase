namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstruments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instruments",
                c => new
                    {
                        InstrumentId = c.Int(nullable: false, identity: true),
                        InstrumentName = c.String(),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        Specification = c.String(),
                    })
                .PrimaryKey(t => t.InstrumentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Instruments");
        }
    }
}
