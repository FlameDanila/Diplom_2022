using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tets_bogdan.Migrations
{
    public partial class Reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompetitionType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthday = table.Column<DateTime>(type: "date", nullable: true),
                    mesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    documents = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Robot",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    videoLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robot", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthday = table.Column<DateTime>(type: "date", nullable: true),
                    mesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    documents = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    competitionTypeId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    selectCategoryId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    place = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    stageTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competition_CompetitionType",
                        column: x => x.competitionTypeId,
                        principalTable: "CompetitionType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trainerId = table.Column<int>(type: "int", nullable: true),
                    firstParticipantId = table.Column<int>(type: "int", nullable: true),
                    secondParticipantId = table.Column<int>(type: "int", nullable: true),
                    selectedStageId = table.Column<int>(type: "int", nullable: true),
                    RobotId = table.Column<int>(type: "int", nullable: true),
                    dateTest = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.id);
                    table.ForeignKey(
                        name: "FK_Team_Competition",
                        column: x => x.selectedStageId,
                        principalTable: "Competition",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Team_Participant",
                        column: x => x.firstParticipantId,
                        principalTable: "Participant",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Team_Participant1",
                        column: x => x.secondParticipantId,
                        principalTable: "Participant",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Team_Robot",
                        column: x => x.RobotId,
                        principalTable: "Robot",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Team_Trainer",
                        column: x => x.trainerId,
                        principalTable: "Trainer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competition_competitionTypeId",
                table: "Competition",
                column: "competitionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_firstParticipantId",
                table: "Team",
                column: "firstParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_RobotId",
                table: "Team",
                column: "RobotId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_secondParticipantId",
                table: "Team",
                column: "secondParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_selectedStageId",
                table: "Team",
                column: "selectedStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_trainerId",
                table: "Team",
                column: "trainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "Robot");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "CompetitionType");
        }
    }
}
