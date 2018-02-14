using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Mariusz', 'Jarosz', '695600544');");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Michał', 'Kowalski', '695634544');");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Marek', 'Nowak', '345600544');");

            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Romanowska', 'Łódź');");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Prusa', 'Łódź');");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('rondo Smaków', 'Łódź');");

            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0,'opis 1',7,170,1,1,1,1,1);");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0,'opis 2',7,170,1,1,1,2,2);");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0,'opis 3',7,170,1,1,1,3,3);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Owners");
            migrationBuilder.Sql("DELETE FROM Addresses");
            migrationBuilder.Sql("DELETE FROM Propewrties");
        }
    }
}
