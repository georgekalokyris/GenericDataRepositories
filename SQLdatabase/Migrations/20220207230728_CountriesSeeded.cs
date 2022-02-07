using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLdatabase.Migrations
{
    public partial class CountriesSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 1, "Europe", "Sweden" },
                    { 159, "Africa", "Mali" },
                    { 160, "Asia", "Oman" },
                    { 161, "Europe", "Malta" },
                    { 162, "Asia", "Maldives" },
                    { 163, "Europe", "Austria" },
                    { 164, "Africa", "Western Sahara" },
                    { 165, "Asia", "North Korea" },
                    { 166, "North America", "British Virgin Islands" },
                    { 167, "Africa", "Burkina Faso" },
                    { 168, "Oceania", "Micronesia" },
                    { 169, "Europe", "Lithuania" },
                    { 170, "South America", "Colombia" },
                    { 171, "Africa", "Rwanda" },
                    { 172, "Africa", "Madagascar" },
                    { 173, "Europe", "France" },
                    { 174, "Europe", "Moldova" },
                    { 175, "Asia", "Nepal" },
                    { 176, "Asia", "Afghanistan" },
                    { 177, "Asia", "Saudi Arabia" },
                    { 178, "South America", "Ecuador" },
                    { 179, "Europe", "Vatican City" },
                    { 180, "Africa", "Zambia" },
                    { 181, "Europe", "Germany" },
                    { 182, "Asia", "Turkey" },
                    { 183, "Asia", "Yemen" },
                    { 184, "Africa", "Comoros" },
                    { 185, "North America", "Curaçao" },
                    { 158, "South America", "Argentina" },
                    { 186, "Europe", "Italy" },
                    { 157, "Europe", "Serbia" },
                    { 155, "North America", "Mexico" },
                    { 128, "Europe", "Åland Islands" },
                    { 129, "North America", "Honduras" },
                    { 130, "North America", "Haiti" },
                    { 131, "North America", "Caribbean Netherlands" },
                    { 132, "Oceania", "Nauru" },
                    { 133, "North America", "Trinidad and Tobago" },
                    { 134, "North America", "Saint Barthélemy" },
                    { 135, "Africa", "DR Congo" },
                    { 136, "Europe", "Denmark" },
                    { 137, "South America", "Venezuela" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 138, "Europe", "Ireland" },
                    { 139, "North America", "Dominica" },
                    { 140, "Africa", "Benin" },
                    { 141, "Asia", "British Indian Ocean Territory" },
                    { 142, "Africa", "Mauritania" },
                    { 143, "Africa", "South Africa" },
                    { 144, "North America", "Saint Pierre and Miquelon" },
                    { 145, "Europe", "San Marino" },
                    { 146, "Africa", "Egypt" },
                    { 147, "Asia", "Tajikistan" },
                    { 148, "Oceania", "Marshall Islands" },
                    { 149, "Asia", "Japan" },
                    { 150, "Oceania", "Pitcairn Islands" },
                    { 151, "Africa", "Senegal" },
                    { 152, "Asia", "Palestine" },
                    { 153, "Africa", "Gabon" },
                    { 154, "North America", "Anguilla" },
                    { 156, "Oceania", "Papua New Guinea" },
                    { 187, "Europe", "Bulgaria" },
                    { 188, "South America", "Brazil" },
                    { 189, "North America", "Turks and Caicos Islands" },
                    { 222, "North America", "Cayman Islands" },
                    { 223, "Asia", "Turkmenistan" },
                    { 224, "Antarctica", "Antarctica" },
                    { 225, "North America", "Grenada" },
                    { 226, "North America", "El Salvador" },
                    { 227, "North America", "Saint Lucia" },
                    { 228, "Asia", "Syria" },
                    { 229, "Asia", "Kazakhstan" },
                    { 230, "Europe", "Belarus" },
                    { 231, "Asia", "Sri Lanka" },
                    { 232, "North America", "Saint Martin" },
                    { 233, "Africa", "Liberia" },
                    { 234, "Europe", "Iceland" },
                    { 235, "Oceania", "New Caledonia" },
                    { 236, "North America", "Bahamas" },
                    { 237, "Oceania", "United States Minor Outlying Islands" },
                    { 238, "Oceania", "Niue" },
                    { 239, "Oceania", "Samoa" },
                    { 240, "Asia", "Vietnam" },
                    { 241, "Africa", "Cameroon" },
                    { 242, "Oceania", "Fiji" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 243, "North America", "Sint Maarten" },
                    { 244, "North America", "Nicaragua" },
                    { 245, "Asia", "Taiwan" },
                    { 246, "Asia", "Iran" },
                    { 247, "South America", "Suriname" },
                    { 248, "Africa", "Togo" },
                    { 221, "Europe", "Russia" },
                    { 220, "Oceania", "Cook Islands" },
                    { 219, "Africa", "Angola" },
                    { 218, "Europe", "Slovenia" },
                    { 190, "Africa", "Lesotho" },
                    { 191, "Europe", "Hungary" },
                    { 192, "North America", "Guatemala" },
                    { 193, "South America", "Chile" },
                    { 194, "Europe", "Cyprus" },
                    { 195, "Antarctica", "Heard Island and McDonald Islands" },
                    { 196, "North America", "Saint Kitts and Nevis" },
                    { 197, "Africa", "Sierra Leone" },
                    { 198, "Asia", "Brunei" },
                    { 199, "Africa", "Seychelles" },
                    { 200, "Africa", "Saint Helena, Ascension and Tristan da Cunha" },
                    { 201, "Asia", "Israel" },
                    { 202, "South America", "Peru" },
                    { 127, "Asia", "Pakistan" },
                    { 203, "Europe", "Romania" },
                    { 205, "Antarctica", "French Southern and Antarctic Lands" },
                    { 206, "Asia", "China" },
                    { 207, "Asia", "Mongolia" },
                    { 208, "Africa", "Libya" },
                    { 209, "Asia", "Hong Kong" },
                    { 210, "Africa", "Algeria" },
                    { 211, "South America", "Guyana" },
                    { 212, "Asia", "Philippines" },
                    { 213, "Europe", "Poland" },
                    { 214, "North America", "Guadeloupe" },
                    { 215, "Asia", "Armenia" },
                    { 216, "Asia", "Jordan" },
                    { 217, "Africa", "Niger" },
                    { 204, "Europe", "Svalbard and Jan Mayen" },
                    { 126, "Europe", "Isle of Man" },
                    { 125, "Europe", "Gibraltar" },
                    { 124, "Africa", "Ethiopia" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 34, "North America", "Panama" },
                    { 35, "Asia", "Myanmar" },
                    { 36, "North America", "Barbados" },
                    { 37, "Asia", "Cambodia" },
                    { 38, "North America", "Antigua and Barbuda" },
                    { 39, "Africa", "Kenya" },
                    { 40, "Asia", "India" },
                    { 41, "Africa", "São Tomé and Príncipe" },
                    { 42, "Europe", "Faroe Islands" },
                    { 43, "Europe", "Czechia" },
                    { 44, "North America", "Montserrat" },
                    { 45, "Antarctica", "South Georgia" },
                    { 46, "Europe", "Ukraine" },
                    { 47, "Africa", "Djibouti" },
                    { 48, "North America", "Greenland" },
                    { 49, "Oceania", "Tonga" },
                    { 50, "North America", "United States" },
                    { 51, "Oceania", "Norfolk Island" },
                    { 52, "Africa", "Republic of the Congo" },
                    { 53, "Asia", "Lebanon" },
                    { 54, "Asia", "Uzbekistan" },
                    { 55, "Oceania", "Guam" },
                    { 56, "Europe", "Estonia" },
                    { 57, "Oceania", "Tuvalu" },
                    { 58, "North America", "Bermuda" },
                    { 59, "Africa", "South Sudan" },
                    { 60, "North America", "Costa Rica" },
                    { 33, "Europe", "Bosnia and Herzegovina" },
                    { 32, "Europe", "Slovakia" },
                    { 31, "Antarctica", "Bouvet Island" },
                    { 30, "North America", "Dominican Republic" },
                    { 2, "Europe", "Albania" },
                    { 3, "Oceania", "Vanuatu" },
                    { 4, "Africa", "Mauritius" },
                    { 5, "Europe", "United Kingdom" },
                    { 6, "Europe", "Portugal" },
                    { 7, "Africa", "Ivory Coast" },
                    { 8, "Asia", "Georgia" },
                    { 9, "Asia", "Bhutan" },
                    { 10, "Africa", "Namibia" },
                    { 11, "Europe", "Netherlands" },
                    { 12, "South America", "Uruguay" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 13, "Europe", "Belgium" },
                    { 14, "Europe", "Guernsey" },
                    { 61, "Europe", "Finland" },
                    { 15, "North America", "United States Virgin Islands" },
                    { 17, "Europe", "Liechtenstein" },
                    { 18, "Africa", "Guinea-Bissau" },
                    { 19, "Asia", "South Korea" },
                    { 20, "North America", "Cuba" },
                    { 21, "Europe", "Montenegro" },
                    { 22, "Europe", "Norway" },
                    { 23, "North America", "Saint Vincent and the Grenadines" },
                    { 24, "Africa", "Mayotte" },
                    { 25, "Europe", "Latvia" },
                    { 26, "South America", "Paraguay" },
                    { 27, "Europe", "Jersey" },
                    { 28, "Asia", "Laos" },
                    { 29, "Asia", "Qatar" },
                    { 16, "Africa", "Uganda" },
                    { 249, "Europe", "Switzerland" },
                    { 62, "Africa", "Gambia" },
                    { 64, "North America", "Belize" },
                    { 97, "Asia", "United Arab Emirates" },
                    { 98, "Oceania", "Palau" },
                    { 99, "South America", "Falkland Islands" },
                    { 100, "Africa", "Malawi" },
                    { 101, "Asia", "Bangladesh" },
                    { 102, "North America", "Canada" },
                    { 103, "North America", "Jamaica" },
                    { 104, "Europe", "Luxembourg" },
                    { 105, "Europe", "Monaco" },
                    { 106, "Africa", "Tunisia" },
                    { 107, "Africa", "Equatorial Guinea" },
                    { 108, "North America", "Martinique" },
                    { 109, "Africa", "Cape Verde" },
                    { 110, "North America", "Aruba" },
                    { 111, "Oceania", "American Samoa" },
                    { 112, "Africa", "Nigeria" },
                    { 113, "Asia", "Cocos (Keeling) Islands" },
                    { 114, "Europe", "Spain" },
                    { 115, "Asia", "Iraq" },
                    { 116, "Oceania", "Tokelau" },
                    { 117, "Africa", "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Continent", "Name" },
                values: new object[,]
                {
                    { 118, "Africa", "Guinea" },
                    { 119, "Africa", "Ghana" },
                    { 120, "Oceania", "Wallis and Futuna" },
                    { 121, "Asia", "Kyrgyzstan" },
                    { 122, "Asia", "Macau" },
                    { 123, "Asia", "Bahrain" },
                    { 96, "Africa", "Burundi" },
                    { 95, "Europe", "Croatia" },
                    { 94, "Africa", "Réunion" },
                    { 93, "Asia", "Thailand" },
                    { 65, "Oceania", "Kiribati" },
                    { 66, "South America", "French Guiana" },
                    { 67, "Europe", "Andorra" },
                    { 68, "Europe", "Kosovo" },
                    { 69, "Africa", "Mozambique" },
                    { 70, "North America", "Puerto Rico" },
                    { 71, "Oceania", "Australia" },
                    { 72, "Asia", "Azerbaijan" },
                    { 73, "Africa", "Sudan" },
                    { 74, "Africa", "Chad" },
                    { 75, "Africa", "Eritrea" },
                    { 76, "Asia", "Malaysia" },
                    { 77, "Asia", "Kuwait" },
                    { 63, "Oceania", "French Polynesia" },
                    { 78, "Oceania", "Northern Mariana Islands" },
                    { 80, "Africa", "Morocco" },
                    { 81, "Africa", "Somalia" },
                    { 82, "Asia", "Singapore" },
                    { 83, "Oceania", "Timor-Leste" },
                    { 84, "Europe", "Greece" },
                    { 85, "Africa", "Botswana" },
                    { 86, "Asia", "Indonesia" },
                    { 87, "Europe", "North Macedonia" },
                    { 88, "Africa", "Tanzania" },
                    { 89, "Africa", "Eswatini" },
                    { 90, "Africa", "Central African Republic" },
                    { 91, "South America", "Bolivia" },
                    { 92, "Oceania", "Solomon Islands" },
                    { 79, "Oceania", "New Zealand" },
                    { 250, "Asia", "Christmas Island" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AreaCode", "Name", "countryId" },
                values: new object[] { 1, "000", "Dream City", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AreaCode", "Name", "countryId" },
                values: new object[] { 2, "666", "Gotham City", null });
        }
    }
}
