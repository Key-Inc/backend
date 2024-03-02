using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKeyRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("01b7049d-66de-4f07-954a-c500424f8a67"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("04e938ab-6b22-412e-a8f3-42920dfd3b19"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("06783507-c52f-4fc5-bf93-4c41b282ce7d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0a559c17-fe5c-418c-a058-1066846565a3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0a8b9d04-2a2f-4d1a-a4fa-374a7d9a8e1a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0bafc1a9-3535-46b1-b8eb-870c4c2c009f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0ee588f0-0c5f-4290-8d88-e986047a21f6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("138fe27e-04ac-4e72-b22e-32f29a2a10d2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1e2401c8-8d91-46a4-8993-9a72c1b3ed07"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1e27b238-fa68-48de-96ff-944afd3275af"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("215eddfb-c2ca-4be3-8af6-94f67a1dea42"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("26e7c8cd-5d68-4af3-af2c-4c6315fa971b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2e95f873-5d6d-4f18-9bc9-e05fa628402a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2f525b0c-510a-45b6-b3bb-164d0d255d5b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2f68e75c-bbd9-443d-99a3-5a7e3a6e6f98"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("30550ea0-dc6e-4031-a39d-5e899dc46344"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("368b8dab-be80-47f2-843e-7c4b816e8d94"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3b41ad47-e8a8-40a9-9c34-f0b3a27f644a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3fcd542d-8a7e-46ce-8465-fafe2fb2ae7e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3fe58b5b-e352-4970-97c9-adfce660d56e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("40b6a5c4-a247-434d-949b-d75672284dac"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4348876a-0691-4f43-8129-57dcc58d8791"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4d76c165-3a09-4c74-8830-16691c110996"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("51a568fd-0ae5-4705-ac07-d749626d805e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("632b93b0-0eba-498d-825c-15e9245ffa82"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7d35605d-0777-491c-b10f-e3278c335abc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("81c71b07-1314-4df1-94e3-4fd291422c60"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8757e5ae-c1e8-4a3a-a6b2-676acda3dee6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8f4377aa-f850-4e18-b346-c7dfebe994c3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("917e593b-1496-41b8-b76a-61eb0e36bf0a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9afb3eeb-6401-4485-8fe7-7f1c9c358f09"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9f75fe08-eeb5-41d5-a26f-e913598e2ef1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a1bc8a50-0c3e-4eb9-a355-9d95bb8bc930"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a780d7eb-1eb5-483f-ac87-8fcd13d742b6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a80d519c-71c2-4a6a-8cd8-7faeb03b13ac"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b2a7460e-727c-45d1-9878-73a032d6aa79"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b54d1560-2661-4a6a-bf94-3be29714c68f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bd4daa24-6e4d-4528-a195-317782cdd4bb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bd845890-5642-42b5-94ec-f2063d6ffede"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c0bb17ea-4f58-4bbb-9c93-1446bfa6ee05"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c2093c41-a3a6-4657-9786-e429547145a2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c6b94177-4022-48ea-8940-504cf3ea3fc9"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c80c923f-c91f-48cf-9f23-9a7c075425a6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c9327c1b-8ab9-431a-80d7-15740245a98e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d2518d4b-19e0-491c-9064-1c034a06fc71"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d8124308-04f3-4de4-8735-a9b420a9db55"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d96ced3e-1dbd-4234-907c-dc4ef5c326ed"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("de33eb4a-dbb9-4a6b-9a64-27ff4afcab53"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e0d25e7f-2760-417a-940b-9320ef0b1263"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("eec38b63-3de0-4554-92ca-522c0d8bc855"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f096773f-6d9d-4039-8469-99ea1151a555"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f0d50435-5624-41cd-86f3-f696db85f951"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f7e1065b-cc5b-482f-914b-ccc436f915e1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("fa664f91-ae92-48e9-a1cb-c09edcca3806"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("fc9fb605-4768-475c-8bf3-e425f39f411f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("300acba5-b104-4a2c-9854-11889f153a82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30a1e9fb-3a4f-474e-8a56-3820baaf35dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fefe082-1e41-42aa-aa8b-bdb2e56e9b48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("533d38d6-bb99-4ac3-a0d1-78b19300dd7c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("021f3121-2a8d-4380-87a4-46c24f369091"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("03377b7d-f83d-45f5-9b15-595773610f45"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05330fd4-2509-44ed-ad97-a72d3e5aefe9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05779436-1d6a-472a-a743-53e638a0f4cd"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05bba24c-525c-4fc7-b000-53f822a5624f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0754f3e1-3515-4553-b2a8-16c52c5130fb"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0af21a18-cb5d-438d-9950-c74ba7dd7195"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0c993341-f269-4c68-948c-e41b5f1252aa"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0f575359-5814-4609-bb30-c663b05338ed"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1214b8e5-2b1f-4790-b4b7-a98c078c978a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1fe25d1a-795f-4a2f-9871-18eb3f775d98"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("207b4582-a685-4208-9a88-997c8dc92f5b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("20c9956c-d2e7-4654-bdf2-a7b1b248536f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("284a99e6-57c9-408d-b745-3ccc42135c91"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("28f43699-5103-4305-af7d-918d520f8acb"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2a2ed7d6-4221-4e4b-8a76-ef7d76c47707"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2e598d0e-e449-46b5-a3aa-59f1bab00f0f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("30f6d5ed-2de2-4e53-a362-e672fb9b6468"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3b74d744-6482-4eb3-b591-3978988476ce"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3d52ddb5-b5e0-4b88-9b05-85e6ea41726b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("43d2fd6c-2261-404b-bc3e-e92fd724e384"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("493d60e0-d865-42b4-bb9e-cf18839bd447"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4a96fb6b-b16e-4695-b8c3-5947052a4ac1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4d2a603a-6f4b-428a-85cb-40f7ffbff3ba"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4dd481e1-aea8-4ef2-a212-056f1484b408"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("60479f87-6ba7-465d-af78-634d0c5cc82b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("690756ba-88ad-4f1f-9daf-a6869b168be3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("69d22e63-2525-48b1-ab7e-09310a02e386"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6d1e58ce-d789-41df-b978-8202e56dfe3f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("70404744-ee3a-4eda-b458-3f0d3c9d932d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("71e8086a-2912-4beb-8ffb-787d9c3774af"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7584691e-1b69-4e87-bc54-5e23543ea27f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7ca539d6-c053-4f64-aed1-30feecc9316c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8070e7c2-b9ac-4e2a-8229-a3fcacb5cfe9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("81fce5b8-c18f-453e-9bdb-f2acd4956b21"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("833d611b-e232-43ea-881d-f1b87686b50d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("83ed74dd-c50f-45ac-8fc9-db8eb506d748"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("87f2771f-734d-4339-a88b-14e677357782"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("88a723b4-7b98-475f-bd68-e6476565c827"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8b31ffc9-1f14-49ab-a40e-6abbb0a1b277"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("934c2cdb-1f46-4b84-8b32-442a7b0626ba"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("986b65dd-ed95-453e-ad81-12e3defc5ca2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ab2c3b70-93eb-4fda-af8c-1b472c0e61b1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b4de0889-30db-4c78-bcea-ad7503ee982a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c11d8194-3a60-43ff-8f90-615ccafdfc3c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c8c262ec-72ae-4bc1-ba45-2787a12fa87b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cee10807-33e2-45fb-a0dd-52e7bf41ed87"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d1e8157d-7318-4e0e-bb9d-e2817289db49"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d41f2273-ba0c-47da-aa96-0005f8e190db"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e446d1bb-d49b-40d1-8827-8d8e8de6d73d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ea1f2717-bc56-4149-ab6e-2440dfc9e574"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f17955ba-0ffd-4b5b-9674-dfacbb04c265"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f49deeb1-c78d-4804-ab60-54f05ec213b2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fb08a950-c382-4de5-a833-07c38aa925b3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fecf6b80-40e0-495e-b2e6-cdeb7f91d71d"));

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndDateOfRecurrence",
                table: "KeyRequests",
                type: "date",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("0e266621-c57c-404b-9366-94069bfa4ac7"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(417), 207 },
                    { new Guid("0fb2adbb-19f4-47df-aacb-f49e82c71a4d"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(416), 206 },
                    { new Guid("170b317f-4acb-479e-9bff-289ee5d78760"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(316), 205 },
                    { new Guid("2b4556ca-b0cf-45a8-b383-c0c001626b57"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(328), 208 },
                    { new Guid("376541c5-23ec-48be-a07c-bfd056662601"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(332), 202 },
                    { new Guid("37a0bfda-8642-4e21-9960-b1471ec4850e"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(427), 205 },
                    { new Guid("38e47e67-bc22-491b-a6d1-1de1235ad193"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(424), 201 },
                    { new Guid("39f1af94-2ee7-435c-81a9-61529bb5a9a2"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(424), 202 },
                    { new Guid("3e0c04e1-aee4-4cf3-8dc2-f63f39c5154b"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(346), 204 },
                    { new Guid("49adc8de-8e22-427f-9a1b-58a4cf466579"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(426), 204 },
                    { new Guid("4c401fc0-07ff-4889-9275-ad3bf078b3cc"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(307), 201 },
                    { new Guid("5214f1e1-a2e2-4fe4-8272-c79f73cee851"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(329), 209 },
                    { new Guid("59357b4b-0a01-4462-b983-7ba92b2ed339"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(345), 203 },
                    { new Guid("59c9777e-8d41-4b17-afc0-a91b154b7c3b"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(341), 210 },
                    { new Guid("5c3ed446-68fd-4e6c-8c58-4b56140aaee0"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(432), 210 },
                    { new Guid("6242103c-3e6a-4761-a6b8-cd19d6c0310e"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(431), 209 },
                    { new Guid("673016ee-985a-43e3-a2f7-a529d8701d2a"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(488), 202 },
                    { new Guid("692d37bc-4ae5-4f8d-986d-5c83cd0e4c77"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(492), 206 },
                    { new Guid("69f3e158-644f-470f-8cd5-5e1922e4b251"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(494), 208 },
                    { new Guid("6ac3971b-e2d3-486e-a7a6-0c6770a35c64"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(429), 206 },
                    { new Guid("700e36e5-d31d-4e40-8e97-9692e49483d8"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(493), 207 },
                    { new Guid("74909e27-be33-4a7a-bff5-414d6a6a76eb"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(344), 202 },
                    { new Guid("74a6a294-0aba-4f34-a47e-8d8b020c98b0"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(331), 200 },
                    { new Guid("816dabe8-50c0-4ee3-af20-3183c21b1da3"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(317), 206 },
                    { new Guid("81aa01a8-4ce2-4e1c-8ced-8da0e341db67"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(421), 210 },
                    { new Guid("82958cdf-cef8-4ccd-a92f-0053b26df438"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(309), 203 },
                    { new Guid("84adaf2a-22aa-4022-acd3-07057cae9759"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(491), 204 },
                    { new Guid("84fdd8cd-5279-45cf-9174-5fe14eaa91d3"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(433), 200 },
                    { new Guid("85485f66-be03-402e-bd9f-f6d52ac646af"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(495), 210 },
                    { new Guid("924c8721-9711-43ec-9c9a-37c5d160bd26"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(308), 202 },
                    { new Guid("951fca45-f944-413d-9c8c-d05da8013c7d"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(283), 200 },
                    { new Guid("96122a4a-3bcd-45e0-9e6f-84d444708c56"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(404), 205 },
                    { new Guid("9afb391f-f062-4081-8035-43d37934a9b5"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(344), 201 },
                    { new Guid("9f1bf1d1-745f-46c7-a49d-105ebe35435d"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(340), 209 },
                    { new Guid("ad3df3b9-ab8b-479c-bdb3-636434ffeb23"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(342), 200 },
                    { new Guid("ade295fa-7748-49d1-8d0e-d74330d2f601"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(339), 207 },
                    { new Guid("b44bbf84-16be-46bc-adc2-b43eddccc911"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(418), 208 },
                    { new Guid("b8782bf7-33cc-418d-ad95-ca5cbd62a607"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(491), 205 },
                    { new Guid("c45341bf-f67c-4be7-b566-a7f1e69183d0"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(487), 201 },
                    { new Guid("c45b9087-15d8-4876-934c-9b3ecbf6e34e"), 3, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(420), 209 },
                    { new Guid("c866080c-d5f1-4278-b91f-e6274bff4a1e"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(327), 207 },
                    { new Guid("cd706952-6977-43e0-8ffc-6507f31b8b43"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(339), 208 },
                    { new Guid("d59195d6-38ff-4093-a22c-10bdade5f31a"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(423), 200 },
                    { new Guid("d7b6a32b-d978-450f-8764-2eefebe2dcc2"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(338), 206 },
                    { new Guid("d863b8a5-0b2d-4fec-8266-d843c03b739d"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(330), 210 },
                    { new Guid("ddee8a4f-9375-490c-ab05-99d9bbc4db86"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(495), 209 },
                    { new Guid("e37d358c-0fb7-4781-a4a7-562f8281ed51"), 1, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(310), 204 },
                    { new Guid("e6e9483b-88fb-438b-a9f1-687f8583c919"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(333), 203 },
                    { new Guid("ec44a5e4-3dbd-496a-9d90-7005bc81da3c"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(430), 207 },
                    { new Guid("ee487369-29ec-4b20-8980-5ec7f1ccda02"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(332), 201 },
                    { new Guid("ee4eeb71-b986-48bd-889e-b88e59de4ab1"), 5, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(490), 203 },
                    { new Guid("f1df7d84-5d41-48ce-9416-c8524391c8b5"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(430), 208 },
                    { new Guid("f4f238e0-af3a-45f4-bdd6-ee287c872933"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(336), 205 },
                    { new Guid("f88cc98d-f506-441e-a360-b13b675531c6"), 4, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(425), 203 },
                    { new Guid("fe955a28-3941-41cb-b5eb-3bc36997ae72"), 2, new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(336), 204 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("442f41db-b9f4-4355-8389-370b610e97fc"), null, new DateTime(2024, 3, 2, 8, 19, 54, 701, DateTimeKind.Utc).AddTicks(8245), "dean@gmail.com", "dean", 0, "$2a$11$xJh052ek4Y3jdLvm8mSMw.d8q34hQlJekO2PJdIhpNRZ4qJcX24.a", null, 2 },
                    { new Guid("4868443b-1cd4-4874-9d63-a47d9587c4a6"), null, new DateTime(2024, 3, 2, 8, 19, 54, 820, DateTimeKind.Utc).AddTicks(7122), "teacher@gmail.com", "teacher", 0, "$2a$11$M9QDb8lzaIp1K0XZ02hYxuOuOdXQUn9GbmfLYrBZpRaiRH1teKd..", null, 1 },
                    { new Guid("b8dcb79e-08aa-4597-b84d-44318911c64b"), null, new DateTime(2024, 3, 2, 8, 19, 54, 583, DateTimeKind.Utc).AddTicks(5593), "admin@gmail.com", "admin", 0, "$2a$11$Fmt//G.NL7ctbgYEmdISpucGz/HyfTT7SR3IvqMCacyLvF3bAnGXa", null, 3 },
                    { new Guid("c705f723-15a2-494d-8d88-0955e73f84ea"), null, new DateTime(2024, 3, 2, 8, 19, 54, 939, DateTimeKind.Utc).AddTicks(8973), "student@gmail.com", "student", 0, "$2a$11$hqrUgXCTDNx4qbvUW2pME.b64glnP787NF37143/NZTFbnBW/nUam", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("023b864c-e8db-4cf6-9665-3c06ba866267"), new Guid("e6e9483b-88fb-438b-a9f1-687f8583c919"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(948), 0, null },
                    { new Guid("07cc0eb1-46a4-406e-b077-fa74bc53a98e"), new Guid("6242103c-3e6a-4761-a6b8-cd19d6c0310e"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(976), 0, null },
                    { new Guid("0db4ca7f-a669-4c54-a460-f1d5bde162cc"), new Guid("f1df7d84-5d41-48ce-9416-c8524391c8b5"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(976), 0, null },
                    { new Guid("0f92e6ca-a419-47fd-b752-b800e605f767"), new Guid("b44bbf84-16be-46bc-adc2-b43eddccc911"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(963), 0, null },
                    { new Guid("1a771e7e-104e-4106-b5e0-e82bc0e8d555"), new Guid("ec44a5e4-3dbd-496a-9d90-7005bc81da3c"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(975), 0, null },
                    { new Guid("1f9c8b10-095c-4ac5-806e-40cc88b4272f"), new Guid("2b4556ca-b0cf-45a8-b383-c0c001626b57"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(943), 0, null },
                    { new Guid("1fcbf1b5-4af1-4c65-a9a6-fab1c3f7b8d1"), new Guid("816dabe8-50c0-4ee3-af20-3183c21b1da3"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(940), 0, null },
                    { new Guid("1fd0dd07-07ff-4c97-96db-68beacf05f85"), new Guid("f4f238e0-af3a-45f4-bdd6-ee287c872933"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(951), 0, null },
                    { new Guid("239149e9-2762-42e7-8134-839d930c2500"), new Guid("96122a4a-3bcd-45e0-9e6f-84d444708c56"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(961), 0, null },
                    { new Guid("24439c1f-2dbd-49bc-8a43-92d9abd773fa"), new Guid("4c401fc0-07ff-4889-9275-ad3bf078b3cc"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(934), 0, null },
                    { new Guid("2fc2cb00-84d9-4d3f-a813-be58bff8bb5f"), new Guid("49adc8de-8e22-427f-9a1b-58a4cf466579"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(970), 0, null },
                    { new Guid("2ff9dfdc-c0e7-490c-a704-4cebd0776d9d"), new Guid("cd706952-6977-43e0-8ffc-6507f31b8b43"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(954), 0, null },
                    { new Guid("34b01c71-efb4-4c75-8557-db8d87719972"), new Guid("170b317f-4acb-479e-9bff-289ee5d78760"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(939), 0, null },
                    { new Guid("3861d315-63aa-48b0-b822-f5195061a754"), new Guid("e37d358c-0fb7-4781-a4a7-562f8281ed51"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(937), 0, null },
                    { new Guid("3af301a1-2150-450d-94e5-bc807c6a860b"), new Guid("c45b9087-15d8-4876-934c-9b3ecbf6e34e"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(964), 0, null },
                    { new Guid("3fe88653-c03b-45a2-acf4-739589355621"), new Guid("84adaf2a-22aa-4022-acd3-07057cae9759"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(982), 0, null },
                    { new Guid("470e20d5-e0bc-42f2-b4e8-32d1a5a7172e"), new Guid("69f3e158-644f-470f-8cd5-5e1922e4b251"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(986), 0, null },
                    { new Guid("496b0217-8082-4f75-927a-7652109d6476"), new Guid("951fca45-f944-413d-9c8c-d05da8013c7d"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(930), 0, null },
                    { new Guid("4e4b3789-bbb7-4ae5-9e4c-ca8a0084f3ae"), new Guid("d7b6a32b-d978-450f-8764-2eefebe2dcc2"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(952), 0, null },
                    { new Guid("60943ecc-88c0-485f-84d4-75ec76740536"), new Guid("700e36e5-d31d-4e40-8e97-9692e49483d8"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(985), 0, null },
                    { new Guid("61adb17e-f81e-4d55-94aa-a030b1cd8f7d"), new Guid("9afb391f-f062-4081-8035-43d37934a9b5"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(957), 0, null },
                    { new Guid("66b8b43f-b02f-4b43-835f-6f7707088b96"), new Guid("ade295fa-7748-49d1-8d0e-d74330d2f601"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(953), 0, null },
                    { new Guid("66f62743-a199-42a8-80f6-7cc7891e0628"), new Guid("ee4eeb71-b986-48bd-889e-b88e59de4ab1"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(980), 0, null },
                    { new Guid("7101b7e5-eda2-424f-b830-99558c168e45"), new Guid("ad3df3b9-ab8b-479c-bdb3-636434ffeb23"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(956), 0, null },
                    { new Guid("7686f21b-32c0-417b-b33a-0668c4b5d47c"), new Guid("6ac3971b-e2d3-486e-a7a6-0c6770a35c64"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(972), 0, null },
                    { new Guid("7bacd4dd-052b-467b-b773-716538f5edaa"), new Guid("d863b8a5-0b2d-4fec-8266-d843c03b739d"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(945), 0, null },
                    { new Guid("7e97eff2-cf60-4242-840c-f8062bf8c161"), new Guid("37a0bfda-8642-4e21-9960-b1471ec4850e"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(971), 0, null },
                    { new Guid("81a27c16-20a0-4b71-8e70-1bf0fd69ba84"), new Guid("c866080c-d5f1-4278-b91f-e6274bff4a1e"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(940), 0, null },
                    { new Guid("885368c0-0922-429e-83bf-8477e3f41b3d"), new Guid("39f1af94-2ee7-435c-81a9-61529bb5a9a2"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(969), 0, null },
                    { new Guid("88acc456-5e82-42d3-92f6-3bc60c44164b"), new Guid("924c8721-9711-43ec-9c9a-37c5d160bd26"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(935), 0, null },
                    { new Guid("8d71cefe-7cb1-4ea7-9d66-721fa103807b"), new Guid("fe955a28-3941-41cb-b5eb-3bc36997ae72"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(949), 0, null },
                    { new Guid("8df97dd3-64e8-4e0d-82e8-2290f4c0e36b"), new Guid("d59195d6-38ff-4093-a22c-10bdade5f31a"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(967), 0, null },
                    { new Guid("93bb8a47-a311-4cd8-88c6-ebe3dca6e560"), new Guid("692d37bc-4ae5-4f8d-986d-5c83cd0e4c77"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(984), 0, null },
                    { new Guid("9a8e6264-698e-480e-8310-8b3f917892bc"), new Guid("9f1bf1d1-745f-46c7-a49d-105ebe35435d"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(954), 0, null },
                    { new Guid("9cccf978-3999-43c6-b5b2-b2924e5499d6"), new Guid("376541c5-23ec-48be-a07c-bfd056662601"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(947), 0, null },
                    { new Guid("9cd521a3-c4ef-449d-beff-09b8591b6d77"), new Guid("81aa01a8-4ce2-4e1c-8ced-8da0e341db67"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(966), 0, null },
                    { new Guid("9dadd29e-58b1-489e-82b1-e8754267a6aa"), new Guid("ddee8a4f-9375-490c-ab05-99d9bbc4db86"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(1010), 0, null },
                    { new Guid("af777de1-2243-44e9-8b1d-92eb6589a6ec"), new Guid("c45341bf-f67c-4be7-b566-a7f1e69183d0"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(979), 0, null },
                    { new Guid("b084e253-4229-47a9-9ec0-6d8bd4f105b1"), new Guid("38e47e67-bc22-491b-a6d1-1de1235ad193"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(968), 0, null },
                    { new Guid("b97c0172-4652-428e-bc33-9e25edc23da2"), new Guid("5214f1e1-a2e2-4fe4-8272-c79f73cee851"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(944), 0, null },
                    { new Guid("bfdc670c-17a6-4ec5-9e5b-75561ac3d404"), new Guid("0e266621-c57c-404b-9366-94069bfa4ac7"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(963), 0, null },
                    { new Guid("c1a49198-e406-45b9-92af-f207bd0d8827"), new Guid("59357b4b-0a01-4462-b983-7ba92b2ed339"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(960), 0, null },
                    { new Guid("c35590bc-6d44-463e-b9e6-b2c31c7d1fc6"), new Guid("b8782bf7-33cc-418d-ad95-ca5cbd62a607"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(983), 0, null },
                    { new Guid("c84aa175-f398-400a-9ef8-7f8c5c122f9e"), new Guid("0fb2adbb-19f4-47df-aacb-f49e82c71a4d"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(962), 0, null },
                    { new Guid("cde88551-a367-4b1f-acea-f519d930bf28"), new Guid("84fdd8cd-5279-45cf-9174-5fe14eaa91d3"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(978), 0, null },
                    { new Guid("d3fb9727-8ed3-4489-8ed3-a2d12c18417c"), new Guid("f88cc98d-f506-441e-a360-b13b675531c6"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(969), 0, null },
                    { new Guid("d70db168-0802-4bbf-b5ff-e149d826e4d2"), new Guid("74909e27-be33-4a7a-bff5-414d6a6a76eb"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(959), 0, null },
                    { new Guid("d85281c3-5130-4790-84a4-52d84cb163c5"), new Guid("5c3ed446-68fd-4e6c-8c58-4b56140aaee0"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(977), 0, null },
                    { new Guid("d9259377-5f9f-45fc-8f25-8c1887a0210e"), new Guid("3e0c04e1-aee4-4cf3-8dc2-f63f39c5154b"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(960), 0, null },
                    { new Guid("de09aceb-cb1d-420e-8e86-0bf5fd5fae17"), new Guid("59c9777e-8d41-4b17-afc0-a91b154b7c3b"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(955), 0, null },
                    { new Guid("e1e996a1-2d30-4d2e-8f36-17a66bc56687"), new Guid("85485f66-be03-402e-bd9f-f6d52ac646af"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(1011), 0, null },
                    { new Guid("e23a1715-3588-4304-8d07-021537dca0bc"), new Guid("ee487369-29ec-4b20-8980-5ec7f1ccda02"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(947), 0, null },
                    { new Guid("ecec16dc-26b1-4b09-9f47-7828f3b0c57e"), new Guid("74a6a294-0aba-4f34-a47e-8d8b020c98b0"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(946), 0, null },
                    { new Guid("f2bcb92d-7f93-4bed-a8d4-a029841f86fa"), new Guid("673016ee-985a-43e3-a2f7-a529d8701d2a"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(980), 0, null },
                    { new Guid("f4b1ef65-5c5a-4102-92b8-ad654e183a5b"), new Guid("82958cdf-cef8-4ccd-a92f-0053b26df438"), new DateTime(2024, 3, 2, 8, 19, 55, 67, DateTimeKind.Utc).AddTicks(936), 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("023b864c-e8db-4cf6-9665-3c06ba866267"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("07cc0eb1-46a4-406e-b077-fa74bc53a98e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0db4ca7f-a669-4c54-a460-f1d5bde162cc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0f92e6ca-a419-47fd-b752-b800e605f767"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1a771e7e-104e-4106-b5e0-e82bc0e8d555"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1f9c8b10-095c-4ac5-806e-40cc88b4272f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1fcbf1b5-4af1-4c65-a9a6-fab1c3f7b8d1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1fd0dd07-07ff-4c97-96db-68beacf05f85"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("239149e9-2762-42e7-8134-839d930c2500"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("24439c1f-2dbd-49bc-8a43-92d9abd773fa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2fc2cb00-84d9-4d3f-a813-be58bff8bb5f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2ff9dfdc-c0e7-490c-a704-4cebd0776d9d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("34b01c71-efb4-4c75-8557-db8d87719972"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3861d315-63aa-48b0-b822-f5195061a754"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3af301a1-2150-450d-94e5-bc807c6a860b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3fe88653-c03b-45a2-acf4-739589355621"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("470e20d5-e0bc-42f2-b4e8-32d1a5a7172e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("496b0217-8082-4f75-927a-7652109d6476"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4e4b3789-bbb7-4ae5-9e4c-ca8a0084f3ae"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("60943ecc-88c0-485f-84d4-75ec76740536"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("61adb17e-f81e-4d55-94aa-a030b1cd8f7d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("66b8b43f-b02f-4b43-835f-6f7707088b96"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("66f62743-a199-42a8-80f6-7cc7891e0628"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7101b7e5-eda2-424f-b830-99558c168e45"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7686f21b-32c0-417b-b33a-0668c4b5d47c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7bacd4dd-052b-467b-b773-716538f5edaa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7e97eff2-cf60-4242-840c-f8062bf8c161"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("81a27c16-20a0-4b71-8e70-1bf0fd69ba84"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("885368c0-0922-429e-83bf-8477e3f41b3d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("88acc456-5e82-42d3-92f6-3bc60c44164b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8d71cefe-7cb1-4ea7-9d66-721fa103807b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8df97dd3-64e8-4e0d-82e8-2290f4c0e36b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("93bb8a47-a311-4cd8-88c6-ebe3dca6e560"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9a8e6264-698e-480e-8310-8b3f917892bc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9cccf978-3999-43c6-b5b2-b2924e5499d6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9cd521a3-c4ef-449d-beff-09b8591b6d77"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9dadd29e-58b1-489e-82b1-e8754267a6aa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("af777de1-2243-44e9-8b1d-92eb6589a6ec"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b084e253-4229-47a9-9ec0-6d8bd4f105b1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b97c0172-4652-428e-bc33-9e25edc23da2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bfdc670c-17a6-4ec5-9e5b-75561ac3d404"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c1a49198-e406-45b9-92af-f207bd0d8827"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c35590bc-6d44-463e-b9e6-b2c31c7d1fc6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c84aa175-f398-400a-9ef8-7f8c5c122f9e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cde88551-a367-4b1f-acea-f519d930bf28"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d3fb9727-8ed3-4489-8ed3-a2d12c18417c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d70db168-0802-4bbf-b5ff-e149d826e4d2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d85281c3-5130-4790-84a4-52d84cb163c5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d9259377-5f9f-45fc-8f25-8c1887a0210e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("de09aceb-cb1d-420e-8e86-0bf5fd5fae17"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e1e996a1-2d30-4d2e-8f36-17a66bc56687"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e23a1715-3588-4304-8d07-021537dca0bc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ecec16dc-26b1-4b09-9f47-7828f3b0c57e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f2bcb92d-7f93-4bed-a8d4-a029841f86fa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f4b1ef65-5c5a-4102-92b8-ad654e183a5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("442f41db-b9f4-4355-8389-370b610e97fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4868443b-1cd4-4874-9d63-a47d9587c4a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8dcb79e-08aa-4597-b84d-44318911c64b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c705f723-15a2-494d-8d88-0955e73f84ea"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0e266621-c57c-404b-9366-94069bfa4ac7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0fb2adbb-19f4-47df-aacb-f49e82c71a4d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("170b317f-4acb-479e-9bff-289ee5d78760"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2b4556ca-b0cf-45a8-b383-c0c001626b57"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("376541c5-23ec-48be-a07c-bfd056662601"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("37a0bfda-8642-4e21-9960-b1471ec4850e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("38e47e67-bc22-491b-a6d1-1de1235ad193"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("39f1af94-2ee7-435c-81a9-61529bb5a9a2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3e0c04e1-aee4-4cf3-8dc2-f63f39c5154b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("49adc8de-8e22-427f-9a1b-58a4cf466579"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4c401fc0-07ff-4889-9275-ad3bf078b3cc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5214f1e1-a2e2-4fe4-8272-c79f73cee851"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("59357b4b-0a01-4462-b983-7ba92b2ed339"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("59c9777e-8d41-4b17-afc0-a91b154b7c3b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5c3ed446-68fd-4e6c-8c58-4b56140aaee0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6242103c-3e6a-4761-a6b8-cd19d6c0310e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("673016ee-985a-43e3-a2f7-a529d8701d2a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("692d37bc-4ae5-4f8d-986d-5c83cd0e4c77"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("69f3e158-644f-470f-8cd5-5e1922e4b251"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6ac3971b-e2d3-486e-a7a6-0c6770a35c64"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("700e36e5-d31d-4e40-8e97-9692e49483d8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("74909e27-be33-4a7a-bff5-414d6a6a76eb"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("74a6a294-0aba-4f34-a47e-8d8b020c98b0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("816dabe8-50c0-4ee3-af20-3183c21b1da3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("81aa01a8-4ce2-4e1c-8ced-8da0e341db67"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("82958cdf-cef8-4ccd-a92f-0053b26df438"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("84adaf2a-22aa-4022-acd3-07057cae9759"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("84fdd8cd-5279-45cf-9174-5fe14eaa91d3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("85485f66-be03-402e-bd9f-f6d52ac646af"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("924c8721-9711-43ec-9c9a-37c5d160bd26"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("951fca45-f944-413d-9c8c-d05da8013c7d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("96122a4a-3bcd-45e0-9e6f-84d444708c56"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9afb391f-f062-4081-8035-43d37934a9b5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9f1bf1d1-745f-46c7-a49d-105ebe35435d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ad3df3b9-ab8b-479c-bdb3-636434ffeb23"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ade295fa-7748-49d1-8d0e-d74330d2f601"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b44bbf84-16be-46bc-adc2-b43eddccc911"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b8782bf7-33cc-418d-ad95-ca5cbd62a607"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c45341bf-f67c-4be7-b566-a7f1e69183d0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c45b9087-15d8-4876-934c-9b3ecbf6e34e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c866080c-d5f1-4278-b91f-e6274bff4a1e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cd706952-6977-43e0-8ffc-6507f31b8b43"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d59195d6-38ff-4093-a22c-10bdade5f31a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d7b6a32b-d978-450f-8764-2eefebe2dcc2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d863b8a5-0b2d-4fec-8266-d843c03b739d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ddee8a4f-9375-490c-ab05-99d9bbc4db86"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e37d358c-0fb7-4781-a4a7-562f8281ed51"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e6e9483b-88fb-438b-a9f1-687f8583c919"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ec44a5e4-3dbd-496a-9d90-7005bc81da3c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ee487369-29ec-4b20-8980-5ec7f1ccda02"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ee4eeb71-b986-48bd-889e-b88e59de4ab1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f1df7d84-5d41-48ce-9416-c8524391c8b5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f4f238e0-af3a-45f4-bdd6-ee287c872933"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f88cc98d-f506-441e-a360-b13b675531c6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fe955a28-3941-41cb-b5eb-3bc36997ae72"));

            migrationBuilder.DropColumn(
                name: "EndDateOfRecurrence",
                table: "KeyRequests");

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("021f3121-2a8d-4380-87a4-46c24f369091"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8578), 210 },
                    { new Guid("03377b7d-f83d-45f5-9b15-595773610f45"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8560), 209 },
                    { new Guid("05330fd4-2509-44ed-ad97-a72d3e5aefe9"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8431), 201 },
                    { new Guid("05779436-1d6a-472a-a743-53e638a0f4cd"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8433), 203 },
                    { new Guid("05bba24c-525c-4fc7-b000-53f822a5624f"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8566), 201 },
                    { new Guid("0754f3e1-3515-4553-b2a8-16c52c5130fb"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8409), 210 },
                    { new Guid("0af21a18-cb5d-438d-9950-c74ba7dd7195"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8587), 204 },
                    { new Guid("0c993341-f269-4c68-948c-e41b5f1252aa"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8558), 207 },
                    { new Guid("0f575359-5814-4609-bb30-c663b05338ed"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8412), 201 },
                    { new Guid("1214b8e5-2b1f-4790-b4b7-a98c078c978a"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8411), 200 },
                    { new Guid("1fe25d1a-795f-4a2f-9871-18eb3f775d98"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8432), 202 },
                    { new Guid("207b4582-a685-4208-9a88-997c8dc92f5b"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8422), 206 },
                    { new Guid("20c9956c-d2e7-4654-bdf2-a7b1b248536f"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8401), 205 },
                    { new Guid("284a99e6-57c9-408d-b745-3ccc42135c91"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8580), 200 },
                    { new Guid("28f43699-5103-4305-af7d-918d520f8acb"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8574), 206 },
                    { new Guid("2a2ed7d6-4221-4e4b-8a76-ef7d76c47707"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8402), 206 },
                    { new Guid("2e598d0e-e449-46b5-a3aa-59f1bab00f0f"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8554), 206 },
                    { new Guid("30f6d5ed-2de2-4e53-a362-e672fb9b6468"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8572), 204 },
                    { new Guid("3b74d744-6482-4eb3-b591-3978988476ce"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8573), 205 },
                    { new Guid("3d52ddb5-b5e0-4b88-9b05-85e6ea41726b"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8585), 202 },
                    { new Guid("43d2fd6c-2261-404b-bc3e-e92fd724e384"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8429), 210 },
                    { new Guid("493d60e0-d865-42b4-bb9e-cf18839bd447"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8568), 203 },
                    { new Guid("4a96fb6b-b16e-4695-b8c3-5947052a4ac1"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8584), 201 },
                    { new Guid("4d2a603a-6f4b-428a-85cb-40f7ffbff3ba"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8425), 209 },
                    { new Guid("4dd481e1-aea8-4ef2-a212-056f1484b408"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8404), 207 },
                    { new Guid("60479f87-6ba7-465d-af78-634d0c5cc82b"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8424), 208 },
                    { new Guid("690756ba-88ad-4f1f-9daf-a6869b168be3"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8417), 203 },
                    { new Guid("69d22e63-2525-48b1-ab7e-09310a02e386"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8370), 201 },
                    { new Guid("6d1e58ce-d789-41df-b978-8202e56dfe3f"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8434), 204 },
                    { new Guid("70404744-ee3a-4eda-b458-3f0d3c9d932d"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8407), 209 },
                    { new Guid("71e8086a-2912-4beb-8ffb-787d9c3774af"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8577), 209 },
                    { new Guid("7584691e-1b69-4e87-bc54-5e23543ea27f"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8575), 207 },
                    { new Guid("7ca539d6-c053-4f64-aed1-30feecc9316c"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8423), 207 },
                    { new Guid("8070e7c2-b9ac-4e2a-8229-a3fcacb5cfe9"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8559), 208 },
                    { new Guid("81fce5b8-c18f-453e-9bdb-f2acd4956b21"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8596), 210 },
                    { new Guid("833d611b-e232-43ea-881d-f1b87686b50d"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8416), 202 },
                    { new Guid("83ed74dd-c50f-45ac-8fc9-db8eb506d748"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8589), 206 },
                    { new Guid("87f2771f-734d-4339-a88b-14e677357782"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8430), 200 },
                    { new Guid("88a723b4-7b98-475f-bd68-e6476565c827"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8374), 204 },
                    { new Guid("8b31ffc9-1f14-49ab-a40e-6abbb0a1b277"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8590), 207 },
                    { new Guid("934c2cdb-1f46-4b84-8b32-442a7b0626ba"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8595), 209 },
                    { new Guid("986b65dd-ed95-453e-ad81-12e3defc5ca2"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8373), 203 },
                    { new Guid("ab2c3b70-93eb-4fda-af8c-1b472c0e61b1"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8565), 200 },
                    { new Guid("b4de0889-30db-4c78-bcea-ad7503ee982a"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8405), 208 },
                    { new Guid("c11d8194-3a60-43ff-8f90-615ccafdfc3c"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8418), 204 },
                    { new Guid("c8c262ec-72ae-4bc1-ba45-2787a12fa87b"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8576), 208 },
                    { new Guid("cee10807-33e2-45fb-a0dd-52e7bf41ed87"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8588), 205 },
                    { new Guid("d1e8157d-7318-4e0e-bb9d-e2817289db49"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8591), 208 },
                    { new Guid("d41f2273-ba0c-47da-aa96-0005f8e190db"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8562), 210 },
                    { new Guid("e446d1bb-d49b-40d1-8827-8d8e8de6d73d"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8336), 200 },
                    { new Guid("ea1f2717-bc56-4149-ab6e-2440dfc9e574"), 1, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8372), 202 },
                    { new Guid("f17955ba-0ffd-4b5b-9674-dfacbb04c265"), 5, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8586), 203 },
                    { new Guid("f49deeb1-c78d-4804-ab60-54f05ec213b2"), 3, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8533), 205 },
                    { new Guid("fb08a950-c382-4de5-a833-07c38aa925b3"), 4, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8567), 202 },
                    { new Guid("fecf6b80-40e0-495e-b2e6-cdeb7f91d71d"), 2, new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(8420), 205 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("300acba5-b104-4a2c-9854-11889f153a82"), null, new DateTime(2024, 3, 2, 4, 54, 3, 791, DateTimeKind.Utc).AddTicks(8638), "admin@gmail.com", "admin", 0, "$2a$11$p1X.HHnLq6dVIdgBcIkvPu1CVDYhI6DWw8TQIY/W7MPhMTrteFHIG", null, 3 },
                    { new Guid("30a1e9fb-3a4f-474e-8a56-3820baaf35dc"), null, new DateTime(2024, 3, 2, 4, 54, 4, 41, DateTimeKind.Utc).AddTicks(7566), "teacher@gmail.com", "teacher", 0, "$2a$11$Wuby2Qr0wnPkfyQveDaBBu6bGsqLgEDzytY0U//IpJp3mlP9HslZ6", null, 1 },
                    { new Guid("4fefe082-1e41-42aa-aa8b-bdb2e56e9b48"), null, new DateTime(2024, 3, 2, 4, 54, 3, 918, DateTimeKind.Utc).AddTicks(6284), "dean@gmail.com", "dean", 0, "$2a$11$12jl9hoWztwm6s7wyCit1O4ldwrC3dvO8xqDrqeKjVAuQ8NUGfpGS", null, 2 },
                    { new Guid("533d38d6-bb99-4ac3-a0d1-78b19300dd7c"), null, new DateTime(2024, 3, 2, 4, 54, 4, 167, DateTimeKind.Utc).AddTicks(5974), "student@gmail.com", "student", 0, "$2a$11$JwAHRBkgEM8GfaZAoNnZgOyHUH6.h7b3r7RHwAEZLSd2dCkKEZBj6", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("01b7049d-66de-4f07-954a-c500424f8a67"), new Guid("20c9956c-d2e7-4654-bdf2-a7b1b248536f"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9721), 0, null },
                    { new Guid("04e938ab-6b22-412e-a8f3-42920dfd3b19"), new Guid("7584691e-1b69-4e87-bc54-5e23543ea27f"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9781), 0, null },
                    { new Guid("06783507-c52f-4fc5-bf93-4c41b282ce7d"), new Guid("43d2fd6c-2261-404b-bc3e-e92fd724e384"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9750), 0, null },
                    { new Guid("0a559c17-fe5c-418c-a058-1066846565a3"), new Guid("70404744-ee3a-4eda-b458-3f0d3c9d932d"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9731), 0, null },
                    { new Guid("0a8b9d04-2a2f-4d1a-a4fa-374a7d9a8e1a"), new Guid("4dd481e1-aea8-4ef2-a212-056f1484b408"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9727), 0, null },
                    { new Guid("0bafc1a9-3535-46b1-b8eb-870c4c2c009f"), new Guid("c8c262ec-72ae-4bc1-ba45-2787a12fa87b"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9782), 0, null },
                    { new Guid("0ee588f0-0c5f-4290-8d88-e986047a21f6"), new Guid("493d60e0-d865-42b4-bb9e-cf18839bd447"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9774), 0, null },
                    { new Guid("138fe27e-04ac-4e72-b22e-32f29a2a10d2"), new Guid("c11d8194-3a60-43ff-8f90-615ccafdfc3c"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9741), 0, null },
                    { new Guid("1e2401c8-8d91-46a4-8993-9a72c1b3ed07"), new Guid("60479f87-6ba7-465d-af78-634d0c5cc82b"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9747), 0, null },
                    { new Guid("1e27b238-fa68-48de-96ff-944afd3275af"), new Guid("71e8086a-2912-4beb-8ffb-787d9c3774af"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9783), 0, null },
                    { new Guid("215eddfb-c2ca-4be3-8af6-94f67a1dea42"), new Guid("8b31ffc9-1f14-49ab-a40e-6abbb0a1b277"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9795), 0, null },
                    { new Guid("26e7c8cd-5d68-4af3-af2c-4c6315fa971b"), new Guid("e446d1bb-d49b-40d1-8827-8d8e8de6d73d"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9705), 0, null },
                    { new Guid("2e95f873-5d6d-4f18-9bc9-e05fa628402a"), new Guid("03377b7d-f83d-45f5-9b15-595773610f45"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9767), 0, null },
                    { new Guid("2f525b0c-510a-45b6-b3bb-164d0d255d5b"), new Guid("3b74d744-6482-4eb3-b591-3978988476ce"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9779), 0, null },
                    { new Guid("2f68e75c-bbd9-443d-99a3-5a7e3a6e6f98"), new Guid("690756ba-88ad-4f1f-9daf-a6869b168be3"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9740), 0, null },
                    { new Guid("30550ea0-dc6e-4031-a39d-5e899dc46344"), new Guid("cee10807-33e2-45fb-a0dd-52e7bf41ed87"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9793), 0, null },
                    { new Guid("368b8dab-be80-47f2-843e-7c4b816e8d94"), new Guid("88a723b4-7b98-475f-bd68-e6476565c827"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9718), 0, null },
                    { new Guid("3b41ad47-e8a8-40a9-9c34-f0b3a27f644a"), new Guid("6d1e58ce-d789-41df-b978-8202e56dfe3f"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9758), 0, null },
                    { new Guid("3fcd542d-8a7e-46ce-8465-fafe2fb2ae7e"), new Guid("69d22e63-2525-48b1-ab7e-09310a02e386"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9714), 0, null },
                    { new Guid("3fe58b5b-e352-4970-97c9-adfce660d56e"), new Guid("0c993341-f269-4c68-948c-e41b5f1252aa"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9762), 0, null },
                    { new Guid("40b6a5c4-a247-434d-949b-d75672284dac"), new Guid("4d2a603a-6f4b-428a-85cb-40f7ffbff3ba"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9748), 0, null },
                    { new Guid("4348876a-0691-4f43-8129-57dcc58d8791"), new Guid("b4de0889-30db-4c78-bcea-ad7503ee982a"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9729), 0, null },
                    { new Guid("4d76c165-3a09-4c74-8830-16691c110996"), new Guid("28f43699-5103-4305-af7d-918d520f8acb"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9780), 0, null },
                    { new Guid("51a568fd-0ae5-4705-ac07-d749626d805e"), new Guid("87f2771f-734d-4339-a88b-14e677357782"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9753), 0, null },
                    { new Guid("632b93b0-0eba-498d-825c-15e9245ffa82"), new Guid("81fce5b8-c18f-453e-9bdb-f2acd4956b21"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9801), 0, null },
                    { new Guid("7d35605d-0777-491c-b10f-e3278c335abc"), new Guid("fecf6b80-40e0-495e-b2e6-cdeb7f91d71d"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9742), 0, null },
                    { new Guid("81c71b07-1314-4df1-94e3-4fd291422c60"), new Guid("1fe25d1a-795f-4a2f-9871-18eb3f775d98"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9756), 0, null },
                    { new Guid("8757e5ae-c1e8-4a3a-a6b2-676acda3dee6"), new Guid("30f6d5ed-2de2-4e53-a362-e672fb9b6468"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9775), 0, null },
                    { new Guid("8f4377aa-f850-4e18-b346-c7dfebe994c3"), new Guid("0af21a18-cb5d-438d-9950-c74ba7dd7195"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9792), 0, null },
                    { new Guid("917e593b-1496-41b8-b76a-61eb0e36bf0a"), new Guid("934c2cdb-1f46-4b84-8b32-442a7b0626ba"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9798), 0, null },
                    { new Guid("9afb3eeb-6401-4485-8fe7-7f1c9c358f09"), new Guid("0f575359-5814-4609-bb30-c663b05338ed"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9735), 0, null },
                    { new Guid("9f75fe08-eeb5-41d5-a26f-e913598e2ef1"), new Guid("2e598d0e-e449-46b5-a3aa-59f1bab00f0f"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9760), 0, null },
                    { new Guid("a1bc8a50-0c3e-4eb9-a355-9d95bb8bc930"), new Guid("f49deeb1-c78d-4804-ab60-54f05ec213b2"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9759), 0, null },
                    { new Guid("a780d7eb-1eb5-483f-ac87-8fcd13d742b6"), new Guid("3d52ddb5-b5e0-4b88-9b05-85e6ea41726b"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9790), 0, null },
                    { new Guid("a80d519c-71c2-4a6a-8cd8-7faeb03b13ac"), new Guid("1214b8e5-2b1f-4790-b4b7-a98c078c978a"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9733), 0, null },
                    { new Guid("b2a7460e-727c-45d1-9878-73a032d6aa79"), new Guid("05779436-1d6a-472a-a743-53e638a0f4cd"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9757), 0, null },
                    { new Guid("b54d1560-2661-4a6a-bf94-3be29714c68f"), new Guid("021f3121-2a8d-4380-87a4-46c24f369091"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9784), 0, null },
                    { new Guid("bd4daa24-6e4d-4528-a195-317782cdd4bb"), new Guid("05330fd4-2509-44ed-ad97-a72d3e5aefe9"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9754), 0, null },
                    { new Guid("bd845890-5642-42b5-94ec-f2063d6ffede"), new Guid("284a99e6-57c9-408d-b745-3ccc42135c91"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9785), 0, null },
                    { new Guid("c0bb17ea-4f58-4bbb-9c93-1446bfa6ee05"), new Guid("8070e7c2-b9ac-4e2a-8229-a3fcacb5cfe9"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9765), 0, null },
                    { new Guid("c2093c41-a3a6-4657-9786-e429547145a2"), new Guid("833d611b-e232-43ea-881d-f1b87686b50d"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9736), 0, null },
                    { new Guid("c6b94177-4022-48ea-8940-504cf3ea3fc9"), new Guid("f17955ba-0ffd-4b5b-9674-dfacbb04c265"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9791), 0, null },
                    { new Guid("c80c923f-c91f-48cf-9f23-9a7c075425a6"), new Guid("986b65dd-ed95-453e-ad81-12e3defc5ca2"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9717), 0, null },
                    { new Guid("c9327c1b-8ab9-431a-80d7-15740245a98e"), new Guid("fb08a950-c382-4de5-a833-07c38aa925b3"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9772), 0, null },
                    { new Guid("d2518d4b-19e0-491c-9064-1c034a06fc71"), new Guid("2a2ed7d6-4221-4e4b-8a76-ef7d76c47707"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9726), 0, null },
                    { new Guid("d8124308-04f3-4de4-8735-a9b420a9db55"), new Guid("4a96fb6b-b16e-4695-b8c3-5947052a4ac1"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9786), 0, null },
                    { new Guid("d96ced3e-1dbd-4234-907c-dc4ef5c326ed"), new Guid("83ed74dd-c50f-45ac-8fc9-db8eb506d748"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9794), 0, null },
                    { new Guid("de33eb4a-dbb9-4a6b-9a64-27ff4afcab53"), new Guid("05bba24c-525c-4fc7-b000-53f822a5624f"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9771), 0, null },
                    { new Guid("e0d25e7f-2760-417a-940b-9320ef0b1263"), new Guid("207b4582-a685-4208-9a88-997c8dc92f5b"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9745), 0, null },
                    { new Guid("eec38b63-3de0-4554-92ca-522c0d8bc855"), new Guid("7ca539d6-c053-4f64-aed1-30feecc9316c"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9746), 0, null },
                    { new Guid("f096773f-6d9d-4039-8469-99ea1151a555"), new Guid("ea1f2717-bc56-4149-ab6e-2440dfc9e574"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9715), 0, null },
                    { new Guid("f0d50435-5624-41cd-86f3-f696db85f951"), new Guid("0754f3e1-3515-4553-b2a8-16c52c5130fb"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9732), 0, null },
                    { new Guid("f7e1065b-cc5b-482f-914b-ccc436f915e1"), new Guid("d41f2273-ba0c-47da-aa96-0005f8e190db"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9768), 0, null },
                    { new Guid("fa664f91-ae92-48e9-a1cb-c09edcca3806"), new Guid("d1e8157d-7318-4e0e-bb9d-e2817289db49"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9796), 0, null },
                    { new Guid("fc9fb605-4768-475c-8bf3-e425f39f411f"), new Guid("ab2c3b70-93eb-4fda-af8c-1b472c0e61b1"), new DateTime(2024, 3, 2, 4, 54, 4, 289, DateTimeKind.Utc).AddTicks(9770), 0, null }
                });
        }
    }
}
