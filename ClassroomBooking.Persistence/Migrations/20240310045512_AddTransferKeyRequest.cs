using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTransferKeyRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "TransferKeyRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KeyId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferKeyRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferKeyRequests_Keys_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Keys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferKeyRequests_Users_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TransferKeyRequests_KeyId",
                table: "TransferKeyRequests",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferKeyRequests_RecipientId",
                table: "TransferKeyRequests",
                column: "RecipientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransferKeyRequests");

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
    }
}
