namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UncertaintyBudgets", "IdInstrument", c => c.Int(nullable: false));
            DropColumn("dbo.UncertaintyBudgets", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UncertaintyBudgets", "Name", c => c.String());
            DropColumn("dbo.UncertaintyBudgets", "IdInstrument");
        }
    }
}
