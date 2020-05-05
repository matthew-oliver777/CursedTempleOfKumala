/*
 * The Cursed Temple of Kumala
 * By: Matthew Oliver, April 2020
 * 
 * This work is intednded for use by Dakota State University
 * for the purpose of CSC-260-DT1 semester project
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public static class Game
    {
        static int Scenarios = 7;
        //Character Name
        static string CharacterName;
        static List<string> Inventory = new List<string>();

        static string[] PartOne =
        {
            "After learning the location of the temple from Peruvian Locals, you pick up some tools to aid you on the journey. \nA whip, lighter, a water canteen, and for some reason a very stylish sable fedora. \nOne local with access to a small plane offers to bring you near the temple, but refuses to get too close out of fear of the dangers surrounding the temple. \nMany hours later, you land in a clearing nearly 20 minutes from the temple. \nThe local says that he will wait for you for today only, but if you don’t return by tomorrow morning, he will assume you have perished. \nThe air becomes incredibly humid and mist seems to blanket the jungle’s edge as you enter the path to the temple, a path that has clearly had many visitors as the ground is beaten. \nThe path is neatly sandwiched between the jungle linings to your left and right. \nAs you progress, the ambient sounds of the jungle slowly go from a faint chitter to a roar. \nIn between the waves of howls and chirps, you hear a faint rustling to your left. \nYou start moving quickly and try to make out how close to you the sound is and quickly realize that it’s getting closer and closer. \nThere is no time to even worry about what Is approaching, you need to make a decision. \nYou can either choose a to run as fast as you can, or b to slowly walk away.",
            "[Run as fast as you can] \nWithin seconds your panic-fueled run causes you to trip and hurt your knee. \nYou watch in horror as an anaconda reveals itself. \nIts intentions are clear as it slithers over your body and around your neck. \nYour vision starts to fade and you soon fall into a deep, permanent rest. \nPerhaps you should have been more careful. \n[DEAD END]",
            "[Slowly walk away] \nYou carefully continue walking, making an effort to be as silent as possible. \nEventually you hear the sound stop, followed by a squeak. \nPeaking behind you, you can see the tail of a large snake sliding into some brush. \nIt must have been pretty hungry, but luckily, you aren’t on the menu. \n[SAFE]",
            "Following the path after your near-death experience, you begin to hear the calming sounds of water in the distance."
        };

        static string[] PartTwo =
        {
            "Before long, you happen upon a small stream that cuts through the rainforest. \nYou take a moment to sit down on a nearby fallen tree and consider how you will make it past the stream. \nIt’s not particularly wide, only about 15 feet and the waterflow is slow, but you also consider your last encounter with danger and wonder if you should just try going into the bushes and see if you can find a smaller body to cross. \nYou don’t see any rustling in the bushing, but you do see small tracks on the ground leading into it. \nAs for the stream, it stays eerily still. \nAside from the waves, you don’t even see so much as a ripple in the muddy, cloudy waters. \nYou rise up from the log, moving towards the stream in order to make an attempt to see if you can find a throat for crossing. \nFrom the corner of your eye, you can make out a patch of water further down the stream to your right hiding behind some foliage that is wide enough to leap across. \nNow that you are closer to the water, you can see tiny ripples against the streams’ waves. \nThat could very well just be fish, or turtles. \nThe water doesn’t actually seem that deep and its’ width wouldn’t take long to cross. \nThis would certainly be an alternative path to walking through the brushing. \nThe tracks on the ground lead near where you would have to walk to get to the streams throat. \nYou can't just sit and wait for the temple to come to you. \nYou can either choose a to walk through the folliage and attempt to leap the stream, or b to wade through the stream",
            "[Walk through the brushing] \nGoing into the woods, you pass up the tracks and your anxiety rises. \nFortunately for you, the walk to the throat is quite pleasant and uneventful. \nThose tracks must have been a small rodent’s or maybe a reptile. \nYou aren’t sure, since you are an archaeologist, not a zoologist. \nYou even find some cool flowers that you have never seen before on your way to your effortless hop over the throat. \nNeat! \n[SAFE]",
            "[Cross the stream] \nYou start to wade through the stream. \nYour socks are wet, your shoes are wet, your jeans are wet, and it’s not a great time for anyone. \nYou make it halfway through the stream before you start seeing some bubbling near you. \nInstantly, a large Black Caiman pops out of the water, sinking its teeth into your sides. \nIt drags you into the water as quickly as it appeared. \nIt probably just wanted to hang out with you. \n[DEAD END]",
            "Upon crossing the stream, you are now very near to the temple. \nYou walk very briefly before breathing a sigh of relief. "
        };

        static string[] PartThree =
        {
            "Just in the distance, you can barely make out what appears to be a structure of stone wrapped in vines. \nYou pick up your pace a bit before stopping abruptly. \nOn both sides of the path are what appears to be human skulls, some appearing to be nearly as old as the temple itself, and some that look as if they were only a couple of weeks removed. \nBut they’re perfectly clean; like the most pg-13 skulls that you have ever seen. \nWith them lined up so neatly, it would almost seem as if they are leading you to the temple while also telling you that it would probably be in your best interest to leave. \nEither you are brave, or really stupid. \nEither way, you end up at the temple. \nMade of old, stained limestone, coated with vines, and surrounded by trees and the sounds of the jungle, this is pretty much exactly what you expected when you thought of what a jungle temple would look like. \nOn both sides of the temple entrance are the coolest statues you have ever seen; both are identical, muscular monkeys. \nThey are both holding spears, and have serious looks on their faces. \nNot angry faces, just stern, like the face your father had when you told him you were going to be an archaeologist instead of a doctor. \nAs you walk by the statues, you notice some etched symbols on the side of the left monkey statue. \nUnfortunately, you have no idea what any of the symbols mean as they appear to be a language you’ve never seen before. \nWhen you turn around, you see similar etchings on the other statue, except they are in perfect English. \nWeird, but convenient! \nThe message reads: This is the cursed temple of Kumala, a once beloved protector of the forest, now a wrathful god tainted by the greed of men who would slay their kind for wealth. \nIf you enter this domain with ill intent, you shall be punished. \nOnly those strong of will and sharp of wit may survive. \nDo not simply walk into this temple thinking you will find glory. \nYou will be tested! \nYour hands shake, and you sweat profusely, your body screaming at you to turn around and leave. \nBut then, you think of how cool it would be to be known as the only person to have survived an ancient temple, and you convince yourself that it’s totally worth it. \nYou take a couple of deep breaths and walk to temple’s open entrance; it’s very dark and you can only hear the sound of whistling winds sweeping the temple walls. \nYou consider using your lighter so you could see a bit better, but there is nothing around that you could use as a torch, and you don’t want to risk using up what you little butane the lighter has. \nYou can either choose a to take the slow, cautious approach into the temple, or choose b to charge on in.",
            "You take a few steps inside to ease your nerves. \nThe walls look rock-solid, probably because they are made of stone. \nThere is a thick accumulation of moss on the walls and floor. \nLike thick with two c’s, at least. \nYou then step on uneven ground, it sinks beneath your feet and hear a mechanical whirl. \nYou’ve seen enough movies to know what happens next.. \n[DEAD END]",
            "Against your better judgment, you ninja-run as fast as you can into the temple. \nYou hear what sounds like metal shooting up out of the ground behind you as you run, urging you to keep moving. \nEventually the sounds stop, but you keep running until you smack your body into a wall. \nDazed, after a dizzy-spell you slowly rise to your feet. \nThere’s a torch on the wall, right above your head. \nHey alright! \n[SAFE]",
            "Now that you have a torch and can see more clearly, you slowly turn around to see all the wackiness that you managed to avoid. \nThere’s a ridiculous amount of spikes sticking out of the ground, along with some surprised looking skeletons."
        };

        static string[] PartFour =
        {
            "Thanking your good fortune, you move around the center column that you ended up running into and you can barely make out a natural staircase leading further down into the temple. \nSo of course, you start head down the stairwell at a nice brisk pace. \nThe stairs feel like they lead downward for an eternity, but at some point, you can hear the sound of water droplets. \nAt the bottom of the stairwell is an entryway. \nBeyond it, a thin walkway barely wide enough to walk across. \nIf you were to fall when crossing it, who knows how far you could drop. \nIt looks like you don’t have a choice, since at the other end lies another entryway. \nIt seems obvious to you that there may be another trap in this upcoming hallway, but you aren’t sure how to prepare for it. \nAfter observing the room, a bit, your eyes lock onto misshapen figures on on the wall next to the hall’s entryway. \nHolding the torch up to the wall reveals what seems to be an illustration of an old deity of war, clad in Aztec armor, etched into the stone wall. \nThe arm of the god quite literally appears to come out of the wall. \nIt appears the hand is cupped. \nUpon observing the face of the illustration, you find a goblet in its mouth. \nYou try to tug it out, and push it down, but this does nothing. \nOpposite the illustration, there appears to be a hole in the wall. \nYou get closer to inspect the hole and of course it’s pitch black inside it. \nA sound of water droplets can now be heard. \nThere is no telling what’s inside, but curiosity gets the best of you. \nSlowly, you put your hand into the hole. \nThe hole keeps going deeper until the tips of your fingers brush up against what feels like fur. \nYou yank your hand back out of the hole in surprise. \nWhat the heck was in the hole? \nAfter psyching yourself up, you reach your hand back into the hole. \nYou feel the fur, but stick your hand in further. \nAll of a sudden you feel something wet hit your palm, and again you yank your hand back in surprise. \nThe fur you were feeling ended up just being a clump of moss, and the wet feeling was water. \nThinking back to the goblet in the deity’s mask, you get an outlandish idea. \nYou pour what little remains of the water you had in your canteen into the goblet. \nThe goblet drops from its spot and tilts ever so slightly. \nAfter a couple of seconds, you hear a clink sound, and the arm of the deity goes inward towards the wall. \nThe wrist snaps down and the fingers of its hand enter a slot in the wall. \nYou begin to hear a tapping sound. \nNot long after, the tapping stops, the hand returns back to its initial position, and the goblet slides back up. \nYou aren’t sure what just happened, but common sense tells you that this is a puzzle. \nYou make your way back to the hole, canteen in hand. \nYou reach inside the hole as far as you can, adjusting your reach once you feel the droplets hitting your wrist. \nYou begin to hear the sounds of water hitting metal, and patiently, you wait for the canteen to fill itself up. \nOnce your canteen fills up completely, you remove your hand from the hole and head back to the deity. \nConsidering the events that occurred last time you poured water into the goblet, you wonder... \nShould you, a, fill the goblet all the way? Or b, halfway?",
            "[Fill the goblet all the way] \nYou fill the goblet as much as you can and, feeling that time is of the essence, dart to the walkway. \nYou wait to hear the click and the tapping begin. \nOnce you do, the attempt to tightrope along the thin walkway begins. \nThe tapping is reassuring, and you feel like you made a good decision. \nYou make it nearly halfway through the hall and hear the tapping abruptly stop, and the sound of water splashing. \nYour heart drops and you hurry as fast as you can to cross the hall. \nSure enough, large blades swing out from both walls, cutting you down to size. \nMaybe you thought the tapping indicated the time, huh? \nI’ll bet you play a lot of video games. \nDon’t you know not to overfill a drink? \nEspecially one you want to give to someone. \n[DEAD END]",
            "[Fill the goblet halfway] \nYou fill the goblet halfway and proceed to bolt to the hallway. \nYou wait to hear the click, and the tapping before you dare to cross the hall. \nIt doesn’t take long before you do. \nCarefully, you cross the thin tightrope-like walkway, trying to keep a quick pace out of fear that you maybe you should have poured more water into that goblet. \nThe tapping continues as you cross the room, as if the deity itself is pleased with your offering. \nSlowly, it drinks the water from the goblet and you can feel the deity holding back a trap from reaching you. \nThankfully, you make it to the other side of the room safely and cross through the threshold of this dangerous room. \nYou should have a victory drink yourself for making it out! \n[SAFE]",
            "Past the room lies a relatively normal looking hall sloped downward, leading even further down into the temple that seems eager to take you out, and no, I’m not talking about a fancy date."
        };

        static string[] PartFive =
        {
            "Thanks to this brief reprieve, you can take time to think about the message that you found at the entrance to the temple. \nWho, or what is Kumala, and could it possibly be real? \nIf the greed of man angered the guardian, then why would it guard a treasure? \nIf you obtain the treasure, aren’t you only showing your greed as well? \nYou think about if you actually care about a treasure at all. \nPossibly, the thrill of the adventure is what you wanted all along? \nAt the same time, who would believe you if you come back empty handed? \nThese thoughts race through your head as you may your way down the slope. \nYou then hear a snap, tripping on what seems to be a wire. \nThunderous roaring booms behind you and your mind acutely focuses. \nYou know exactly what is coming up behind you; a boulder rolls down the hill as you rise to your feet and run as fast as you can. \nThe boulder gets closer, and closer to you while your body tries it’s hardest to not tumble and roll down the slope. \nYou then catch a glimpse of a stone door at the bottom of the hill, right past a wide pit! \nYour eyes dart around to see if you can find anything to leap to. \nThe only things you can see are some vines hanging from the ceiling, but they are too high up, and you aren’t sure they would support your weight. \nThe only other alternative is to leap to the other side to the pit, but it’s risky. \nThe boulder gets dangerously close to you, you toss your torch to the other side of the pit and make a risky choice… \nChoose a to leap the gap, or choose b to reach for the vines. \n",
            "[Jump the gap] \nYour muscles tense as your make your way to the end of the slope. \nYour eyes gauge the massive pit in front of you and your stomach drops as you feel the sole on your front-most foot touch the edge. \nWith all of the strength you can muster, you springboard off of the platform with your arms extended to grasp the other side. \nAs you fly through the air, time seems to slow down and you are sure you have met your end. \nWhat feels like minutes pass until your palms finally make contact with the other side. A loud roar right behind you rings as the boulder falls endlessly down the pit.\nYour arms begin to ache as you try to pull yourself up to safety. \nAs you sit hanging from the ledge your mind begins to assume the worst, thinking you cannot pull yourself up. \nThen you start to think about how far you have come, surely you must be coming close to the end of these trials. \nYou gather every ounce of strength you have left in your body and pull yourself up. \nYou throw your chest onto the platform and breath a sigh of relief. \nYou made it. \n[SAFE]",
            "[Reach for the vines] \nLike a lightbulb turning on, the idea pops into your head to grab hold of your whip and swing for the vines. \nA loud pop, then one end of the vine pops off. \nYou jump with all your might, reaching for the vine and manage to grab hold of it. \nScreaming, you swing across the gap just as the boulder falls into the pit right behind your back, landing square on the platform. \n[SAFE]",
            "After running your butt off, you take a moment to catch your breath."
        };

        static string[] PartSix =
        {
            "Despite nearly hitting rock bottom (I'm sorry), you can't help but think, “Why does there always have to be a giant boulder in every temple!?” \nAs you rise to your feet, you pick back up your torch and take a look at the stone door in front of you. \nSurely, there has to be some sort of gimmick. \nThere is no way that you can just open it up and walk on through, right? \nSure enough, after attempting to push, lift, and bum rush the door, it wouldn't so much as budge an inch. \nA quick glance around the platform tells you what must be done to progress further; what looks like a lever is positioned about 6 feet from the stone door. \nPulling down on the lever causes the door to rise and open, but the moment you release the lever, the door comes smashing down. \nThere is nothing on the platform that you can use to hold down the lever. \nFrustrated, you plop down on your tuckus and try to think about what you can do in the situation you are in. \nYou stare at the torch, crackling and giving off its comforting glow. \nAn idea dawns on you, to wedge the torch in between the lever! \nYou pull the lever a little more than halfway, sliding the torch in between the gap. \nIt is long enough so the temple wall naturally supports its shape. \nThe stone door rises high enough so that you can crawl beneath it, but you aren't sure how long the torch will hold the switch before it snaps. \nSaying goodbye to your brief ally, you rush to the door and drop to the ground on your hands and knees. \nYou slowly crawl under the door and make it to the other side. \nOnce you rise to your feet, you hear a snap and the door comes crashing down behind you. \nThe torch is lost, and with it, the benefits of a guiding light. \nThis new room looks unlike any that you have seen thus far. \nThe room is bright, the walls are golden with tribal figures all over, and the ground looks practically untouched by anything. \nIt almost feels as if you aren’t even in the same temple anymore. \nYou can no longer her the natural sounds of wind, or water, or anything else. \nThere is only silence now. \nAhead of you is a long corridor and nothing else. \nYou follow the hall, looking around to see if there is anything out of the ordinary, anything that could be a trap. \nBut there’s nothing, nothing put the path. \nEventually the room starts slowly getting wider, bit by bit as you go down the hall. \nAnd then? \nA light. \nYou emerge into a room now made entirely out of gold. \nThere are two Monkey statues in the center with ruby encrusted eyes staring menacingly at one another, and two large fountains are next to the entryway. \nLit torches adorn the walls, and the crackling sound of fire fills the room. \nNow, it definitely doesn't feel like you are in the same temple anymore. \nBased on the surroundings, the treasure must lie just beyond this room. \nBut of course, based on your previous experiences, there must be a trap in the room as well. \nObviously, the trick has something to do with the monkey statues, right? \nYou take your hat off, and proceed to throw it in between the statues... \nSure enough, the monkey statues' mouths open and a blazing inferno shoots out from both of them, instantly incinerating the iconic fedora. \nYou don’t know what you were expecting, but you are no longer surprised by the over the top traps. \nI mean… someone had to have set these things up. \nWhy would a god need to set up traps anyways? \nAnyways, the statues are too big to climb and you can’t walk around them. \nYou could try to soak yourself with water from the fountain, maybe that will protect you, or maybe you could try to stick to the ground and crawl past the statues. \nIt’s your call adventurer! \nChoose a to soak yourself and run past the statues, or b to crawl past them.",
            "[Daring run through the fire] \nYou roll around in the fountain soaking yourself with water. \nYou couldn’t be more wet if you tried, and you did! \nYou get out of the fountain as water pours off of you. \nYou approach the statues, confident that the flames will not touch you. \nJumping in place for a second, you then break into a full sprint! \nYou pass by the statues, triggering the flames. \nYou see a flicker of light all around you, and then nothing at all. \n[DEAD END]",
            "[Crawl past the statues] \nThere is something about the statue’s eyes that make you think they trigger the flames. \nYou get down on the ground, making yourself as flat as you can. \nThen you start shimmying your way towards the statues. \nYou start feeling a little shaky about your plan, thinking that maybe it wasn’t the best decision after all. \nBut you push on, eventually you crawl in-between the statues, taking a moment to glance up at the eyes of the statues. \nYou feel relieved and, once you get fast the statues, you jump to your feet. \nYou’ve bested this trial. \n[SAFE]",
            "In front of you is a wall covered in vines."
        };

        static string[] PartSeven =
        {
            "With nowhere else to go, you walk up to the wall to inspect the vines. \nThere is nothing out of the ordinary about them, but there certainly is a lot of them. \nYou start pulling away at them hoping to find something that could lead you to progress. \nYou see a crack of light after pulling one of the vines away. \nYou eagerly start pulling away the vines around the crack until the vines start falling away by themselves, revealing a hidden room. \nTaking your first steps forward, the ground beneath you becomes soft. \nYou’re standing on some white flowers. \nThe grassy ground is covered with them. \nConfused, you look up and… you are outside? \nYou are in a forest clearing, and looking towards the sky, you see clouds drifting about. \nNone of what you’re seeing makes any sense. \nYou were just inside the temple, and you kept going down, so how are you outside again? \nYou look around, and the wall that you walked through is no longer there. \nYou walk up to the trees wrapped around the clearing, and you can’t go past them. \nThey are a wall trapping you to the clearing. \nFrustrated, you walk to the center of the clearing. \nCould this be another trap? \nYou close your eyes to contemplate the situation. \nWhen you open your eyes there is a figure standing in front of you… \nIt is none other than the local you flew you into the jungle. \n“You must be very confused”, he says. \n“No one has ever made it here before. I didn’t think anyone ever would.” \n“This place was created to punish the greed of man.” \n“I was once a guardian of this jungle, worshipped by all, and I protected the people.” \n“But then time and time again I witnessed cruelty, deception, and greed.” \n“Humans became willing to kill one another for any gain.” \n“One day, a mother and son trekked the fields looking for a freshwater spring.” \n“They were just looking to bring some water back home.” \n“They were carrying a priceless gem, called the Jungle’s Heart, a gift the mother received just before her father’s passing.” \n“A cruel man found out about the gem and followed them until no one was around to speak of.” \n“The man attacked the mother, and the son, who was but a child.” \n“The mother was stabbed trying to protect her son.” \n“The man stole the gem and ran away, and the mother died shortly after.” \n“The son ran back to his village to seek help, but the thief was never found.” \n“I watched all of this as it happened, and couldn’t believe the man was even human.” \n“No…he must have been a demon.” \n“Who could have committed such evils…?” \nThe man fades away, revealing a large, mandrill monkey. \n“I am called Kumala, and I punished the thief so that he could never again commit evils in this world again.” \n“This temple serves as a reminder of kind souls like the mother, those with love in their hearts, devoid of greed.” \n“You have stood steadfast against every trial thrown at you, despite the odds.” \n“You express quantities of an adventurer, pure of heart, and have proven yourself worthy.” \nA shining green light surrounds you and Kumala, blinding you for but a moment. \nOnce you open your eyes, Kumala’s arms are extended, and in his palms rests the most beautiful gem you have ever seen before, and larger than an orange. \nKumala continues, “This gem holds a mysterious power, and protects the holder.” \n“It guarantees whoever holds it will possess incredible luck, and success throughout their lives.” \n“It is called Jungle’s Heart, and now.. it is yours…” \nPress a to take the Jungle’s Heart..?",
            "[Take the Jungle’s Heart] \nYou approach Kumala, reaching your hands out. \nYou pick the gem out of the massive mandrill’s palms. \nHowever, when you look up, your hair raises on your arms and your body becomes ice cold. \nKumala’s eyes are empty... soulless and pure white. \nHis expression is horrifying, barring his massive fangs with his jaw spread. \n“You are just like all the rest human..” \n“Greed lays in your heart and you cannot hide the evil within you that rests.” \n“I will purge you from this world, like all the rest who have tainted this temple.” \nYou are too terrified to even move. \nYou watch in horror as Kumala’s jaws open wider and wider. \nThe image of the fear inducing scowl worn by an angry god is now replaced by the mouth filled with razor sharp teeth. \nYou turn your head and all you can see is teeth…and then nothing.. ever again. \n[YOU HAVE FAILED]",
            "[Refuse the gem] \nYou stare at Kumala, not taking a step. \n“What’s the matter, human?” \n“Do you not want this gift?” \nAgain, you refuse to step forward, merely looking at the god. \nYou nod. \n“So... you reject the gem so many have died to obtain?” \nAgain, you nod. \n“I see…” \n“I was wrong…” \n[SAFE]",
            "“When that mother gave her life, I was certain this world was doomed, and it’s people… corrupt.” \n“And yet… there are people like you still in this world.” \n“I know why you came here, to seek glory, and a treasure like all who have come before.” \n“But you listened to my story, and I can tell that you too wish to honor the mother’s sacrifice…” \n“I truly believe you are worthy. Your heart shines brighter than your desire.” \n“Thank you for showing me there is more to this world human.” \n“It is time to be a protector again…” \n“Please, close your eyes for me, human.” \nYou do as the god asks. \nWhen you close your eyes, you see a flicker, and then feel a gentle breeze… \nYou open your eyes and you are in the clearing you first landed in. \nThe plane is right in front of you, as is the local. \nYou turn quickly turn around and there is a grave behind you that wasn’t there before. \nYou walk up to the grave and read the inscription. \nIt reads, “A mother with a kind soul dreams here, may she rest in peace.” \n“This is my mother’s grave…”, the local says as he walks to your side. \n“A long time ago, she protected me from a man who wanted to steal our family heirloom.” \n“Sadly, she lost her life to do so.” \n“You must have found the temple as well as a Kumala’s blessing or you wouldn’t be here.” \n“I fell that in my heart.” \n“After my mother’s passing, that temple just appeared out of nowhere.” \n“The villagers took it as an omen, but I knew it didn’t appear right then by coincidence.” \n“Nowadays, the villagers call him an angry god, but Kumala was once the protector of this jungle.” \n“I wasn’t lying before when I said no one has returned from the temple before. They must have not been found to be worthy.” \n“And yet, here you are…” \n“Let me take you back home, you must be exhausted.” \nYou get in your seat of the plane and sit on something; you lean up and pick out whatever was in the seat. \nYou don’t believe it… it’s the Jungle’s Heart, just lying there in the seat. \nYou look at the local’s face, and it’s covered in tears. \n“That was the gem…” \n“That was my mother’s gem from that day..” \n“She is telling you that she wants you to keep it safe for her…” \n“Thank you..” \nYears later, " + CharacterName + " is known throughout the world as one of the greatest adventures in the world, never seen of course, without the famed Jungle’s Heart. \nThe End..."
        };

        //Print out game title and overview
        public static void StartGame()
        {
            GameTitle();
            Console.WriteLine("The Cursed Temple of Kumala\n\n");
            Continue();
            Console.WriteLine("Welcome to The Cursed Temple of Kumala!\n");
            Console.WriteLine("This is a Fantasy-Based Pick Your Own Adventure Game, and my first attempt at making a game! I hope you enjoy it!\n\n");
            Continue();
            NameCharacter();
            Continue();
            Choice();
            EndGame();
        }
        static void GameTitle()
        {
            string Title = @"The Cursed Temple of Kumala";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }

        //Ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("A charming adventurer with the courage to pursue the treasure, what is your name?\n");
            Console.Write("Character Name: ");
            CharacterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It appears that your character name is " + CharacterName + ". Good luck and I hope you have fun!\n\n");
        }

        static void Continue()
        {
            Console.Write("Press Enter to Continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:

                        Console.WriteLine(PartOne[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);
                            section--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        Console.WriteLine(PartOne[3]);

                        break;

                    case 2:

                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                            section--;
                            break;
                        }

                        Console.WriteLine(PartTwo[3]);

                        break;

                    case 3:

                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                            section--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }

                        Console.WriteLine(PartThree[3]);

                        break;

                    case 4:

                        Console.WriteLine(PartFour[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartFour[1]);
                            section--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(PartFour[2]);
                        }

                        Console.WriteLine(PartFour[3]);

                        break;

                    case 5:

                        Console.WriteLine(PartFive[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartFive[1]);
                        }
                        else
                        {
                            Console.WriteLine(PartFive[2]);
                        }

                        Console.WriteLine(PartFive[3]);

                        break;

                    case 6:

                        Console.WriteLine(PartSix[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartSix[1]);
                            section--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(PartSix[2]);
                        }

                        Console.WriteLine(PartSix[3]);

                        break;

                    case 7:

                        Console.WriteLine(PartSeven[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartSeven[1]);
                            section--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(PartSeven[2]);
                            Inventory.Add("Jungle's Heart");
                        }

                        Console.WriteLine(PartSeven[3]);

                        break;
                }

                Console.WriteLine("press enter to continue...");
                Console.ReadKey();
                Console.Clear();
            }


        }

        public static void EndGame()
        {
            //End of game text
            Console.WriteLine("You have survived the curse and became one of the most renown explorers in the world, Congradulations " + CharacterName + "!");

            Console.WriteLine(CharacterName + " you found some items in your journey: ");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }

            if (Inventory.Contains("Jungle's Heart"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Congratulations you accomplished the goal! You found the Jungle's Heart!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("You didn't find the Jungle's Heart... try again next time!");
            }
        }
    }
    public class item
    {
        public string Name = "Whip";
        public string Description = "You've watched the movies enough to know you had to bring this thing, even if you don't know how to use it.";

        string[] Items = { "water canteen", "lighter" };
        string[] Descriptions = { "Gotta have water on an adventure, there's a cute monkey on this one!", "This is a necessity for long trips, but it doesn't have a lot of lighter fluid in it" };
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
