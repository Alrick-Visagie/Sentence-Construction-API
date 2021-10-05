using Microsoft.EntityFrameworkCore;
using SentenceConstruction.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceConstruction.Repository
{
    public class SentenceConstructionDbContext : DbContext
    {
        public SentenceConstructionDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Ading list of word types
            modelBuilder.Entity<Words>().HasData(
                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Nouns",
                    Word = "Actor,Gold,Painting,Advertisement,Grass,Parrot,Afternoon,Greece," +
                                                             "Pencil,Airport,Guitar,Piano,Ambulance,Hair,Pillow,Animal,Hamburger," +
                                                             "Pizza,Answer,Helicopter,Planet"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Verbs",
                    Word = "to ask,asked,ask,will ask,to be,was,am,will be,to become,became,become," +
                                                             "will become,to bring,brought,bring,will bring,to build,built,build,will build," +
                                                             "to buy,bought,buy,will buy,to call,called,call,will call,to change,changed," +
                                                             "change,will change"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Adjectives",
                    Word = "adorable,adventurous,aggressive,agreeable,alert,alive,amused,angry,annoyed," +
                                                                  "annoying,anxious,arrogant,ashamed,attractive,average,awful,bad,beautiful," +
                                                                  "better,bewildered,black,bloody,blue,blue-eyed,blushing,bored,brainy,brave," +
                                                                  "breakable,bright,busy,calm,careful"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Adverbs",
                    Word = "absentmindedly,adoringly,awkwardly,beautifully,briskly,brutally,carefully," +
                                                               "cheerfully,competitively,eagerly,effortlessly,extravagantly,girlishly,gracefully," +
                                                               "grimly,happily,halfheartedly,hungrily,lazily,lifelessly,loyally,quickly," +
                                                               "quietly,quizzically,really,recklessly,remorsefully,ruthlessly,savagely,sloppily," +
                                                               "so,stylishly,unabashedly,unevenly,urgently,well,wishfully,worriedly"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Pronouns",
                    Word = "I,you,he,she,it,we,they,me,him,her,us,them,who,whom,which,what," +
                                                                "whose,whoever,whatever,whichever,whomever,this,that,these,those,myself," +
                                                                "yourself,himself,herself,itself,ourselves,themselves"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Prepositions",
                    Word = "aboard,about,above,according to,across,after,against,ahead of,along," +
                                                                    "amid,amidst,among,around,as,as far as,as of,aside from,at,athwart,atop," +
                                                                    "of,off,on,on account of,on behalf of,on top of,onto,opposite,out,out of," +
                                                                    "outside,over,with,with regard to,within,without,regarding,regardless of"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Conjunctions",
                    Word = "After,As,As long as,As soon as,As though,Before,Even if,If,If when,Inasmuch," +
                                                                    "Just as,Now,Now that,Once,Provided that,Since,Supposing,That,Though,Until," +
                                                                    "Whenever,Whereas,Wherever,Which,Who,Although,As if,As much as,Because,Even," +
                                                                    "Even though,If only,If then,In order that,Lest,Now since,Now when,Provided," +
                                                                    "Rather than,So that,After all,As a result,Consequently,Finally,For example," +
                                                                    "Furthermore,Hence,However,In addition,In fact,Incidentally,Indeed,Instead," +
                                                                    "Likewise,Meanwhile"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Determiners",
                    Word = "a,a few,a little,all,an,another,any,anybody,anyone,anything,anywhere,both," +
                                                                   "certain,each,either,enough,every,everybody,everyone,everything,everywhere," +
                                                                   "few,fewer,fewest,last,least,less,little,many,many a,more,most,much,neither," +
                                                                   "next,no,no one,nobody,none,nothing,nowhere,once,one,said,several,some," +
                                                                   "somebody,something,somewhere,sufficient,that,the,these"
                },

                new Words
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Exclamations",
                    Word = "Shh,Please,Psst,Shoo,Hey,Oh,Yo,Here,Ahem,Encore,There,Hush,Scat,No,Silence," +
                                                                    "Enough'Yuck,Eww,Aww,Ouch,Oh,Ah,Ugh,Phew,Phooey,Rats,Yippee,Blah,Brr,Eek," +
                                                                    "Good grief,Alas,Bingo,Bravo,Eureka,Crikey,Gee,Golly,Gosh,Hmm,Holy cow," +
                                                                    "Aha,Oh,Huh,Duh,Ahh,Well"
                });

            //Adding some Sentences to display
            modelBuilder.Entity<Sentences>().HasData(
                new Sentences { ID = Guid.NewGuid().ToString(), Sentence = "Actor asked absentmindedly." },
                new Sentences { ID = Guid.NewGuid().ToString(), Sentence = "He said afternoon." },
                new Sentences { ID = Guid.NewGuid().ToString(), Sentence = "She asked him if he was angry." });
        }

        public DbSet<Sentences> Sentences { get; set; }
        public DbSet<Words> Words { get; set; }
    }
}
