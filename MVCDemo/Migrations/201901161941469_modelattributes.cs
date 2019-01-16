namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelattributes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "Id");
            AddForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "Id");
            AddForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
