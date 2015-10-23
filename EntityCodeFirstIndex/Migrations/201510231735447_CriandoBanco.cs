namespace EntityCodeFirstIndex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Sobrenome = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Nome, t.Sobrenome }, unique: true, name: "NomeCliente");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clientes", "NomeCliente");
            DropTable("dbo.Clientes");
        }
    }
}
