using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phadec.Migrations
{
    /// <inheritdoc />
    public partial class review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_AbpUsers_UserId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugInteraction_Drug_DrugId",
                table: "DrugInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodInteraction_Drug_DrugId",
                table: "FoodInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_AbpUsers_UserId",
                table: "Opinion");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Drug_DrugId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Product_ProductId",
                table: "Recommendation");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Recommendation",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Recommendation",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Prescription",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Prescription",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Opinion",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "FoodInteraction",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "DrugInteraction",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Document",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_AbpUsers_UserId",
                table: "Document",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugInteraction_Drug_DrugId",
                table: "DrugInteraction",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInteraction_Drug_DrugId",
                table: "FoodInteraction",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_AbpUsers_UserId",
                table: "Opinion",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Drug_DrugId",
                table: "Recommendation",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Product_ProductId",
                table: "Recommendation",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_AbpUsers_UserId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugInteraction_Drug_DrugId",
                table: "DrugInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodInteraction_Drug_DrugId",
                table: "FoodInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_AbpUsers_UserId",
                table: "Opinion");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Drug_DrugId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Product_ProductId",
                table: "Recommendation");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Recommendation",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "Recommendation",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Prescription",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Prescription",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Opinion",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "FoodInteraction",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "DrugInteraction",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Document",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_AbpUsers_UserId",
                table: "Document",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrugInteraction_Drug_DrugId",
                table: "DrugInteraction",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInteraction_Drug_DrugId",
                table: "FoodInteraction",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_AbpUsers_UserId",
                table: "Opinion",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Drug_DrugId",
                table: "Recommendation",
                column: "DrugId",
                principalTable: "Drug",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Product_ProductId",
                table: "Recommendation",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
