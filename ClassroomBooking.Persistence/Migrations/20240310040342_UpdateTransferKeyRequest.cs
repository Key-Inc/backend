using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTransferKeyRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferKeyRequests",
                table: "TransferKeyRequests");

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("06995d50-ea5e-4c77-bc39-4b9bdad610cf"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0a30539e-05cd-4ed4-a84f-c4da499071b6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("134f0b04-5f5c-4971-9c6f-7760509be75f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("13508d9d-4fe0-4ca5-a262-7c8219c3ced4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("180ab39b-53bd-4748-85af-fad2c9fccf33"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("18644e06-d34f-400e-aeff-ffd595cf86a9"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("18a65db9-f47e-4c55-ae22-a3685237fe96"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1c7f4d4c-cddb-41ff-9ca3-98c554c530e2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("23594341-cf2a-4eb9-810b-3e21ae72f774"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("27568a47-15ea-4eac-a651-7f8295780818"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2a8b82d6-aa62-4387-964b-b27964c838b1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2e0d2170-a102-43f0-8138-51b205ddf388"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3212e069-6d52-4c89-b3c8-970e33295216"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3e174f70-cb28-4204-8dda-641233b47296"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("40ffeeec-4581-4526-a9fb-1bd5ae59fb31"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("426fdce5-cc0b-4b81-9d38-b20cd750e952"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("46cfa060-f79b-4845-8c87-7a485da8d348"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("478426c2-291d-4900-aef9-af312ba4b2cb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("482c2304-29a3-462e-9e65-751480fbd08a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4c0d67d4-bf73-4436-a68f-27dacdc5ca90"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5be5d8ac-58ad-40d9-9e00-960e747f7273"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("60007d23-2ffd-41eb-bf17-4dc362dbcf7e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6078dcc9-c52d-4563-b0ad-d9fdee023463"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("653ea1b9-7e2e-49a5-bd67-47658e5dd353"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("673b2c00-7f3f-48d1-8704-364337c0e0bb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("67fcd0da-2946-4043-bb10-77be1d5892cc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6d2a19aa-6745-45f7-9ac7-57717a1f387c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("75a01a64-d28e-4794-8e68-fa250050168f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("770c1b10-38af-40a7-8712-6ef4bf3f02d3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("779a9675-98d1-45c2-be69-520b3d6ee68e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7c7b068f-2dd0-4943-9b45-5722ea5da154"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("84e1a94a-1803-4104-ba1e-21acedfcebee"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("89ab668d-6ea5-4d4d-a4ee-5f8cb74b6137"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8b4f95e0-5633-47b0-b33a-b7a1c0d257c0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8c372eea-c817-491c-84dd-6763e4be9a98"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9355964c-69d6-4129-b9e3-6b6325376597"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("95dd280b-f954-4dc4-8725-c500f5ebe4f8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a6c2553a-36bf-41de-ae36-7668739c15ee"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a93eef46-b50f-4050-8213-a9975e7c78ed"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a9db2eb9-bd7e-43b1-81f8-b396496b71c3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ac4a7461-6084-41c3-9420-de5b85fccb3b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b36921b9-d88a-47ad-84ba-3f61ff34825a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b6529a39-3740-4931-81a3-322fd981c202"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bb266f8a-9906-4196-9b61-69ecd335da75"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bf1a98a7-f68d-46bf-87ce-b1361ad155a5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c61c8793-9f7a-40ee-82c2-36b04c548802"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cbb711d6-71ec-4cf7-a925-dbaac2a76076"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cda682d8-0ee6-46e3-ad27-c6fb723ddd72"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("dd73f946-1896-4564-bdb9-e24a2cd528c0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("df3ef4ca-d3bd-4be3-acf1-065347be7862"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e002c00e-a531-4b36-b52c-3375cb0ab839"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e04f6b73-f8e8-44f6-ae1f-d36ec24abd27"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e400d63e-03e6-4f3e-830f-7404af86662b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f4b7e5a2-04d4-4c68-99a3-0cd0523a8e2f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f82d953f-09be-4aad-ba4a-5c463e21e56c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51540c49-d30f-45d0-9abf-de9bc9a8d2bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7946583b-13ef-406b-8a7a-6738c3105987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae3842de-d8c5-400e-81a6-63e1a826668b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("feecb044-7935-4e55-9245-445e258384ee"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("029da668-f86f-4a64-8d8a-75cbd02423d8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("02c16dfc-9c2f-4e6c-984a-254f6cd26936"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("054e02f5-3be1-426b-8560-a4bd02d83cbf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("06961358-d364-4e65-96c7-1a2f53da9d68"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0e195743-b407-4155-a25b-38cbf726985b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0f821ebe-5456-466c-b394-e28b21c5ebe6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1816ade5-714e-4ea5-9aba-49a4ec7dbe13"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1ce6eb0a-5591-4fe0-aa83-9be6c4bb97bb"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1dfd674f-0859-417b-9c47-ddc4fde08545"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("231c731c-7f71-4c00-bccf-5c2c64f03a1e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2897600a-13e1-4b98-9a8b-43659909b1b3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2fa9409e-311b-47c8-a06e-ddb5bb3bb99d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("317f7a6c-cddb-4ff0-b655-770709f7bfba"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3b0848ff-9e77-4665-a605-a53a309f6e7a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3c0c19e8-2fe4-4193-b1d4-cca242feb570"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3cef97ab-c08c-4876-af22-e7627e319ec4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("40470fb9-ac7b-46f0-9bc0-43a0d4f4478e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("455f64ad-143d-473f-82ba-5c808560e872"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("47bb6675-0d23-4528-952e-ceb046e3ee62"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("486ccb32-1f38-4f10-ab7a-7203744b55c4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4ee853a1-6ce0-48a7-9b0e-e30ff051ea3d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("53f2b763-76cd-4a18-acba-1ea1caf460fe"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("561e6743-fef8-42ca-84d6-c71a1d35f227"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5cc6aeb7-f5b3-4f51-9be7-7f37b196d9ef"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5e888a85-d674-4727-b3d9-e8641ff157a9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("645daf2c-0788-465a-98f2-443ced657d4b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6597fc3b-4b6b-4ef1-94bc-63699d7f1f79"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("66149d1f-9f3e-4bbd-9ac6-743d7a6afdc6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("69e95ee8-af8b-47eb-a6a1-34cb92ff098d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6ac86a87-6b39-4a94-b8f9-4b261a35a18d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("727e8eda-113b-4628-8ffa-4b268e675b32"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("854e9792-2c57-4707-8be4-398dece1c835"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("89d89b7a-0a09-44b2-881c-9cc0a42180e2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("911c73c4-95ba-4133-8617-7c934c6b36db"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("97184f0a-1433-4675-b37b-99aaa84ec966"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("97d832c6-1230-4c5b-9105-04aabf9c67a9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9ac76204-9c43-4758-ba85-709599d5c086"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a46220a7-64fc-493d-babb-a5c548d11f95"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a911f444-5d22-40ab-9592-f16bad08ad6d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("aed7f9e3-a88c-481e-884c-41059113f307"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bd83aec2-58bf-4468-a282-9060c840ecc8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c63e6bd0-e712-48e5-86ad-364a46a9cf95"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c8c873e7-669a-46d9-9406-513456192bfa"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cac074ab-0c73-440f-b83e-25dc5b0df244"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cdb41023-c1d3-4560-9f33-a1f7c60a0ebc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d03ef224-e56a-4915-b328-0c6361eb2c66"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d1e3f3d7-675d-48b5-b0ea-bead6faf4f01"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d392cc41-e63e-48ac-be89-a6a825ece3fb"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("dc74b82b-a82b-44cd-819d-fd1c0beda725"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("dd69139d-5456-4725-9285-8cd4bda63203"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e55d21d9-572e-4646-911c-44f9e7a12456"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ea59bbe5-027a-468b-8836-3ce0b42782c3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ed6e064a-9231-4d9f-ab95-d828f6ee35d5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fac3a3e8-b15c-40e0-a871-3d0f7e5f94b3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fc86dc15-4d97-436e-9902-3d0128afb605"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "TransferKeyRequests",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "TransferKeyRequests",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferKeyRequests",
                table: "TransferKeyRequests",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("1df03cd7-c86f-4549-9b1c-0f808bcd435c"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6600), 201 },
                    { new Guid("22f4aa08-1549-41d2-8c86-3dfab2aa49f5"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6600), 200 },
                    { new Guid("234b66d4-edc9-44d2-8f96-751528bc5998"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6550), 208 },
                    { new Guid("2b96eb37-9871-479d-917b-3791472b04a3"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6690), 208 },
                    { new Guid("2eeb3459-89f2-45c3-aeca-15893e83a109"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6660), 204 },
                    { new Guid("3002213c-ce71-47cc-bdb5-25d5c57eb498"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6680), 201 },
                    { new Guid("316ea899-9cb8-4bd0-b44b-530591b419e7"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6650), 202 },
                    { new Guid("36126804-f568-4b40-9aa0-c8fd4b0a0037"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6690), 204 },
                    { new Guid("3adef3f1-27e4-47c6-93da-f5f49f25ae44"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6610), 203 },
                    { new Guid("42014eff-8be4-4e82-9e79-57fa444ec8fc"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6700), 210 },
                    { new Guid("4c19adf9-9664-4cab-b414-776605eb6bea"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6510), 204 },
                    { new Guid("5b250c3c-50ee-4e36-8055-0e22628d99ec"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6630), 207 },
                    { new Guid("60ffb073-3f6f-4b0c-a51f-1e3939f7879f"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6520), 210 },
                    { new Guid("614610c2-8f1c-45be-bf20-c89f79c8a36e"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6550), 209 },
                    { new Guid("629b5a2e-a283-456d-99fa-a60107e8904a"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6520), 206 },
                    { new Guid("62eb98ba-5494-4ff8-b1e1-285fcafd70c9"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6660), 205 },
                    { new Guid("6cbba81c-46e4-485a-ad62-babe5070a538"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6680), 203 },
                    { new Guid("6e766a8a-3312-441b-9915-aced7ff3e458"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6520), 207 },
                    { new Guid("7053ebf6-5c7e-43b5-9546-3a4da8aabff6"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6480), 201 },
                    { new Guid("778fa6e5-de5b-4466-9549-c018b0cf2d89"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6630), 206 },
                    { new Guid("881c7004-092a-47f3-8889-417f94c69e9a"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6640), 200 },
                    { new Guid("8f2f9e28-646d-4c70-9a90-5b83bc233492"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6600), 202 },
                    { new Guid("9960d9ed-d6bc-45ef-bf9d-7d52e2401d23"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6550), 210 },
                    { new Guid("9bdaec8b-28d5-4bf1-9ba3-4f4231d8f6f3"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6530), 202 },
                    { new Guid("9f4019c3-43dd-4283-99bf-0b1b4e847670"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6650), 201 },
                    { new Guid("a4113603-ed92-4262-9eda-965a027db2e3"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6530), 201 },
                    { new Guid("a44615a8-9ccf-4b3e-ba5f-2a49afc6f2d6"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6540), 206 },
                    { new Guid("a625ede8-243e-4f2a-9537-9eb9493d8698"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6670), 208 },
                    { new Guid("a67cb00f-d07f-4039-8dbb-0ff772b6519b"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6690), 205 },
                    { new Guid("a7375a75-2472-4f89-b245-d24f220337b1"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6630), 208 },
                    { new Guid("b4745440-a3d5-4dad-9b4d-81e638920b51"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6640), 209 },
                    { new Guid("b51fec19-2869-4f7c-98c0-94995ba897bf"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6690), 206 },
                    { new Guid("b817c1d3-e593-4be4-bce6-e78b2bee9e8d"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6680), 202 },
                    { new Guid("ba08f84c-9f6b-4c0b-b327-d4d226e42893"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6650), 203 },
                    { new Guid("bc170d25-6413-4d7e-aa7c-4900cd0535c2"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6670), 209 },
                    { new Guid("bd00a96c-75b5-4781-870b-da2864adb4f2"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6700), 209 },
                    { new Guid("bdf26201-e92a-4869-9bad-1853d4a3bec4"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6520), 208 },
                    { new Guid("bf24b8ca-de67-42cc-b40c-1dd45f6729a3"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6490), 203 },
                    { new Guid("c6d3ea63-bf32-4ec3-8732-69cfcd186555"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6620), 204 },
                    { new Guid("cba64341-3dea-4f52-8d9c-4a578d5c12c8"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6670), 210 },
                    { new Guid("cddf78ae-b9da-4a30-baf7-0bcdbbac2a79"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6470), 200 },
                    { new Guid("d2baac43-9f15-4ddd-b3a9-f1e26771a49c"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6530), 200 },
                    { new Guid("d9c81a84-0c39-45a1-ac19-104846f03ae8"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6660), 206 },
                    { new Guid("dabddd74-37d9-4137-9e91-69644551ca24"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6620), 205 },
                    { new Guid("db20f722-e4cd-41db-ad8b-983668164eae"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6540), 207 },
                    { new Guid("e0ab6b3a-d5ad-49e5-8484-fee592613f8c"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6680), 200 },
                    { new Guid("e0be6732-e266-40f7-9158-41ddc1930311"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6520), 209 },
                    { new Guid("e265e523-08f6-4352-ba9c-ab1dfae0721c"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6540), 204 },
                    { new Guid("e50eb0fa-e48f-4d99-b8b3-789d671f90b9"), 4, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6660), 207 },
                    { new Guid("e53bcc9b-33e1-462e-80be-997ebd4c81c6"), 5, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6690), 207 },
                    { new Guid("e60311b7-40db-491d-8a73-11d390054df2"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6530), 203 },
                    { new Guid("e7e9f836-80cb-421d-b891-a2ded2a6909d"), 2, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6540), 205 },
                    { new Guid("ed3b2c19-c3d4-4743-98ae-f5722bc1aae9"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6510), 205 },
                    { new Guid("f094201e-25a8-43fb-9d1a-ae272de862b2"), 1, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6480), 202 },
                    { new Guid("fdb6ff45-07c4-463f-b0c6-fd34ba6677c4"), 3, new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(6640), 210 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("526dd803-83c4-431a-9211-ac30445607c6"), null, new DateTime(2024, 3, 10, 4, 3, 41, 559, DateTimeKind.Utc).AddTicks(5650), "admin@gmail.com", "admin", 0, "$2a$11$yBdMeIprPipvkac.UeWiFeO9rrV8jE12xK9wTuLOgTfAs4h15ebKG", null, 3 },
                    { new Guid("5d209580-c292-48b0-847f-b95731dc663c"), null, new DateTime(2024, 3, 10, 4, 3, 41, 893, DateTimeKind.Utc).AddTicks(1950), "student@gmail.com", "student", 0, "$2a$11$ribaGKlMbDCqqkDp8L4dxetbe4tCItXAenouvsv2XPcOvmRponmJq", null, 0 },
                    { new Guid("9ed9b8e8-f1b4-4a3a-8ff8-c1fa07891f22"), null, new DateTime(2024, 3, 10, 4, 3, 41, 782, DateTimeKind.Utc).AddTicks(4170), "teacher@gmail.com", "teacher", 0, "$2a$11$0wY22IEt8l10BKcy9LzAk.l.Qh7DbNh0QEWB05MEKk7gRQK5hHLYG", null, 1 },
                    { new Guid("ee057118-ee9d-4668-952c-52572fea0bf6"), null, new DateTime(2024, 3, 10, 4, 3, 41, 670, DateTimeKind.Utc).AddTicks(1410), "dean@gmail.com", "dean", 0, "$2a$11$QBvCpxAB6rT2JmHNwo/MAuI/K8Hsl6R6rD7q4e62g.u1WGYRs3GeO", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("019bbb02-3813-4174-b8dc-4a8f73723b97"), new Guid("881c7004-092a-47f3-8889-417f94c69e9a"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7280), 0, null },
                    { new Guid("0faa77b4-2692-4f81-a60d-17cf1685b403"), new Guid("e60311b7-40db-491d-8a73-11d390054df2"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7200), 0, null },
                    { new Guid("178d8d6f-1b76-44a2-af3c-be2d9d4762e6"), new Guid("a7375a75-2472-4f89-b245-d24f220337b1"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7270), 0, null },
                    { new Guid("1afb190e-2cc6-44dc-89db-38ff4f1a2635"), new Guid("b51fec19-2869-4f7c-98c0-94995ba897bf"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7320), 0, null },
                    { new Guid("1bb7a10a-1b43-43d7-ba62-d8caa5d7e04a"), new Guid("316ea899-9cb8-4bd0-b44b-530591b419e7"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7280), 0, null },
                    { new Guid("1ed38495-5ec6-4811-bb6a-c983b49adac7"), new Guid("bdf26201-e92a-4869-9bad-1853d4a3bec4"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7180), 0, null },
                    { new Guid("1efba1c5-c094-477a-bba4-03bb971528fe"), new Guid("d2baac43-9f15-4ddd-b3a9-f1e26771a49c"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7190), 0, null },
                    { new Guid("1efd2ae6-32d6-4e67-be98-90e1ac5c22d5"), new Guid("36126804-f568-4b40-9aa0-c8fd4b0a0037"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7310), 0, null },
                    { new Guid("20d5bcd6-3e8b-4072-acc9-ddbd9c460519"), new Guid("dabddd74-37d9-4137-9e91-69644551ca24"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7260), 0, null },
                    { new Guid("29b51717-e62d-453c-babc-822b8c470d7d"), new Guid("629b5a2e-a283-456d-99fa-a60107e8904a"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7180), 0, null },
                    { new Guid("397c8e39-885d-4694-a111-267a31eb71ca"), new Guid("614610c2-8f1c-45be-bf20-c89f79c8a36e"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7210), 0, null },
                    { new Guid("44cd6372-89e7-449a-a0a3-35207951326f"), new Guid("bc170d25-6413-4d7e-aa7c-4900cd0535c2"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7300), 0, null },
                    { new Guid("496f0c01-fbed-49a0-805a-2553a66cd132"), new Guid("6e766a8a-3312-441b-9915-aced7ff3e458"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7180), 0, null },
                    { new Guid("4cced6d5-6090-4bd0-b031-a51190a3cfb2"), new Guid("9f4019c3-43dd-4283-99bf-0b1b4e847670"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7280), 0, null },
                    { new Guid("5e787aea-c4f3-4471-9163-4653c7fba74a"), new Guid("bf24b8ca-de67-42cc-b40c-1dd45f6729a3"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7170), 0, null },
                    { new Guid("600038e1-e024-433c-9388-da7df2a136a0"), new Guid("e0be6732-e266-40f7-9158-41ddc1930311"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7190), 0, null },
                    { new Guid("70b13bf2-dc87-4014-9d23-b48324386784"), new Guid("ba08f84c-9f6b-4c0b-b327-d4d226e42893"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7280), 0, null },
                    { new Guid("72bb2f04-e7c1-4b3e-9dc8-007007c4b494"), new Guid("3002213c-ce71-47cc-bdb5-25d5c57eb498"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7300), 0, null },
                    { new Guid("769224e4-61f4-407b-b640-f03ab6bafc62"), new Guid("ed3b2c19-c3d4-4743-98ae-f5722bc1aae9"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7180), 0, null },
                    { new Guid("7b6766f9-b762-4f25-bca7-35cdcac0e31e"), new Guid("60ffb073-3f6f-4b0c-a51f-1e3939f7879f"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7190), 0, null },
                    { new Guid("7cdc2e72-003a-408f-873d-ba44183a1b66"), new Guid("5b250c3c-50ee-4e36-8055-0e22628d99ec"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7270), 0, null },
                    { new Guid("7f3b8638-adb8-4fba-b4c2-af7be65eb820"), new Guid("a4113603-ed92-4262-9eda-965a027db2e3"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7190), 0, null },
                    { new Guid("8825af68-aeac-4705-94c4-09612f947d82"), new Guid("e50eb0fa-e48f-4d99-b8b3-789d671f90b9"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7290), 0, null },
                    { new Guid("8a0ef5b6-4d78-44ba-a734-433b2439d9a0"), new Guid("d9c81a84-0c39-45a1-ac19-104846f03ae8"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7290), 0, null },
                    { new Guid("906660cc-7b91-47ec-abf9-20eb4a93b1b3"), new Guid("1df03cd7-c86f-4549-9b1c-0f808bcd435c"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7220), 0, null },
                    { new Guid("9ac455d3-a60e-4c78-8598-4deb0cc07afc"), new Guid("e53bcc9b-33e1-462e-80be-997ebd4c81c6"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7320), 0, null },
                    { new Guid("9ed5edba-c0ab-4d2a-8a33-23281c2055e9"), new Guid("3adef3f1-27e4-47c6-93da-f5f49f25ae44"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7230), 0, null },
                    { new Guid("a221beb1-2c9b-4f3d-9e28-3d040da819ca"), new Guid("42014eff-8be4-4e82-9e79-57fa444ec8fc"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7330), 0, null },
                    { new Guid("a22d6f7b-fca7-44ad-b0cc-ac5064b5dfc8"), new Guid("6cbba81c-46e4-485a-ad62-babe5070a538"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7310), 0, null },
                    { new Guid("a47d1bda-b134-4c0e-803a-c4bc4c55fb45"), new Guid("7053ebf6-5c7e-43b5-9546-3a4da8aabff6"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7170), 0, null },
                    { new Guid("a6bed6b4-9be8-48a5-89e5-a309d075e5f4"), new Guid("db20f722-e4cd-41db-ad8b-983668164eae"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7210), 0, null },
                    { new Guid("b11a622e-ce55-4d65-84ab-de2a6b454720"), new Guid("cddf78ae-b9da-4a30-baf7-0bcdbbac2a79"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7160), 0, null },
                    { new Guid("b2272c26-570d-4c9d-84b6-348b9d6e1c33"), new Guid("234b66d4-edc9-44d2-8f96-751528bc5998"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7210), 0, null },
                    { new Guid("b2daac8e-3392-459f-96c4-0f6eec0d2c97"), new Guid("e265e523-08f6-4352-ba9c-ab1dfae0721c"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7200), 0, null },
                    { new Guid("b45a88c6-93ff-4fd8-80e2-ae38279118d8"), new Guid("2eeb3459-89f2-45c3-aeca-15893e83a109"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7290), 0, null },
                    { new Guid("b8ebe98e-7c65-4f1c-8b6b-2972031713a5"), new Guid("4c19adf9-9664-4cab-b414-776605eb6bea"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7170), 0, null },
                    { new Guid("b9ea5db4-d93d-48a8-b98d-b48813bbaf2a"), new Guid("fdb6ff45-07c4-463f-b0c6-fd34ba6677c4"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7270), 0, null },
                    { new Guid("be4f79cd-9128-48c9-a6f9-17cd0d1f23f6"), new Guid("bd00a96c-75b5-4781-870b-da2864adb4f2"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7330), 0, null },
                    { new Guid("be518907-ccd3-4cb2-a0c4-53794a4c04f0"), new Guid("b4745440-a3d5-4dad-9b4d-81e638920b51"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7270), 0, null },
                    { new Guid("cae04adc-21d4-4baa-ba59-53e78ae3e7fb"), new Guid("a67cb00f-d07f-4039-8dbb-0ff772b6519b"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7320), 0, null },
                    { new Guid("cdb3faea-e272-4fe6-980f-1ebcf039ee7a"), new Guid("f094201e-25a8-43fb-9d1a-ae272de862b2"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7170), 0, null },
                    { new Guid("d5de18d7-8281-4f76-9711-a55bcaf85fef"), new Guid("9bdaec8b-28d5-4bf1-9ba3-4f4231d8f6f3"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7200), 0, null },
                    { new Guid("d764f8e8-3fe7-4d50-aeda-fc194b6555ba"), new Guid("62eb98ba-5494-4ff8-b1e1-285fcafd70c9"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7290), 0, null },
                    { new Guid("ddf1edd8-4099-4677-865c-3f18a25dd321"), new Guid("b817c1d3-e593-4be4-bce6-e78b2bee9e8d"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7310), 0, null },
                    { new Guid("e2adf901-6df2-43a3-9c0d-7b213a8069fa"), new Guid("9960d9ed-d6bc-45ef-bf9d-7d52e2401d23"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7220), 0, null },
                    { new Guid("e39e9b6b-c290-4c8a-adf7-484a64281832"), new Guid("a44615a8-9ccf-4b3e-ba5f-2a49afc6f2d6"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7210), 0, null },
                    { new Guid("e5edf320-1028-4792-9a71-85b690e3875d"), new Guid("c6d3ea63-bf32-4ec3-8732-69cfcd186555"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7230), 0, null },
                    { new Guid("e7f6ccd5-ca96-43e9-a704-bf116be69be8"), new Guid("e7e9f836-80cb-421d-b891-a2ded2a6909d"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7200), 0, null },
                    { new Guid("e83cf677-c66c-4887-adac-a265977d91ad"), new Guid("778fa6e5-de5b-4466-9549-c018b0cf2d89"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7260), 0, null },
                    { new Guid("eb8b6cc7-2524-4d00-b170-bd91c656d73a"), new Guid("cba64341-3dea-4f52-8d9c-4a578d5c12c8"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7300), 0, null },
                    { new Guid("ef731c85-4a81-4afb-b660-7002c731e792"), new Guid("e0ab6b3a-d5ad-49e5-8484-fee592613f8c"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7300), 0, null },
                    { new Guid("f2a4f2d1-a8d8-434b-a01a-74e214069e1a"), new Guid("2b96eb37-9871-479d-917b-3791472b04a3"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7320), 0, null },
                    { new Guid("f4657f1d-6482-43e2-8d7a-d95280fc8e81"), new Guid("22f4aa08-1549-41d2-8c86-3dfab2aa49f5"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7220), 0, null },
                    { new Guid("f58093cb-792b-4c14-ab4e-a5390adecbf1"), new Guid("8f2f9e28-646d-4c70-9a90-5b83bc233492"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7220), 0, null },
                    { new Guid("f72e4f65-f236-4eda-8891-8aa5fd9c251b"), new Guid("a625ede8-243e-4f2a-9537-9eb9493d8698"), new DateTime(2024, 3, 10, 4, 3, 42, 3, DateTimeKind.Utc).AddTicks(7300), 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransferKeyRequests_KeyId",
                table: "TransferKeyRequests",
                column: "KeyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferKeyRequests",
                table: "TransferKeyRequests");

            migrationBuilder.DropIndex(
                name: "IX_TransferKeyRequests_KeyId",
                table: "TransferKeyRequests");

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("019bbb02-3813-4174-b8dc-4a8f73723b97"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0faa77b4-2692-4f81-a60d-17cf1685b403"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("178d8d6f-1b76-44a2-af3c-be2d9d4762e6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1afb190e-2cc6-44dc-89db-38ff4f1a2635"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1bb7a10a-1b43-43d7-ba62-d8caa5d7e04a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1ed38495-5ec6-4811-bb6a-c983b49adac7"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1efba1c5-c094-477a-bba4-03bb971528fe"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1efd2ae6-32d6-4e67-be98-90e1ac5c22d5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("20d5bcd6-3e8b-4072-acc9-ddbd9c460519"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("29b51717-e62d-453c-babc-822b8c470d7d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("397c8e39-885d-4694-a111-267a31eb71ca"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("44cd6372-89e7-449a-a0a3-35207951326f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("496f0c01-fbed-49a0-805a-2553a66cd132"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4cced6d5-6090-4bd0-b031-a51190a3cfb2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5e787aea-c4f3-4471-9163-4653c7fba74a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("600038e1-e024-433c-9388-da7df2a136a0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("70b13bf2-dc87-4014-9d23-b48324386784"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("72bb2f04-e7c1-4b3e-9dc8-007007c4b494"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("769224e4-61f4-407b-b640-f03ab6bafc62"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7b6766f9-b762-4f25-bca7-35cdcac0e31e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7cdc2e72-003a-408f-873d-ba44183a1b66"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7f3b8638-adb8-4fba-b4c2-af7be65eb820"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8825af68-aeac-4705-94c4-09612f947d82"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8a0ef5b6-4d78-44ba-a734-433b2439d9a0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("906660cc-7b91-47ec-abf9-20eb4a93b1b3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9ac455d3-a60e-4c78-8598-4deb0cc07afc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9ed5edba-c0ab-4d2a-8a33-23281c2055e9"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a221beb1-2c9b-4f3d-9e28-3d040da819ca"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a22d6f7b-fca7-44ad-b0cc-ac5064b5dfc8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a47d1bda-b134-4c0e-803a-c4bc4c55fb45"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a6bed6b4-9be8-48a5-89e5-a309d075e5f4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b11a622e-ce55-4d65-84ab-de2a6b454720"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b2272c26-570d-4c9d-84b6-348b9d6e1c33"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b2daac8e-3392-459f-96c4-0f6eec0d2c97"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b45a88c6-93ff-4fd8-80e2-ae38279118d8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b8ebe98e-7c65-4f1c-8b6b-2972031713a5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b9ea5db4-d93d-48a8-b98d-b48813bbaf2a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("be4f79cd-9128-48c9-a6f9-17cd0d1f23f6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("be518907-ccd3-4cb2-a0c4-53794a4c04f0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cae04adc-21d4-4baa-ba59-53e78ae3e7fb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cdb3faea-e272-4fe6-980f-1ebcf039ee7a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d5de18d7-8281-4f76-9711-a55bcaf85fef"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d764f8e8-3fe7-4d50-aeda-fc194b6555ba"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ddf1edd8-4099-4677-865c-3f18a25dd321"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e2adf901-6df2-43a3-9c0d-7b213a8069fa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e39e9b6b-c290-4c8a-adf7-484a64281832"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e5edf320-1028-4792-9a71-85b690e3875d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e7f6ccd5-ca96-43e9-a704-bf116be69be8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e83cf677-c66c-4887-adac-a265977d91ad"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("eb8b6cc7-2524-4d00-b170-bd91c656d73a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ef731c85-4a81-4afb-b660-7002c731e792"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f2a4f2d1-a8d8-434b-a01a-74e214069e1a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f4657f1d-6482-43e2-8d7a-d95280fc8e81"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f58093cb-792b-4c14-ab4e-a5390adecbf1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f72e4f65-f236-4eda-8891-8aa5fd9c251b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("526dd803-83c4-431a-9211-ac30445607c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d209580-c292-48b0-847f-b95731dc663c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ed9b8e8-f1b4-4a3a-8ff8-c1fa07891f22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee057118-ee9d-4668-952c-52572fea0bf6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1df03cd7-c86f-4549-9b1c-0f808bcd435c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22f4aa08-1549-41d2-8c86-3dfab2aa49f5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("234b66d4-edc9-44d2-8f96-751528bc5998"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2b96eb37-9871-479d-917b-3791472b04a3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2eeb3459-89f2-45c3-aeca-15893e83a109"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3002213c-ce71-47cc-bdb5-25d5c57eb498"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("316ea899-9cb8-4bd0-b44b-530591b419e7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("36126804-f568-4b40-9aa0-c8fd4b0a0037"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3adef3f1-27e4-47c6-93da-f5f49f25ae44"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("42014eff-8be4-4e82-9e79-57fa444ec8fc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4c19adf9-9664-4cab-b414-776605eb6bea"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5b250c3c-50ee-4e36-8055-0e22628d99ec"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("60ffb073-3f6f-4b0c-a51f-1e3939f7879f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("614610c2-8f1c-45be-bf20-c89f79c8a36e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("629b5a2e-a283-456d-99fa-a60107e8904a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("62eb98ba-5494-4ff8-b1e1-285fcafd70c9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6cbba81c-46e4-485a-ad62-babe5070a538"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6e766a8a-3312-441b-9915-aced7ff3e458"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7053ebf6-5c7e-43b5-9546-3a4da8aabff6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("778fa6e5-de5b-4466-9549-c018b0cf2d89"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("881c7004-092a-47f3-8889-417f94c69e9a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8f2f9e28-646d-4c70-9a90-5b83bc233492"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9960d9ed-d6bc-45ef-bf9d-7d52e2401d23"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9bdaec8b-28d5-4bf1-9ba3-4f4231d8f6f3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9f4019c3-43dd-4283-99bf-0b1b4e847670"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a4113603-ed92-4262-9eda-965a027db2e3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a44615a8-9ccf-4b3e-ba5f-2a49afc6f2d6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a625ede8-243e-4f2a-9537-9eb9493d8698"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a67cb00f-d07f-4039-8dbb-0ff772b6519b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a7375a75-2472-4f89-b245-d24f220337b1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b4745440-a3d5-4dad-9b4d-81e638920b51"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b51fec19-2869-4f7c-98c0-94995ba897bf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b817c1d3-e593-4be4-bce6-e78b2bee9e8d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ba08f84c-9f6b-4c0b-b327-d4d226e42893"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bc170d25-6413-4d7e-aa7c-4900cd0535c2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bd00a96c-75b5-4781-870b-da2864adb4f2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bdf26201-e92a-4869-9bad-1853d4a3bec4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bf24b8ca-de67-42cc-b40c-1dd45f6729a3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c6d3ea63-bf32-4ec3-8732-69cfcd186555"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cba64341-3dea-4f52-8d9c-4a578d5c12c8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cddf78ae-b9da-4a30-baf7-0bcdbbac2a79"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2baac43-9f15-4ddd-b3a9-f1e26771a49c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d9c81a84-0c39-45a1-ac19-104846f03ae8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("dabddd74-37d9-4137-9e91-69644551ca24"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("db20f722-e4cd-41db-ad8b-983668164eae"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e0ab6b3a-d5ad-49e5-8484-fee592613f8c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e0be6732-e266-40f7-9158-41ddc1930311"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e265e523-08f6-4352-ba9c-ab1dfae0721c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e50eb0fa-e48f-4d99-b8b3-789d671f90b9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e53bcc9b-33e1-462e-80be-997ebd4c81c6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e60311b7-40db-491d-8a73-11d390054df2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e7e9f836-80cb-421d-b891-a2ded2a6909d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ed3b2c19-c3d4-4743-98ae-f5722bc1aae9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f094201e-25a8-43fb-9d1a-ae272de862b2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fdb6ff45-07c4-463f-b0c6-fd34ba6677c4"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TransferKeyRequests");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "TransferKeyRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferKeyRequests",
                table: "TransferKeyRequests",
                columns: new[] { "KeyId", "RecipientId" });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("029da668-f86f-4a64-8d8a-75cbd02423d8"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9860), 200 },
                    { new Guid("02c16dfc-9c2f-4e6c-984a-254f6cd26936"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9960), 206 },
                    { new Guid("054e02f5-3be1-426b-8560-a4bd02d83cbf"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(40), 208 },
                    { new Guid("06961358-d364-4e65-96c7-1a2f53da9d68"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(80), 201 },
                    { new Guid("0e195743-b407-4155-a25b-38cbf726985b"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9930), 204 },
                    { new Guid("0f821ebe-5456-466c-b394-e28b21c5ebe6"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9920), 201 },
                    { new Guid("1816ade5-714e-4ea5-9aba-49a4ec7dbe13"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(100), 206 },
                    { new Guid("1ce6eb0a-5591-4fe0-aa83-9be6c4bb97bb"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(70), 206 },
                    { new Guid("1dfd674f-0859-417b-9c47-ddc4fde08545"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(40), 209 },
                    { new Guid("231c731c-7f71-4c00-bccf-5c2c64f03a1e"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9970), 209 },
                    { new Guid("2897600a-13e1-4b98-9a8b-43659909b1b3"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9920), 203 },
                    { new Guid("2fa9409e-311b-47c8-a06e-ddb5bb3bb99d"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(80), 209 },
                    { new Guid("317f7a6c-cddb-4ff0-b655-770709f7bfba"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(100), 209 },
                    { new Guid("3b0848ff-9e77-4665-a605-a53a309f6e7a"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9950), 202 },
                    { new Guid("3c0c19e8-2fe4-4193-b1d4-cca242feb570"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(100), 208 },
                    { new Guid("3cef97ab-c08c-4876-af22-e7627e319ec4"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9950), 201 },
                    { new Guid("40470fb9-ac7b-46f0-9bc0-43a0d4f4478e"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(10), 201 },
                    { new Guid("455f64ad-143d-473f-82ba-5c808560e872"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(100), 207 },
                    { new Guid("47bb6675-0d23-4528-952e-ceb046e3ee62"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(90), 204 },
                    { new Guid("486ccb32-1f38-4f10-ab7a-7203744b55c4"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(20), 204 },
                    { new Guid("4ee853a1-6ce0-48a7-9b0e-e30ff051ea3d"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9960), 203 },
                    { new Guid("53f2b763-76cd-4a18-acba-1ea1caf460fe"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(30), 206 },
                    { new Guid("561e6743-fef8-42ca-84d6-c71a1d35f227"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9940), 207 },
                    { new Guid("5cc6aeb7-f5b3-4f51-9be7-7f37b196d9ef"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9970), 208 },
                    { new Guid("5e888a85-d674-4727-b3d9-e8641ff157a9"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(30), 205 },
                    { new Guid("645daf2c-0788-465a-98f2-443ced657d4b"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9950), 210 },
                    { new Guid("6597fc3b-4b6b-4ef1-94bc-63699d7f1f79"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9940), 206 },
                    { new Guid("66149d1f-9f3e-4bbd-9ac6-743d7a6afdc6"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9950), 200 },
                    { new Guid("69e95ee8-af8b-47eb-a6a1-34cb92ff098d"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(50), 210 },
                    { new Guid("6ac86a87-6b39-4a94-b8f9-4b261a35a18d"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(60), 202 },
                    { new Guid("727e8eda-113b-4628-8ffa-4b268e675b32"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(90), 203 },
                    { new Guid("854e9792-2c57-4707-8be4-398dece1c835"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9930), 205 },
                    { new Guid("89d89b7a-0a09-44b2-881c-9cc0a42180e2"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(60), 203 },
                    { new Guid("911c73c4-95ba-4133-8617-7c934c6b36db"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(10), 203 },
                    { new Guid("97184f0a-1433-4675-b37b-99aaa84ec966"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(50), 200 },
                    { new Guid("97d832c6-1230-4c5b-9105-04aabf9c67a9"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(110), 210 },
                    { new Guid("9ac76204-9c43-4758-ba85-709599d5c086"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc), 200 },
                    { new Guid("a46220a7-64fc-493d-babb-a5c548d11f95"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(50), 201 },
                    { new Guid("a911f444-5d22-40ab-9592-f16bad08ad6d"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(60), 204 },
                    { new Guid("aed7f9e3-a88c-481e-884c-41059113f307"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9940), 209 },
                    { new Guid("bd83aec2-58bf-4468-a282-9060c840ecc8"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(60), 205 },
                    { new Guid("c63e6bd0-e712-48e5-86ad-364a46a9cf95"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9940), 208 },
                    { new Guid("c8c873e7-669a-46d9-9406-513456192bfa"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(40), 207 },
                    { new Guid("cac074ab-0c73-440f-b83e-25dc5b0df244"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(90), 202 },
                    { new Guid("cdb41023-c1d3-4560-9f33-a1f7c60a0ebc"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(80), 210 },
                    { new Guid("d03ef224-e56a-4915-b328-0c6361eb2c66"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9960), 205 },
                    { new Guid("d1e3f3d7-675d-48b5-b0ea-bead6faf4f01"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(70), 208 },
                    { new Guid("d392cc41-e63e-48ac-be89-a6a825ece3fb"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(90), 205 },
                    { new Guid("dc74b82b-a82b-44cd-819d-fd1c0beda725"), 5, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(80), 200 },
                    { new Guid("dd69139d-5456-4725-9285-8cd4bda63203"), 3, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(10), 202 },
                    { new Guid("e55d21d9-572e-4646-911c-44f9e7a12456"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9960), 204 },
                    { new Guid("ea59bbe5-027a-468b-8836-3ce0b42782c3"), 4, new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(70), 207 },
                    { new Guid("ed6e064a-9231-4d9f-ab95-d828f6ee35d5"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9960), 207 },
                    { new Guid("fac3a3e8-b15c-40e0-a871-3d0f7e5f94b3"), 1, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9920), 202 },
                    { new Guid("fc86dc15-4d97-436e-9902-3d0128afb605"), 2, new DateTime(2024, 3, 10, 3, 57, 34, 588, DateTimeKind.Utc).AddTicks(9970), 210 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("51540c49-d30f-45d0-9abf-de9bc9a8d2bb"), null, new DateTime(2024, 3, 10, 3, 57, 34, 369, DateTimeKind.Utc).AddTicks(2810), "teacher@gmail.com", "teacher", 0, "$2a$11$azMjJzgYlvtVrHhjJxJpsu.ymmo9w9UC/SKp9dO.5Q.k4ehd9DNXi", null, 1 },
                    { new Guid("7946583b-13ef-406b-8a7a-6738c3105987"), null, new DateTime(2024, 3, 10, 3, 57, 34, 254, DateTimeKind.Utc).AddTicks(8240), "dean@gmail.com", "dean", 0, "$2a$11$vG8wBr7.dsgUMc3/aOXut.BQJOLgHb5g1ocKJ7IM4XHBlYRYD.suW", null, 2 },
                    { new Guid("ae3842de-d8c5-400e-81a6-63e1a826668b"), null, new DateTime(2024, 3, 10, 3, 57, 34, 145, DateTimeKind.Utc).AddTicks(6950), "admin@gmail.com", "admin", 0, "$2a$11$GKCr5qLxSWYBT1tz.isEvO5U0MdJaIjI9Ufh/DygenvdGo9QS6B42", null, 3 },
                    { new Guid("feecb044-7935-4e55-9245-445e258384ee"), null, new DateTime(2024, 3, 10, 3, 57, 34, 480, DateTimeKind.Utc).AddTicks(6950), "student@gmail.com", "student", 0, "$2a$11$UGdyI7X5aPZtmCCz9MDhCe61CaAMtAjeykU0YZxa48gCv.1IxNnUy", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("06995d50-ea5e-4c77-bc39-4b9bdad610cf"), new Guid("054e02f5-3be1-426b-8560-a4bd02d83cbf"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(820), 0, null },
                    { new Guid("0a30539e-05cd-4ed4-a84f-c4da499071b6"), new Guid("fac3a3e8-b15c-40e0-a871-3d0f7e5f94b3"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(750), 0, null },
                    { new Guid("134f0b04-5f5c-4971-9c6f-7760509be75f"), new Guid("ea59bbe5-027a-468b-8836-3ce0b42782c3"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(840), 0, null },
                    { new Guid("13508d9d-4fe0-4ca5-a262-7c8219c3ced4"), new Guid("6ac86a87-6b39-4a94-b8f9-4b261a35a18d"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(830), 0, null },
                    { new Guid("180ab39b-53bd-4748-85af-fad2c9fccf33"), new Guid("455f64ad-143d-473f-82ba-5c808560e872"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(870), 0, null },
                    { new Guid("18644e06-d34f-400e-aeff-ffd595cf86a9"), new Guid("d1e3f3d7-675d-48b5-b0ea-bead6faf4f01"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(850), 0, null },
                    { new Guid("18a65db9-f47e-4c55-ae22-a3685237fe96"), new Guid("bd83aec2-58bf-4468-a282-9060c840ecc8"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(840), 0, null },
                    { new Guid("1c7f4d4c-cddb-41ff-9ca3-98c554c530e2"), new Guid("a46220a7-64fc-493d-babb-a5c548d11f95"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(830), 0, null },
                    { new Guid("23594341-cf2a-4eb9-810b-3e21ae72f774"), new Guid("029da668-f86f-4a64-8d8a-75cbd02423d8"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(730), 0, null },
                    { new Guid("27568a47-15ea-4eac-a651-7f8295780818"), new Guid("6597fc3b-4b6b-4ef1-94bc-63699d7f1f79"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(760), 0, null },
                    { new Guid("2a8b82d6-aa62-4387-964b-b27964c838b1"), new Guid("0e195743-b407-4155-a25b-38cbf726985b"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(750), 0, null },
                    { new Guid("2e0d2170-a102-43f0-8138-51b205ddf388"), new Guid("47bb6675-0d23-4528-952e-ceb046e3ee62"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(860), 0, null },
                    { new Guid("3212e069-6d52-4c89-b3c8-970e33295216"), new Guid("e55d21d9-572e-4646-911c-44f9e7a12456"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(780), 0, null },
                    { new Guid("3e174f70-cb28-4204-8dda-641233b47296"), new Guid("3c0c19e8-2fe4-4193-b1d4-cca242feb570"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(880), 0, null },
                    { new Guid("40ffeeec-4581-4526-a9fb-1bd5ae59fb31"), new Guid("645daf2c-0788-465a-98f2-443ced657d4b"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(770), 0, null },
                    { new Guid("426fdce5-cc0b-4b81-9d38-b20cd750e952"), new Guid("231c731c-7f71-4c00-bccf-5c2c64f03a1e"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(790), 0, null },
                    { new Guid("46cfa060-f79b-4845-8c87-7a485da8d348"), new Guid("c63e6bd0-e712-48e5-86ad-364a46a9cf95"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(760), 0, null },
                    { new Guid("478426c2-291d-4900-aef9-af312ba4b2cb"), new Guid("2897600a-13e1-4b98-9a8b-43659909b1b3"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(750), 0, null },
                    { new Guid("482c2304-29a3-462e-9e65-751480fbd08a"), new Guid("06961358-d364-4e65-96c7-1a2f53da9d68"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(860), 0, null },
                    { new Guid("4c0d67d4-bf73-4436-a68f-27dacdc5ca90"), new Guid("02c16dfc-9c2f-4e6c-984a-254f6cd26936"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(780), 0, null },
                    { new Guid("5be5d8ac-58ad-40d9-9e00-960e747f7273"), new Guid("1ce6eb0a-5591-4fe0-aa83-9be6c4bb97bb"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(840), 0, null },
                    { new Guid("60007d23-2ffd-41eb-bf17-4dc362dbcf7e"), new Guid("5e888a85-d674-4727-b3d9-e8641ff157a9"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(810), 0, null },
                    { new Guid("6078dcc9-c52d-4563-b0ad-d9fdee023463"), new Guid("cac074ab-0c73-440f-b83e-25dc5b0df244"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(860), 0, null },
                    { new Guid("653ea1b9-7e2e-49a5-bd67-47658e5dd353"), new Guid("d392cc41-e63e-48ac-be89-a6a825ece3fb"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(870), 0, null },
                    { new Guid("673b2c00-7f3f-48d1-8704-364337c0e0bb"), new Guid("1dfd674f-0859-417b-9c47-ddc4fde08545"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(820), 0, null },
                    { new Guid("67fcd0da-2946-4043-bb10-77be1d5892cc"), new Guid("a911f444-5d22-40ab-9592-f16bad08ad6d"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(840), 0, null },
                    { new Guid("6d2a19aa-6745-45f7-9ac7-57717a1f387c"), new Guid("89d89b7a-0a09-44b2-881c-9cc0a42180e2"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(840), 0, null },
                    { new Guid("75a01a64-d28e-4794-8e68-fa250050168f"), new Guid("fc86dc15-4d97-436e-9902-3d0128afb605"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(800), 0, null },
                    { new Guid("770c1b10-38af-40a7-8712-6ef4bf3f02d3"), new Guid("97184f0a-1433-4675-b37b-99aaa84ec966"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(830), 0, null },
                    { new Guid("779a9675-98d1-45c2-be69-520b3d6ee68e"), new Guid("9ac76204-9c43-4758-ba85-709599d5c086"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(800), 0, null },
                    { new Guid("7c7b068f-2dd0-4943-9b45-5722ea5da154"), new Guid("3b0848ff-9e77-4665-a605-a53a309f6e7a"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(770), 0, null },
                    { new Guid("84e1a94a-1803-4104-ba1e-21acedfcebee"), new Guid("ed6e064a-9231-4d9f-ab95-d828f6ee35d5"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(790), 0, null },
                    { new Guid("89ab668d-6ea5-4d4d-a4ee-5f8cb74b6137"), new Guid("854e9792-2c57-4707-8be4-398dece1c835"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(750), 0, null },
                    { new Guid("8b4f95e0-5633-47b0-b33a-b7a1c0d257c0"), new Guid("5cc6aeb7-f5b3-4f51-9be7-7f37b196d9ef"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(790), 0, null },
                    { new Guid("8c372eea-c817-491c-84dd-6763e4be9a98"), new Guid("53f2b763-76cd-4a18-acba-1ea1caf460fe"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(820), 0, null },
                    { new Guid("9355964c-69d6-4129-b9e3-6b6325376597"), new Guid("561e6743-fef8-42ca-84d6-c71a1d35f227"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(760), 0, null },
                    { new Guid("95dd280b-f954-4dc4-8725-c500f5ebe4f8"), new Guid("97d832c6-1230-4c5b-9105-04aabf9c67a9"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(880), 0, null },
                    { new Guid("a6c2553a-36bf-41de-ae36-7668739c15ee"), new Guid("aed7f9e3-a88c-481e-884c-41059113f307"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(760), 0, null },
                    { new Guid("a93eef46-b50f-4050-8213-a9975e7c78ed"), new Guid("486ccb32-1f38-4f10-ab7a-7203744b55c4"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(810), 0, null },
                    { new Guid("a9db2eb9-bd7e-43b1-81f8-b396496b71c3"), new Guid("0f821ebe-5456-466c-b394-e28b21c5ebe6"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(740), 0, null },
                    { new Guid("ac4a7461-6084-41c3-9420-de5b85fccb3b"), new Guid("69e95ee8-af8b-47eb-a6a1-34cb92ff098d"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(830), 0, null },
                    { new Guid("b36921b9-d88a-47ad-84ba-3f61ff34825a"), new Guid("2fa9409e-311b-47c8-a06e-ddb5bb3bb99d"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(850), 0, null },
                    { new Guid("b6529a39-3740-4931-81a3-322fd981c202"), new Guid("911c73c4-95ba-4133-8617-7c934c6b36db"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(810), 0, null },
                    { new Guid("bb266f8a-9906-4196-9b61-69ecd335da75"), new Guid("3cef97ab-c08c-4876-af22-e7627e319ec4"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(770), 0, null },
                    { new Guid("bf1a98a7-f68d-46bf-87ce-b1361ad155a5"), new Guid("1816ade5-714e-4ea5-9aba-49a4ec7dbe13"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(870), 0, null },
                    { new Guid("c61c8793-9f7a-40ee-82c2-36b04c548802"), new Guid("cdb41023-c1d3-4560-9f33-a1f7c60a0ebc"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(850), 0, null },
                    { new Guid("cbb711d6-71ec-4cf7-a925-dbaac2a76076"), new Guid("4ee853a1-6ce0-48a7-9b0e-e30ff051ea3d"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(780), 0, null },
                    { new Guid("cda682d8-0ee6-46e3-ad27-c6fb723ddd72"), new Guid("dd69139d-5456-4725-9285-8cd4bda63203"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(810), 0, null },
                    { new Guid("dd73f946-1896-4564-bdb9-e24a2cd528c0"), new Guid("317f7a6c-cddb-4ff0-b655-770709f7bfba"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(880), 0, null },
                    { new Guid("df3ef4ca-d3bd-4be3-acf1-065347be7862"), new Guid("40470fb9-ac7b-46f0-9bc0-43a0d4f4478e"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(800), 0, null },
                    { new Guid("e002c00e-a531-4b36-b52c-3375cb0ab839"), new Guid("66149d1f-9f3e-4bbd-9ac6-743d7a6afdc6"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(770), 0, null },
                    { new Guid("e04f6b73-f8e8-44f6-ae1f-d36ec24abd27"), new Guid("d03ef224-e56a-4915-b328-0c6361eb2c66"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(780), 0, null },
                    { new Guid("e400d63e-03e6-4f3e-830f-7404af86662b"), new Guid("c8c873e7-669a-46d9-9406-513456192bfa"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(820), 0, null },
                    { new Guid("f4b7e5a2-04d4-4c68-99a3-0cd0523a8e2f"), new Guid("dc74b82b-a82b-44cd-819d-fd1c0beda725"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(850), 0, null },
                    { new Guid("f82d953f-09be-4aad-ba4a-5c463e21e56c"), new Guid("727e8eda-113b-4628-8ffa-4b268e675b32"), new DateTime(2024, 3, 10, 3, 57, 34, 589, DateTimeKind.Utc).AddTicks(860), 0, null }
                });
        }
    }
}
