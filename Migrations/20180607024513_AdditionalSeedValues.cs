using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DatingApp.API.Migrations
{
    public partial class AdditionalSeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Values", "Name", "Value 104");
            migrationBuilder.InsertData("Values", "Name", "Value 105");
            migrationBuilder.InsertData("Values", "Name", "Value 106");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
