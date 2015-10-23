namespace EntityCodeFirstIndex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Cidade = c.String(),
                        UF = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nome, unique: true, name: "NomeCliente");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clientes", "NomeCliente");
            DropTable("dbo.Clientes");
        }
    }
}
