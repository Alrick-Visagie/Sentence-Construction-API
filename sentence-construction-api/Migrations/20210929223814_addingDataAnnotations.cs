using Microsoft.EntityFrameworkCore.Migrations;

namespace SentenceConstruction.Migrations
{
    public partial class addingDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "9");

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sentence",
                table: "Sentences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Sentences",
                columns: new[] { "ID", "Sentence" },
                values: new object[,]
                {
                    { "8a8f3ab2-9907-4771-8df6-a0227e813970", "Actor asked absentmindedly." },
                    { "5719b00e-676e-44d7-85fb-f68b329d3df5", "He said afternoon." },
                    { "da7ec728-71a0-4b9a-b8f8-d3c5dbec3852", "She asked him if he was angry." }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "Name", "Word" },
                values: new object[,]
                {
                    { "189d8d0b-8366-4aa2-8a9f-59df8143ccd9", "Nouns", "Actor,Gold,Painting,Advertisement,Grass,Parrot,Afternoon,Greece,Pencil,Airport,Guitar,Piano,Ambulance,Hair,Pillow,Animal,Hamburger,Pizza,Answer,Helicopter,Planet" },
                    { "ba14a904-62cc-4e5b-9cd7-cae1e4ccf882", "Verbs", "to ask,asked,ask,will ask,to be,was,am,will be,to become,became,become,will become,to bring,brought,bring,will bring,to build,built,build,will build,to buy,bought,buy,will buy,to call,called,call,will call,to change,changed,change,will change" },
                    { "ac398e7a-4ed9-40b6-99e0-d324d6053eee", "Adjectives", "adorable,adventurous,aggressive,agreeable,alert,alive,amused,angry,annoyed,annoying,anxious,arrogant,ashamed,attractive,average,awful,bad,beautiful,better,bewildered,black,bloody,blue,blue-eyed,blushing,bored,brainy,brave,breakable,bright,busy,calm,careful" },
                    { "15a9a9f8-d0c5-421b-881e-54010b7d595e", "Adverbs", "absentmindedly,adoringly,awkwardly,beautifully,briskly,brutally,carefully,cheerfully,competitively,eagerly,effortlessly,extravagantly,girlishly,gracefully,grimly,happily,halfheartedly,hungrily,lazily,lifelessly,loyally,quickly,quietly,quizzically,really,recklessly,remorsefully,ruthlessly,savagely,sloppily,so,stylishly,unabashedly,unevenly,urgently,well,wishfully,worriedly" },
                    { "f622b7ae-c7b3-460b-850e-f2025e06db46", "Pronouns", "I,you,he,she,it,we,they,me,him,her,us,them,who,whom,which,what,whose,whoever,whatever,whichever,whomever,this,that,these,those,myself,yourself,himself,herself,itself,ourselves,themselves" },
                    { "26b7dc7e-55dd-4215-b539-d9070e99a90c", "Prepositions", "aboard,about,above,according to,across,after,against,ahead of,along,amid,amidst,among,around,as,as far as,as of,aside from,at,athwart,atop,of,off,on,on account of,on behalf of,on top of,onto,opposite,out,out of,outside,over,with,with regard to,within,without,regarding,regardless of" },
                    { "dbaecc51-6fe9-4630-b42e-2a20a2a20dc6", "Conjunctions", "After,As,As long as,As soon as,As though,Before,Even if,If,If when,Inasmuch,Just as,Now,Now that,Once,Provided that,Since,Supposing,That,Though,Until,Whenever,Whereas,Wherever,Which,Who,Although,As if,As much as,Because,Even,Even though,If only,If then,In order that,Lest,Now since,Now when,Provided,Rather than,So that,After all,As a result,Consequently,Finally,For example,Furthermore,Hence,However,In addition,In fact,Incidentally,Indeed,Instead,Likewise,Meanwhile" },
                    { "4272a9d8-bf92-460b-a1f5-a362052e1519", "Determiners", "a,a few,a little,all,an,another,any,anybody,anyone,anything,anywhere,both,certain,each,either,enough,every,everybody,everyone,everything,everywhere,few,fewer,fewest,last,least,less,little,many,many a,more,most,much,neither,next,no,no one,nobody,none,nothing,nowhere,once,one,said,several,some,somebody,something,somewhere,sufficient,that,the,these" },
                    { "46ed68fc-5f35-49ca-a9cb-8a541990b110", "Exclamations", "Shh,Please,Psst,Shoo,Hey,Oh,Yo,Here,Ahem,Encore,There,Hush,Scat,No,Silence,Enough'Yuck,Eww,Aww,Ouch,Oh,Ah,Ugh,Phew,Phooey,Rats,Yippee,Blah,Brr,Eek,Good grief,Alas,Bingo,Bravo,Eureka,Crikey,Gee,Golly,Gosh,Hmm,Holy cow,Aha,Oh,Huh,Duh,Ahh,Well" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "5719b00e-676e-44d7-85fb-f68b329d3df5");

            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "8a8f3ab2-9907-4771-8df6-a0227e813970");

            migrationBuilder.DeleteData(
                table: "Sentences",
                keyColumn: "ID",
                keyValue: "da7ec728-71a0-4b9a-b8f8-d3c5dbec3852");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "15a9a9f8-d0c5-421b-881e-54010b7d595e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "189d8d0b-8366-4aa2-8a9f-59df8143ccd9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "26b7dc7e-55dd-4215-b539-d9070e99a90c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "4272a9d8-bf92-460b-a1f5-a362052e1519");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "46ed68fc-5f35-49ca-a9cb-8a541990b110");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "ac398e7a-4ed9-40b6-99e0-d324d6053eee");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "ba14a904-62cc-4e5b-9cd7-cae1e4ccf882");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "dbaecc51-6fe9-4630-b42e-2a20a2a20dc6");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: "f622b7ae-c7b3-460b-850e-f2025e06db46");

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sentence",
                table: "Sentences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Sentences",
                columns: new[] { "ID", "Sentence" },
                values: new object[,]
                {
                    { "1", "Actor asked absentmindedly." },
                    { "2", "He said afternoon." },
                    { "3", "She asked him if he was angry." }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "Name", "Word" },
                values: new object[,]
                {
                    { "1", "Nouns", "Actor,Gold,Painting,Advertisement,Grass,Parrot,Afternoon,Greece,Pencil,Airport,Guitar,Piano,Ambulance,Hair,Pillow,Animal,Hamburger,Pizza,Answer,Helicopter,Planet" },
                    { "2", "Verbs", "to ask,asked,ask,will ask,to be,was,am,will be,to become,became,become,will become,to bring,brought,bring,will bring,to build,built,build,will build,to buy,bought,buy,will buy,to call,called,call,will call,to change,changed,change,will change" },
                    { "3", "Adjectives", "adorable,adventurous,aggressive,agreeable,alert,alive,amused,angry,annoyed,annoying,anxious,arrogant,ashamed,attractive,average,awful,bad,beautiful,better,bewildered,black,bloody,blue,blue-eyed,blushing,bored,brainy,brave,breakable,bright,busy,calm,careful" },
                    { "4", "Adverbs", "absentmindedly,adoringly,awkwardly,beautifully,briskly,brutally,carefully,cheerfully,competitively,eagerly,effortlessly,extravagantly,girlishly,gracefully,grimly,happily,halfheartedly,hungrily,lazily,lifelessly,loyally,quickly,quietly,quizzically,really,recklessly,remorsefully,ruthlessly,savagely,sloppily,so,stylishly,unabashedly,unevenly,urgently,well,wishfully,worriedly" },
                    { "5", "Pronouns", "I,you,he,she,it,we,they,me,him,her,us,them,who,whom,which,what,whose,whoever,whatever,whichever,whomever,this,that,these,those,myself,yourself,himself,herself,itself,ourselves,themselves" },
                    { "6", "Prepositions", "aboard,about,above,according to,across,after,against,ahead of,along,amid,amidst,among,around,as,as far as,as of,aside from,at,athwart,atop,of,off,on,on account of,on behalf of,on top of,onto,opposite,out,out of,outside,over,with,with regard to,within,without,regarding,regardless of" },
                    { "7", "Conjunctions", "After,As,As long as,As soon as,As though,Before,Even if,If,If when,Inasmuch,Just as,Now,Now that,Once,Provided that,Since,Supposing,That,Though,Until,Whenever,Whereas,Wherever,Which,Who,Although,As if,As much as,Because,Even,Even though,If only,If then,In order that,Lest,Now since,Now when,Provided,Rather than,So that,After all,As a result,Consequently,Finally,For example,Furthermore,Hence,However,In addition,In fact,Incidentally,Indeed,Instead,Likewise,Meanwhile" },
                    { "8", "Determiners", "a,a few,a little,all,an,another,any,anybody,anyone,anything,anywhere,both,certain,each,either,enough,every,everybody,everyone,everything,everywhere,few,fewer,fewest,last,least,less,little,many,many a,more,most,much,neither,next,no,no one,nobody,none,nothing,nowhere,once,one,said,several,some,somebody,something,somewhere,sufficient,that,the,these" },
                    { "9", "Exclamations", "Shh,Please,Psst,Shoo,Hey,Oh,Yo,Here,Ahem,Encore,There,Hush,Scat,No,Silence,Enough'Yuck,Eww,Aww,Ouch,Oh,Ah,Ugh,Phew,Phooey,Rats,Yippee,Blah,Brr,Eek,Good grief,Alas,Bingo,Bravo,Eureka,Crikey,Gee,Golly,Gosh,Hmm,Holy cow,Aha,Oh,Huh,Duh,Ahh,Well" }
                });
        }
    }
}
