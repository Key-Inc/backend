using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Building", "CreateTime", "Number" },
                values: new object[,]
                {
                    { new Guid("05c1bee7-4fac-4a6f-a042-8a767982d058"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1935), 202 },
                    { new Guid("065cbca0-f08f-4543-aae5-607f636182b9"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1954), 200 },
                    { new Guid("088ba334-1a19-4b0e-9d62-a1e9b6ad76c3"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1907), 207 },
                    { new Guid("0be39bb8-121e-43a9-8c59-a23724a24b2d"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1906), 206 },
                    { new Guid("138af5d2-c683-4dc4-9fb6-88f1a0924dd1"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1887), 202 },
                    { new Guid("167cab42-3679-4d13-ae21-405f1925d532"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1959), 205 },
                    { new Guid("181b3968-847a-4726-9a79-e43df3e4a5ee"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1901), 201 },
                    { new Guid("1a258085-4c30-4b26-ada8-848e90289b43"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1953), 209 },
                    { new Guid("1afd860f-2784-4886-a9a9-8850fe87b5d8"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1894), 207 },
                    { new Guid("1d003ffc-4fc8-4e60-9d0b-2605078e642f"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1908), 209 },
                    { new Guid("1e25d569-b84c-4075-a891-2ae31163baa4"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1938), 204 },
                    { new Guid("2742ff3f-9819-4aab-80f8-81fd80be378d"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1948), 204 },
                    { new Guid("2d6ec56e-a8d3-4286-9855-f8c87dc45622"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1898), 209 },
                    { new Guid("2fa9c53f-04a4-499f-b210-42f9c6711cbe"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1961), 209 },
                    { new Guid("3261bbc0-7756-4746-95ef-974c54dbb61d"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1910), 200 },
                    { new Guid("36af8deb-3590-4343-aa6f-b8a2251c1fc6"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1940), 207 },
                    { new Guid("3b582545-2147-46d9-809d-ed583625fd59"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1945), 200 },
                    { new Guid("3c6c7356-7825-4cde-b6ab-3a1c3beef0ca"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1949), 206 },
                    { new Guid("3eadd648-b989-4f3f-ba4e-17a28e86d49e"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1909), 210 },
                    { new Guid("53af5c8b-af58-45c5-974f-3738584fae33"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1942), 209 },
                    { new Guid("54ff8f75-90f4-4b1c-b637-5feb6f63ef55"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1950), 207 },
                    { new Guid("55a78784-71d2-4a2d-8243-6ae10df4615c"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1831), 200 },
                    { new Guid("5a801a73-2e5a-4cbe-aef2-f6345a2ff3f5"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1952), 208 },
                    { new Guid("5ef33d95-0369-4486-a2e3-e5d8a2ffd4c1"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1904), 205 },
                    { new Guid("660b116e-0013-418d-95a4-6246013ab152"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1955), 201 },
                    { new Guid("75f3e100-3896-4c4c-a051-b773509cf361"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1938), 203 },
                    { new Guid("93851ae0-5bca-404e-b182-05415884f2d2"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1961), 208 },
                    { new Guid("944fabde-c6cc-4e6a-a6b3-2e95500382a8"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1902), 203 },
                    { new Guid("994ab436-913b-452c-80af-aea6c67ac856"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1962), 210 },
                    { new Guid("9a1b145b-743f-4c52-8a89-e2234281d6cf"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1957), 204 },
                    { new Guid("9a87a711-e3e4-4488-b150-1f67e9f986cc"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1939), 205 },
                    { new Guid("9debcc54-d21e-4519-a294-8f57bd81c74e"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1903), 204 },
                    { new Guid("a2a93df4-a3b3-437e-90ba-119f88d17e4c"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1894), 206 },
                    { new Guid("ae46d053-891a-4702-89ce-d1dc3198f237"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1908), 208 },
                    { new Guid("b0a2a866-578e-44d2-ab1a-906054f72bda"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1934), 201 },
                    { new Guid("b0fb1477-a138-425f-898a-baab5b21b280"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1956), 203 },
                    { new Guid("b49de164-97db-4070-9d24-09030ceb289f"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1953), 210 },
                    { new Guid("ba25c17a-a8b1-4736-846a-824f985c1a35"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1889), 204 },
                    { new Guid("bcb12c6d-be8d-45ca-a249-6812aef94723"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1900), 200 },
                    { new Guid("bfbc1a7f-aef6-45ec-b004-a2e8364e3c25"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1940), 206 },
                    { new Guid("ceed09bc-cdcc-414f-bbcd-be895304fd92"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1942), 210 },
                    { new Guid("d4cd8dd1-4d7a-472d-bbb2-398bf7f36362"), 3, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1941), 208 },
                    { new Guid("d5fa9c9f-ba88-498c-bec8-09f6b5bc9ac7"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1949), 205 },
                    { new Guid("d6b35c7b-bf17-4461-8b8f-ce30da17486a"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1960), 207 },
                    { new Guid("d9d29ec0-0aac-4296-8a27-cc0ffd1697d7"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1888), 203 },
                    { new Guid("defcedd4-c2b9-4645-b010-0d05103f2fbf"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1955), 202 },
                    { new Guid("dfd96413-46c5-43b9-ba5d-2aac8299939c"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1895), 208 },
                    { new Guid("e79481c1-c77c-4ba1-8ee6-061e92571007"), 2, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1901), 202 },
                    { new Guid("eaa2d8e8-a7f3-4c23-a590-dc35abccfdf7"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1947), 202 },
                    { new Guid("ecf87bd4-b6b5-4704-a67e-ac20b4326a50"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1886), 201 },
                    { new Guid("f63f902d-7776-433b-a4a7-ea465258cbad"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1899), 210 },
                    { new Guid("f7d98ae6-69e3-4032-afe4-c35811374636"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1947), 203 },
                    { new Guid("f7f83c23-96e9-440a-8eec-2ba048c2143b"), 1, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1893), 205 },
                    { new Guid("f8d3dbda-c478-46ec-b072-d626e9c870bf"), 5, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1959), 206 },
                    { new Guid("fa5eb8a0-1c77-4e27-8a90-3c38c7727490"), 4, new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(1946), 201 }
                });

            migrationBuilder.InsertData(
                table: "Keys",
                columns: new[] { "Id", "ClassroomId", "CreateTime", "KeyStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("03f60102-6032-4081-8d1d-117ac5796a9e"), new Guid("55a78784-71d2-4a2d-8243-6ae10df4615c"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2070), 0, null },
                    { new Guid("1208e08f-2bf6-4483-8593-62ff9ff8ff0b"), new Guid("9a87a711-e3e4-4488-b150-1f67e9f986cc"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2102), 0, null },
                    { new Guid("16337324-2f41-4405-948f-1a18f420fc23"), new Guid("d9d29ec0-0aac-4296-8a27-cc0ffd1697d7"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2078), 0, null },
                    { new Guid("192f5786-c7b8-4026-b57d-0c02586f8d54"), new Guid("088ba334-1a19-4b0e-9d62-a1e9b6ad76c3"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2094), 0, null },
                    { new Guid("19d1b184-47a2-4c5b-b203-7fe9341654fd"), new Guid("3261bbc0-7756-4746-95ef-974c54dbb61d"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2097), 0, null },
                    { new Guid("1d65b515-c7df-49c0-9f3b-f9e02c320598"), new Guid("5a801a73-2e5a-4cbe-aef2-f6345a2ff3f5"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2138), 0, null },
                    { new Guid("1e28eece-8252-41d9-9313-38d7a8dd8218"), new Guid("2d6ec56e-a8d3-4286-9855-f8c87dc45622"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2084), 0, null },
                    { new Guid("1e782d22-4081-42f1-9fbd-56a810994838"), new Guid("d6b35c7b-bf17-4461-8b8f-ce30da17486a"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2148), 0, null },
                    { new Guid("248e90ef-fd3d-40f8-95f8-3a375c0214c2"), new Guid("138af5d2-c683-4dc4-9fb6-88f1a0924dd1"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2077), 0, null },
                    { new Guid("296f4861-80dd-4240-8bc0-c5fbc3060c6d"), new Guid("f63f902d-7776-433b-a4a7-ea465258cbad"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2086), 0, null },
                    { new Guid("39842d86-b19f-41d0-a417-8a65791348ef"), new Guid("93851ae0-5bca-404e-b182-05415884f2d2"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2149), 0, null },
                    { new Guid("3d63615d-7423-4a03-8ab9-1585d04f4f7e"), new Guid("3eadd648-b989-4f3f-ba4e-17a28e86d49e"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2096), 0, null },
                    { new Guid("4244aabc-323b-41d3-bb80-1af3cb03eaf4"), new Guid("994ab436-913b-452c-80af-aea6c67ac856"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2151), 0, null },
                    { new Guid("45b3aaa8-513e-4620-add1-dbe22332d43d"), new Guid("fa5eb8a0-1c77-4e27-8a90-3c38c7727490"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2109), 0, null },
                    { new Guid("48a25300-5ca2-4ce1-a18e-6521cc328b0b"), new Guid("9debcc54-d21e-4519-a294-8f57bd81c74e"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2090), 0, null },
                    { new Guid("4cfcf4b2-8d4b-4627-9408-d9f75bfb0eb5"), new Guid("53af5c8b-af58-45c5-974f-3738584fae33"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2105), 0, null },
                    { new Guid("50be5cd5-d6c0-4ab9-bc32-189dd8015d2b"), new Guid("1d003ffc-4fc8-4e60-9d0b-2605078e642f"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2096), 0, null },
                    { new Guid("523b897e-48d6-46a7-9c2f-f5e18e20a7ae"), new Guid("b49de164-97db-4070-9d24-09030ceb289f"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2141), 0, null },
                    { new Guid("5260d0e0-6f30-4dbd-b3bc-57d586c726a1"), new Guid("3b582545-2147-46d9-809d-ed583625fd59"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2107), 0, null },
                    { new Guid("554e9091-9bd0-4f94-af26-2f240695c01c"), new Guid("167cab42-3679-4d13-ae21-405f1925d532"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2146), 0, null },
                    { new Guid("58b75ecb-03f9-4088-9540-2731f4a0cdf1"), new Guid("f7f83c23-96e9-440a-8eec-2ba048c2143b"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2080), 0, null },
                    { new Guid("5c2f27fd-bdc6-47b9-8353-2ec74880173b"), new Guid("f7d98ae6-69e3-4032-afe4-c35811374636"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2134), 0, null },
                    { new Guid("5fcc9e54-f319-40f4-936c-35660042c4fd"), new Guid("1a258085-4c30-4b26-ada8-848e90289b43"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2141), 0, null },
                    { new Guid("607600f9-c343-4fe1-b48c-ad65b60430b2"), new Guid("0be39bb8-121e-43a9-8c59-a23724a24b2d"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2092), 0, null },
                    { new Guid("61a09a14-d9d3-4cbb-abe7-c40b22048eaf"), new Guid("5ef33d95-0369-4486-a2e3-e5d8a2ffd4c1"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2091), 0, null },
                    { new Guid("663e2d17-9dd0-454e-b62c-d52673e6db13"), new Guid("f8d3dbda-c478-46ec-b072-d626e9c870bf"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2148), 0, null },
                    { new Guid("6b5d8f00-d74c-4ec1-b8df-f6bff6cd3d5a"), new Guid("2742ff3f-9819-4aab-80f8-81fd80be378d"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2135), 0, null },
                    { new Guid("6c0b255f-66b8-4123-bfc5-7d2462af4f72"), new Guid("ae46d053-891a-4702-89ce-d1dc3198f237"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2095), 0, null },
                    { new Guid("6c175ea5-fb1b-4bb2-86e0-d1aa0561514b"), new Guid("1e25d569-b84c-4075-a891-2ae31163baa4"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2101), 0, null },
                    { new Guid("7155283e-78f4-45cb-90fd-9c11e4a9bb5d"), new Guid("d4cd8dd1-4d7a-472d-bbb2-398bf7f36362"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2104), 0, null },
                    { new Guid("73dcdf18-8bfd-4715-bba5-00cb84cf5a78"), new Guid("ba25c17a-a8b1-4736-846a-824f985c1a35"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2079), 0, null },
                    { new Guid("7ce30be7-a10c-4804-9573-88c5bfed8db9"), new Guid("b0a2a866-578e-44d2-ab1a-906054f72bda"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2098), 0, null },
                    { new Guid("7e049b20-85d6-41a6-b8ef-e7933c694bd0"), new Guid("36af8deb-3590-4343-aa6f-b8a2251c1fc6"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2104), 0, null },
                    { new Guid("837bf5a2-80de-4ab1-bf21-1067d2260a20"), new Guid("defcedd4-c2b9-4645-b010-0d05103f2fbf"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2143), 0, null },
                    { new Guid("875dfa77-f955-4348-8b62-6a0f23a1114e"), new Guid("bcb12c6d-be8d-45ca-a249-6812aef94723"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2087), 0, null },
                    { new Guid("8d4da44b-8b5c-491e-a33a-64ef8ee88390"), new Guid("ceed09bc-cdcc-414f-bbcd-be895304fd92"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2106), 0, null },
                    { new Guid("8d634747-a89c-4b6e-8958-e962c04d5b12"), new Guid("b0fb1477-a138-425f-898a-baab5b21b280"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2144), 0, null },
                    { new Guid("8e889dd2-d73e-4c78-809c-9f7ae830eff7"), new Guid("1afd860f-2784-4886-a9a9-8850fe87b5d8"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2082), 0, null },
                    { new Guid("90eb3f6f-b8a3-4eb4-a719-e53f6d16bf09"), new Guid("3c6c7356-7825-4cde-b6ab-3a1c3beef0ca"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2137), 0, null },
                    { new Guid("9d7388a4-0315-4fd0-8b30-3afc367c8dd4"), new Guid("05c1bee7-4fac-4a6f-a042-8a767982d058"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2099), 0, null },
                    { new Guid("a86671b7-4aaf-438b-bf7b-269a93511786"), new Guid("ecf87bd4-b6b5-4704-a67e-ac20b4326a50"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2074), 0, null },
                    { new Guid("b0d081ff-ca2b-48b2-9564-97c85ca9946b"), new Guid("2fa9c53f-04a4-499f-b210-42f9c6711cbe"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2150), 0, null },
                    { new Guid("b4f5715d-fdf4-4722-b255-62dad50f5e63"), new Guid("660b116e-0013-418d-95a4-6246013ab152"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2143), 0, null },
                    { new Guid("b51366de-40ad-4d00-bab6-5798ad5a6197"), new Guid("181b3968-847a-4726-9a79-e43df3e4a5ee"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2088), 0, null },
                    { new Guid("b70bdc5e-d25f-4f54-9ffa-b0f8ec0207b6"), new Guid("944fabde-c6cc-4e6a-a6b3-2e95500382a8"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2089), 0, null },
                    { new Guid("bb1f398f-9d6c-41d1-aba5-59777c343761"), new Guid("065cbca0-f08f-4543-aae5-607f636182b9"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2142), 0, null },
                    { new Guid("bc009c9d-e2bb-4d23-aa88-c3971789068d"), new Guid("75f3e100-3896-4c4c-a051-b773509cf361"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2099), 0, null },
                    { new Guid("bcbe00e4-3618-49a7-b4e1-c473f825a24b"), new Guid("bfbc1a7f-aef6-45ec-b004-a2e8364e3c25"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2103), 0, null },
                    { new Guid("bd6b311b-975a-4004-84db-8869e8c0e282"), new Guid("9a1b145b-743f-4c52-8a89-e2234281d6cf"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2145), 0, null },
                    { new Guid("ce143ea7-abe9-418f-a4bb-f6d17f52dec1"), new Guid("a2a93df4-a3b3-437e-90ba-119f88d17e4c"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2081), 0, null },
                    { new Guid("d309d61e-4e60-4093-97f9-4cf7a279ccec"), new Guid("e79481c1-c77c-4ba1-8ee6-061e92571007"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2088), 0, null },
                    { new Guid("d35a00a1-9ad5-4aba-a734-7d9b50b716ee"), new Guid("dfd96413-46c5-43b9-ba5d-2aac8299939c"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2083), 0, null },
                    { new Guid("d4d1972e-388f-4051-9bfe-9e806ec8fe09"), new Guid("d5fa9c9f-ba88-498c-bec8-09f6b5bc9ac7"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2136), 0, null },
                    { new Guid("e6ff2cd0-7c6c-49fa-a13a-6aeb3423ebd1"), new Guid("54ff8f75-90f4-4b1c-b637-5feb6f63ef55"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2138), 0, null },
                    { new Guid("fc37d11a-bf77-4cd8-881a-344e60f9f1cd"), new Guid("eaa2d8e8-a7f3-4c23-a590-dc35abccfdf7"), new DateTime(2024, 2, 18, 4, 19, 27, 165, DateTimeKind.Utc).AddTicks(2110), 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("03f60102-6032-4081-8d1d-117ac5796a9e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1208e08f-2bf6-4483-8593-62ff9ff8ff0b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("16337324-2f41-4405-948f-1a18f420fc23"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("192f5786-c7b8-4026-b57d-0c02586f8d54"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("19d1b184-47a2-4c5b-b203-7fe9341654fd"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1d65b515-c7df-49c0-9f3b-f9e02c320598"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1e28eece-8252-41d9-9313-38d7a8dd8218"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("1e782d22-4081-42f1-9fbd-56a810994838"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("248e90ef-fd3d-40f8-95f8-3a375c0214c2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("296f4861-80dd-4240-8bc0-c5fbc3060c6d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("39842d86-b19f-41d0-a417-8a65791348ef"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("3d63615d-7423-4a03-8ab9-1585d04f4f7e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4244aabc-323b-41d3-bb80-1af3cb03eaf4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("45b3aaa8-513e-4620-add1-dbe22332d43d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("48a25300-5ca2-4ce1-a18e-6521cc328b0b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("4cfcf4b2-8d4b-4627-9408-d9f75bfb0eb5"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("50be5cd5-d6c0-4ab9-bc32-189dd8015d2b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("523b897e-48d6-46a7-9c2f-f5e18e20a7ae"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5260d0e0-6f30-4dbd-b3bc-57d586c726a1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("554e9091-9bd0-4f94-af26-2f240695c01c"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("58b75ecb-03f9-4088-9540-2731f4a0cdf1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5c2f27fd-bdc6-47b9-8353-2ec74880173b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("5fcc9e54-f319-40f4-936c-35660042c4fd"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("607600f9-c343-4fe1-b48c-ad65b60430b2"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("61a09a14-d9d3-4cbb-abe7-c40b22048eaf"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("663e2d17-9dd0-454e-b62c-d52673e6db13"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6b5d8f00-d74c-4ec1-b8df-f6bff6cd3d5a"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6c0b255f-66b8-4123-bfc5-7d2462af4f72"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("6c175ea5-fb1b-4bb2-86e0-d1aa0561514b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7155283e-78f4-45cb-90fd-9c11e4a9bb5d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("73dcdf18-8bfd-4715-bba5-00cb84cf5a78"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7ce30be7-a10c-4804-9573-88c5bfed8db9"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("7e049b20-85d6-41a6-b8ef-e7933c694bd0"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("837bf5a2-80de-4ab1-bf21-1067d2260a20"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("875dfa77-f955-4348-8b62-6a0f23a1114e"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8d4da44b-8b5c-491e-a33a-64ef8ee88390"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8d634747-a89c-4b6e-8958-e962c04d5b12"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("8e889dd2-d73e-4c78-809c-9f7ae830eff7"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("90eb3f6f-b8a3-4eb4-a719-e53f6d16bf09"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("9d7388a4-0315-4fd0-8b30-3afc367c8dd4"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("a86671b7-4aaf-438b-bf7b-269a93511786"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b0d081ff-ca2b-48b2-9564-97c85ca9946b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b4f5715d-fdf4-4722-b255-62dad50f5e63"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b51366de-40ad-4d00-bab6-5798ad5a6197"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("b70bdc5e-d25f-4f54-9ffa-b0f8ec0207b6"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bb1f398f-9d6c-41d1-aba5-59777c343761"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bc009c9d-e2bb-4d23-aa88-c3971789068d"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bcbe00e4-3618-49a7-b4e1-c473f825a24b"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("bd6b311b-975a-4004-84db-8869e8c0e282"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("ce143ea7-abe9-418f-a4bb-f6d17f52dec1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d309d61e-4e60-4093-97f9-4cf7a279ccec"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d35a00a1-9ad5-4aba-a734-7d9b50b716ee"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("d4d1972e-388f-4051-9bfe-9e806ec8fe09"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("e6ff2cd0-7c6c-49fa-a13a-6aeb3423ebd1"));

            migrationBuilder.DeleteData(
                table: "Keys",
                keyColumn: "Id",
                keyValue: new Guid("fc37d11a-bf77-4cd8-881a-344e60f9f1cd"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05c1bee7-4fac-4a6f-a042-8a767982d058"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("065cbca0-f08f-4543-aae5-607f636182b9"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("088ba334-1a19-4b0e-9d62-a1e9b6ad76c3"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0be39bb8-121e-43a9-8c59-a23724a24b2d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("138af5d2-c683-4dc4-9fb6-88f1a0924dd1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("167cab42-3679-4d13-ae21-405f1925d532"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("181b3968-847a-4726-9a79-e43df3e4a5ee"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1a258085-4c30-4b26-ada8-848e90289b43"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1afd860f-2784-4886-a9a9-8850fe87b5d8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1d003ffc-4fc8-4e60-9d0b-2605078e642f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1e25d569-b84c-4075-a891-2ae31163baa4"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2742ff3f-9819-4aab-80f8-81fd80be378d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2d6ec56e-a8d3-4286-9855-f8c87dc45622"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("2fa9c53f-04a4-499f-b210-42f9c6711cbe"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3261bbc0-7756-4746-95ef-974c54dbb61d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("36af8deb-3590-4343-aa6f-b8a2251c1fc6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3b582545-2147-46d9-809d-ed583625fd59"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3c6c7356-7825-4cde-b6ab-3a1c3beef0ca"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3eadd648-b989-4f3f-ba4e-17a28e86d49e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("53af5c8b-af58-45c5-974f-3738584fae33"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("54ff8f75-90f4-4b1c-b637-5feb6f63ef55"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("55a78784-71d2-4a2d-8243-6ae10df4615c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5a801a73-2e5a-4cbe-aef2-f6345a2ff3f5"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5ef33d95-0369-4486-a2e3-e5d8a2ffd4c1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("660b116e-0013-418d-95a4-6246013ab152"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("75f3e100-3896-4c4c-a051-b773509cf361"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("93851ae0-5bca-404e-b182-05415884f2d2"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("944fabde-c6cc-4e6a-a6b3-2e95500382a8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("994ab436-913b-452c-80af-aea6c67ac856"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9a1b145b-743f-4c52-8a89-e2234281d6cf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9a87a711-e3e4-4488-b150-1f67e9f986cc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9debcc54-d21e-4519-a294-8f57bd81c74e"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a2a93df4-a3b3-437e-90ba-119f88d17e4c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ae46d053-891a-4702-89ce-d1dc3198f237"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b0a2a866-578e-44d2-ab1a-906054f72bda"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b0fb1477-a138-425f-898a-baab5b21b280"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b49de164-97db-4070-9d24-09030ceb289f"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ba25c17a-a8b1-4736-846a-824f985c1a35"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bcb12c6d-be8d-45ca-a249-6812aef94723"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bfbc1a7f-aef6-45ec-b004-a2e8364e3c25"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ceed09bc-cdcc-414f-bbcd-be895304fd92"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d4cd8dd1-4d7a-472d-bbb2-398bf7f36362"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d5fa9c9f-ba88-498c-bec8-09f6b5bc9ac7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d6b35c7b-bf17-4461-8b8f-ce30da17486a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d9d29ec0-0aac-4296-8a27-cc0ffd1697d7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("defcedd4-c2b9-4645-b010-0d05103f2fbf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("dfd96413-46c5-43b9-ba5d-2aac8299939c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e79481c1-c77c-4ba1-8ee6-061e92571007"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("eaa2d8e8-a7f3-4c23-a590-dc35abccfdf7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ecf87bd4-b6b5-4704-a67e-ac20b4326a50"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f63f902d-7776-433b-a4a7-ea465258cbad"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f7d98ae6-69e3-4032-afe4-c35811374636"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f7f83c23-96e9-440a-8eec-2ba048c2143b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f8d3dbda-c478-46ec-b072-d626e9c870bf"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fa5eb8a0-1c77-4e27-8a90-3c38c7727490"));
        }
    }
}
