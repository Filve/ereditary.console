namespace ereditarycode.console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbEredity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children");
            DropForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children");
            DropForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.OriginalFatherAndMotherChilds", "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id", "dbo.OriginalFatherAndMotherChilds");
            DropForeignKey("dbo.Models", "SupremeEntity_Id", "dbo.SupremeEntities");
            DropIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "Childs_Id" });
            DropIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMothers", new[] { "originalFatherAndMotherChilds_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChilds", new[] { "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "Childs_Id" });
            DropIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id" });
            DropIndex("dbo.Models", new[] { "SupremeEntity_Id" });
            RenameColumn(table: "dbo.SupremeEntities", name: "OriginalFatherAndMother_Id", newName: "orgnlFatherAndMother_Id");
            RenameIndex(table: "dbo.SupremeEntities", name: "IX_OriginalFatherAndMother_Id", newName: "IX_orgnlFatherAndMother_Id");
            CreateTable(
                "dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        Childs_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Childs_Id)
                .Index(t => t.Childs_Id);
            
            CreateTable(
                "dbo.OriginalChildrenFromFamilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OriginalFatherAndMotherChildrens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", t => t.orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id)
                .Index(t => t.orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id);
            
            CreateTable(
                "dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        Childs_Id = c.Int(),
                        orgnlChildrenHousbandAndWife_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Childs_Id)
                .ForeignKey("dbo.OriginalChildrenFromFamilies", t => t.orgnlChildrenHousbandAndWife_Id)
                .Index(t => t.Childs_Id)
                .Index(t => t.orgnlChildrenHousbandAndWife_Id);
            
            CreateTable(
                "dbo.EredityModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompleteName = c.String(),
                        orgnlChildren_Id = c.Int(),
                        orgnlChildrenFromFamily_Id = c.Int(),
                        orgnlChildrenHousbandAndWifeFromOriginal_Id = c.Int(),
                        orgnlFatherAndMother_Id = c.Int(),
                        orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id = c.Int(),
                        orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id = c.Int(),
                        orgnlWifesOfChildren_Id = c.Int(),
                        SupremeEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OriginalFatherAndMotherChildrens", t => t.orgnlChildren_Id)
                .ForeignKey("dbo.OriginalChildrenFromFamilies", t => t.orgnlChildrenFromFamily_Id)
                .ForeignKey("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", t => t.orgnlChildrenHousbandAndWifeFromOriginal_Id)
                .ForeignKey("dbo.OriginalFatherAndMothers", t => t.orgnlFatherAndMother_Id)
                .ForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers", t => t.orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id)
                .ForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", t => t.orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id)
                .ForeignKey("dbo.OriginalWifeFromOtherFamilies", t => t.orgnlWifesOfChildren_Id)
                .ForeignKey("dbo.SupremeEntities", t => t.SupremeEntity_Id)
                .Index(t => t.orgnlChildren_Id)
                .Index(t => t.orgnlChildrenFromFamily_Id)
                .Index(t => t.orgnlChildrenHousbandAndWifeFromOriginal_Id)
                .Index(t => t.orgnlFatherAndMother_Id)
                .Index(t => t.orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id)
                .Index(t => t.orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id)
                .Index(t => t.orgnlWifesOfChildren_Id)
                .Index(t => t.SupremeEntity_Id);
            
            AddColumn("dbo.Children", "Name", c => c.String());
            AddColumn("dbo.Children", "Surname", c => c.String());
            AddColumn("dbo.Children", "ParentalBond", c => c.String());
            AddColumn("dbo.Children", "Parental", c => c.Int());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Name", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Surname", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "ParentalBond", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Parental", c => c.Int());
            AddColumn("dbo.OriginalFatherAndMothers", "OriginalFatherCompleteName", c => c.String());
            AddColumn("dbo.OriginalFatherAndMothers", "OriginalMotherCompleteSurname", c => c.String());
            AddColumn("dbo.OriginalFatherAndMothers", "ParentalChild", c => c.String());
            AddColumn("dbo.OriginalFatherAndMothers", "orgnlFatherAndMotherChilds_Id", c => c.Int());
            AddColumn("dbo.SupremeEntities", "Name", c => c.String());
            AddColumn("dbo.SupremeEntities", "Surname", c => c.String());
            AddColumn("dbo.SupremeEntities", "ParentalBond", c => c.String());
            AddColumn("dbo.SupremeEntities", "Parental", c => c.Int());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "Name", c => c.String());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "Surname", c => c.String());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "ParentalBond", c => c.String());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "Parental", c => c.Int());
            CreateIndex("dbo.OriginalFatherAndMothers", "orgnlFatherAndMotherChilds_Id");
            AddForeignKey("dbo.OriginalFatherAndMothers", "orgnlFatherAndMotherChilds_Id", "dbo.OriginalFatherAndMotherChildrens", "Id");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "FirstChildFatherAndMotherFirstChild");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "SecondChildFatherAndMotherFirstChild");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "ThirdChildFatherAndMotherFirstChild");
            DropColumn("dbo.OriginalFatherAndMothers", "OriginalFather");
            DropColumn("dbo.OriginalFatherAndMothers", "OriginalMother");
            DropColumn("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id");
            DropColumn("dbo.SupremeEntities", "supremeEntity");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfFirstChildOfOriginalFatherAndMotherOfChildren");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfSecondChildOfOriginalFatherAndMotherOfChildren");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfThirdChildOfOriginalFatherAndMotherOfChildren");
            DropTable("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.OriginalFatherAndMotherChilds");
            DropTable("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers");
            DropTable("dbo.Models");
            CreateStoredProcedure(
                "dbo.EredityModel_Insert",
                p => new
                    {
                        CompleteName = p.String(),
                        orgnlChildren_Id = p.Int(),
                        orgnlChildrenFromFamily_Id = p.Int(),
                        orgnlChildrenHousbandAndWifeFromOriginal_Id = p.Int(),
                        orgnlFatherAndMother_Id = p.Int(),
                        orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id = p.Int(),
                        orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id = p.Int(),
                        orgnlWifesOfChildren_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[EredityModels]([CompleteName], [orgnlChildren_Id], [orgnlChildrenFromFamily_Id], [orgnlChildrenHousbandAndWifeFromOriginal_Id], [orgnlFatherAndMother_Id], [orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id], [orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id], [orgnlWifesOfChildren_Id], [SupremeEntity_Id])
                      VALUES (@CompleteName, @orgnlChildren_Id, @orgnlChildrenFromFamily_Id, @orgnlChildrenHousbandAndWifeFromOriginal_Id, @orgnlFatherAndMother_Id, @orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id, @orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id, @orgnlWifesOfChildren_Id, @SupremeEntity_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[EredityModels]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[EredityModels] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.EredityModel_Update",
                p => new
                    {
                        Id = p.Int(),
                        CompleteName = p.String(),
                        orgnlChildren_Id = p.Int(),
                        orgnlChildrenFromFamily_Id = p.Int(),
                        orgnlChildrenHousbandAndWifeFromOriginal_Id = p.Int(),
                        orgnlFatherAndMother_Id = p.Int(),
                        orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id = p.Int(),
                        orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id = p.Int(),
                        orgnlWifesOfChildren_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[EredityModels]
                      SET [CompleteName] = @CompleteName, [orgnlChildren_Id] = @orgnlChildren_Id, [orgnlChildrenFromFamily_Id] = @orgnlChildrenFromFamily_Id, [orgnlChildrenHousbandAndWifeFromOriginal_Id] = @orgnlChildrenHousbandAndWifeFromOriginal_Id, [orgnlFatherAndMother_Id] = @orgnlFatherAndMother_Id, [orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id] = @orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id, [orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id] = @orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id, [orgnlWifesOfChildren_Id] = @orgnlWifesOfChildren_Id, [SupremeEntity_Id] = @SupremeEntity_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.EredityModel_Delete",
                p => new
                    {
                        Id = p.Int(),
                        orgnlChildren_Id = p.Int(),
                        orgnlChildrenFromFamily_Id = p.Int(),
                        orgnlChildrenHousbandAndWifeFromOriginal_Id = p.Int(),
                        orgnlFatherAndMother_Id = p.Int(),
                        orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id = p.Int(),
                        orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id = p.Int(),
                        orgnlWifesOfChildren_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[EredityModels]
                      WHERE ((((((((([Id] = @Id) AND (([orgnlChildren_Id] = @orgnlChildren_Id) OR ([orgnlChildren_Id] IS NULL AND @orgnlChildren_Id IS NULL))) AND (([orgnlChildrenFromFamily_Id] = @orgnlChildrenFromFamily_Id) OR ([orgnlChildrenFromFamily_Id] IS NULL AND @orgnlChildrenFromFamily_Id IS NULL))) AND (([orgnlChildrenHousbandAndWifeFromOriginal_Id] = @orgnlChildrenHousbandAndWifeFromOriginal_Id) OR ([orgnlChildrenHousbandAndWifeFromOriginal_Id] IS NULL AND @orgnlChildrenHousbandAndWifeFromOriginal_Id IS NULL))) AND (([orgnlFatherAndMother_Id] = @orgnlFatherAndMother_Id) OR ([orgnlFatherAndMother_Id] IS NULL AND @orgnlFatherAndMother_Id IS NULL))) AND (([orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id] = @orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id) OR ([orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id] IS NULL AND @orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id IS NULL))) AND (([orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id] = @orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id) OR ([orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id] IS NULL AND @orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id IS NULL))) AND (([orgnlWifesOfChildren_Id] = @orgnlWifesOfChildren_Id) OR ([orgnlWifesOfChildren_Id] IS NULL AND @orgnlWifesOfChildren_Id IS NULL))) AND (([SupremeEntity_Id] = @SupremeEntity_Id) OR ([SupremeEntity_Id] IS NULL AND @SupremeEntity_Id IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EredityModel_Delete");
            DropStoredProcedure("dbo.EredityModel_Update");
            DropStoredProcedure("dbo.EredityModel_Insert");
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupremeEntity_Id = c.Int(),
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
                "dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecondChildFatherAndMotherFirstChild = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstChildFatherAndMotherFirstChild = c.String(),
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfThirdChildOfOriginalFatherAndMotherOfChildren", c => c.String());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfSecondChildOfOriginalFatherAndMotherOfChildren", c => c.String());
            AddColumn("dbo.OriginalWifeFromOtherFamilies", "OriginalWifeOfFirstChildOfOriginalFatherAndMotherOfChildren", c => c.String());
            AddColumn("dbo.SupremeEntities", "supremeEntity", c => c.String());
            AddColumn("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id", c => c.Int());
            AddColumn("dbo.OriginalFatherAndMothers", "OriginalMother", c => c.String());
            AddColumn("dbo.OriginalFatherAndMothers", "OriginalFather", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "ThirdChildFatherAndMotherFirstChild", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "SecondChildFatherAndMotherFirstChild", c => c.String());
            AddColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "FirstChildFatherAndMotherFirstChild", c => c.String());
            DropForeignKey("dbo.EredityModels", "SupremeEntity_Id", "dbo.SupremeEntities");
            DropForeignKey("dbo.EredityModels", "orgnlWifesOfChildren_Id", "dbo.OriginalWifeFromOtherFamilies");
            DropForeignKey("dbo.EredityModels", "orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id", "dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies");
            DropForeignKey("dbo.EredityModels", "orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id", "dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.EredityModels", "orgnlFatherAndMother_Id", "dbo.OriginalFatherAndMothers");
            DropForeignKey("dbo.EredityModels", "orgnlChildrenHousbandAndWifeFromOriginal_Id", "dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers");
            DropForeignKey("dbo.EredityModels", "orgnlChildrenFromFamily_Id", "dbo.OriginalChildrenFromFamilies");
            DropForeignKey("dbo.EredityModels", "orgnlChildren_Id", "dbo.OriginalFatherAndMotherChildrens");
            DropForeignKey("dbo.OriginalFatherAndMothers", "orgnlFatherAndMotherChilds_Id", "dbo.OriginalFatherAndMotherChildrens");
            DropForeignKey("dbo.OriginalFatherAndMotherChildrens", "orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id", "dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies");
            DropForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", "orgnlChildrenHousbandAndWife_Id", "dbo.OriginalChildrenFromFamilies");
            DropForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", "Childs_Id", "dbo.Children");
            DropForeignKey("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children");
            DropIndex("dbo.EredityModels", new[] { "SupremeEntity_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlWifesOfChildren_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlFatherAndMother_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlChildrenHousbandAndWifeFromOriginal_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlChildrenFromFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "orgnlChildren_Id" });
            DropIndex("dbo.OriginalFatherAndMothers", new[] { "orgnlFatherAndMotherChilds_Id" });
            DropIndex("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", new[] { "orgnlChildrenHousbandAndWife_Id" });
            DropIndex("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies", new[] { "Childs_Id" });
            DropIndex("dbo.OriginalFatherAndMotherChildrens", new[] { "orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily_Id" });
            DropIndex("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers", new[] { "Childs_Id" });
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "Parental");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "ParentalBond");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "Surname");
            DropColumn("dbo.OriginalWifeFromOtherFamilies", "Name");
            DropColumn("dbo.SupremeEntities", "Parental");
            DropColumn("dbo.SupremeEntities", "ParentalBond");
            DropColumn("dbo.SupremeEntities", "Surname");
            DropColumn("dbo.SupremeEntities", "Name");
            DropColumn("dbo.OriginalFatherAndMothers", "orgnlFatherAndMotherChilds_Id");
            DropColumn("dbo.OriginalFatherAndMothers", "ParentalChild");
            DropColumn("dbo.OriginalFatherAndMothers", "OriginalMotherCompleteSurname");
            DropColumn("dbo.OriginalFatherAndMothers", "OriginalFatherCompleteName");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Parental");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "ParentalBond");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Surname");
            DropColumn("dbo.OriginalChildOfHousbandAndWifeFromOriginalFatherAndMothers", "Name");
            DropColumn("dbo.Children", "Parental");
            DropColumn("dbo.Children", "ParentalBond");
            DropColumn("dbo.Children", "Surname");
            DropColumn("dbo.Children", "Name");
            DropTable("dbo.EredityModels");
            DropTable("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamilies");
            DropTable("dbo.OriginalFatherAndMotherChildrens");
            DropTable("dbo.OriginalChildrenFromFamilies");
            DropTable("dbo.OriginalHousbandAndWifeFromOriginalFatherAndMothers");
            RenameIndex(table: "dbo.SupremeEntities", name: "IX_orgnlFatherAndMother_Id", newName: "IX_OriginalFatherAndMother_Id");
            RenameColumn(table: "dbo.SupremeEntities", name: "orgnlFatherAndMother_Id", newName: "OriginalFatherAndMother_Id");
            CreateIndex("dbo.Models", "SupremeEntity_Id");
            CreateIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id");
            CreateIndex("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id");
            CreateIndex("dbo.OriginalFatherAndMotherChilds", "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id");
            CreateIndex("dbo.OriginalFatherAndMotherChilds", "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id");
            CreateIndex("dbo.OriginalFatherAndMotherChilds", "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id");
            CreateIndex("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id");
            CreateIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id");
            CreateIndex("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id");
            AddForeignKey("dbo.Models", "SupremeEntity_Id", "dbo.SupremeEntities", "Id");
            AddForeignKey("dbo.OriginalFatherAndMothers", "originalFatherAndMotherChilds_Id", "dbo.OriginalFatherAndMotherChilds", "Id");
            AddForeignKey("dbo.OriginalFatherAndMotherChilds", "thirdChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.ThirdChildrenHousbandAndWifeFromOriginalFatherAndMothers", "Id");
            AddForeignKey("dbo.OriginalFatherAndMotherChilds", "secondOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Id");
            AddForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.SecondChildrenHousbandAndWifeFromOriginalFatherAndMothers", "Id");
            AddForeignKey("dbo.SecondOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children", "Id");
            AddForeignKey("dbo.OriginalFatherAndMotherChilds", "firstOriginalHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Id");
            AddForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "firstChildrenHousbandAndWifeFromOriginalFatherAndMother_Id", "dbo.FirstChildrenHousbandAndWifeFromOriginalFatherAndMothers", "Id");
            AddForeignKey("dbo.FirstOriginalHousbandAndWifeFromOriginalFatherAndMothers", "Childs_Id", "dbo.Children", "Id");
        }
    }
}
