using Microsoft.EntityFrameworkCore.Migrations;

namespace SentenceConstruction.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
