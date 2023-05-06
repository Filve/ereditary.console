namespace ereditarycode.console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbEredity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SecondGenerationChildrenOfFamilies",
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
                "dbo.FirstGenerationHousbandAndWives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        secondGenerationChildren_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SecondGenerationChildrenOfFamilies", t => t.secondGenerationChildren_Id)
                .Index(t => t.secondGenerationChildren_Id);
            
            CreateTable(
                "dbo.FirstGenerationWifesOfChildrenOfFamilies",
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
                "dbo.FirstGenerationChildrenOfFamilies",
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
                "dbo.FatherAndMotherChildrens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        HousbandAndWifeFromFamily_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HousbandAndWifeOfFamilies", t => t.HousbandAndWifeFromFamily_Id)
                .Index(t => t.HousbandAndWifeFromFamily_Id);
            
            CreateTable(
                "dbo.HousbandAndWifeOfFamilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        ChildrenHousbandAndWife_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FirstGenerationChildrenOfFamilies", t => t.ChildrenHousbandAndWife_Id)
                .Index(t => t.ChildrenHousbandAndWife_Id);
            
            CreateTable(
                "dbo.FaterAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalFatherCompleteName = c.String(),
                        OriginalMotherCompleteSurname = c.String(),
                        ParentalChild = c.String(),
                        FatherAndMotherChilds_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FatherAndMotherChildrens", t => t.FatherAndMotherChilds_Id)
                .Index(t => t.FatherAndMotherChilds_Id);
            
            CreateTable(
                "dbo.SupremeEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                        FatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FaterAndMothers", t => t.FatherAndMother_Id)
                .Index(t => t.FatherAndMother_Id);
            
            CreateTable(
                "dbo.EredityModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompleteName = c.String(),
                        FatherAndMother_Id = c.Int(),
                        FatherAndMotherChildren_Id = c.Int(),
                        FirstGenerationChildrenOfFamily_Id = c.Int(),
                        FirstGenerationHousbandAndWife_Id = c.Int(),
                        FirstGenerationWifesOfChildrenOfFamily_Id = c.Int(),
                        HousbandAndWifeOfFamily_Id = c.Int(),
                        SecondGenerationChildrenOfFamily_Id = c.Int(),
                        SupremeEntity_Id = c.Int(),
                        WifesOfChildrenOfFatherAndMother_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FaterAndMothers", t => t.FatherAndMother_Id)
                .ForeignKey("dbo.FatherAndMotherChildrens", t => t.FatherAndMotherChildren_Id)
                .ForeignKey("dbo.FirstGenerationChildrenOfFamilies", t => t.FirstGenerationChildrenOfFamily_Id)
                .ForeignKey("dbo.FirstGenerationHousbandAndWives", t => t.FirstGenerationHousbandAndWife_Id)
                .ForeignKey("dbo.FirstGenerationWifesOfChildrenOfFamilies", t => t.FirstGenerationWifesOfChildrenOfFamily_Id)
                .ForeignKey("dbo.HousbandAndWifeOfFamilies", t => t.HousbandAndWifeOfFamily_Id)
                .ForeignKey("dbo.SecondGenerationChildrenOfFamilies", t => t.SecondGenerationChildrenOfFamily_Id)
                .ForeignKey("dbo.SupremeEntities", t => t.SupremeEntity_Id)
                .ForeignKey("dbo.WifesOfChildrenOfFatherAndMothers", t => t.WifesOfChildrenOfFatherAndMother_Id)
                .Index(t => t.FatherAndMother_Id)
                .Index(t => t.FatherAndMotherChildren_Id)
                .Index(t => t.FirstGenerationChildrenOfFamily_Id)
                .Index(t => t.FirstGenerationHousbandAndWife_Id)
                .Index(t => t.FirstGenerationWifesOfChildrenOfFamily_Id)
                .Index(t => t.HousbandAndWifeOfFamily_Id)
                .Index(t => t.SecondGenerationChildrenOfFamily_Id)
                .Index(t => t.SupremeEntity_Id)
                .Index(t => t.WifesOfChildrenOfFatherAndMother_Id);
            
            CreateTable(
                "dbo.WifesOfChildrenOfFatherAndMothers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ParentalBond = c.String(),
                        Parental = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.EredityModel_Insert",
                p => new
                    {
                        CompleteName = p.String(),
                        FatherAndMother_Id = p.Int(),
                        FatherAndMotherChildren_Id = p.Int(),
                        FirstGenerationChildrenOfFamily_Id = p.Int(),
                        FirstGenerationHousbandAndWife_Id = p.Int(),
                        FirstGenerationWifesOfChildrenOfFamily_Id = p.Int(),
                        HousbandAndWifeOfFamily_Id = p.Int(),
                        SecondGenerationChildrenOfFamily_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                        WifesOfChildrenOfFatherAndMother_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[EredityModels]([CompleteName], [FatherAndMother_Id], [FatherAndMotherChildren_Id], [FirstGenerationChildrenOfFamily_Id], [FirstGenerationHousbandAndWife_Id], [FirstGenerationWifesOfChildrenOfFamily_Id], [HousbandAndWifeOfFamily_Id], [SecondGenerationChildrenOfFamily_Id], [SupremeEntity_Id], [WifesOfChildrenOfFatherAndMother_Id])
                      VALUES (@CompleteName, @FatherAndMother_Id, @FatherAndMotherChildren_Id, @FirstGenerationChildrenOfFamily_Id, @FirstGenerationHousbandAndWife_Id, @FirstGenerationWifesOfChildrenOfFamily_Id, @HousbandAndWifeOfFamily_Id, @SecondGenerationChildrenOfFamily_Id, @SupremeEntity_Id, @WifesOfChildrenOfFatherAndMother_Id)
                      
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
                        FatherAndMother_Id = p.Int(),
                        FatherAndMotherChildren_Id = p.Int(),
                        FirstGenerationChildrenOfFamily_Id = p.Int(),
                        FirstGenerationHousbandAndWife_Id = p.Int(),
                        FirstGenerationWifesOfChildrenOfFamily_Id = p.Int(),
                        HousbandAndWifeOfFamily_Id = p.Int(),
                        SecondGenerationChildrenOfFamily_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                        WifesOfChildrenOfFatherAndMother_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[EredityModels]
                      SET [CompleteName] = @CompleteName, [FatherAndMother_Id] = @FatherAndMother_Id, [FatherAndMotherChildren_Id] = @FatherAndMotherChildren_Id, [FirstGenerationChildrenOfFamily_Id] = @FirstGenerationChildrenOfFamily_Id, [FirstGenerationHousbandAndWife_Id] = @FirstGenerationHousbandAndWife_Id, [FirstGenerationWifesOfChildrenOfFamily_Id] = @FirstGenerationWifesOfChildrenOfFamily_Id, [HousbandAndWifeOfFamily_Id] = @HousbandAndWifeOfFamily_Id, [SecondGenerationChildrenOfFamily_Id] = @SecondGenerationChildrenOfFamily_Id, [SupremeEntity_Id] = @SupremeEntity_Id, [WifesOfChildrenOfFatherAndMother_Id] = @WifesOfChildrenOfFatherAndMother_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.EredityModel_Delete",
                p => new
                    {
                        Id = p.Int(),
                        FatherAndMother_Id = p.Int(),
                        FatherAndMotherChildren_Id = p.Int(),
                        FirstGenerationChildrenOfFamily_Id = p.Int(),
                        FirstGenerationHousbandAndWife_Id = p.Int(),
                        FirstGenerationWifesOfChildrenOfFamily_Id = p.Int(),
                        HousbandAndWifeOfFamily_Id = p.Int(),
                        SecondGenerationChildrenOfFamily_Id = p.Int(),
                        SupremeEntity_Id = p.Int(),
                        WifesOfChildrenOfFatherAndMother_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[EredityModels]
                      WHERE (((((((((([Id] = @Id) AND (([FatherAndMother_Id] = @FatherAndMother_Id) OR ([FatherAndMother_Id] IS NULL AND @FatherAndMother_Id IS NULL))) AND (([FatherAndMotherChildren_Id] = @FatherAndMotherChildren_Id) OR ([FatherAndMotherChildren_Id] IS NULL AND @FatherAndMotherChildren_Id IS NULL))) AND (([FirstGenerationChildrenOfFamily_Id] = @FirstGenerationChildrenOfFamily_Id) OR ([FirstGenerationChildrenOfFamily_Id] IS NULL AND @FirstGenerationChildrenOfFamily_Id IS NULL))) AND (([FirstGenerationHousbandAndWife_Id] = @FirstGenerationHousbandAndWife_Id) OR ([FirstGenerationHousbandAndWife_Id] IS NULL AND @FirstGenerationHousbandAndWife_Id IS NULL))) AND (([FirstGenerationWifesOfChildrenOfFamily_Id] = @FirstGenerationWifesOfChildrenOfFamily_Id) OR ([FirstGenerationWifesOfChildrenOfFamily_Id] IS NULL AND @FirstGenerationWifesOfChildrenOfFamily_Id IS NULL))) AND (([HousbandAndWifeOfFamily_Id] = @HousbandAndWifeOfFamily_Id) OR ([HousbandAndWifeOfFamily_Id] IS NULL AND @HousbandAndWifeOfFamily_Id IS NULL))) AND (([SecondGenerationChildrenOfFamily_Id] = @SecondGenerationChildrenOfFamily_Id) OR ([SecondGenerationChildrenOfFamily_Id] IS NULL AND @SecondGenerationChildrenOfFamily_Id IS NULL))) AND (([SupremeEntity_Id] = @SupremeEntity_Id) OR ([SupremeEntity_Id] IS NULL AND @SupremeEntity_Id IS NULL))) AND (([WifesOfChildrenOfFatherAndMother_Id] = @WifesOfChildrenOfFatherAndMother_Id) OR ([WifesOfChildrenOfFatherAndMother_Id] IS NULL AND @WifesOfChildrenOfFatherAndMother_Id IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EredityModel_Delete");
            DropStoredProcedure("dbo.EredityModel_Update");
            DropStoredProcedure("dbo.EredityModel_Insert");
            DropForeignKey("dbo.EredityModels", "WifesOfChildrenOfFatherAndMother_Id", "dbo.WifesOfChildrenOfFatherAndMothers");
            DropForeignKey("dbo.EredityModels", "SupremeEntity_Id", "dbo.SupremeEntities");
            DropForeignKey("dbo.EredityModels", "SecondGenerationChildrenOfFamily_Id", "dbo.SecondGenerationChildrenOfFamilies");
            DropForeignKey("dbo.EredityModels", "HousbandAndWifeOfFamily_Id", "dbo.HousbandAndWifeOfFamilies");
            DropForeignKey("dbo.EredityModels", "FirstGenerationWifesOfChildrenOfFamily_Id", "dbo.FirstGenerationWifesOfChildrenOfFamilies");
            DropForeignKey("dbo.EredityModels", "FirstGenerationHousbandAndWife_Id", "dbo.FirstGenerationHousbandAndWives");
            DropForeignKey("dbo.EredityModels", "FirstGenerationChildrenOfFamily_Id", "dbo.FirstGenerationChildrenOfFamilies");
            DropForeignKey("dbo.EredityModels", "FatherAndMotherChildren_Id", "dbo.FatherAndMotherChildrens");
            DropForeignKey("dbo.EredityModels", "FatherAndMother_Id", "dbo.FaterAndMothers");
            DropForeignKey("dbo.SupremeEntities", "FatherAndMother_Id", "dbo.FaterAndMothers");
            DropForeignKey("dbo.FaterAndMothers", "FatherAndMotherChilds_Id", "dbo.FatherAndMotherChildrens");
            DropForeignKey("dbo.FatherAndMotherChildrens", "HousbandAndWifeFromFamily_Id", "dbo.HousbandAndWifeOfFamilies");
            DropForeignKey("dbo.HousbandAndWifeOfFamilies", "ChildrenHousbandAndWife_Id", "dbo.FirstGenerationChildrenOfFamilies");
            DropForeignKey("dbo.FirstGenerationHousbandAndWives", "secondGenerationChildren_Id", "dbo.SecondGenerationChildrenOfFamilies");
            DropIndex("dbo.EredityModels", new[] { "WifesOfChildrenOfFatherAndMother_Id" });
            DropIndex("dbo.EredityModels", new[] { "SupremeEntity_Id" });
            DropIndex("dbo.EredityModels", new[] { "SecondGenerationChildrenOfFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "HousbandAndWifeOfFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "FirstGenerationWifesOfChildrenOfFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "FirstGenerationHousbandAndWife_Id" });
            DropIndex("dbo.EredityModels", new[] { "FirstGenerationChildrenOfFamily_Id" });
            DropIndex("dbo.EredityModels", new[] { "FatherAndMotherChildren_Id" });
            DropIndex("dbo.EredityModels", new[] { "FatherAndMother_Id" });
            DropIndex("dbo.SupremeEntities", new[] { "FatherAndMother_Id" });
            DropIndex("dbo.FaterAndMothers", new[] { "FatherAndMotherChilds_Id" });
            DropIndex("dbo.HousbandAndWifeOfFamilies", new[] { "ChildrenHousbandAndWife_Id" });
            DropIndex("dbo.FatherAndMotherChildrens", new[] { "HousbandAndWifeFromFamily_Id" });
            DropIndex("dbo.FirstGenerationHousbandAndWives", new[] { "secondGenerationChildren_Id" });
            DropTable("dbo.WifesOfChildrenOfFatherAndMothers");
            DropTable("dbo.EredityModels");
            DropTable("dbo.SupremeEntities");
            DropTable("dbo.FaterAndMothers");
            DropTable("dbo.HousbandAndWifeOfFamilies");
            DropTable("dbo.FatherAndMotherChildrens");
            DropTable("dbo.FirstGenerationChildrenOfFamilies");
            DropTable("dbo.FirstGenerationWifesOfChildrenOfFamilies");
            DropTable("dbo.FirstGenerationHousbandAndWives");
            DropTable("dbo.SecondGenerationChildrenOfFamilies");
        }
    }
}
