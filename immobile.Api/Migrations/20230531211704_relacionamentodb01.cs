using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace immobile.Api.Migrations
{
    /// <inheritdoc />
    public partial class relacionamentodb01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postal_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.PriceId);
                });

            migrationBuilder.CreateTable(
                name: "TagAdvertiseType",
                columns: table => new
                {
                    TagAdvertiseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagAdvertiseType", x => x.TagAdvertiseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TagCommonArea",
                columns: table => new
                {
                    TagCommonAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagCommonArea", x => x.TagCommonAreaId);
                });

            migrationBuilder.CreateTable(
                name: "TagImmobileType",
                columns: table => new
                {
                    TagImmobileTipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagImmobileType", x => x.TagImmobileTipeId);
                });

            migrationBuilder.CreateTable(
                name: "TagPrivateArea",
                columns: table => new
                {
                    TagPrivateAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagPrivateArea", x => x.TagPrivateAreaId);
                });

            migrationBuilder.CreateTable(
                name: "Immobile",
                columns: table => new
                {
                    ImmobileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    TagImmobileTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immobile", x => x.ImmobileId);
                    table.ForeignKey(
                        name: "FK_Immobile_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Immobile_TagImmobileType_TagImmobileTypeId",
                        column: x => x.TagImmobileTypeId,
                        principalTable: "TagImmobileType",
                        principalColumn: "TagImmobileTipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact_and_immobile",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    ImmobileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_and_immobile", x => new { x.ContactId, x.ImmobileId });
                    table.ForeignKey(
                        name: "FK_Contact_and_immobile_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_and_immobile_Immobile_ImmobileId",
                        column: x => x.ImmobileId,
                        principalTable: "Immobile",
                        principalColumn: "ImmobileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagAdvertiseType_and_immobile",
                columns: table => new
                {
                    TagAdvertiseTypeId = table.Column<int>(type: "int", nullable: false),
                    ImmobileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagAdvertiseType_and_immobile", x => new { x.TagAdvertiseTypeId, x.ImmobileId });
                    table.ForeignKey(
                        name: "FK_TagAdvertiseType_and_immobile_Immobile_ImmobileId",
                        column: x => x.ImmobileId,
                        principalTable: "Immobile",
                        principalColumn: "ImmobileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagAdvertiseType_and_immobile_TagAdvertiseType_TagAdvertiseTypeId",
                        column: x => x.TagAdvertiseTypeId,
                        principalTable: "TagAdvertiseType",
                        principalColumn: "TagAdvertiseTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagBusiness",
                columns: table => new
                {
                    TagBusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmobileId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagBusiness", x => x.TagBusinessId);
                    table.ForeignKey(
                        name: "FK_TagBusiness_Immobile_ImmobileId",
                        column: x => x.ImmobileId,
                        principalTable: "Immobile",
                        principalColumn: "ImmobileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagBusiness_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "PriceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagCommonArea_and_Immobile",
                columns: table => new
                {
                    TagCommonAreaId = table.Column<int>(type: "int", nullable: false),
                    ImmobileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagCommonArea_and_Immobile", x => new { x.TagCommonAreaId, x.ImmobileId });
                    table.ForeignKey(
                        name: "FK_TagCommonArea_and_Immobile_Immobile_ImmobileId",
                        column: x => x.ImmobileId,
                        principalTable: "Immobile",
                        principalColumn: "ImmobileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagCommonArea_and_Immobile_TagCommonArea_TagCommonAreaId",
                        column: x => x.TagCommonAreaId,
                        principalTable: "TagCommonArea",
                        principalColumn: "TagCommonAreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagPrivateArea_and_immobile",
                columns: table => new
                {
                    TagPrivateAreaId = table.Column<int>(type: "int", nullable: false),
                    ImmobileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagPrivateArea_and_immobile", x => new { x.TagPrivateAreaId, x.ImmobileId });
                    table.ForeignKey(
                        name: "FK_TagPrivateArea_and_immobile_Immobile_ImmobileId",
                        column: x => x.ImmobileId,
                        principalTable: "Immobile",
                        principalColumn: "ImmobileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagPrivateArea_and_immobile_TagPrivateArea_TagPrivateAreaId",
                        column: x => x.TagPrivateAreaId,
                        principalTable: "TagPrivateArea",
                        principalColumn: "TagPrivateAreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_and_immobile_ImmobileId",
                table: "Contact_and_immobile",
                column: "ImmobileId");

            migrationBuilder.CreateIndex(
                name: "IX_Immobile_AddressId",
                table: "Immobile",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Immobile_TagImmobileTypeId",
                table: "Immobile",
                column: "TagImmobileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TagAdvertiseType_and_immobile_ImmobileId",
                table: "TagAdvertiseType_and_immobile",
                column: "ImmobileId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBusiness_ImmobileId",
                table: "TagBusiness",
                column: "ImmobileId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBusiness_PriceId",
                table: "TagBusiness",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_TagCommonArea_and_Immobile_ImmobileId",
                table: "TagCommonArea_and_Immobile",
                column: "ImmobileId");

            migrationBuilder.CreateIndex(
                name: "IX_TagPrivateArea_and_immobile_ImmobileId",
                table: "TagPrivateArea_and_immobile",
                column: "ImmobileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact_and_immobile");

            migrationBuilder.DropTable(
                name: "TagAdvertiseType_and_immobile");

            migrationBuilder.DropTable(
                name: "TagBusiness");

            migrationBuilder.DropTable(
                name: "TagCommonArea_and_Immobile");

            migrationBuilder.DropTable(
                name: "TagPrivateArea_and_immobile");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "TagAdvertiseType");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "TagCommonArea");

            migrationBuilder.DropTable(
                name: "Immobile");

            migrationBuilder.DropTable(
                name: "TagPrivateArea");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "TagImmobileType");
        }
    }
}
