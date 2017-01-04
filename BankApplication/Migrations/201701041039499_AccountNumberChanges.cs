namespace BankApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccs", "AccountNumber",
                c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccs", "AccountNumber",
                c => c.String(nullable: false));
        }
    }
}
