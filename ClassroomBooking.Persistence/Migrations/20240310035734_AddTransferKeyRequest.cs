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
                    KeyId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferKeyRequests", x => new { x.KeyId, x.RecipientId });
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
