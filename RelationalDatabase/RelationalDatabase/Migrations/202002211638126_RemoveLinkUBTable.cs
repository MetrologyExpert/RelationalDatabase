namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLinkUBTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contributions", "UncertaintyBudgets_IdNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contributions", "UncertaintyBudgets_IdNumber", c => c.Int(nullable: false));
        }
    }
}
