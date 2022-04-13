using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopSelect.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BrancheID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BrancheID);
                    table.ForeignKey(
                        name: "FK_Branches_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branches_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarLicenses",
                columns: table => new
                {
                    CarLicenseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModelType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    CarLicenseType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarLicenses", x => x.CarLicenseId);
                    table.ForeignKey(
                        name: "FK_CarLicenses_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarLicenses_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoriteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModelType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    ModelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SkillType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skills_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Postal = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    HouseNumber = table.Column<ushort>(type: "INTEGER", nullable: false),
                    CityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CountryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ContactName = table.Column<string>(type: "TEXT", nullable: false),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kvk = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Webpage = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfEmployees = table.Column<ushort>(type: "INTEGER", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeID = table.Column<Guid>(type: "TEXT", nullable: false),
                    BirthPlaceCityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nationality = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeID);
                    table.ForeignKey(
                        name: "FK_Resumes_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Cities_BirthPlaceCityId",
                        column: x => x.BirthPlaceCityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    VacancyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MinimalAge = table.Column<int>(type: "INTEGER", nullable: false),
                    MaximumAge = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    HoursAWeek = table.Column<int>(type: "INTEGER", nullable: false),
                    VacancyType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    HolidaysAYear = table.Column<ushort>(type: "INTEGER", nullable: false),
                    MinimalSalary = table.Column<int>(type: "INTEGER", nullable: false),
                    MaximumSalary = table.Column<int>(type: "INTEGER", nullable: false),
                    CityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FunctionRequirements = table.Column<string>(type: "TEXT", nullable: false),
                    FunctionDescription = table.Column<string>(type: "TEXT", nullable: false),
                    VacancyDescription = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BranchId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BrancheID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.VacancyId);
                    table.ForeignKey(
                        name: "FK_Vacancies_Branches_BrancheID",
                        column: x => x.BrancheID,
                        principalTable: "Branches",
                        principalColumn: "BrancheID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiances",
                columns: table => new
                {
                    ExperianceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExperianceType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Function = table.Column<string>(type: "TEXT", nullable: false),
                    StartDateOnly = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndedDateOnly = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ResumeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BrancheId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiances", x => x.ExperianceId);
                    table.ForeignKey(
                        name: "FK_Experiances_Branches_BrancheId",
                        column: x => x.BrancheId,
                        principalTable: "Branches",
                        principalColumn: "BrancheID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiances_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiances_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiances_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiances_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModelType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    ReactionStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ResumeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    VacancyOd = table.Column<Guid>(type: "TEXT", nullable: true),
                    VacancyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ReactionId);
                    table.ForeignKey(
                        name: "FK_Reactions_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeID");
                    table.ForeignKey(
                        name: "FK_Reactions_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reactions_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reactions_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId");
                });

            migrationBuilder.CreateTable(
                name: "SkillScores",
                columns: table => new
                {
                    SkillScoreId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SkillScoreType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    LanguageType = table.Column<int>(type: "INTEGER", nullable: true),
                    ModelType = table.Column<ushort>(type: "INTEGER", nullable: false),
                    ResumeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    VacancyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SkillId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedByForeignKey = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillScores", x => x.SkillScoreId);
                    table.ForeignKey(
                        name: "FK_SkillScores_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeID");
                    table.ForeignKey(
                        name: "FK_SkillScores_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillScores_Users_CreatedByForeignKey",
                        column: x => x.CreatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillScores_Users_UpdatedByForeignKey",
                        column: x => x.UpdatedByForeignKey,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillScores_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillScores_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CreatedByForeignKey",
                table: "Addresses",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UpdatedByForeignKey",
                table: "Addresses",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CreatedByForeignKey",
                table: "Branches",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_UpdatedByForeignKey",
                table: "Branches",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_CarLicenses_CreatedByForeignKey",
                table: "CarLicenses",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_CarLicenses_UpdatedByForeignKey",
                table: "CarLicenses",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AddressId",
                table: "Companies",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CreatedByForeignKey",
                table: "Companies",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UpdatedByForeignKey",
                table: "Companies",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CreatedByForeignKey",
                table: "Countries",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_UpdatedByForeignKey",
                table: "Countries",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_BrancheId",
                table: "Experiances",
                column: "BrancheId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_CompanyId",
                table: "Experiances",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_CreatedByForeignKey",
                table: "Experiances",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_ResumeId",
                table: "Experiances",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiances_UpdatedByForeignKey",
                table: "Experiances",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_CreatedByForeignKey",
                table: "Favorites",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UpdatedByForeignKey",
                table: "Favorites",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_CreatedByForeignKey",
                table: "Reactions",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ResumeId",
                table: "Reactions",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UpdatedByForeignKey",
                table: "Reactions",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_VacancyId",
                table: "Reactions",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_AddressID",
                table: "Resumes",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_BirthPlaceCityId",
                table: "Resumes",
                column: "BirthPlaceCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CreatedByForeignKey",
                table: "Resumes",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_UpdatedByForeignKey",
                table: "Resumes",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CreatedByForeignKey",
                table: "Skills",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UpdatedByForeignKey",
                table: "Skills",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_CreatedByForeignKey",
                table: "SkillScores",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_ResumeId",
                table: "SkillScores",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_SkillId",
                table: "SkillScores",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_UpdatedByForeignKey",
                table: "SkillScores",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_UserId",
                table: "SkillScores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillScores_VacancyId",
                table: "SkillScores",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedByForeignKey",
                table: "Users",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdatedByForeignKey",
                table: "Users",
                column: "UpdatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_BrancheID",
                table: "Vacancies",
                column: "BrancheID");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CityId",
                table: "Vacancies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CompanyId",
                table: "Vacancies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CreatedByForeignKey",
                table: "Vacancies",
                column: "CreatedByForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_UpdatedByForeignKey",
                table: "Vacancies",
                column: "UpdatedByForeignKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarLicenses");

            migrationBuilder.DropTable(
                name: "Experiances");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "SkillScores");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
