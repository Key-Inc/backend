using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTransferKeyRequestStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1ccee6cd-41df-42d7-b2fe-1e4d24e05a2f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("20719f0d-07c3-41c1-8d01-e0a1555cfedd"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("228997a6-d870-400f-9aa0-e76807464872"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2a061ca5-86a2-4ff7-bed1-ba3a1e2db77a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2a2cd7e7-1ddf-4c16-a492-6a01c9df4851"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3047f379-d38a-46db-968e-26229750c158"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("31f4c585-6fab-4946-8ede-0b1fa24af6a6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3313fa13-887b-40c6-8a57-54e6b203d430"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3520882c-b151-4250-b1ff-51fdaff9e332"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3c7e9cfc-3092-4949-8a4b-d08759616043"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3d29772e-1c9a-4eb4-bef1-aa32b8c05157"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3f55535b-033f-43a2-aaa9-59363717b7fe"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("474e5a74-406e-41c1-a46e-6a7ff43128e1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4ce7d778-b432-4e22-9a1d-8308d534b876"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4f1e6a0a-2136-406c-8aac-e517d1923914"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("55871ca0-faa5-4983-bd3e-b66f305e090a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("64e65bf4-b5d7-4393-93e2-b7a1e7d24f84"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6ce06c5d-f44d-4bfe-8ad0-3a21d414f072"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6fd11c86-9a3b-453d-a62f-7979523bdd40"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7942ef47-4e68-418c-93d2-2ca1fa5d0c9a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7f1ea2ae-db91-4b92-94f8-bbc8abdabf8c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("811e5f48-8fc7-493f-9f39-92b54fb083b9"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("812d5970-dee2-4457-adcb-c91c16dbd21e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8293300c-c0f6-4cad-be5e-08c6eaf185e5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("84f22920-1718-4865-9e91-e8640ff596c4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8514f5bd-d756-4955-ba2c-21850cd7b7c1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("873184cf-d16f-432f-be49-18cebe0dd10c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8d1ba9d6-39b3-4dbd-bcc1-ff71606fb83e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8ee51b02-5e61-4f86-81de-83b5f0324d9c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8fd22a0c-46bb-4ad6-8cdb-00fa1d3845b5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("977adf97-ae93-4bc7-8de5-3e4d30a41482"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("991fd769-67c4-4ab7-ad6e-63b5543ce72c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9e9f9aab-b34e-4e01-ab4d-14bf51a9af9e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9fb014fc-b34c-4fae-addf-c5e71acb7951"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a158c963-9dd7-4275-952b-61e5f9c5d253"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a3ab227a-a5e3-4684-a937-68b054139794"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a97def36-a34a-47e5-ab89-60ea123d4929"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b0831dd9-4f49-4dd4-b0f7-8272f4c330e2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c04cf9ca-0a57-4711-96db-06c2172bf0b8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cb70065f-076c-4903-9cb7-0111839b7a75"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cd7391b1-edb4-494e-83f1-36c75ac49f8a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d21ac3ac-06f0-4c50-a932-35c4896ae031"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d9b1e3e6-5a8e-479e-8a12-4affeb1139c5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d9dcd118-f4b5-4d06-92ce-d3461dff3496"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("dc5e170b-6576-4734-b234-7e18f9758edb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("dc60b0d9-1cf9-44c2-b47f-d3805f83c5c3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("de94930e-58ed-4fa7-b40e-23f0162a9150"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("dfbf55cb-2616-4133-9ec7-b5d8998312f1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e192b13e-5ba8-4792-80a8-b616c2bd277d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e271b19e-d4d7-4c69-aa2b-42f997a3c064"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e3fc6028-cac6-405f-9e09-f019e3aa446a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e4381c12-ffdc-46f1-8261-996f6ea3c15b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e58cb672-bcc5-4fb3-a8ef-db94d2f25b10"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e7cce20e-5dc7-456b-947a-dcb2c170fea8"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f50577fb-3f9e-482e-be25-a8ece215589e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ffaa9a2-3314-425f-85ca-a5a44df51f7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32fa17d9-b9b2-4564-a232-7335de84f209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6388e355-6889-4bab-b217-460b7af446e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7958e57-f151-4c1e-9034-786b39b6d3b3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("01a67120-ada5-412c-9b5e-6a335c3098e0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("04d8b6f4-24c1-4c97-82f3-2bc3fef36bee"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0609beb8-1053-4f57-a9c0-03e466e8909c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0b1d3b4d-760d-4c6f-bf44-6c910e86c027"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("18817dac-d617-45f0-b1d2-62c4cde557ed"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("18bd34a0-89b6-4dc6-9975-f23458cdd890"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1ad2ca85-c6db-49db-b522-0dab1891dd72"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("30237486-9607-4979-9da5-db262720ce31"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("373a09d3-b5b2-4968-b07a-1d930aa72f08"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3b8f3f67-5d08-4bbb-80b1-3ead9bb443de"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3ea7bd90-029d-41ba-9564-36c42513df85"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3eabeb07-60dd-4b6f-82d4-087ac46ad779"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("42038e4c-0271-4889-847f-b73f928fe5d9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("429fce3c-9bfe-4123-8698-b53cfd99be24"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("46e38ba2-fb03-46e0-8492-63b9c268da85"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("47532bf5-130b-423b-bb1f-8b2e71a8f6f2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("48101ee3-bca4-4744-a7c5-e77e370a2b5b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4e853fa0-deab-4c38-9e50-c3545af0d5f3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("57dfa9c2-e89f-4b1a-ab32-2e440c583bad"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5b75d172-a703-4a26-8d77-bfa5a591a313"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f325d44-6186-4800-84b5-cf5fbf058330"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6095f3f7-30c2-42f9-af40-39688b816815"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6a8d3a45-dc01-4d92-88ac-6eda1b6bfd89"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6f0939be-b16a-4fc3-ac17-58af4be14875"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("777a0912-d486-40ed-9981-ffd514a016da"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("789fcbdf-7168-4c83-b543-283cde841b0c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("93933301-2cac-49b7-80da-b380c7d60389"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9415ed4c-701c-42ef-a79d-9a250e118907"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("941fd184-eabe-401a-945a-97c9a0eb429b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("971485c1-5bbe-43c3-a5dd-4f9080d1a798"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9941e5fc-0a74-484f-9823-7a1526c37c51"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9ee93fcf-363d-4e7b-9852-c7a2ff517f79"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9fb42181-de32-471c-ad73-4c9f8320241d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a24ae76f-ce3a-491a-abc8-104712a15c7a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a40edf40-7f3f-405e-a717-b7ebec4e543c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a5c7632f-8214-4811-9d77-2cb0b0d19c02"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ad8d81db-7fe4-4193-b0a6-900eb68eff58"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b49f7dc9-129d-4e61-bbef-262b7fc91f42"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b5415d4d-b551-4759-886d-ae3c44a84a0c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b6f9dfdd-6faa-4a90-9665-39e39df18877"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("beca7854-ebed-43b3-9e82-19f50c483869"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c408d0be-6d1f-47c9-b435-03760d2bbfff"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ca6b4016-1411-4f09-9bbc-36a5f4adbb4a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cfd60424-c1fb-4948-b9ca-00ddaa84d8c6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("dd4e5977-956a-44a5-8bed-56b77bfa5785"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e0c433aa-e2d5-4196-ab50-b355d0bf671e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e3752e9d-e9a0-4277-92b1-51ef0d6b8ff7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e414c132-7112-4415-95eb-1f769f30fd8b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e5cd8380-ba54-47af-82f9-db07551403ae"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e9bd2968-e7ac-4d09-8f31-1fc7dccbac43"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ea001936-4b93-4ad5-bb40-98469d00e1b0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ee25cfd3-b5e5-455f-be83-7a60dbd4b6fc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f0631f96-14f0-4ac5-9573-5f59945a699f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fb2402e1-24c4-4fa4-8921-a57acc4edfac"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ff8979cf-87e1-4598-9b5b-1516166b81d7"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TransferKeyRequests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("03403da8-e010-4490-87f2-0d406ee95e44"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8610), 205 },
                    { new Guid("1d62e2b8-97b6-4207-8f61-39357b9b7499"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8730), 208 },
                    { new Guid("1e37ba0d-e660-4d32-9f3e-1f355dab53d1"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8700), 202 },
                    { new Guid("1eb75642-ba0f-4072-a7c2-f2d9f7df2c07"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8700), 203 },
                    { new Guid("1fd9d87e-7176-4242-a1a2-302724e6a1ec"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8850), 205 },
                    { new Guid("2516201c-236f-4071-ae4f-0163b60d945e"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8620), 206 },
                    { new Guid("25a765bc-66a8-4411-b1ca-1be8a5b5c37d"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8730), 207 },
                    { new Guid("2d10b0f7-182d-4ec6-9fd6-59890a5c2c6c"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8640), 205 },
                    { new Guid("304ce9d5-6ff6-4a62-b418-ab4988cd659b"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8840), 203 },
                    { new Guid("40d13ea5-1f8c-4390-82b0-fc6ab0b047e5"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8700), 201 },
                    { new Guid("44bdcfcd-7501-45f8-b181-012ee37c1ce1"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8810), 204 },
                    { new Guid("47cef1b2-77df-4a3f-971a-13ac866934c2"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8800), 203 },
                    { new Guid("48a31bc3-8078-40b8-807f-b0a1b08f2d94"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8720), 206 },
                    { new Guid("4fbcdace-7d82-422f-a517-f28a22247222"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8700), 200 },
                    { new Guid("51024c7b-3fb4-49e0-b907-485f4adb6435"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8600), 203 },
                    { new Guid("5e366b30-082b-4aab-93a2-1bb70bb2d10c"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8620), 208 },
                    { new Guid("600cae99-cafb-4d82-92cb-286d88a8fed5"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8650), 208 },
                    { new Guid("6254a611-5cc5-4b71-b6f6-d53351c7bb44"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8650), 207 },
                    { new Guid("6413d3a2-4e85-4c18-b7aa-6e33d14e7638"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8640), 204 },
                    { new Guid("66a27a07-a8d5-43ae-be6c-f8690c013f94"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8860), 210 },
                    { new Guid("6acc7531-cc7a-4ab6-87de-d2f7af5d6329"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8860), 208 },
                    { new Guid("72d8f80c-e611-4af9-889e-8e4c5d870b74"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8800), 202 },
                    { new Guid("734788b2-5bfc-4d76-897c-40a918106c16"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8850), 206 },
                    { new Guid("741be67c-e1c9-447f-ba7f-7aa8f4c3c5f8"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8820), 209 },
                    { new Guid("7ae880b6-0914-4b1e-b276-7fb7af52a19f"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8640), 203 },
                    { new Guid("7bc4b7fb-855c-406f-8964-0e641a54ce18"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8600), 201 },
                    { new Guid("80f8dce5-662a-4c5a-86ed-98da8643109d"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8630), 210 },
                    { new Guid("8224b0a9-9cc6-43d8-9acc-98c5d7db6f89"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8630), 202 },
                    { new Guid("84e3da95-9372-4af6-b4c4-64c397c4fb96"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8810), 205 },
                    { new Guid("949542b2-14e5-4944-aa15-db194000003b"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8790), 200 },
                    { new Guid("a28105ec-9132-47d2-b769-c4472e41b4df"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8640), 206 },
                    { new Guid("a60a6ac1-99e7-468d-bcd3-c3b6d3bf215d"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8630), 200 },
                    { new Guid("a690bd67-4949-4382-b2bd-a4cd6dd0b0f7"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8840), 204 },
                    { new Guid("aa4b69ec-024b-4f23-bb61-dd1f8982e0de"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8790), 210 },
                    { new Guid("b198921a-3d68-4067-a5b6-19f086b1d30b"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8590), 200 },
                    { new Guid("b2a855f1-6263-4c54-83d7-24d30d280563"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8850), 207 },
                    { new Guid("b779915d-52df-4e0d-8173-bfde01304a48"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8810), 206 },
                    { new Guid("b7abc369-e304-4e18-a953-c148beac05d8"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8630), 201 },
                    { new Guid("bc386832-bad5-429b-a350-eb3a5b9063e8"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8820), 207 },
                    { new Guid("bf497f2a-a004-4abf-9e1d-36f1659c189a"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8830), 210 },
                    { new Guid("c49ea702-42dd-4524-a95b-4298ab4f4a69"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8600), 202 },
                    { new Guid("cf5300fb-1880-443d-a731-80682c7a889d"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8620), 207 },
                    { new Guid("d06ca3f8-a3e1-4cfa-8925-44d007dc4db3"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8860), 209 },
                    { new Guid("d10fdbdf-b229-435f-82cc-347c09a7c8be"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8610), 204 },
                    { new Guid("d3f30e56-1492-4f05-b3cb-f28b8830c6c9"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8720), 205 },
                    { new Guid("d7d60ae3-2253-47eb-b8d2-592ff3eff606"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8650), 209 },
                    { new Guid("db4002f8-2661-4cdd-b377-dd017e779462"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8820), 208 },
                    { new Guid("e2990d44-ca16-4f23-9aa1-203c47e11b13"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8730), 209 },
                    { new Guid("e60c9e86-ef8e-4f45-ac07-4e6078df11f0"), 3, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8720), 204 },
                    { new Guid("eb3820d2-a6da-4ac4-a403-b3bd8a0c8d4a"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8830), 200 },
                    { new Guid("ebd66a9e-0813-4d77-9498-f66933d46412"), 4, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8800), 201 },
                    { new Guid("ecf56071-7ce2-430f-a2e1-219b3804a23e"), 2, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8650), 210 },
                    { new Guid("f000260e-fb82-4b2c-84a6-eba34cd5f1f5"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8840), 202 },
                    { new Guid("f2425a1e-0433-4508-aed4-3f63f3a148f2"), 1, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8620), 209 },
                    { new Guid("fb1e4faf-a95e-451c-99b9-373177f0651f"), 5, new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(8830), 201 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("056f5c1c-5738-4730-b762-f6558ad2fb73"), null, new DateTime(2024, 3, 10, 4, 57, 6, 142, DateTimeKind.Utc).AddTicks(9830), "dean@gmail.com", "dean", 0, "$2a$11$nkZlBbgn/1BNu1D8AyBD4umvEan8aUflTekR7L60pDO2.mRDZHoXK", null, 2 },
                    { new Guid("06fbbf6d-d7c3-4501-b634-17f72e4124d9"), null, new DateTime(2024, 3, 10, 4, 57, 6, 32, DateTimeKind.Utc).AddTicks(5410), "admin@gmail.com", "admin", 0, "$2a$11$.uCUo9hzeamgVWoafg7vS.Q2SrWWo7WmbInsug7Xqpu75cWyztDYW", null, 3 },
                    { new Guid("5ca1bc07-a59b-49c2-8c5f-ee3ed827ed4d"), null, new DateTime(2024, 3, 10, 4, 57, 6, 378, DateTimeKind.Utc).AddTicks(4270), "student@gmail.com", "student", 0, "$2a$11$ss74ukx6vtCb..cxCQZDquQkmxXErfuQQ.N/aWPL1dYIgBR25nLgu", null, 0 },
                    { new Guid("b63b35d3-f277-4f6a-9277-27a55a88f930"), null, new DateTime(2024, 3, 10, 4, 57, 6, 262, DateTimeKind.Utc).AddTicks(8220), "teacher@gmail.com", "teacher", 0, "$2a$11$EgvUsRnyCrtv53u1R9wak.iuZM.xnyCe8AoRd0rVZdx8PK7MGwU3m", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("00095c41-05b6-428d-b3bd-1e61fe781fb0"), new Guid("304ce9d5-6ff6-4a62-b418-ab4988cd659b"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9500), 0, null },
                    { new Guid("03e5d627-2c15-4769-8d48-9e4e6aaa44ad"), new Guid("a28105ec-9132-47d2-b769-c4472e41b4df"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9420), 0, null },
                    { new Guid("0528628c-dc5a-4726-bd44-b262032657db"), new Guid("aa4b69ec-024b-4f23-bb61-dd1f8982e0de"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9450), 0, null },
                    { new Guid("11cb9a71-3456-4c24-8b52-7fc808674ee2"), new Guid("949542b2-14e5-4944-aa15-db194000003b"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9460), 0, null },
                    { new Guid("16fccf53-8d29-46c4-9f2c-39f6192461db"), new Guid("6413d3a2-4e85-4c18-b7aa-6e33d14e7638"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9410), 0, null },
                    { new Guid("1b908a53-926a-48f2-9eb8-a0d0d9e5987a"), new Guid("72d8f80c-e611-4af9-889e-8e4c5d870b74"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9460), 0, null },
                    { new Guid("1e47f410-f1ea-45bd-ba9a-6441ac90d128"), new Guid("a60a6ac1-99e7-468d-bcd3-c3b6d3bf215d"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9400), 0, null },
                    { new Guid("28b0c5c0-2543-4689-ab87-490250a25daa"), new Guid("03403da8-e010-4490-87f2-0d406ee95e44"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9380), 0, null },
                    { new Guid("2963f30a-cf0e-48ed-8347-29a3fba963dd"), new Guid("2516201c-236f-4071-ae4f-0163b60d945e"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9390), 0, null },
                    { new Guid("2bac4e68-a481-4fbb-96da-cff7ff595cde"), new Guid("1e37ba0d-e660-4d32-9f3e-1f355dab53d1"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9430), 0, null },
                    { new Guid("3002824a-67e6-421e-9266-47a01bd346b0"), new Guid("eb3820d2-a6da-4ac4-a403-b3bd8a0c8d4a"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9490), 0, null },
                    { new Guid("33aff1d4-d530-4c74-82d2-6a786703b085"), new Guid("80f8dce5-662a-4c5a-86ed-98da8643109d"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9400), 0, null },
                    { new Guid("34530c6d-9a03-47d8-a459-1b2ba29c540e"), new Guid("25a765bc-66a8-4411-b1ca-1be8a5b5c37d"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9450), 0, null },
                    { new Guid("3551551d-a10f-4d99-a4ba-6a05af29776b"), new Guid("b7abc369-e304-4e18-a953-c148beac05d8"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9400), 0, null },
                    { new Guid("433417e6-a2fa-4940-bb0a-0a597f8ccc0b"), new Guid("7ae880b6-0914-4b1e-b276-7fb7af52a19f"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9410), 0, null },
                    { new Guid("4c85b5a7-350d-4bd7-993a-af2598f070b3"), new Guid("734788b2-5bfc-4d76-897c-40a918106c16"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9510), 0, null },
                    { new Guid("4dcc2061-eaeb-4052-9a61-665603d36786"), new Guid("51024c7b-3fb4-49e0-b907-485f4adb6435"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9380), 0, null },
                    { new Guid("4ede55af-128e-4a3e-be59-a43651fd1fe1"), new Guid("d10fdbdf-b229-435f-82cc-347c09a7c8be"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9380), 0, null },
                    { new Guid("522cd84f-9af5-463d-87c5-b2e52eddff6e"), new Guid("b2a855f1-6263-4c54-83d7-24d30d280563"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9510), 0, null },
                    { new Guid("538d6844-dbe3-4c24-a982-b3e6c8a7b327"), new Guid("741be67c-e1c9-447f-ba7f-7aa8f4c3c5f8"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9490), 0, null },
                    { new Guid("5479ae66-ccb2-48fc-8ac3-722219429050"), new Guid("f000260e-fb82-4b2c-84a6-eba34cd5f1f5"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9500), 0, null },
                    { new Guid("550385de-f3e3-4ae4-b1cf-072ec63d6cf2"), new Guid("db4002f8-2661-4cdd-b377-dd017e779462"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9480), 0, null },
                    { new Guid("56483076-c325-45bf-8cca-4c969550e590"), new Guid("a690bd67-4949-4382-b2bd-a4cd6dd0b0f7"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9500), 0, null },
                    { new Guid("648d5ad5-b363-4f42-b9f6-289737050acc"), new Guid("40d13ea5-1f8c-4390-82b0-fc6ab0b047e5"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9430), 0, null },
                    { new Guid("6d6ff562-c133-47f2-b014-42608f305786"), new Guid("d06ca3f8-a3e1-4cfa-8925-44d007dc4db3"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9520), 0, null },
                    { new Guid("7075149f-5d8d-490a-b011-a826c43c3648"), new Guid("b779915d-52df-4e0d-8173-bfde01304a48"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9470), 0, null },
                    { new Guid("733c5a63-4f43-48a6-8cbd-5b56c9d07186"), new Guid("600cae99-cafb-4d82-92cb-286d88a8fed5"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9420), 0, null },
                    { new Guid("78598b48-ee00-45ce-a516-0f7a60c0e256"), new Guid("e2990d44-ca16-4f23-9aa1-203c47e11b13"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9450), 0, null },
                    { new Guid("7c92d805-6b65-41a2-8498-ee5d25391dfe"), new Guid("e60c9e86-ef8e-4f45-ac07-4e6078df11f0"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9440), 0, null },
                    { new Guid("8099dac5-e65f-415a-b04e-751981e80b43"), new Guid("ebd66a9e-0813-4d77-9498-f66933d46412"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9460), 0, null },
                    { new Guid("8b907038-3ba8-44ea-ab0c-26bb426240aa"), new Guid("bf497f2a-a004-4abf-9e1d-36f1659c189a"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9490), 0, null },
                    { new Guid("968098d5-3eb9-4c74-b16b-e8c8db3a68a2"), new Guid("2d10b0f7-182d-4ec6-9fd6-59890a5c2c6c"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9410), 0, null },
                    { new Guid("9911969c-b7ea-449f-a776-b0f480cf5233"), new Guid("cf5300fb-1880-443d-a731-80682c7a889d"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9390), 0, null },
                    { new Guid("99456a00-107f-49c9-a2cc-6fe2256e9831"), new Guid("d3f30e56-1492-4f05-b3cb-f28b8830c6c9"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9440), 0, null },
                    { new Guid("a1fc0cab-0bcf-4ffe-8a85-d527cf9654ef"), new Guid("5e366b30-082b-4aab-93a2-1bb70bb2d10c"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9390), 0, null },
                    { new Guid("a37af81c-d648-4080-b9c8-1ca3fd104389"), new Guid("1fd9d87e-7176-4242-a1a2-302724e6a1ec"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9510), 0, null },
                    { new Guid("a8456133-3b2f-49b8-8bd9-e670c16f55b4"), new Guid("d7d60ae3-2253-47eb-b8d2-592ff3eff606"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9420), 0, null },
                    { new Guid("b629ee70-5763-44be-8367-06c300b74a34"), new Guid("b198921a-3d68-4067-a5b6-19f086b1d30b"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9360), 0, null },
                    { new Guid("ba849c6a-7aef-47f3-b308-93ab1b7e69da"), new Guid("48a31bc3-8078-40b8-807f-b0a1b08f2d94"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9440), 0, null },
                    { new Guid("bcaf5e67-6f0b-4aa6-be64-efa85a2b57f5"), new Guid("6254a611-5cc5-4b71-b6f6-d53351c7bb44"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9420), 0, null },
                    { new Guid("c5371275-8055-4160-bf5d-6bd56a24dc07"), new Guid("fb1e4faf-a95e-451c-99b9-373177f0651f"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9500), 0, null },
                    { new Guid("cb3c1413-53f7-4fa5-b08a-f556c556914c"), new Guid("c49ea702-42dd-4524-a95b-4298ab4f4a69"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9370), 0, null },
                    { new Guid("ccba6b5b-8d93-4339-a037-698be89acc34"), new Guid("ecf56071-7ce2-430f-a2e1-219b3804a23e"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9430), 0, null },
                    { new Guid("cee19b4f-f133-453d-ab1c-ed54948684f4"), new Guid("7bc4b7fb-855c-406f-8964-0e641a54ce18"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9370), 0, null },
                    { new Guid("cf5ebb7a-65af-4804-a3ed-308dd1d1019d"), new Guid("66a27a07-a8d5-43ae-be6c-f8690c013f94"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9520), 0, null },
                    { new Guid("d093b930-cfb9-465d-9e34-b6b9ad423d53"), new Guid("8224b0a9-9cc6-43d8-9acc-98c5d7db6f89"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9400), 0, null },
                    { new Guid("d7429847-a55e-44e1-8c03-47931205ac3a"), new Guid("1d62e2b8-97b6-4207-8f61-39357b9b7499"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9450), 0, null },
                    { new Guid("e35c0559-e0bd-46e7-bd74-31a35f978c95"), new Guid("6acc7531-cc7a-4ab6-87de-d2f7af5d6329"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9510), 0, null },
                    { new Guid("e4c78987-e6b8-4f5f-914b-78f217547039"), new Guid("44bdcfcd-7501-45f8-b181-012ee37c1ce1"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9470), 0, null },
                    { new Guid("ec533196-0a01-43fa-932e-efeadf26080b"), new Guid("47cef1b2-77df-4a3f-971a-13ac866934c2"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9470), 0, null },
                    { new Guid("ee6b85d6-463b-457e-ad17-c5197ae40877"), new Guid("4fbcdace-7d82-422f-a517-f28a22247222"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9430), 0, null },
                    { new Guid("f620328b-17b1-428b-b6d8-9d313ffc5108"), new Guid("84e3da95-9372-4af6-b4c4-64c397c4fb96"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9470), 0, null },
                    { new Guid("f9d99718-18cf-4639-b5bf-dad49bfda9e2"), new Guid("1eb75642-ba0f-4072-a7c2-f2d9f7df2c07"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9440), 0, null },
                    { new Guid("facb7047-f20d-403f-a6eb-7fb98b88e042"), new Guid("bc386832-bad5-429b-a350-eb3a5b9063e8"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9480), 0, null },
                    { new Guid("ff7a0174-d8bb-46e4-8ad0-12a8acacd610"), new Guid("f2425a1e-0433-4508-aed4-3f63f3a148f2"), new DateTime(2024, 3, 10, 4, 57, 6, 493, DateTimeKind.Utc).AddTicks(9390), 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("00095c41-05b6-428d-b3bd-1e61fe781fb0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("03e5d627-2c15-4769-8d48-9e4e6aaa44ad"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0528628c-dc5a-4726-bd44-b262032657db"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("11cb9a71-3456-4c24-8b52-7fc808674ee2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("16fccf53-8d29-46c4-9f2c-39f6192461db"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1b908a53-926a-48f2-9eb8-a0d0d9e5987a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1e47f410-f1ea-45bd-ba9a-6441ac90d128"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("28b0c5c0-2543-4689-ab87-490250a25daa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2963f30a-cf0e-48ed-8347-29a3fba963dd"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2bac4e68-a481-4fbb-96da-cff7ff595cde"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3002824a-67e6-421e-9266-47a01bd346b0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("33aff1d4-d530-4c74-82d2-6a786703b085"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("34530c6d-9a03-47d8-a459-1b2ba29c540e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3551551d-a10f-4d99-a4ba-6a05af29776b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("433417e6-a2fa-4940-bb0a-0a597f8ccc0b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4c85b5a7-350d-4bd7-993a-af2598f070b3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4dcc2061-eaeb-4052-9a61-665603d36786"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4ede55af-128e-4a3e-be59-a43651fd1fe1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("522cd84f-9af5-463d-87c5-b2e52eddff6e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("538d6844-dbe3-4c24-a982-b3e6c8a7b327"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5479ae66-ccb2-48fc-8ac3-722219429050"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("550385de-f3e3-4ae4-b1cf-072ec63d6cf2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("56483076-c325-45bf-8cca-4c969550e590"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("648d5ad5-b363-4f42-b9f6-289737050acc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6d6ff562-c133-47f2-b014-42608f305786"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7075149f-5d8d-490a-b011-a826c43c3648"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("733c5a63-4f43-48a6-8cbd-5b56c9d07186"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("78598b48-ee00-45ce-a516-0f7a60c0e256"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7c92d805-6b65-41a2-8498-ee5d25391dfe"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8099dac5-e65f-415a-b04e-751981e80b43"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8b907038-3ba8-44ea-ab0c-26bb426240aa"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("968098d5-3eb9-4c74-b16b-e8c8db3a68a2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9911969c-b7ea-449f-a776-b0f480cf5233"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("99456a00-107f-49c9-a2cc-6fe2256e9831"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a1fc0cab-0bcf-4ffe-8a85-d527cf9654ef"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a37af81c-d648-4080-b9c8-1ca3fd104389"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a8456133-3b2f-49b8-8bd9-e670c16f55b4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b629ee70-5763-44be-8367-06c300b74a34"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ba849c6a-7aef-47f3-b308-93ab1b7e69da"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bcaf5e67-6f0b-4aa6-be64-efa85a2b57f5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("c5371275-8055-4160-bf5d-6bd56a24dc07"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cb3c1413-53f7-4fa5-b08a-f556c556914c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ccba6b5b-8d93-4339-a037-698be89acc34"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cee19b4f-f133-453d-ab1c-ed54948684f4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("cf5ebb7a-65af-4804-a3ed-308dd1d1019d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d093b930-cfb9-465d-9e34-b6b9ad423d53"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d7429847-a55e-44e1-8c03-47931205ac3a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e35c0559-e0bd-46e7-bd74-31a35f978c95"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e4c78987-e6b8-4f5f-914b-78f217547039"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ec533196-0a01-43fa-932e-efeadf26080b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ee6b85d6-463b-457e-ad17-c5197ae40877"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f620328b-17b1-428b-b6d8-9d313ffc5108"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f9d99718-18cf-4639-b5bf-dad49bfda9e2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("facb7047-f20d-403f-a6eb-7fb98b88e042"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ff7a0174-d8bb-46e4-8ad0-12a8acacd610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("056f5c1c-5738-4730-b762-f6558ad2fb73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06fbbf6d-d7c3-4501-b634-17f72e4124d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ca1bc07-a59b-49c2-8c5f-ee3ed827ed4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b63b35d3-f277-4f6a-9277-27a55a88f930"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("03403da8-e010-4490-87f2-0d406ee95e44"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1d62e2b8-97b6-4207-8f61-39357b9b7499"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1e37ba0d-e660-4d32-9f3e-1f355dab53d1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1eb75642-ba0f-4072-a7c2-f2d9f7df2c07"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1fd9d87e-7176-4242-a1a2-302724e6a1ec"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2516201c-236f-4071-ae4f-0163b60d945e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("25a765bc-66a8-4411-b1ca-1be8a5b5c37d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2d10b0f7-182d-4ec6-9fd6-59890a5c2c6c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("304ce9d5-6ff6-4a62-b418-ab4988cd659b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("40d13ea5-1f8c-4390-82b0-fc6ab0b047e5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("44bdcfcd-7501-45f8-b181-012ee37c1ce1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("47cef1b2-77df-4a3f-971a-13ac866934c2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("48a31bc3-8078-40b8-807f-b0a1b08f2d94"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4fbcdace-7d82-422f-a517-f28a22247222"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("51024c7b-3fb4-49e0-b907-485f4adb6435"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5e366b30-082b-4aab-93a2-1bb70bb2d10c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("600cae99-cafb-4d82-92cb-286d88a8fed5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6254a611-5cc5-4b71-b6f6-d53351c7bb44"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6413d3a2-4e85-4c18-b7aa-6e33d14e7638"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("66a27a07-a8d5-43ae-be6c-f8690c013f94"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6acc7531-cc7a-4ab6-87de-d2f7af5d6329"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("72d8f80c-e611-4af9-889e-8e4c5d870b74"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("734788b2-5bfc-4d76-897c-40a918106c16"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("741be67c-e1c9-447f-ba7f-7aa8f4c3c5f8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7ae880b6-0914-4b1e-b276-7fb7af52a19f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7bc4b7fb-855c-406f-8964-0e641a54ce18"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("80f8dce5-662a-4c5a-86ed-98da8643109d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8224b0a9-9cc6-43d8-9acc-98c5d7db6f89"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("84e3da95-9372-4af6-b4c4-64c397c4fb96"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("949542b2-14e5-4944-aa15-db194000003b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a28105ec-9132-47d2-b769-c4472e41b4df"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a60a6ac1-99e7-468d-bcd3-c3b6d3bf215d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a690bd67-4949-4382-b2bd-a4cd6dd0b0f7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("aa4b69ec-024b-4f23-bb61-dd1f8982e0de"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b198921a-3d68-4067-a5b6-19f086b1d30b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b2a855f1-6263-4c54-83d7-24d30d280563"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b779915d-52df-4e0d-8173-bfde01304a48"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b7abc369-e304-4e18-a953-c148beac05d8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bc386832-bad5-429b-a350-eb3a5b9063e8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bf497f2a-a004-4abf-9e1d-36f1659c189a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c49ea702-42dd-4524-a95b-4298ab4f4a69"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cf5300fb-1880-443d-a731-80682c7a889d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d06ca3f8-a3e1-4cfa-8925-44d007dc4db3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d10fdbdf-b229-435f-82cc-347c09a7c8be"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d3f30e56-1492-4f05-b3cb-f28b8830c6c9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d7d60ae3-2253-47eb-b8d2-592ff3eff606"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("db4002f8-2661-4cdd-b377-dd017e779462"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e2990d44-ca16-4f23-9aa1-203c47e11b13"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e60c9e86-ef8e-4f45-ac07-4e6078df11f0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("eb3820d2-a6da-4ac4-a403-b3bd8a0c8d4a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ebd66a9e-0813-4d77-9498-f66933d46412"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ecf56071-7ce2-430f-a2e1-219b3804a23e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f000260e-fb82-4b2c-84a6-eba34cd5f1f5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f2425a1e-0433-4508-aed4-3f63f3a148f2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fb1e4faf-a95e-451c-99b9-373177f0651f"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TransferKeyRequests");

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("01a67120-ada5-412c-9b5e-6a335c3098e0"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2680), 203 },
                    { new Guid("04d8b6f4-24c1-4c97-82f3-2bc3fef36bee"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2700), 206 },
                    { new Guid("0609beb8-1053-4f57-a9c0-03e466e8909c"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2620), 210 },
                    { new Guid("0b1d3b4d-760d-4c6f-bf44-6c910e86c027"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2750), 200 },
                    { new Guid("18817dac-d617-45f0-b1d2-62c4cde557ed"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2620), 200 },
                    { new Guid("18bd34a0-89b6-4dc6-9975-f23458cdd890"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2590), 202 },
                    { new Guid("1ad2ca85-c6db-49db-b522-0dab1891dd72"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2720), 201 },
                    { new Guid("30237486-9607-4979-9da5-db262720ce31"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2710), 208 },
                    { new Guid("373a09d3-b5b2-4968-b07a-1d930aa72f08"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2680), 201 },
                    { new Guid("3b8f3f67-5d08-4bbb-80b1-3ead9bb443de"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2690), 204 },
                    { new Guid("3ea7bd90-029d-41ba-9564-36c42513df85"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2730), 206 },
                    { new Guid("3eabeb07-60dd-4b6f-82d4-087ac46ad779"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2610), 209 },
                    { new Guid("42038e4c-0271-4889-847f-b73f928fe5d9"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2770), 209 },
                    { new Guid("429fce3c-9bfe-4123-8698-b53cfd99be24"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2750), 201 },
                    { new Guid("46e38ba2-fb03-46e0-8492-63b9c268da85"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2750), 202 },
                    { new Guid("47532bf5-130b-423b-bb1f-8b2e71a8f6f2"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2680), 200 },
                    { new Guid("48101ee3-bca4-4744-a7c5-e77e370a2b5b"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2760), 204 },
                    { new Guid("4e853fa0-deab-4c38-9e50-c3545af0d5f3"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2760), 203 },
                    { new Guid("57dfa9c2-e89f-4b1a-ab32-2e440c583bad"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2720), 202 },
                    { new Guid("5b75d172-a703-4a26-8d77-bfa5a591a313"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2610), 208 },
                    { new Guid("5f325d44-6186-4800-84b5-cf5fbf058330"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2630), 205 },
                    { new Guid("6095f3f7-30c2-42f9-af40-39688b816815"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2620), 202 },
                    { new Guid("6a8d3a45-dc01-4d92-88ac-6eda1b6bfd89"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2680), 202 },
                    { new Guid("6f0939be-b16a-4fc3-ac17-58af4be14875"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2630), 207 },
                    { new Guid("777a0912-d486-40ed-9981-ffd514a016da"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2630), 206 },
                    { new Guid("789fcbdf-7168-4c83-b543-283cde841b0c"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2590), 203 },
                    { new Guid("93933301-2cac-49b7-80da-b380c7d60389"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2700), 207 },
                    { new Guid("9415ed4c-701c-42ef-a79d-9a250e118907"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2740), 210 },
                    { new Guid("941fd184-eabe-401a-945a-97c9a0eb429b"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2620), 201 },
                    { new Guid("971485c1-5bbe-43c3-a5dd-4f9080d1a798"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2610), 207 },
                    { new Guid("9941e5fc-0a74-484f-9823-7a1526c37c51"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2740), 208 },
                    { new Guid("9ee93fcf-363d-4e7b-9852-c7a2ff517f79"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2550), 200 },
                    { new Guid("9fb42181-de32-471c-ad73-4c9f8320241d"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2640), 210 },
                    { new Guid("a24ae76f-ce3a-491a-abc8-104712a15c7a"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2580), 201 },
                    { new Guid("a40edf40-7f3f-405e-a717-b7ebec4e543c"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2720), 200 },
                    { new Guid("a5c7632f-8214-4811-9d77-2cb0b0d19c02"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2730), 204 },
                    { new Guid("ad8d81db-7fe4-4193-b0a6-900eb68eff58"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2710), 210 },
                    { new Guid("b49f7dc9-129d-4e61-bbef-262b7fc91f42"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2700), 205 },
                    { new Guid("b5415d4d-b551-4759-886d-ae3c44a84a0c"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2760), 206 },
                    { new Guid("b6f9dfdd-6faa-4a90-9665-39e39df18877"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2770), 208 },
                    { new Guid("beca7854-ebed-43b3-9e82-19f50c483869"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2720), 203 },
                    { new Guid("c408d0be-6d1f-47c9-b435-03760d2bbfff"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2770), 210 },
                    { new Guid("ca6b4016-1411-4f09-9bbc-36a5f4adbb4a"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2620), 203 },
                    { new Guid("cfd60424-c1fb-4948-b9ca-00ddaa84d8c6"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2600), 205 },
                    { new Guid("dd4e5977-956a-44a5-8bed-56b77bfa5785"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2730), 205 },
                    { new Guid("e0c433aa-e2d5-4196-ab50-b355d0bf671e"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2640), 208 },
                    { new Guid("e3752e9d-e9a0-4277-92b1-51ef0d6b8ff7"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2760), 205 },
                    { new Guid("e414c132-7112-4415-95eb-1f769f30fd8b"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2610), 206 },
                    { new Guid("e5cd8380-ba54-47af-82f9-db07551403ae"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2640), 209 },
                    { new Guid("e9bd2968-e7ac-4d09-8f31-1fc7dccbac43"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2740), 207 },
                    { new Guid("ea001936-4b93-4ad5-bb40-98469d00e1b0"), 3, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2710), 209 },
                    { new Guid("ee25cfd3-b5e5-455f-be83-7a60dbd4b6fc"), 2, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2630), 204 },
                    { new Guid("f0631f96-14f0-4ac5-9573-5f59945a699f"), 1, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2590), 204 },
                    { new Guid("fb2402e1-24c4-4fa4-8921-a57acc4edfac"), 4, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2740), 209 },
                    { new Guid("ff8979cf-87e1-4598-9b5b-1516166b81d7"), 5, new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(2770), 207 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("2ffaa9a2-3314-425f-85ca-a5a44df51f7c"), null, new DateTime(2024, 3, 10, 4, 55, 11, 519, DateTimeKind.Utc).AddTicks(6940), "admin@gmail.com", "admin", 0, "$2a$11$XszftaG1hWqoNDHryIorD.6zUVu9eqdnqVJwRYrgR4LXLXvSSHfP.", null, 3 },
                    { new Guid("32fa17d9-b9b2-4564-a232-7335de84f209"), null, new DateTime(2024, 3, 10, 4, 55, 11, 742, DateTimeKind.Utc).AddTicks(3810), "teacher@gmail.com", "teacher", 0, "$2a$11$NmXUCovLbvX9MxfJjiXxz.Sk8D93J0FkO7obiUh2hACZl/2yyjcS.", null, 1 },
                    { new Guid("6388e355-6889-4bab-b217-460b7af446e3"), null, new DateTime(2024, 3, 10, 4, 55, 11, 853, DateTimeKind.Utc).AddTicks(5590), "student@gmail.com", "student", 0, "$2a$11$5gvFvf8SWBoILSOdakDhU.xBceId5iBNQkeMFwhfIJ5.50TG0I/oC", null, 0 },
                    { new Guid("f7958e57-f151-4c1e-9034-786b39b6d3b3"), null, new DateTime(2024, 3, 10, 4, 55, 11, 629, DateTimeKind.Utc).AddTicks(2790), "dean@gmail.com", "dean", 0, "$2a$11$x.e82vzVCdG5IQH4Ml4SwOC3dy.5fmDEcPFhrfecI5Q0j52S4gsU.", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ccee6cd-41df-42d7-b2fe-1e4d24e05a2f"), new Guid("57dfa9c2-e89f-4b1a-ab32-2e440c583bad"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3330), 0, null },
                    { new Guid("20719f0d-07c3-41c1-8d01-e0a1555cfedd"), new Guid("5b75d172-a703-4a26-8d77-bfa5a591a313"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3190), 0, null },
                    { new Guid("228997a6-d870-400f-9aa0-e76807464872"), new Guid("e0c433aa-e2d5-4196-ab50-b355d0bf671e"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3290), 0, null },
                    { new Guid("2a061ca5-86a2-4ff7-bed1-ba3a1e2db77a"), new Guid("beca7854-ebed-43b3-9e82-19f50c483869"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3330), 0, null },
                    { new Guid("2a2cd7e7-1ddf-4c16-a492-6a01c9df4851"), new Guid("4e853fa0-deab-4c38-9e50-c3545af0d5f3"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3360), 0, null },
                    { new Guid("3047f379-d38a-46db-968e-26229750c158"), new Guid("a5c7632f-8214-4811-9d77-2cb0b0d19c02"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3330), 0, null },
                    { new Guid("31f4c585-6fab-4946-8ede-0b1fa24af6a6"), new Guid("47532bf5-130b-423b-bb1f-8b2e71a8f6f2"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3300), 0, null },
                    { new Guid("3313fa13-887b-40c6-8a57-54e6b203d430"), new Guid("3ea7bd90-029d-41ba-9564-36c42513df85"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3340), 0, null },
                    { new Guid("3520882c-b151-4250-b1ff-51fdaff9e332"), new Guid("30237486-9607-4979-9da5-db262720ce31"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3320), 0, null },
                    { new Guid("3c7e9cfc-3092-4949-8a4b-d08759616043"), new Guid("93933301-2cac-49b7-80da-b380c7d60389"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3310), 0, null },
                    { new Guid("3d29772e-1c9a-4eb4-bef1-aa32b8c05157"), new Guid("0609beb8-1053-4f57-a9c0-03e466e8909c"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3200), 0, null },
                    { new Guid("3f55535b-033f-43a2-aaa9-59363717b7fe"), new Guid("b5415d4d-b551-4759-886d-ae3c44a84a0c"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3360), 0, null },
                    { new Guid("474e5a74-406e-41c1-a46e-6a7ff43128e1"), new Guid("e9bd2968-e7ac-4d09-8f31-1fc7dccbac43"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3340), 0, null },
                    { new Guid("4ce7d778-b432-4e22-9a1d-8308d534b876"), new Guid("429fce3c-9bfe-4123-8698-b53cfd99be24"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3350), 0, null },
                    { new Guid("4f1e6a0a-2136-406c-8aac-e517d1923914"), new Guid("04d8b6f4-24c1-4c97-82f3-2bc3fef36bee"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3310), 0, null },
                    { new Guid("55871ca0-faa5-4983-bd3e-b66f305e090a"), new Guid("ca6b4016-1411-4f09-9bbc-36a5f4adbb4a"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3210), 0, null },
                    { new Guid("64e65bf4-b5d7-4393-93e2-b7a1e7d24f84"), new Guid("971485c1-5bbe-43c3-a5dd-4f9080d1a798"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3190), 0, null },
                    { new Guid("6ce06c5d-f44d-4bfe-8ad0-3a21d414f072"), new Guid("ee25cfd3-b5e5-455f-be83-7a60dbd4b6fc"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3210), 0, null },
                    { new Guid("6fd11c86-9a3b-453d-a62f-7979523bdd40"), new Guid("6f0939be-b16a-4fc3-ac17-58af4be14875"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3290), 0, null },
                    { new Guid("7942ef47-4e68-418c-93d2-2ca1fa5d0c9a"), new Guid("b49f7dc9-129d-4e61-bbef-262b7fc91f42"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3310), 0, null },
                    { new Guid("7f1ea2ae-db91-4b92-94f8-bbc8abdabf8c"), new Guid("ad8d81db-7fe4-4193-b0a6-900eb68eff58"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3320), 0, null },
                    { new Guid("811e5f48-8fc7-493f-9f39-92b54fb083b9"), new Guid("5f325d44-6186-4800-84b5-cf5fbf058330"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3210), 0, null },
                    { new Guid("812d5970-dee2-4457-adcb-c91c16dbd21e"), new Guid("6a8d3a45-dc01-4d92-88ac-6eda1b6bfd89"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3300), 0, null },
                    { new Guid("8293300c-c0f6-4cad-be5e-08c6eaf185e5"), new Guid("3b8f3f67-5d08-4bbb-80b1-3ead9bb443de"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3310), 0, null },
                    { new Guid("84f22920-1718-4865-9e91-e8640ff596c4"), new Guid("1ad2ca85-c6db-49db-b522-0dab1891dd72"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3330), 0, null },
                    { new Guid("8514f5bd-d756-4955-ba2c-21850cd7b7c1"), new Guid("42038e4c-0271-4889-847f-b73f928fe5d9"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3370), 0, null },
                    { new Guid("873184cf-d16f-432f-be49-18cebe0dd10c"), new Guid("fb2402e1-24c4-4fa4-8921-a57acc4edfac"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3340), 0, null },
                    { new Guid("8d1ba9d6-39b3-4dbd-bcc1-ff71606fb83e"), new Guid("789fcbdf-7168-4c83-b543-283cde841b0c"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3180), 0, null },
                    { new Guid("8ee51b02-5e61-4f86-81de-83b5f0324d9c"), new Guid("cfd60424-c1fb-4948-b9ca-00ddaa84d8c6"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3180), 0, null },
                    { new Guid("8fd22a0c-46bb-4ad6-8cdb-00fa1d3845b5"), new Guid("941fd184-eabe-401a-945a-97c9a0eb429b"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3200), 0, null },
                    { new Guid("977adf97-ae93-4bc7-8de5-3e4d30a41482"), new Guid("a40edf40-7f3f-405e-a717-b7ebec4e543c"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3320), 0, null },
                    { new Guid("991fd769-67c4-4ab7-ad6e-63b5543ce72c"), new Guid("0b1d3b4d-760d-4c6f-bf44-6c910e86c027"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3350), 0, null },
                    { new Guid("9e9f9aab-b34e-4e01-ab4d-14bf51a9af9e"), new Guid("e5cd8380-ba54-47af-82f9-db07551403ae"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3290), 0, null },
                    { new Guid("9fb014fc-b34c-4fae-addf-c5e71acb7951"), new Guid("a24ae76f-ce3a-491a-abc8-104712a15c7a"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3170), 0, null },
                    { new Guid("a158c963-9dd7-4275-952b-61e5f9c5d253"), new Guid("ff8979cf-87e1-4598-9b5b-1516166b81d7"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3370), 0, null },
                    { new Guid("a3ab227a-a5e3-4684-a937-68b054139794"), new Guid("9fb42181-de32-471c-ad73-4c9f8320241d"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3290), 0, null },
                    { new Guid("a97def36-a34a-47e5-ab89-60ea123d4929"), new Guid("9415ed4c-701c-42ef-a79d-9a250e118907"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3350), 0, null },
                    { new Guid("b0831dd9-4f49-4dd4-b0f7-8272f4c330e2"), new Guid("18817dac-d617-45f0-b1d2-62c4cde557ed"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3200), 0, null },
                    { new Guid("c04cf9ca-0a57-4711-96db-06c2172bf0b8"), new Guid("46e38ba2-fb03-46e0-8492-63b9c268da85"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3350), 0, null },
                    { new Guid("cb70065f-076c-4903-9cb7-0111839b7a75"), new Guid("3eabeb07-60dd-4b6f-82d4-087ac46ad779"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3190), 0, null },
                    { new Guid("cd7391b1-edb4-494e-83f1-36c75ac49f8a"), new Guid("dd4e5977-956a-44a5-8bed-56b77bfa5785"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3330), 0, null },
                    { new Guid("d21ac3ac-06f0-4c50-a932-35c4896ae031"), new Guid("6095f3f7-30c2-42f9-af40-39688b816815"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3200), 0, null },
                    { new Guid("d9b1e3e6-5a8e-479e-8a12-4affeb1139c5"), new Guid("9ee93fcf-363d-4e7b-9852-c7a2ff517f79"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3170), 0, null },
                    { new Guid("d9dcd118-f4b5-4d06-92ce-d3461dff3496"), new Guid("e414c132-7112-4415-95eb-1f769f30fd8b"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3190), 0, null },
                    { new Guid("dc5e170b-6576-4734-b234-7e18f9758edb"), new Guid("e3752e9d-e9a0-4277-92b1-51ef0d6b8ff7"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3360), 0, null },
                    { new Guid("dc60b0d9-1cf9-44c2-b47f-d3805f83c5c3"), new Guid("777a0912-d486-40ed-9981-ffd514a016da"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3280), 0, null },
                    { new Guid("de94930e-58ed-4fa7-b40e-23f0162a9150"), new Guid("ea001936-4b93-4ad5-bb40-98469d00e1b0"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3320), 0, null },
                    { new Guid("dfbf55cb-2616-4133-9ec7-b5d8998312f1"), new Guid("373a09d3-b5b2-4968-b07a-1d930aa72f08"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3300), 0, null },
                    { new Guid("e192b13e-5ba8-4792-80a8-b616c2bd277d"), new Guid("01a67120-ada5-412c-9b5e-6a335c3098e0"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3300), 0, null },
                    { new Guid("e271b19e-d4d7-4c69-aa2b-42f997a3c064"), new Guid("18bd34a0-89b6-4dc6-9975-f23458cdd890"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3180), 0, null },
                    { new Guid("e3fc6028-cac6-405f-9e09-f019e3aa446a"), new Guid("48101ee3-bca4-4744-a7c5-e77e370a2b5b"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3360), 0, null },
                    { new Guid("e4381c12-ffdc-46f1-8261-996f6ea3c15b"), new Guid("b6f9dfdd-6faa-4a90-9665-39e39df18877"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3370), 0, null },
                    { new Guid("e58cb672-bcc5-4fb3-a8ef-db94d2f25b10"), new Guid("c408d0be-6d1f-47c9-b435-03760d2bbfff"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3370), 0, null },
                    { new Guid("e7cce20e-5dc7-456b-947a-dcb2c170fea8"), new Guid("f0631f96-14f0-4ac5-9573-5f59945a699f"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3180), 0, null },
                    { new Guid("f50577fb-3f9e-482e-be25-a8ece215589e"), new Guid("9941e5fc-0a74-484f-9823-7a1526c37c51"), new DateTime(2024, 3, 10, 4, 55, 11, 962, DateTimeKind.Utc).AddTicks(3340), 0, null }
                });
        }
    }
}
