using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCoffeeShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT Into dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('PJ''s Coffee of New Orleans', '9-5 Mon-Sat', '9079 West Locust St. Buffalo NY')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Starbucks', '7-9 Mon-Fri', '1234 Elm St. Seattle WA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Blue Bottle Coffee', '8-6 Daily', '567 Oak St. San Francisco CA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Dunkin'' Donuts', '6-10 Daily', '789 Pine St. Boston MA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Tim Hortons', '5-11 Mon-Sun', '101 Maple St. Toronto ON')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Peet''s Coffee', '7-8 Mon-Fri', '234 Cedar St. Berkeley CA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Caribou Coffee', '6-9 Mon-Sat', '345 Birch St. Minneapolis MN')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Coffee Bean & Tea Leaf', '8-7 Mon-Fri', '456 Spruce St. Los Angeles CA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Stumptown Coffee', '7-6 Daily', '678 Fir St. Portland OR')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Philz Coffee', '7-8 Mon-Sun', '890 Walnut St. San Jose CA')");

            migrationBuilder.Sql(
                "INSERT INTO dbo.CoffeeShops(Name, OpeningHours, Address) VALUES('Intelligentsia Coffee', '7-9 Mon-Fri', '112 Ash St. Chicago IL')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
