namespace Alpha.Pruebas.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mes = c.String(),
                        Anio = c.String(),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "ClienteID", "dbo.Cliente");
            DropIndex("dbo.Factura", new[] { "ClienteID" });
            DropTable("dbo.Factura");
        }
    }
}
