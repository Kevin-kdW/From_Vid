using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContextToPlural : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Group_GroupId",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserProject_AppUser_AppUserId",
                table: "AppUserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserProject_Project_ProjectId",
                table: "AppUserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Project_ProjectId",
                table: "Todo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserProject",
                table: "AppUserProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "AppUserProject",
                newName: "AppUserProjects");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserProject_ProjectId",
                table: "AppUserProjects",
                newName: "IX_AppUserProjects_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserProject_AppUserId",
                table: "AppUserProjects",
                newName: "IX_AppUserProjects_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_Username",
                table: "AppUsers",
                newName: "IX_AppUsers_Username");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_GroupId",
                table: "AppUsers",
                newName: "IX_AppUsers_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserProjects",
                table: "AppUserProjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserProjects_AppUsers_AppUserId",
                table: "AppUserProjects",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserProjects_Projects_ProjectId",
                table: "AppUserProjects",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Group_GroupId",
                table: "AppUsers",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Projects_ProjectId",
                table: "Todo",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserProjects_AppUsers_AppUserId",
                table: "AppUserProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserProjects_Projects_ProjectId",
                table: "AppUserProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Group_GroupId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Projects_ProjectId",
                table: "Todo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserProjects",
                table: "AppUserProjects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUserProjects",
                newName: "AppUserProject");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_Username",
                table: "AppUser",
                newName: "IX_AppUser_Username");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_GroupId",
                table: "AppUser",
                newName: "IX_AppUser_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserProjects_ProjectId",
                table: "AppUserProject",
                newName: "IX_AppUserProject_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserProjects_AppUserId",
                table: "AppUserProject",
                newName: "IX_AppUserProject_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserProject",
                table: "AppUserProject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Group_GroupId",
                table: "AppUser",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserProject_AppUser_AppUserId",
                table: "AppUserProject",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserProject_Project_ProjectId",
                table: "AppUserProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Project_ProjectId",
                table: "Todo",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
