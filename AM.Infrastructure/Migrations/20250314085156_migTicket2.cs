using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migTicket2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFlightPassenger_Flights_FlightsFlightId",
                table: "ReservationFlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "ReservationFlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationFlightPassenger",
                table: "ReservationFlightPassenger");

            migrationBuilder.RenameTable(
                name: "ReservationFlightPassenger",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFlightPassenger_ListPassengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_ListPassengersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "ListPassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "FlightPassenger",
                column: "ListPassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "ReservationFlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_ListPassengersPassportNumber",
                table: "ReservationFlightPassenger",
                newName: "IX_ReservationFlightPassenger_ListPassengersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationFlightPassenger",
                table: "ReservationFlightPassenger",
                columns: new[] { "FlightsFlightId", "ListPassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFlightPassenger_Flights_FlightsFlightId",
                table: "ReservationFlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFlightPassenger_Passengers_ListPassengersPassportNumber",
                table: "ReservationFlightPassenger",
                column: "ListPassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
