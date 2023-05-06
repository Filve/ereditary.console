namespace ereditarycode.console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eredity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFatherAndMotherFirstChild = c.String(),
                        OriginalWifeOfFirstChildOfOriginalFatherAndMotherOfChildren = c.String(),
                        Childs_Id = c.Int(),
                        firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Childs_Id)
                .ForeignKey("dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers", t => t.firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id)
                .Index(t => t.Childs_Id)
                .Index(t => t.firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id);
            
            CreateTable(
                "dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstChildFatherAndMotherFirstChild = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstChildFatherAndMotherFirstChild = c.String(),
                        SecondChildFatherAndMotherFirstChild = c.String(),
                        ThirdChildFatherAndMotherFirstChild = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFather = c.String(),
                        OriginalMother = c.String(),
                        originalFatherAndMotherChilds_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OriginalFatherAndMotherChilds", t => t.originalFatherAndMotherChilds_Id)
                .Index(t => t.originalFatherAndMotherChilds_Id);
            
            CreateTable(
                "dbo.OriginalFatherAndMotherChilds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFatherAndMotherFirstChild = c.String(),
                        OriginalFatherAndMotherSecondChild = c.String(),
                        OriginalFatherAndMotherThirdChild = c.String(),
                        firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id = c.Int(),
                        secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id = c.Int(),
                        thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", t => t.firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id)
                .ForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", t => t.secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id)
                .ForeignKey("dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers", t => t.thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id)
                .Index(t => t.firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id)
                .Index(t => t.secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id)
                .Index(t => t.thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id);
            
            CreateTable(
                "dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFatherAndMotherSecondChild = c.String(),
                        OriginalWifeOfSecondChildOfOriginalFatherAndMotherOfChildren = c.String(),
                        Childs_Id = c.Int(),
                        firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Childs_Id)
                .ForeignKey("dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers", t => t.firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id)
                .Index(t => t.Childs_Id)
                .Index(t => t.firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id);
            
            CreateTable(
                "dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecondChildFatherAndMotherFirstChild = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThirdChildFatherAndMotherFirstChild = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupremeEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SupremeEntities", t => t.SupremeEntity_Id)
                .Index(t => t.SupremeEntity_Id);
            
            CreateTable(
                "dbo.SupremeEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        supremeEntity = c.String(),
                        Childs_Id = c.Int(),
                        OriginalFatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Childs_Id)
                .ForeignKey("dbo.OriginalFatherAndMothers", t => t.OriginalFatherAndMother_Id)
                .Index(t => t.Childs_Id)
                .Index(t => t.OriginalFatherAndMother_Id);
            
            CreateTable(
                "dbo.OriginalWifeFromOtherFamilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalWifeOfFirstChildOfOriginalFatherAndMotherOfChildren = c.String(),
                        OriginalWifeOfSecondChildOfOriginalFatherAndMotherOfChildren = c.String(),
                        OriginalWifeOfThirdChildOfOriginalFatherAndMotherOfChildren = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "SupremeEntity_Id", "dbo.SupremeEntities");
            DropForeignKey("dbo.SupremeEntities", "OriginalFatherAndMother_Id", "dbo.OriginalFatherAndMothers");
            DropForeignKey("dbo.SupremeEntities", "Childs_Id", "dbo.Children");
            DropForeignKey("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id", "dbo.OriginalFatherAndMotherChilds");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children");
            DropIndex("dbo.SupremeEntities", new[] { "OriginalFatherAndMother_Id" });
            DropIndex("dbo.SupremeEntities", new[] { "Childs_Id" });
            DropIndex("dbo.Models", new[] { "SupremeEntity_Id" });
            DropIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "Childs_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMothers", new[] { "originalFatherAndMotherChilds_Id" });
            DropIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "Childs_Id" });
            DropTable("dbo.OriginalWifeFromOtherFamilies");
            DropTable("dbo.SupremeEntities");
            DropTable("dbo.Models");
            DropTable("dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.OriginalFatherAndMotherChilds");
            DropTable("dbo.OriginalFatherAndMothers");
            DropTable("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.Children");
        }
    }
}
