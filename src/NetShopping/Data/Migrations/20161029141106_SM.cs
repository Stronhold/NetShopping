using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetShopping.Data.Migrations
{
    public partial class SM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.AddColumn<short>(
                name: "StateId",
                table: "UserProducts",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProducts_StateId",
                table: "UserProducts",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProducts_State_StateId",
                table: "UserProducts",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProducts_State_StateId",
                table: "UserProducts");

            migrationBuilder.DropIndex(
                name: "IX_UserProducts_StateId",
                table: "UserProducts");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "UserProducts");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
