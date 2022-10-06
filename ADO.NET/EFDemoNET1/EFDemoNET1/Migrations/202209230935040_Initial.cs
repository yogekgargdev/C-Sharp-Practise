namespace EFDemoNET1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Medicine",
                c => new
                    {
                        MID = c.Int(nullable: false),
                        MName = c.String(),
                        ExpiryDate = c.DateTime(nullable: false),
                        Price = c.Single(),
                        Quantity = c.Int(),
                    })
                .PrimaryKey(t => t.MID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tbl_Medicine");
        }
    }
}
