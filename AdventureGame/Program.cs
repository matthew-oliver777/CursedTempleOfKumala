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
        static int Scenarios = 6;
        //Character Name
        static string CharacterName;

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
            "[Fill the goblet all the way] \nYou fill the goblet as much as you can and, feeling that time is of the essence, dart to the walkway. \nYou wait to hear the click and the tapping begin. \nOnce you do, the attempt to tightrope along the thin walkway begins. \nThe tapping is reassuring, and you feel like you made a good decision. \nYou make it nearly halfway through the hall and hear the tapping abruptly stop, and the sound of water splashing. \nYour heart drops and you hurry as fast as you can to cross the hall. \nSure enough, large blades swing out from both walls, cutting you down to size. \nMaybe you thought the tapping indicated the time, huh? \nI’ll bet you play a lot of video games. \nDon’t you know not to overfill a drink? \nEspecially one you want to give to someone.",
            "[Fill the goblet halfway] \nYou fill the goblet halfway and proceed to bolt to the hallway. \nYou wait to hear the click, and the tapping before you dare to cross the hall. \nIt doesn’t take long before you do. \nCarefully, you cross the thin tightrope-like walkway, trying to keep a quick pace out of fear that you maybe you should have poured more water into that goblet. \nThe tapping continues as you cross the room, as if the deity itself is pleased with your offering. \nSlowly, it drinks the water from the goblet and you can feel the deity holding back a trap from reaching you. \nThankfully, you make it to the other side of the room safely and cross through the threshold of this dangerous room. \nYou should have a victory drink yourself for making it out!",
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

        };

        //Print out game title and overview
        public static void StartGame()
        {
            GameTitle();
            Console.WriteLine("The Cursed Temple of Kumala\n\n");
            Continue();
            Console.WriteLine("Welcome to The Cursed Temple of Kumala!\n");
            Console.WriteLine("This is a Fantasy Pick Your own adventure game, and my first attempt at making a game! I hope you enjoy it!\n\n");
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
                        }
                        else
                        {
                            Console.WriteLine(PartSix[2]);
                        }

                        Console.WriteLine(PartSix[3]);

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
        }
    }
    class item
    { }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
