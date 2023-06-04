using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBank.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Customers_CustomerId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cards_CardId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Dailers_DailerId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dailers",
                table: "Dailers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "transactions");

            migrationBuilder.RenameTable(
                name: "Dailers",
                newName: "dailers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "cards");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_DailerId",
                table: "transactions",
                newName: "IX_transactions_DailerId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CardId",
                table: "transactions",
                newName: "IX_transactions_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_CustomerId",
                table: "cards",
                newName: "IX_cards_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transactions",
                table: "transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dailers",
                table: "dailers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cards",
                table: "cards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_customers_CustomerId",
                table: "cards",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_cards_CardId",
                table: "transactions",
                column: "CardId",
                principalTable: "cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_dailers_DailerId",
                table: "transactions",
                column: "DailerId",
                principalTable: "dailers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_customers_CustomerId",
                table: "cards");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_cards_CardId",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_dailers_DailerId",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transactions",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dailers",
                table: "dailers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cards",
                table: "cards");

            migrationBuilder.RenameTable(
                name: "transactions",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "dailers",
                newName: "Dailers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "cards",
                newName: "Cards");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_DailerId",
                table: "Transactions",
                newName: "IX_Transactions_DailerId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_CardId",
                table: "Transactions",
                newName: "IX_Transactions_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_cards_CustomerId",
                table: "Cards",
                newName: "IX_Cards_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dailers",
                table: "Dailers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Customers_CustomerId",
                table: "Cards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cards_CardId",
                table: "Transactions",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Dailers_DailerId",
                table: "Transactions",
                column: "DailerId",
                principalTable: "Dailers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
