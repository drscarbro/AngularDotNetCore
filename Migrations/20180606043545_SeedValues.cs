using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DatingApp.API.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Values", "Name", "Value 101");
            migrationBuilder.InsertData("Values", "Name", "Value 102");
            migrationBuilder.InsertData("Values", "Name", "Value 103");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
