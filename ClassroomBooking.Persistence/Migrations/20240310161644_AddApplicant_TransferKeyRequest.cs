using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicant_TransferKeyRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "TransferKeyRequests",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("062584c5-087b-4865-8de0-4ea693f7d8f7"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3950), 210 },
                    { new Guid("0c7cc95c-3d0c-49ef-a68b-27f4e79902ce"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3930), 203 },
                    { new Guid("0ea4f505-6219-4d9f-a382-406aa6bf85d9"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3960), 201 },
                    { new Guid("18cf6922-ab01-4a89-ad3c-43ff607efdad"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3910), 206 },
                    { new Guid("19869e28-996d-4b72-969b-918f56cf1146"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3990), 210 },
                    { new Guid("1d98fbc5-822e-49cd-8ae1-9d484d3b457f"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4010), 208 },
                    { new Guid("21017d05-7eac-4b53-8eae-1d7486268096"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3940), 204 },
                    { new Guid("22ad8594-c8b9-4cef-82be-7e0dc31cecc5"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4030), 205 },
                    { new Guid("230435a5-bad4-4293-8a1a-e2e02c8887c4"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3980), 209 },
                    { new Guid("2cf989a4-2215-449f-8413-9dfe51e7d8e1"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4000), 205 },
                    { new Guid("3011e30b-58e6-4a40-ba37-d323bee3c15a"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3910), 204 },
                    { new Guid("32d483de-d021-4109-8801-b1c15604bd3f"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3920), 207 },
                    { new Guid("41a03bcc-62af-4680-b21d-5963b46f0fb2"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3920), 209 },
                    { new Guid("4bc6c8c6-a3ce-43dd-ba88-b33af5163de8"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3930), 200 },
                    { new Guid("59df537b-67d1-477e-b3cd-f930580c4f2d"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4030), 204 },
                    { new Guid("5e5fd0b5-ac51-44bd-bc7f-2596377e8c8c"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3980), 207 },
                    { new Guid("61ab281a-a8c1-46ff-a97b-3ee6e9c0037a"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4020), 200 },
                    { new Guid("6572d001-8b92-4a3a-839b-693c616c77e1"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3940), 206 },
                    { new Guid("6a6b448e-bdaf-43e1-95c8-288a475f7eba"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4010), 210 },
                    { new Guid("701f5ccd-6b85-4dd7-95d2-e16073fb3cad"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3950), 209 },
                    { new Guid("71f7ca6c-4885-4668-9974-8ff69c7c5d57"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3950), 207 },
                    { new Guid("73bfb99b-f6f8-4a16-b74c-337452a817d4"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4030), 206 },
                    { new Guid("741f8960-82ca-40bc-929c-298e0e066769"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3950), 208 },
                    { new Guid("7478a60d-9788-4c89-b352-465f8db4aba4"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3970), 206 },
                    { new Guid("81aa2044-77e1-4fde-bb8d-bfb2f2b9be2f"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3960), 202 },
                    { new Guid("8253fded-71ba-4f7e-a15e-733c749104c8"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3930), 201 },
                    { new Guid("82de3c4e-4549-44be-ab92-eec2d8cf3b20"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3900), 202 },
                    { new Guid("831a9b71-b9d6-46fc-a93b-d07e49a46248"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4000), 206 },
                    { new Guid("8ed39399-13b0-4c10-bd50-2737dbcad558"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4010), 207 },
                    { new Guid("8f711aea-b3d8-4e67-a409-03ea0f52eabf"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4040), 209 },
                    { new Guid("909ffaf0-dd6d-40dc-ade3-80974d72ae15"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3980), 208 },
                    { new Guid("93260ce5-4d81-4c24-9925-1f4c987d7e08"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4020), 202 },
                    { new Guid("9ae758ce-edbb-4097-934d-1e86f1c7a977"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3990), 201 },
                    { new Guid("9f30d90b-6898-44ac-9abe-433c099c8c04"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3940), 205 },
                    { new Guid("adbfda62-39e3-4638-a028-cfc66cbee386"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3850), 200 },
                    { new Guid("b085cffc-fbb0-4ae6-a65d-049e625a6222"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3900), 203 },
                    { new Guid("b7a90e57-3942-4991-9662-dd6e96259456"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4000), 203 },
                    { new Guid("c1ec9604-418f-4225-9bd5-4d8563f098bf"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4040), 210 },
                    { new Guid("c3ae051f-939d-4a99-9d39-2482c97bf2bc"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3970), 204 },
                    { new Guid("c40e9303-c69e-47bf-8094-f31ea1604c9c"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4020), 201 },
                    { new Guid("c4dbb25c-5964-4176-a4fb-01bbde8f6914"), 2, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3930), 202 },
                    { new Guid("cb2a8001-e04e-4398-b121-0bfa1528fd5c"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3960), 200 },
                    { new Guid("cb4697ef-8b96-4f1d-b2ca-f22aba621fd9"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4010), 209 },
                    { new Guid("cb546816-100a-44a3-91a3-f6f486df46ea"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4000), 204 },
                    { new Guid("d308371a-6432-4fcd-b0c4-016b5da9d398"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4040), 208 },
                    { new Guid("da9848ff-7b00-40e9-a720-da28592dc61e"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3990), 200 },
                    { new Guid("db252781-65e2-4665-83d1-7c3d27008ff4"), 4, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3990), 202 },
                    { new Guid("e99e4cbd-ecab-4d6b-9ab7-b810bba43bba"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3920), 210 },
                    { new Guid("ef2d48ff-18d0-4b2f-96a2-aec53741da69"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3900), 201 },
                    { new Guid("f0328834-1cfe-4b01-99cb-4136096baa52"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3920), 208 },
                    { new Guid("f11b6123-a094-469a-b599-642f229ead5e"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4020), 203 },
                    { new Guid("f769b6be-cc52-4c2a-a16c-d2271a6f6e4a"), 1, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3910), 205 },
                    { new Guid("f902ad5e-3f0f-4642-ad52-4bbd51a121f6"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3960), 203 },
                    { new Guid("fc6381d6-93e7-4c69-a027-44f83fbeac7f"), 3, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(3970), 205 },
                    { new Guid("fd03d018-c7cb-4fea-bf4a-28aef430c64a"), 5, new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4030), 207 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateTime", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserRole" },
                values: new object[,]
                {
                    { new Guid("08c0b13f-9deb-4141-9116-f63de491e7b1"), null, new DateTime(2024, 3, 10, 16, 16, 44, 164, DateTimeKind.Utc).AddTicks(9490), "admin@gmail.com", "admin", 0, "$2a$11$Mvk6rNr99YhY1uJ3K2YDjeia9B1277/zBcfNwk.epaLjethzWNNDa", null, 3 },
                    { new Guid("1fab8f48-652f-4f1a-873d-0cd764f99ed4"), null, new DateTime(2024, 3, 10, 16, 16, 44, 406, DateTimeKind.Utc).AddTicks(930), "teacher@gmail.com", "teacher", 0, "$2a$11$50l0OZmpxwsxBIDpT14XSOAsj1lZuAG5rbm41LxNhlsYC4zreB6ma", null, 1 },
                    { new Guid("35524fee-e0d7-4948-8802-debca2ef6573"), null, new DateTime(2024, 3, 10, 16, 16, 44, 286, DateTimeKind.Utc).AddTicks(7380), "dean@gmail.com", "dean", 0, "$2a$11$VIxLf/VlPgtefN0aOEU0yuY0ZicRdAp3/UmcLzhp9tJryn7LlTcnO", null, 2 },
                    { new Guid("b4ad654f-e775-4a7f-b1ee-3e0b3b16fb70"), null, new DateTime(2024, 3, 10, 16, 16, 44, 525, DateTimeKind.Utc).AddTicks(5760), "student@gmail.com", "student", 0, "$2a$11$eXtZsGIyVU7UHZ9VsZvht.qOi0Ynt.hLdQdu/TSxU8cpk/NYjfdJ.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("07f67f95-09bb-451d-9afa-ddd2928e9cf0"), new Guid("b085cffc-fbb0-4ae6-a65d-049e625a6222"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4160), 0, null },
                    { new Guid("0a2e55b2-7dee-4bc0-958b-eaf2f4913894"), new Guid("82de3c4e-4549-44be-ab92-eec2d8cf3b20"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4160), 0, null },
                    { new Guid("0be05894-58ca-4820-9c5e-b4a4ba7bf8b0"), new Guid("f769b6be-cc52-4c2a-a16c-d2271a6f6e4a"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4170), 0, null },
                    { new Guid("13ee2bf1-298a-4e9e-b6f4-3b0823b020da"), new Guid("2cf989a4-2215-449f-8413-9dfe51e7d8e1"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4270), 0, null },
                    { new Guid("14e2d8ce-b130-4c66-a0e3-9b0dcf2a1f3a"), new Guid("909ffaf0-dd6d-40dc-ade3-80974d72ae15"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4240), 0, null },
                    { new Guid("154338b0-9231-4a92-a6cf-13359530a843"), new Guid("71f7ca6c-4885-4668-9974-8ff69c7c5d57"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4200), 0, null },
                    { new Guid("1b48ca58-5538-46e3-8438-504a0ceaedda"), new Guid("1d98fbc5-822e-49cd-8ae1-9d484d3b457f"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4280), 0, null },
                    { new Guid("25f5e47f-1cb1-42b8-803d-f4f69a15b0df"), new Guid("db252781-65e2-4665-83d1-7c3d27008ff4"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4260), 0, null },
                    { new Guid("2ab2292a-4014-4ec5-b0c1-cc928778d10f"), new Guid("5e5fd0b5-ac51-44bd-bc7f-2596377e8c8c"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4240), 0, null },
                    { new Guid("2e9017c8-cfe7-407c-b54b-3717b2c485d6"), new Guid("c4dbb25c-5964-4176-a4fb-01bbde8f6914"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4190), 0, null },
                    { new Guid("2ff27440-0684-4554-98fb-930a670285fb"), new Guid("cb4697ef-8b96-4f1d-b2ca-f22aba621fd9"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4280), 0, null },
                    { new Guid("32d1d9c6-9908-4132-865d-e8ca2d2cb35d"), new Guid("c40e9303-c69e-47bf-8094-f31ea1604c9c"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4290), 0, null },
                    { new Guid("3e88cbaf-64fc-48c6-b4ab-ca2c5e424abf"), new Guid("701f5ccd-6b85-4dd7-95d2-e16073fb3cad"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4210), 0, null },
                    { new Guid("4159d035-b394-4d2e-90a2-a8466813ad5e"), new Guid("831a9b71-b9d6-46fc-a93b-d07e49a46248"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4270), 0, null },
                    { new Guid("42e4607d-5470-4558-806f-e27059f870de"), new Guid("9ae758ce-edbb-4097-934d-1e86f1c7a977"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4260), 0, null },
                    { new Guid("48e02aa0-7905-456c-a87b-514dcc68e32c"), new Guid("da9848ff-7b00-40e9-a720-da28592dc61e"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4250), 0, null },
                    { new Guid("51c78f5a-bfbc-4672-ac63-dd6c3ffd93e2"), new Guid("cb2a8001-e04e-4398-b121-0bfa1528fd5c"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4220), 0, null },
                    { new Guid("52c84241-b7ee-403d-bb1f-acc5fc2ee600"), new Guid("c1ec9604-418f-4225-9bd5-4d8563f098bf"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4320), 0, null },
                    { new Guid("5f5b2f7c-158a-4009-89ca-36055fc1d1db"), new Guid("19869e28-996d-4b72-969b-918f56cf1146"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4250), 0, null },
                    { new Guid("66bf3b75-0491-4a3a-b952-d88d0fcc9960"), new Guid("8253fded-71ba-4f7e-a15e-733c749104c8"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4190), 0, null },
                    { new Guid("67a7a8e4-007f-46da-8c28-4d6b42a1d6fe"), new Guid("fd03d018-c7cb-4fea-bf4a-28aef430c64a"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4310), 0, null },
                    { new Guid("6b05da42-86eb-4146-9395-24884a878ad3"), new Guid("18cf6922-ab01-4a89-ad3c-43ff607efdad"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4170), 0, null },
                    { new Guid("6efc7483-2f2d-453c-9802-e7aad636f481"), new Guid("4bc6c8c6-a3ce-43dd-ba88-b33af5163de8"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4180), 0, null },
                    { new Guid("70e77c88-9c10-45b1-95cd-801fc17a26fc"), new Guid("59df537b-67d1-477e-b3cd-f930580c4f2d"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4300), 0, null },
                    { new Guid("7f8eacb4-0e89-4c73-a415-9c80adb8cc56"), new Guid("741f8960-82ca-40bc-929c-298e0e066769"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4210), 0, null },
                    { new Guid("82044320-5da7-4b79-9021-ef9b5950c68d"), new Guid("61ab281a-a8c1-46ff-a97b-3ee6e9c0037a"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4290), 0, null },
                    { new Guid("827151a3-ab56-4e58-8f59-223943df7c06"), new Guid("adbfda62-39e3-4638-a028-cfc66cbee386"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4130), 0, null },
                    { new Guid("8cfd6194-156f-4b17-b5a5-ce21ade1e992"), new Guid("22ad8594-c8b9-4cef-82be-7e0dc31cecc5"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4300), 0, null },
                    { new Guid("8ea41f49-67d8-4b90-adf1-fce240e397c2"), new Guid("cb546816-100a-44a3-91a3-f6f486df46ea"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4270), 0, null },
                    { new Guid("8fc87580-7aae-4c63-8ee1-0a3f1c2b0cb4"), new Guid("41a03bcc-62af-4680-b21d-5963b46f0fb2"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4180), 0, null },
                    { new Guid("9770addd-6472-440f-a340-db8875fdfd9d"), new Guid("9f30d90b-6898-44ac-9abe-433c099c8c04"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4200), 0, null },
                    { new Guid("98569024-ad7f-47c6-8c00-cbd9678ff824"), new Guid("32d483de-d021-4109-8801-b1c15604bd3f"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4170), 0, null },
                    { new Guid("a1460c63-ebbc-44ce-b948-e0a867f45d26"), new Guid("230435a5-bad4-4293-8a1a-e2e02c8887c4"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4250), 0, null },
                    { new Guid("a2916e68-b2ac-4ae9-8f27-07d78cb5aa51"), new Guid("6a6b448e-bdaf-43e1-95c8-288a475f7eba"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4280), 0, null },
                    { new Guid("a54a4ec1-7fca-4aea-bec7-78e6f045a83c"), new Guid("f902ad5e-3f0f-4642-ad52-4bbd51a121f6"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4230), 0, null },
                    { new Guid("a7dd521e-396c-4048-8ff4-0d8055304b95"), new Guid("8ed39399-13b0-4c10-bd50-2737dbcad558"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4280), 0, null },
                    { new Guid("a9b776eb-47c9-4ac4-a65e-0f5b0534c767"), new Guid("0c7cc95c-3d0c-49ef-a68b-27f4e79902ce"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4190), 0, null },
                    { new Guid("ad460593-6b8d-41f7-94cb-059f79c4f7c5"), new Guid("73bfb99b-f6f8-4a16-b74c-337452a817d4"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4310), 0, null },
                    { new Guid("ade3e627-4e5e-4945-b5d9-9ef39f99eb7d"), new Guid("0ea4f505-6219-4d9f-a382-406aa6bf85d9"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4220), 0, null },
                    { new Guid("b01a18a8-7219-44b6-bed2-781637939d14"), new Guid("81aa2044-77e1-4fde-bb8d-bfb2f2b9be2f"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4220), 0, null },
                    { new Guid("b0dac904-d9a2-41fc-9dad-024bdbe21eb4"), new Guid("b7a90e57-3942-4991-9662-dd6e96259456"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4260), 0, null },
                    { new Guid("b1e74d76-1504-4857-a4c3-86539286cdb4"), new Guid("062584c5-087b-4865-8de0-4ea693f7d8f7"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4210), 0, null },
                    { new Guid("b3189bf5-3dd1-49df-a4c9-c14bd22784f7"), new Guid("fc6381d6-93e7-4c69-a027-44f83fbeac7f"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4230), 0, null },
                    { new Guid("b4387db8-9561-4b54-b2a1-23baaa6aa662"), new Guid("e99e4cbd-ecab-4d6b-9ab7-b810bba43bba"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4180), 0, null },
                    { new Guid("b874edb7-46cc-4696-bf9c-d5d31ad3af76"), new Guid("8f711aea-b3d8-4e67-a409-03ea0f52eabf"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4320), 0, null },
                    { new Guid("ba15fc63-f7e6-42d4-a5a3-e9f08c6786cf"), new Guid("c3ae051f-939d-4a99-9d39-2482c97bf2bc"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4230), 0, null },
                    { new Guid("bbac40ca-2dc2-4534-b582-1cc8b6ca6bed"), new Guid("3011e30b-58e6-4a40-ba37-d323bee3c15a"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4160), 0, null },
                    { new Guid("bf92337f-11a5-4a5d-baf6-57369f811508"), new Guid("7478a60d-9788-4c89-b352-465f8db4aba4"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4240), 0, null },
                    { new Guid("d0b0eb1f-f319-4877-8e3d-0842fb80f909"), new Guid("93260ce5-4d81-4c24-9925-1f4c987d7e08"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4290), 0, null },
                    { new Guid("d1c48c12-4092-4035-87d4-3e1dbc70826d"), new Guid("d308371a-6432-4fcd-b0c4-016b5da9d398"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4310), 0, null },
                    { new Guid("e112773b-3e8d-4531-bd51-0793fb20acf3"), new Guid("f0328834-1cfe-4b01-99cb-4136096baa52"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4180), 0, null },
                    { new Guid("e6a068cf-3da3-4247-8f44-d87577f9e25f"), new Guid("ef2d48ff-18d0-4b2f-96a2-aec53741da69"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4160), 0, null },
                    { new Guid("e86133ce-5d0d-4c0b-ac14-e3fb8a83a560"), new Guid("21017d05-7eac-4b53-8eae-1d7486268096"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4190), 0, null },
                    { new Guid("f60ffbdf-c2ab-40f5-84c8-547afeadb0a7"), new Guid("f11b6123-a094-469a-b599-642f229ead5e"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4300), 0, null },
                    { new Guid("fd4611fd-5447-4f8f-ac46-a0d338beac06"), new Guid("6572d001-8b92-4a3a-839b-693c616c77e1"), new DateTime(2024, 3, 10, 16, 16, 44, 646, DateTimeKind.Utc).AddTicks(4200), 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransferKeyRequests_ApplicantId",
                table: "TransferKeyRequests",
                column: "ApplicantId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransferKeyRequests_Users_ApplicantId",
                table: "TransferKeyRequests",
                column: "ApplicantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransferKeyRequests_Users_ApplicantId",
                table: "TransferKeyRequests");

            migrationBuilder.DropIndex(
                name: "IX_TransferKeyRequests_ApplicantId",
                table: "TransferKeyRequests");

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("07f67f95-09bb-451d-9afa-ddd2928e9cf0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0a2e55b2-7dee-4bc0-958b-eaf2f4913894"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("0be05894-58ca-4820-9c5e-b4a4ba7bf8b0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("13ee2bf1-298a-4e9e-b6f4-3b0823b020da"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("14e2d8ce-b130-4c66-a0e3-9b0dcf2a1f3a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("154338b0-9231-4a92-a6cf-13359530a843"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1b48ca58-5538-46e3-8438-504a0ceaedda"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("25f5e47f-1cb1-42b8-803d-f4f69a15b0df"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2ab2292a-4014-4ec5-b0c1-cc928778d10f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2e9017c8-cfe7-407c-b54b-3717b2c485d6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("2ff27440-0684-4554-98fb-930a670285fb"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("32d1d9c6-9908-4132-865d-e8ca2d2cb35d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3e88cbaf-64fc-48c6-b4ab-ca2c5e424abf"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4159d035-b394-4d2e-90a2-a8466813ad5e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("42e4607d-5470-4558-806f-e27059f870de"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("48e02aa0-7905-456c-a87b-514dcc68e32c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("51c78f5a-bfbc-4672-ac63-dd6c3ffd93e2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("52c84241-b7ee-403d-bb1f-acc5fc2ee600"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5f5b2f7c-158a-4009-89ca-36055fc1d1db"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("66bf3b75-0491-4a3a-b952-d88d0fcc9960"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("67a7a8e4-007f-46da-8c28-4d6b42a1d6fe"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6b05da42-86eb-4146-9395-24884a878ad3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6efc7483-2f2d-453c-9802-e7aad636f481"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("70e77c88-9c10-45b1-95cd-801fc17a26fc"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7f8eacb4-0e89-4c73-a415-9c80adb8cc56"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("82044320-5da7-4b79-9021-ef9b5950c68d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("827151a3-ab56-4e58-8f59-223943df7c06"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8cfd6194-156f-4b17-b5a5-ce21ade1e992"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8ea41f49-67d8-4b90-adf1-fce240e397c2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8fc87580-7aae-4c63-8ee1-0a3f1c2b0cb4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9770addd-6472-440f-a340-db8875fdfd9d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("98569024-ad7f-47c6-8c00-cbd9678ff824"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a1460c63-ebbc-44ce-b948-e0a867f45d26"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a2916e68-b2ac-4ae9-8f27-07d78cb5aa51"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a54a4ec1-7fca-4aea-bec7-78e6f045a83c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a7dd521e-396c-4048-8ff4-0d8055304b95"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a9b776eb-47c9-4ac4-a65e-0f5b0534c767"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ad460593-6b8d-41f7-94cb-059f79c4f7c5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ade3e627-4e5e-4945-b5d9-9ef39f99eb7d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b01a18a8-7219-44b6-bed2-781637939d14"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b0dac904-d9a2-41fc-9dad-024bdbe21eb4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b1e74d76-1504-4857-a4c3-86539286cdb4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b3189bf5-3dd1-49df-a4c9-c14bd22784f7"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b4387db8-9561-4b54-b2a1-23baaa6aa662"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b874edb7-46cc-4696-bf9c-d5d31ad3af76"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ba15fc63-f7e6-42d4-a5a3-e9f08c6786cf"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bbac40ca-2dc2-4534-b582-1cc8b6ca6bed"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bf92337f-11a5-4a5d-baf6-57369f811508"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d0b0eb1f-f319-4877-8e3d-0842fb80f909"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d1c48c12-4092-4035-87d4-3e1dbc70826d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e112773b-3e8d-4531-bd51-0793fb20acf3"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e6a068cf-3da3-4247-8f44-d87577f9e25f"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e86133ce-5d0d-4c0b-ac14-e3fb8a83a560"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("f60ffbdf-c2ab-40f5-84c8-547afeadb0a7"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("fd4611fd-5447-4f8f-ac46-a0d338beac06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08c0b13f-9deb-4141-9116-f63de491e7b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fab8f48-652f-4f1a-873d-0cd764f99ed4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35524fee-e0d7-4948-8802-debca2ef6573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4ad654f-e775-4a7f-b1ee-3e0b3b16fb70"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("062584c5-087b-4865-8de0-4ea693f7d8f7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0c7cc95c-3d0c-49ef-a68b-27f4e79902ce"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0ea4f505-6219-4d9f-a382-406aa6bf85d9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("18cf6922-ab01-4a89-ad3c-43ff607efdad"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("19869e28-996d-4b72-969b-918f56cf1146"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1d98fbc5-822e-49cd-8ae1-9d484d3b457f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("21017d05-7eac-4b53-8eae-1d7486268096"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22ad8594-c8b9-4cef-82be-7e0dc31cecc5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("230435a5-bad4-4293-8a1a-e2e02c8887c4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2cf989a4-2215-449f-8413-9dfe51e7d8e1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3011e30b-58e6-4a40-ba37-d323bee3c15a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("32d483de-d021-4109-8801-b1c15604bd3f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("41a03bcc-62af-4680-b21d-5963b46f0fb2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("4bc6c8c6-a3ce-43dd-ba88-b33af5163de8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("59df537b-67d1-477e-b3cd-f930580c4f2d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5e5fd0b5-ac51-44bd-bc7f-2596377e8c8c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("61ab281a-a8c1-46ff-a97b-3ee6e9c0037a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6572d001-8b92-4a3a-839b-693c616c77e1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("6a6b448e-bdaf-43e1-95c8-288a475f7eba"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("701f5ccd-6b85-4dd7-95d2-e16073fb3cad"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("71f7ca6c-4885-4668-9974-8ff69c7c5d57"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("73bfb99b-f6f8-4a16-b74c-337452a817d4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("741f8960-82ca-40bc-929c-298e0e066769"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7478a60d-9788-4c89-b352-465f8db4aba4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("81aa2044-77e1-4fde-bb8d-bfb2f2b9be2f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8253fded-71ba-4f7e-a15e-733c749104c8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("82de3c4e-4549-44be-ab92-eec2d8cf3b20"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("831a9b71-b9d6-46fc-a93b-d07e49a46248"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8ed39399-13b0-4c10-bd50-2737dbcad558"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8f711aea-b3d8-4e67-a409-03ea0f52eabf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("909ffaf0-dd6d-40dc-ade3-80974d72ae15"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("93260ce5-4d81-4c24-9925-1f4c987d7e08"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9ae758ce-edbb-4097-934d-1e86f1c7a977"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9f30d90b-6898-44ac-9abe-433c099c8c04"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("adbfda62-39e3-4638-a028-cfc66cbee386"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b085cffc-fbb0-4ae6-a65d-049e625a6222"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b7a90e57-3942-4991-9662-dd6e96259456"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c1ec9604-418f-4225-9bd5-4d8563f098bf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3ae051f-939d-4a99-9d39-2482c97bf2bc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c40e9303-c69e-47bf-8094-f31ea1604c9c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c4dbb25c-5964-4176-a4fb-01bbde8f6914"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cb2a8001-e04e-4398-b121-0bfa1528fd5c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cb4697ef-8b96-4f1d-b2ca-f22aba621fd9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cb546816-100a-44a3-91a3-f6f486df46ea"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d308371a-6432-4fcd-b0c4-016b5da9d398"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("da9848ff-7b00-40e9-a720-da28592dc61e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("db252781-65e2-4665-83d1-7c3d27008ff4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e99e4cbd-ecab-4d6b-9ab7-b810bba43bba"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ef2d48ff-18d0-4b2f-96a2-aec53741da69"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f0328834-1cfe-4b01-99cb-4136096baa52"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f11b6123-a094-469a-b599-642f229ead5e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f769b6be-cc52-4c2a-a16c-d2271a6f6e4a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f902ad5e-3f0f-4642-ad52-4bbd51a121f6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fc6381d6-93e7-4c69-a027-44f83fbeac7f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fd03d018-c7cb-4fea-bf4a-28aef430c64a"));

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "TransferKeyRequests");

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
    }
}
