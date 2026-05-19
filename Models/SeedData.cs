using ProjectSuperhero.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjectSuperhero.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ProjectSuperheroContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ProjectSuperheroContext>>()))
        {
            // Look for any movies.
            if (context.Comic.Any())
            {
                return;   // DB has been seeded
            }
            context.Comic.AddRange(
                new Comic
                {
                    SeriesId = 0,
                    Name = "Superman",
                    Number = 2,
                    Cover = "base64(image)",
                    ReleaseDate = DateTime.Parse("2020-04-09"),
                    Resource = "SystemFilePath",
                    Rating = 5,
                    OtherName = "",
                    Genres = "['Action', 'Adventure', 'Movies & TV', 'Superhero']",
                    Publisher = "DC Comics",
                    Writer = "Various",
                    Artist = "Various",
                    PublicationDate = "June 1995",
                    Summary = "One shot.",
                },
                new Comic
                {
                    SeriesId = 0,
                    Name = "Superman",
                    Number = 2,
                    Cover = "https://rcostation.xyz/Uploads/Etc/9-23-2017/88161943071126.jpg",
                    ReleaseDate = DateTime.Parse("2020-04-09"),
                    Resource = "SystemFilePath",
                    Rating = 5,
                    OtherName = "Batman Forever",
                    Genres = "['Action', 'Adventure', 'Movies & TV', 'Superhero']",
                    Publisher = "DC Comics",
                    Writer = "Various",
                    Artist = "Various",
                    PublicationDate = "June 1995",
                    Summary = "One shot.",
                },
                new Comic
                {
                    SeriesId = 0,
                    Name = "Batman Forever: The Official Comic Adaptation of the Warner Bros. Motion Picture",
                    Number = 2,
                    Cover = "https://rcostation.xyz/Uploads/Etc/9-23-2017/88161943071126.jpg",
                    ReleaseDate = DateTime.Parse("2020-04-09"),
                    Resource = "SystemFilePath",
                    Rating = 5,
                    OtherName = "Batman Forever",
                    Genres = "['Action', 'Adventure', 'Movies & TV', 'Superhero']",
                    Publisher = "DC Comics",
                    Writer = "Various",
                    Artist = "Various",
                    PublicationDate = "June 1995",
                    Summary = "One shot.",
                },
new Comic
{
    SeriesId = 0,
    Name = "Thrillkiller '62",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/10-21-2020/62761443071156.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: Thrillkiller",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Howard Chaykin",
    Artist = "Dan Brereton",
    PublicationDate = "1998",
    Summary = "This is an Elseworlds story set in an alternate 1962. It's dark, it's violent, and it's unexpected. Beautifully drawn by Dan Brereton and well written by Howard Chaykin.",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman: The Complete Hush",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/8-11-2016/8075311534267.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: Hush",
    Genres = "['Crime', 'Drama', 'Movies & TV', 'Mystery', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Jeph Loeb",
    Artist = "Jim Lee",
    PublicationDate = "2009",
    Summary = "Born into affluence, Bruce Wayne was fundamentally changed the night his parents were murdered before his eyes. From that day on, Bruce trained his mind and body beyond peak human perfection to become Batman--a symbol of terror, striking at the hearts of criminals and villains across the globe.",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman '66 [II]",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/10-10-2019/79575543071167.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman '66",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Jeff Parker",
    Artist = "Laura Allred",
    PublicationDate = "September 2013 - February 2016",
    Summary = "Put on your go-go boots and get ready to 'Batusi' back to the Swingin' 60s as DC Comics reimagines the classic Batman TV show! In this hardcover collecting issues #1-5 of the hit series, The Dynamic Duo takes on The Riddler, Mr. Freeze, The Penguin, The Mad Hatter, The Joker, and more of the world's most colorful Bat-villains!",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman: Nightwalker: The Graphic Novel",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/10-30-2019/61712543071340.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: Nightwalker",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Stuart Moore",
    Artist = "Chris Wildgoose",
    PublicationDate = "October 1 2019",
    Summary = "A ruthless new gang of criminals known only as Nightwalkers is terrorizing Gotham, and the city’s elite are being taken out one by one. On the way home from his 18th birthday party, newly minted billionaire Bruce Wayne makes an impulsive choice that puts him in their crosshairs and lands him in Arkham Asylum, the once-infamous mental hospital. There, he meets Madeleine Wallace, a brilliant killer…and Bruce’s only hope. Madeleine is the mystery Bruce must unravel, but is he convincing her to divulge her secrets, or is he feeding her the information she needs to bring Gotham City to its knees?Adapted by Stuart Moore and illustrated by Chris Wildgoose, this graphic novel presents a thrilling new take on Batman before he donned the cape and cowl.",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman/The Maxx: Arkham Dreams",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/10-4-2018/5901443071355.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman/The Maxx",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "IDW Publishing",
    Writer = "Sam Kieth",
    Artist = "Sam Kieth",
    PublicationDate = "October 3 2018",
    Summary = "Batman must face the strangest and most bizarre adventure of his career, as he meets comics’ strangest and most bizarre hero… THE MAXX! IDW and DC Comics proudly present the most surreal, quirky, and wonderful crossover of all time! A devious new doctor at Arkham Asylum is conducting unconventional experiments into the human psyche, and he kicks off a chain reaction of disaster when he experiments on Arkham’s newest patient, The Maxx! The city of Gotham is starting to merge with The Maxx’s psychedelic mental landscape, known as the Outback, blurring the line between real and unreal. It’s up to Batman to save not just Gotham, but all of reality, and he and The Maxx are going to have to travel through some of the darkest places imaginable—the twisted minds of Batman’s greatest enemies! Join Batman and The Maxx on an off-kilter and unforgettable romp through the diabolical consciousnesses of Batman’s greatest foes. Legendary artist Sam Kieth (Sandman, Wolverine) returns to his greatest creation, The Maxx, and returns to Gotham as well, assisted by multi-Eisner Award-winning writer John Layman (Detective Comics, Chew).",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman/Grendel (1993)",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/5-30-2016/33854429.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman/Grendel Devil's Riddle",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Matt Wagner",
    Artist = "Matt Wagner",
    PublicationDate = "April 1993 - May 1993",
    Summary = "BATMAN/GRENDEL pits the relentless determination of the Dark Knight  Detective against the diabolic methodology of Hunter Rose, the first  incarnation of Matt Wagner's now-classic creation, Grendel. While Bruce  Wayne and Hunter Rose play power games in Gotham's high society, Batman  finds himself up against a new and vicious foe of uncanny intellect and  evil intent, one more than capable of testing the Dark Knight's  formidable skills to their limits.",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman: Joker Time",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/3-29-2017/93848643071565.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: It's Joker Time",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Bob Hall",
    Artist = "Bob Hall",
    PublicationDate = "2000",
    Summary = "A Prestige miniseries finds the Clown Prince of Crime agreeing to be psychoanalyzed...on live television! Can the Dark Knight stop the unorthodox session when he doesn't even know where it's taking place?    The Joker's time in Arkham Asylum has sent him madder than he was before by making him watch the Barry Dancer Show. He breaks out of there and is approached by the desperate show host, but is unable to speak due to his confinement.",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman/Planetary Deluxe",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/10-18-2017/9947914307174.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Deluxe Planetary/Batman",
    Genres = "['Action', 'Adventure', 'Mystery', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Warren Ellis",
    Artist = "John Cassaday",
    PublicationDate = "April 2011",
    Summary = "Planetary, the archaeologists of the unknown, cross paths with Batman on the trail of a killer in this special-edition collection. When Planetary—Jakita Wagner, Elijah Snow and the Drummer travel to Gotham City, they mean business. Wagner, Snow and the Drummer track an amoral killer to Gotham City, prepared for battle. What they aren't prepared for is the Dark Knight! Of course, Batman doesn't exist on the same Earth as Planetary, which means the killer has worked in some very strange ways! Now the killer's reality-distorting technology is pulling, twisting and shifting the heroes through untold versions of Gotham City and Batman! This special-edition collection also features Warren Ellis' script for the story.",
},
new Comic
{
    SeriesId = 0,
    Name = "Dark Nights: The Batman Who Laughs",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/11-16-2017/61964543071197.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "The Batman Who Laughs",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "James Tynion IV",
    Artist = "Riley Rossmo",
    PublicationDate = "January 2018",
    Summary = "As the events of DARK NIGHTS: METAL rock the DC Universe, the creatures of the Dark Multiverse stand ready to invade our world! How can the World’s Greatest Heroes stop a horde of deadly beings that appear to be powerful nightmare versions of familiar figures?",
},
new Comic
{
    SeriesId = 0,
    Name = "DC Comics Essentials: The Black Mirror",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/7-12-2017/27183143071577.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: The Black Mirror",
    Genres = "['Action', 'Adventure', 'Crime', 'Drama', 'Movies & TV', 'Mystery', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Scott Snyder",
    Artist = "Jock",
    PublicationDate = "December 2014",
    Summary = "A NEW YORK TIMES #1 Bestseller! In The Black Mirror,a series of brutal murders pushes Batmas detective skills to the limit and forces him to confront one of Gotham City's oldest evils. Helpless and trapped in the deadly Mirror House, Batman must fight for his life against one of Gotham City's oldest and most powerful evils! Then, in a second story called Hungry City,     the corpse of a killer whale shows up on the floor of one of Gotham Citys foremost banks. The event begins a strange and deadly mystery that will bring Batman face-to-face with the new, terrifying faces of organized crime in Gotham. Collects Detective Comics vol. 1 #871-881.",
},
new Comic
{
    SeriesId = 0,
    Name = "Beware the Batman [I]",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/1-12-2017/25270331586900.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Beware the Batman",
    Genres = "['Action', 'Adventure', 'Movies & TV', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Ivan Cohen",
    Artist = "Luciano Vecchio",
    PublicationDate = "November 2013 - April 2014",
    Summary = "The Dark Knight Detective takes on the criminals of Gotham City in his never-ending quest for justice. Spins out of the Cartoon Network animated series!",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman/Predator III",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/7-18-2016/8521601534289.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman Versus Predator III",
    Genres = "['Action', 'Adventure', 'Superhero']",
    Publisher = "DC Comics",
    Writer = "Chuck Dixon",
    Artist = "Rodolfo Damaggio",
    PublicationDate = "November 1997 - February 1998",
    Summary = "N/a",
},
new Comic
{
    SeriesId = 0,
    Name = "Batman: Hush",
    Number = 2,
    Cover = "https://rcostation.xyz/Uploads/Etc/5-2-2016/2646391hush.jpg",
    ReleaseDate = DateTime.Parse("2020-04-09"),
    Resource = "SystemFilePath",
    Rating = 5,
    OtherName = "Batman: Hush Double Feature",
    Genres = "['Action', 'Adventure', 'Crime', 'Martial Arts']",
    Publisher = "DC Comics",
    Writer = "Jeph Loeb",
    Artist = "Jim Lee",
    PublicationDate = "January 2003",
    Summary = "Batman saves a young boy who was kidnapped by Killer Croc who was hired by Poison Ivy. While chasing Catwoman, Batman is seriously injured as he falls from a building. He teams up with Catwoman and follows Poison Ivy to Metropolis and fights Superman who is under Poison Ivy's control. Batman is able to help Superman regain control of himself and stop Poison Ivy as Hush watches from the sidelines.",
}
            );

            /* SERIE */
            // Look for any movies.
            if (context.Serie.Any())
            {
                return;   // DB has been seeded
            }
            context.Serie.AddRange(
                new Serie
                {
                    Name = "Batman series",
                    Description = "Batman is KEWL",
                    WikipediaLink = "https://somewhere.something.anyhow.net/url/lol"
}
            );
            context.SaveChanges();
        }
    }
}