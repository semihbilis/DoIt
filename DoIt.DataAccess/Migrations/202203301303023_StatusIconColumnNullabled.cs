namespace DoIt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusIconColumnNullabled : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Status", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Status", "Icon", c => c.String(nullable: false));
        }
    }
}
