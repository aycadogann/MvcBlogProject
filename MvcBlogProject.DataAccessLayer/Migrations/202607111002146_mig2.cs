namespace MvcBlogProject.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 250));
            DropColumn("dbo.Headings", "HeadName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "HeadName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            DropColumn("dbo.Headings", "HeadingName");
        }
    }
}
