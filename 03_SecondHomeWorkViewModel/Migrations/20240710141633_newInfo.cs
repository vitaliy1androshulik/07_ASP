using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_SecondHomeWorkViewModel.Migrations
{
    /// <inheritdoc />
    public partial class newInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/5d18acbf1848174117e1b0223235a361/e_220_d_4matic.png");

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/acfe7552173b3f6c863cee630a2345a0/e_220_d.png");

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/aae4042503cc00d78b7772f9c12f7271/a180.png");

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUrl",
                value: "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/3172c0ee5ae878080765fbc455e54e6e/a35.png");

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUrl",
                value: "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/6cc5b5823b68a44ccafcb0d49ebdb4d7/c_200.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mercedes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUrl",
                value: null);
        }
    }
}
