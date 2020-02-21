namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUncertaintyBudgetTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contributions", "UncertaintyBudgets_IdNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contributions", "UncertaintyBudgets_IdNumber");
        }
    }
}
