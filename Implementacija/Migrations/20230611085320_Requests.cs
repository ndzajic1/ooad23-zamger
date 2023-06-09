﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ooadproject.Migrations
{
    public partial class Requests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Student_RequesterID",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_StudentService_ProcessorID",
                table: "Request");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequesterID",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestTime",
                table: "Request",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorID",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Student_RequesterID",
                table: "Request",
                column: "RequesterID",
                principalTable: "Student",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_StudentService_ProcessorID",
                table: "Request",
                column: "ProcessorID",
                principalTable: "StudentService",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Student_RequesterID",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_StudentService_ProcessorID",
                table: "Request");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequesterID",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestTime",
                table: "Request",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorID",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Student_RequesterID",
                table: "Request",
                column: "RequesterID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_StudentService_ProcessorID",
                table: "Request",
                column: "ProcessorID",
                principalTable: "StudentService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
