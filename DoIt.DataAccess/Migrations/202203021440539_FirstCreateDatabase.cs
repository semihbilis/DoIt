namespace DoIt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        Priority = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        AssigneeId = c.Int(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.AssigneeId)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId)
                .Index(t => t.AssigneeId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 13),
                        Surname = c.String(nullable: false, maxLength: 13),
                        Email = c.String(nullable: false, maxLength: 21),
                        Password = c.String(nullable: false, maxLength: 21),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organization",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        OrganizationId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organization", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Icon = c.String(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Quote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DutyTags",
                c => new
                    {
                        Duty_Id = c.Int(nullable: false),
                        Tag_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Duty_Id, t.Tag_Id })
                .ForeignKey("dbo.Duty", t => t.Duty_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.Tag_Id, cascadeDelete: true)
                .Index(t => t.Duty_Id)
                .Index(t => t.Tag_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DutyTags", "Tag_Id", "dbo.Tag");
            DropForeignKey("dbo.DutyTags", "Duty_Id", "dbo.Duty");
            DropForeignKey("dbo.Quote", "UserId", "dbo.User");
            DropForeignKey("dbo.Organization", "UserId", "dbo.User");
            DropForeignKey("dbo.Project", "OrganizationId", "dbo.Organization");
            DropForeignKey("dbo.Status", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.Duty", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Duty", "AssigneeId", "dbo.User");
            DropIndex("dbo.DutyTags", new[] { "Tag_Id" });
            DropIndex("dbo.DutyTags", new[] { "Duty_Id" });
            DropIndex("dbo.Quote", new[] { "UserId" });
            DropIndex("dbo.Status", new[] { "ProjectId" });
            DropIndex("dbo.Project", new[] { "OrganizationId" });
            DropIndex("dbo.Organization", new[] { "UserId" });
            DropIndex("dbo.Duty", new[] { "AssigneeId" });
            DropIndex("dbo.Duty", new[] { "StatusId" });
            DropTable("dbo.DutyTags");
            DropTable("dbo.Tag");
            DropTable("dbo.Quote");
            DropTable("dbo.Status");
            DropTable("dbo.Project");
            DropTable("dbo.Organization");
            DropTable("dbo.User");
            DropTable("dbo.Duty");
        }
    }
}
