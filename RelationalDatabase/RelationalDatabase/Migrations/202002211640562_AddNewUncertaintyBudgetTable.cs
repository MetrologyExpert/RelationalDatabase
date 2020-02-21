namespace RelationalDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewUncertaintyBudgetTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UncertaintyBudgets",
                c => new
                    {
                        IdNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UncertaintyBudgets");
        }
    }
}
