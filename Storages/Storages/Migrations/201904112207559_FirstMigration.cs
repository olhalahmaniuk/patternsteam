namespace Storages.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserId = c.Int(),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        ContactPhone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(),
                        Description = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.String(maxLength: 50),
                        Description = c.String(maxLength: 300),
                        DateFrom = c.DateTime(precision: 7, storeType: "datetime2"),
                        DateTo = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Location = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Container",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Size = c.String(nullable: false, maxLength: 50),
                        Location = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Storage", t => t.StorageId)
                .Index(t => t.StorageId);
            
            CreateTable(
                "dbo.Storage",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Location = c.String(nullable: false, maxLength: 50),
                        FreeSpace = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Garage",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        FreeSpace = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Size = c.String(nullable: false, maxLength: 50),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(maxLength: 300),
                        DateFrom = c.DateTime(precision: 7, storeType: "datetime2"),
                        DateTo = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                        GarageId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Freespace = c.String(nullable: false, maxLength: 50),
                        Location = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 300),
                        Available = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Container", "StorageId", "dbo.Storage");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Client", "UserId", "dbo.User");
            DropForeignKey("dbo.Order", "ClientId", "dbo.Client");
            DropIndex("dbo.Container", new[] { "StorageId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.Order", new[] { "ClientId" });
            DropIndex("dbo.Client", new[] { "UserId" });
            DropTable("dbo.Transport");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.ProductType");
            DropTable("dbo.Product");
            DropTable("dbo.Garage");
            DropTable("dbo.Storage");
            DropTable("dbo.Container");
            DropTable("dbo.Company");
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.Order");
            DropTable("dbo.Client");
        }
    }
}
