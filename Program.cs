// See https://aka.ms/new-console-template for more information
// A skeleton of a C# program
using System;

public class DecisionMatrix
{
    //Constructor that takes no arguments
    public DecisionMatrix()
    {
        Decision = true;
    }

    //Constructor that takes 1 argument
    public DecisionMatrix(bool X)
    {
        Decision = X;
    }

    //Auto implemented read only property
    public bool Decision { get; set; }
}

public class Coffee
{
    // Constructor that takes no arguments:
    public Coffee()
    {
        string Name = "Latte";
    }

    // Constructor that takes one argument:
    public Coffee(string Milk)
    {
        Milk = "Oat";
    }

    // Auto-implemented readonly property:
    public string Beans { get; set; }
}



class MainMethod
{

    // Main Method
    static public void Main(String[] args)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        Console.WriteLine("Main Method");
        Console.WriteLine("This is a char array: " + alpha);

        var coffee = new Coffee();

        Console.WriteLine(coffee.Beans);

        var decision = new DecisionMatrix();

        Console.WriteLine(decision.Decision);

        String[] ChooseYOA = new string[] { "0\r\nJOURNEY UNDER\r\nTHE SEA\r\nby R.A. Montgomery\r\nCHOOSE YOUR OWN ADVENTURE • 2\r\nWARNING! ! ! !\r\nDo not read this book straight through from beginning to end! These pages contain many different\r\nadventures you can go on as you journey under\r\nthe sea. From time to time as you read along, you\r\nwill be asked to make a choice. Your choice may\r\nlead to success or disaster!\r\nThe adventures you take are a result of your\r\nchoice. You are responsible because you choose!\r\nAfter you make your choice follow the instructions\r\nto see what happens to you next.\r\nRemember—you cannot go back! Think carefully\r\nbefore you make a move! One mistake can be\r\nyour last ... or it may lead you to fame and\r\nfortune!",
            "1\r\n2\r\nYou are an underwater explorer. You are leaving to explore the deepest oceans. You must find\r\nthe lost city of Atlantis. This is your most challenging assignment.\r\nIt is morning and the sun pushes up on the\r\nhorizon. The sea is calm. You climb into the narrow pilot's compartment of the underwater vessel\r\nSeeker with your special gear. The crew of the\r\nresearch vessel Maray screws down the hatch\r\nclamps. Now begins the plunge into the depths of\r\nthe ocean. The Seeker crew begins lowering by a\r\nstrong, but thin cable. Within minutes, you are so\r\ndeep in the ocean that little light filters down to\r\nyou. The silence is eerie as the Seeker slips deeper\r\nand deeper. You peer out the thick glass porthole\r\nand see fish drifting past, sometimes stopping to\r\nlook at you—an intruder from another world.",
            "2\r\n3\r\nNow the cable attaching you to Maray is extended almost to its limit. You have come to rest on\r\na ledge near the canyon in the ocean floor that\r\nsupposedly leads to the lost city of Atlantis.\r\nYou have a special sea suit that will protect you\r\nfrom the intense pressure of the deep if you choose\r\nto walk about on the sea bottom. You can cut\r\nloose from the cable if you wish because the\r\nSeeker is self-propelled. You are now in another\r\nworld.\r\n________________________________________\r\nIf you decide to explore the ledge\r\nwhere the Seeker has come to rest,\r\nturn to page 6.\r\nIf you decide to cut loose from\r\nthe Maray and dive with the Seeker\r\ninto the canyon in the ocean floor,\r\nturn to page 5.",
            "3\r\n5\r\nYou radio a status report to the Moray and tell\r\nthem that you are going to cast off from the line\r\nand descend under your own power. Your plan is\r\napproved and you cast off your line. Now you are\r\non your own. The Seeker slips noiselessly into the\r\nundersea canyon.\r\nAs you drop into the canyon, you turn on the\r\nSeeker's powerful searchlight. Straight ahead is a\r\ndark wall covered with a strange type of barnacle\r\ngrowth. To the left (port) side you see what appears to be a grotto. The entrance is perfectly\r\nround, as if it had been cut by human hands.\r\nLantern fish give off a pale, greenish light. To the\r\nright (starboard) side of the Seeker you see bubbles rising steadily from the floor of the canyon.\r\n_______________________________________\r\nIf you decide to investigate\r\nthe bubbles, turn to page 8.\r\nIf you decide to investigate the grotto\r\nwith the round entrance, turn to page 9.\r\n",
            "4\n6\r\nYour sea suit will protect you from the intense\r\npressures of the deep. It is a tight fit and takes you\r\nsome time to put it on. Finally you slip from the\r\nairlock of the Seeker and stand on the ocean floor.\r\nIt is a strange and marvelous world where your\r\nevery move isslowed down. You begin to explore\r\nwith your special hand-held searchlight. You\r\nexamine the ledge by the canyon.\r\nSuddenly, a school of bright yellow angel fish\r\ndart by, almost brushing you. What made them\r\nmove so fast? Are they being chased?\r\nThen you see it. The Seeker is in the grips of a\r\nhuge sea monster. It is similar to a squid, but it is\r\nenormous. The Seeker is just a toy in its long,\r\npowerful tentacles. You seek shelter behind a rock\r\nformation. You know the spear gun you carry will\r\nbe useless against this monster. It looks asthough it\r\nwill destroy the Seeker. Fish of allsizes huddle with\r\nyou in an attempt to escape the monster.\r\n______________________________________\r\nIf you stay hidden close to\r\nthe Seeker, turn to page 10.\r\nIf you try to escape in the\r\nhope that rescuers willsee\r\nyou, turn to page 12.",
            "5\n8\r\nCarefully, you maneuver the Seeker between\r\nthe walls of the canyon.\r\nOn the floor of the canyon, you discover a large\r\nround hole out of which flow the large bubbles.\r\nThe Seeker is equipped with scientific equipment\r\nto analyze the bubbles. It also has sonar equipment that can measure the depth of any hole.\r\nIf you decide to analyze the bubbles,\r\nturn to page 11.\r\nIf you decide to take sonar readings,\r\nturn to page 15.",
            "6\n9\r\nYou pilot the Seeker through the rounded entrance to the grotto. Once inside, your searchlight\r\npicks up what appear to be docks and piers along\r\nthe grotto walls. The Seeker's searchlight is not\r\nvery powerful. However, you do have a special\r\nlaser light which would light up the grotto like\r\ndaylight. Unfortunately, the laser light can only be\r\nused twice for very short periods before it must be\r\nrecharged aboard the Maray, now more than\r\n2,000 feet above you on the surface.\r\n______________________________________\r\nIf you decide to use the laser light,\r\nturn to page 16.\r\nIf you decide to cruise further into\r\nthe grotto, turn to page 14.",
            "7\n10\r\nThe giant squid tosses and turnsthe Seeker, but\r\nfinally the creature growstired of its new game and\r\njets off with an enormous squirt of water. You now\r\nare free to leave your hiding place and examine\r\nthe Seeker for damage.\r\nTo your dismay, the airlock entrance has been\r\njammed shut. You are locked out of the Seeker.\r\nThe crew of the Maray, however, suspected trouble when you did not respond to a routine radio\r\ncheck and they are now lowering an escape platform to you. Once on the platform, you radio them\r\nto start the slow pull to the surface. To avoid the\r\nbends—rapid expansion of nitrogen bubbles in\r\nyour blood—they will have to bring you up very\r\nslowly.\r\nJust as the platform begins to move, the giant\r\nsquid suddenly returns as if from nowhere. It is\r\nheaded directly at you.\r\n______________________________________\r\nIf you decide to fight the squid\r\nwith yourspear gun, hoping to scare\r\nit off, turn to page 17.\r\nIf you decide to signal Maray to pull\r\nyou up at top speed, knowing you will\r\nget the bends, turn to page 18.",
            "8\n11\r\nYou squeeze into your sea suit and, outside the\r\nSeeker, you use special equipment to analyze the\r\nbubbles. As you work, you clumsily knock against\r\nthe valve that dumpsthe compressed air necessary\r\nto make the Seeker rise to the surface. There is\r\nnothing to be done about it; so you continue to\r\nanalyze the bubbles. They contain a high percentage of oxygen and no poisonous gases. Perhaps\r\nthey are coming from some area below the sea\r\nwhere human-type beings can live and breathe.\r\nPerhaps they are coming from Atlantis.\r\nYou wonder whether you should try the\r\nSeeker's drilling arm to enlarge the source of the\r\nbubbles so you can explore it with the Seeker. But\r\nyou are also very worried about the Seeker's loss\r\nof rising capability. You might also be able to trap\r\nthe bubbles and use them to raise the Seeker.\r\n______________________________________\r\nIf you try to collect the bubbles\r\ncoming from the hole to fill the tanks\r\nof the Seeker, turn to page 24.\r\nIf you decide to drill, turn to page 22.",
            "9\n12\r\nMoving cautiously, you climb up the sides of the\r\ncanyon hoping to reach the ocean floor. You leave\r\nthe Seekerin the grips of the giantsquid. Your plan\r\nis to signal for help with a dye marker that will float\r\nto the surface and make a bright yellow patch in\r\nthe water. The crewmen above have been instructed to watch for such emergency signals.\r\nThey will send help.\r\nOnce you reach the ledge above the canyon\r\nand feel slightiy safer, you see the most feared of all\r\nsea creatures— a huge shark. It begins to circle\r\ntowards you and you know that you are its target.\r\nYou wonder whether you should fire your\r\nemergency propulsion charge that will send you\r\nrapidly to the surface. The shark is fast; he might\r\ncatch you anyway. You also know that you will get\r\nthe bends from the rapid rise to the surface.\r\n______________________________________\r\nIf you decide to fire the special\r\npropulsion charge to get to the surface,\r\nturn to page 21.\r\nIf you decide to wait quietly\r\nhoping that the shark will go away,\r\nturn to page 19.",
            "10\n13\r\nYou cruise silently into the grotto. Its roof seems\r\nto slope upward and you follow the slope. The\r\ndepth finder shows that you are rising quite\r\nrapidly. Perhaps you will reach the surface and\r\nopen air. Then the roof of the grotto stops sloping\r\nupward. Before you is a perfectly round metallic\r\nhatch made of a metal that you have never seen\r\nbefore. With the mechanical arm of the Seeker\r\nyou try to open the hatch. It will not open. You\r\nbegin to send radio signals at the door hoping to\r\nmake contact on the other side.\r\n_____________________________________\r\nIf you decide to blow the hatch open\r\nwith an explosive charge,\r\nturn to page 26.\r\nIf you decide to continue\r\ntransmitting radio communicationsthrough\r\nthe hatch, turn to page 28.",
            "11\n15\r\nYou maneuver the Seeker next to the hole and\r\nbegin to take sonar readings to determine the\r\ndepth of the hole. To your amazement, the sonar\r\nreadings indicate that the hole is extraordinarily\r\ndeep— it might reach the center of the earth!\r\nWhat lies down there? Where are the bubbles\r\ncoming from? Is Atlantis beneath you?\r\nThen you notice a disturbing reading on your\r\ninstruments; a mild earthquake has occurred. The\r\nSeeker is not damaged, but the earthquake could\r\nset up a tsunami wave on the surface causing the\r\nMoray to leave forsafer areas. It might be dangerous not to get back to the surface and leave with\r\nthe Moray. On the other hand, you are perhaps on\r\nthe verge of one of the world's greatest discoveries.\r\n________________________________________\r\nIf you decide to descend into the hole,\r\nturn to page 23.\r\nIf you decide to return to the surface,\r\nturn to page 27.",
            "12\n16\r\nThe beam from the laser light illuminates the\r\nentire grotto. Far back on the floor of the grotto is a\r\nsubmarine! Cautiously, you maneuver the Seeker\r\ncloser. You identify it asthe submarine that mysteriously disappeared in the Bermuda Triangle almost a year before. The Bermuda Triangle is more\r\nthan 2000 miles away.\r\nThe submarine is apparently not damaged, but\r\nit is covered with a slimy algae. Beautiful fish swim\r\naround it as though it is their own special prize.\r\nThen you notice that the main hatch is free of\r\nalgae!\r\n_________________________________________\r\nIf you decide to try\r\nto enter the submarine,\r\nturn to page 29.\r\nIf you decide to cruise on through\r\nthe grotto, turn to page 31.",
            "13\n17\r\nWith a rush of water, the giant squid attacks you.\r\nTwo 20 foot tentacles with their pulsing suction\r\ncups reach out trying to ensnare you. You dive off\r\nthe platform and rapidly fire two of your spears.\r\nThey strike the squid close to its two monstrous\r\neyes. But the squid keeps on coming.\r\nOne of the tentacles wraps around your diving\r\nhelmet and ruptures the seal to your suit. You fire\r\nyour last spear hoping to hit the monster in a\r\nvulnerable spot. Water is beginning to trickle into\r\nyour suit. You signal the Maray to haul you up\r\nfast— \"Emergency Hoist.\" You must have hit the\r\nsquid. It floats away writhing and thrashing. You\r\nthink you're about to black out.\r\nYou wake up on the deck of the Moray and are\r\nquickly rushed to the decompression chambers to\r\nward off the effect of the bends. In a few days you\r\nare better and start to worry about diving into the\r\nabyss again.\r\n_______________________________________\r\nIf you decide to quit the\r\nexpedition now, turn to page 32.\r\nIf you decide to go back down to\r\nthe deep, turn to page 33.",
            "14\n18\r\nAs they begin the rapid hauling, you lose your\r\nability to function in the deep. You start to get dizzy\r\nand your arms and legs feel weak. You lose your\r\nhold on the platform and drift in the water\r\nexhausted. Then you see a dolphin heading toward you. You know that these marvelous\r\nmammalssometimes help people in trouble. Will it\r\nhelp you?\r\n______________________________________\r\nIf you try to get help from\r\nthe dolphin, turn to page 34.\r\nIf you decide to carry\r\non alone swimming to the\r\nsurface, turn to page 37.",
            "15\n19\r\nYou wait for the shark to go away. But then you\r\nnotice other sharks coming to join in the hunt.\r\nThey circle you, coming closer and faster each\r\ntime. It is too late. There is no escape!\r\nThe End",
            "16\n21\r\nYou fire the special propulsion charge and zoom\r\nupward through the water, frightening schools of\r\nfish as you go. You become dizzy and lose track of\r\nwhere you are. The world seems upside down.\r\nThe shark is nowhere around, you hope. Then\r\nyou break through to the surface floating about a\r\nhalf mile from the Maray.\r\nThe lookouts spot you in the water and quickly\r\nrescue you. Unfortunately, the rapid ascent has\r\ngiven you a bad case of the bends. It takes a long\r\ntime to decompress. And when you are finally all\r\nright, the ship's doctor informs you that your\r\nunderwater days are over. Someone else will have\r\nto find Atlantis.\r\nThe End",
            "17\n22\r\nAs you begin to drill, the stream of bubbles\r\nincreases.\r\nThe stream of bubbles is strong enough now to\r\nruffle the surface of the sea. You could try to\r\nsurface now and locate the exact position of the\r\nbubble area. Then you could make plans with the\r\nscientists aboard the Moray about what to do next.\r\nBut also, you could simply explore the hole with\r\nthe Seeker to determine the source of the bubbles\r\nnow! There is great risk in entering the hole, but it\r\ncould lead to the source of the bubbles and maybe\r\nto Atlantis.\r\n_______________________________________\r\nIf you explore, turn to page 38.\r\nIf you try to surface, turn to page 35.",
            "18\n23\r\nNow is the time for decision. You check all the\r\ncontrols of the Seeker, grit your teeth, and push\r\nthe control column into the deep dive position.\r\nDown, down you go where no person has ever\r\nventured. The Seeker is built for deep, deep dives,\r\nbut you are descending rapidly mile after mile into\r\nthe deep. The pressure is intense, the darkness is\r\ncomplete, and the depth guage indicates an incredible 15 miles. You quickly reverse the control\r\ncolumn. Warning lights flare up on your control\r\npanel; they show that gravitational forces are now\r\nstronger than the Seeker's propulsion motors. You\r\nhave passed the point of no return and your journey downward will continue in utter darkness until\r\nthe water pressure is too great for the Seeker. This\r\nis the final voyage.\r\nThe End",
            "19\n24\r\nYou are able to capture the bubbling gases and\r\nfill the tanks of the Seeker, enough to allow it to\r\nrise. Slowly, the Seeker rises out of the canyon,\r\nscattering schools of brightly colored fish, and\r\nbrushing past underwater plants that wave like\r\npalm trees in a wind. Just as you reach the ledge at\r\nthe top of the canyon, you see what appears to be\r\nan old road! Rocks along its side seem to be guard\r\nrails. Could this be a path that leads to the lost city\r\nof Atlantis? You anchor the Seeker and prepare to\r\ninvestigate more closely.\r\n_______________________________________\r\nTurn to page 6.",
            "20\n26\r\nThe only way to get beyond the door isto blast it\r\naway, or so you believe. The Seeker's laser cannon is powerful and you position the Seeker to fire.\r\nPushing the fire button, you send a powerful beam\r\nat the hatch. Nothing happens. Then you advance\r\nthe cannon control to full emergency force. Again\r\nyou push the button and the beam dissolves the\r\nhatch instantly. A flood ofsea water rushesinto the\r\ngiant hole, carrying you with it into an air-filled\r\ncavern beyond. The water fills the cavern with\r\nspeed and explosive force. You see several people\r\nscurrying towards escape hatches. IT IS TOO\r\nLATE! You did the wrong thing.\r\nThe End",
            "21\n27\r\nDeciding to return to the surface, you direct the\r\nSeeker cautiously back along the side of the canyon in the ocean floor. Without warning, the\r\nSeekeris gripped in a powerful current thatsweeps\r\nit toward a grotto. Once in the grotto, the current\r\ncarries you to what appears to be a large metal\r\ndoor. It swings open and the Seeker is swept inside. The door closes, the water in the grotto drains\r\naway, and you step out into a chamber that you\r\ndecide must be made by human hands.\r\nA door opens in the wall, two people dressed in\r\nsimple clothes come towards you. One of them\r\nsays, \"Welcome to Atlantis. We have been expecting you.\"\r\nWhat a discovery! You have found the lost continent and its civilization. The two people tell you\r\nthat although citizens of Atlantis occasionally journey to the upper world, anyone who happens\r\nupon Atlantis is never permitted to leave. The\r\nAtlanteans are not cruel but fear discovery of their\r\nworld.\r\nThey want you to follow them and you agree.\r\nBut you have another thought. Perhaps you could\r\nblast your way out of the chamber with the\r\nSeeker's laser cannon.\r\n______________________________________\r\nIf you decide to follow the people and\r\njoin the Atlantean society, turn to page 39.\r\nIf you decide to make a dash for\r\nthe Seeker and try to blast through the closed\r\ndoor with the laser cannon, turn to page 40.",
            "22\n28\r\nThe radio transmissions seem to be failing, and\r\nyou grow tired of sending signals through the\r\nclosed door. You are just about to give up when\r\nthe doorsuddenly swings open revealing behind it\r\na cavern with another door. You enter the cavern\r\ncautiously and receive a radio signal in English. It\r\ntells you that you are welcome here, but that once\r\nyou enter this place, you may never return to the\r\nworld above. It is up to you to decide.\r\n______________________________________\r\nIf you decide to go on\r\nand investigate what might be Atlantis,\r\nturn to page 41.\r\nIf you decide to retreat, turn to page 42.",
            "23\n29\r\nThe submarine is indeed mysterious. You now\r\nhave on your sea suit and you open the hatch on\r\nthe conning tower and enter the sub. It is amazingly clean and in order. There are no signs of life,\r\nbut there are also no signs ofstruggle or trouble. In\r\nthe control room, you see a piece of mystifying\r\nequipment that just doesn't belong on this sub.\r\nA voice begins telling you that, thousands of\r\nyears ago, the leaders of Atlantis realized that their\r\ncontinent was slipping into the sea. They discovered a large underground cavern and built new\r\nforms of living quarters for their people. Later\r\nwhen Atlantis was deep beneath the ocean, some\r\nof their scientists discovered and perfected an operation enabling them to breathe under water.\r\nThe voice, which sounds friendly, also tells you\r\nthat there are two groups in Atlantis. One group is\r\ngood and the other is evil. The voice invites you to\r\nenter the world of Atlantis and gives directions and\r\ninstructions to a secret passageway to the underwater city.\r\nAs you follow directions, you spy an unbelievable underwater craft with several people in it. It\r\nmust be an Atlantean ship, but are the people\r\ngood or evil? Do they know of the secret passageway?\r\n_________________________________________\r\nIf you hurry in, trying to reach\r\nthe secret passageway without being seen,\r\nturn to page 43.\r\nIf you rush back to the Seeker\r\ntrying to escape danger, turn to page 44.",
            "24\n31\r\nYou cruise through the grotto past the wreck of\r\nthe submarine and then you spot another ship\r\nwreck. And then another. They, too, are covered\r\nwith algae, but they appear undamaged. Maybe\r\npeople from Atlantis capture ships in the Bermuda\r\nTriangle and bring them here. Then you see\r\nanother ship, but this one is a three-masted\r\nschooner of the type used in the early 1800s. Its\r\nrigging isfestooned with algae, and fish swim lazily\r\naround its mast.\r\nYour curiosity captures you and you put on your\r\nsea suit. Leaving the Seeker, you move towards\r\nthe old sailing ship. Suddenly a thirteen-foot long\r\ndeadly poisonous sea snake strikes from behind\r\nthe forward cabin and bites you in the soft flesh\r\nbetween the fingers of your right hand. There is no\r\nantidote to the deadly poison.\r\nThe End",
            "25\n32\r\nWith great sorrow, you decide that it is wisest to\r\nleave the expedition now. You can't risk returning\r\nto the great depths below. So, you reluctantly\r\nreturn to the United States.\r\nYou are invited to tell of your adventures on\r\nseveral major television shows. While on one such\r\nshow, a special news flash announces to the world\r\nthe discovery of Atlantis. You regret your decision,\r\nbut you didn't really have a choice. Did you?\r\nThe End",
            "26\n33\r\nYou can't resist the adventure beneath the sea.\r\nYou must go down again, and after several weeks\r\nof rest, you enter the Seeker and slip quickly into\r\nthe deep. You bring the Seeker to rest by the great\r\ncanyon in the ocean bottom and, wearing your\r\nspecial suit, you venture out into the depths. There\r\nare no signs of the giant squid and you feel safe.\r\nRounding a rock formation, you come upon the\r\nwreck of an ancient Greek ship. How strange to\r\nfind this ship, intact, so far below the surface. What\r\nbrought it here? Was it visiting Atlantis before the\r\nlost continent slipped beneath the sea?\r\nYou take pictures and make notes in your special undersea book. Maybe this ancient ship hides\r\nthe secret to Atlantis.\r\n_______________________________________\r\nIf you go aboard\r\nthe Greek ship, turn to page 45.\r\nIf you return to the surface to\r\nreport your findings, turn to page 46.\r\n",
            "27\n34\r\nThe dolphin looks at you, and you even imagine\r\nthat he is smiling at you. You grab one of his\r\nflippers and with a powerfulswitch of his body, the\r\ndolphin swims upward. In a short time, you break\r\nthrough to the surface. You blink in the brightsun.\r\nThe Maray is nowhere in sight. You are lost far at\r\nsea.\r\nThe dolphin dives beneath the surface with you\r\nstill clinging to him. He speeds off and within 20\r\nminutes you are next to the Moray. The dolphin\r\nmust have heard the Moray's engine noises underneath the water.\r\nOnce aboard, everyone congratulates you on\r\nyour escape. You will go down again, but the\r\nthought keeps haunting you: What if your luck has\r\nrun out?\r\n______________________________________\r\nIf you decide to dive again\r\nthe next day, turn to page 48.\r\nIf you decide to give up\r\nthe expedition, turn to page 47.",
            "28\n35\r\nYou suddenly realize the stream of bubbles is\r\npowerful enough to raise the Seeker. You guide\r\nthe Seeker into the bubble stream and it heads\r\ntowards the surface. As you swirl upward, you\r\nbegin to notice increasing amounts of brown\r\nkelp— seaweed. Near the surface, you become\r\nentangled in the seaweed. The instruments in the\r\nSeeker indicate that the propellers and the steering\r\nmechanisms will not work.\r\nYou put on your sea suit and go out to see what\r\ncan be done. Once outside in the kelp, you realize\r\nthat you can't free the Seeker. You start to swim\r\nfor the surface but then you are soon completely\r\nstuck in the clinging seaweed. You are trapped and\r\nunable to go forward or return to the Seeker.\r\nIf you decide to keep struggling\r\ntowards the surface, turn to page 50.\r\nIf you decide to rest quietly,\r\ngain strength, and work out a plan,\r\nturn to page 53.",
            "29\n37\r\nThe dolphin might help and might not. You\r\ndecide to chance it alone. So, up you head, swimming towards the surface. The dolphin follows for\r\nsome time, and then swims off. You rest for awhile\r\nabout 300 feet below the surface before your final\r\nascent.\r\nThen a large fish— ugly, lumpy, puffed up, and\r\ncovered with black and white markings swims towards you. Its bulging eyes fasten on you. It is a\r\nbig-mouthed grouper, a fish which does not\r\nbother to bite its victims, butsimply swallowsthem\r\nwhole.\r\nIt looks as though you are its next meal.\r\nThe End",
            "30\n38\r\nYou decide to guide the Seeker into the new\r\npassageway to the bubble source. Suddenly the\r\nSeeker is swept downward as if pulled by a giant\r\nmagnet. You lose consciousness. When you\r\nawake, you are in a well-lighted and comfortable\r\nroom. Three people are standing close to you.\r\nThey look normal and appear to be friendly.\r\nThe middle one speaks. \"You are in the nether\r\nregion of Atlantis. Thisis a visitors'reception room.\r\nIf you wish to come into the city of Atlantis, then\r\nfollow us; but you may never return to your world.\r\nIf you wish to leave now, we will escort you safely\r\nto the surface. It is your choice. We do not wish to\r\nharm you.\"\r\n_____________________________________\r\nIf you follow them into\r\nthe city of Atlantis, turn to page 55.\r\nIf you decide to return\r\nto the surface, turn to page 51.",
            "31\n39\r\nYou are led to a room. The floors are a rich\r\nmarble. The walls glow. The ceiling is like being\r\ninside a diamond looking through the many facets.\r\nA person who immediately commands respect\r\nbeckons you with firmness and kindness to come\r\nto her.\r\n\"Welcome to Atlantis. Thousands of years ago\r\nwe learned that we were about to slip into the sea.\r\nOur people prepared for the calamity by building a\r\nnew city inside an extinct volcano. We have lived\r\nhere in peace and harmony ever since. We have\r\nno sunlight, nor stars to gaze at, but we have other\r\nspaces to meditate upon.\"\r\nShe tells you about a group of people called the\r\nNodoors. If you wish, you can live with them, but\r\nyou cannot leave Atlantis.\r\nA bearded man is to be your escort. Atlantis is a\r\nbeautiful city. Buildings merge one into another,\r\ncolors radiate light, and coral branches fill courtyards. There is a sense of well-being and peace.\r\nIt would be pleasant here, but you don't want to\r\nbe a prisoner. Maybe there would be a better\r\nchance to escape if you join the Nodoors. You ask\r\nyour guide about them.\r\n\"Oh, we believe they are dangerous, but we\r\ndon't really know. They live in the center of the old\r\nvolcano. If you wish, I can take you there.\"\r\n______________________________________\r\nIf you decide to join the Nodoors,\r\nturn to page 56.\r\nIf you decide to remain with\r\nthe Atlanteans and perhaps get a\r\nchance to escape, turn to page 57.",
            "32\n40\r\nThe Atlanteans have lived in peace for thousands\r\nof years. They have no love of warfare. Their\r\ncivilization is technologically very advanced and a\r\nsensing mechanism tells them that you are about\r\nto use your laser cannon. They quickly fire a special beam at the Seeker that makes all its functions\r\nstop. You are now powerlessto escape. They walk\r\nup calmly to the Seeker and tell you to come with\r\nthem to Atlantis.\r\n\"You are now part of Atlantis. We understand\r\nyour fear, but do not be frightened. No harm will\r\ncome to you and your life will be full. Follow us.\"\r\nAs you walk with them, into a new world, you\r\nwonder if you will ever see the sky again.\r\nThe End",
            "33\n41\r\nYou are greeted by a group of people who look\r\nlike ordinary human beings except that there are\r\ngill-like slits on their necks. Their bare feet have\r\nskin between the toes forming a web. They order\r\nyou to put on your sea suit, pull you quickly from\r\nthe Seeker, and lead you towards their city. On the\r\nway they show you the zoo where there are animals from the world above the sea. There is a\r\nglass-like cage surrounding them filled with air,\r\nallowing them to live below the sea.\r\nThe leader of the group explainsthat if you wish\r\nyou may eithersubmit to an operation to have gills\r\ninserted so that you may breathe underwater, or\r\nyou may join the other animals in the zoo.\r\n_____________________________________\r\nIf you agree to the operation,\r\nturn to page 58.\r\nIf you go to the zoo, turn to page 59.",
            "34\n42\r\nBack aboard the Seeker, you radio the Maray\r\nthat you are surfacing to make a plan. While rising\r\nout of the giant crevice-like canyon, you spot what\r\nappears to be a road running along the top of the\r\nledge. What is this? The scientists aboard the\r\nMaray had mentioned the possibilities of finding\r\nsigns of the ancient civilization, such asroads. You\r\nmust investigate.\r\n_____________________________________\r\nTurn to page 6.",
            "35\n43\r\nYou escape being seen by the submarine craft.\r\nFollowing the instructions you enter a passageway. At the end of the passageway is an airlock\r\ndoor and beyond it an incredibly large air-filled\r\ncavern. Perhaps it is the inside of an extinct volcano.\r\nThe land is pleasant, although strange to your\r\nexperience. A softsubstance covers the ground. It\r\nseems to be alive. You can't tell. A gentle light\r\ncomes from the sides of this huge cavern. It reminds you of early morning light just before the\r\nsun rises.\r\nA group of people approach you with friendly\r\ngestures. They are wearing simple clothes much\r\nlike the clothes people wore in ancient Greece.\r\nThey are kind and generous. You remove your\r\ndiving suit to find that the air is good to breathe.\r\nThese people speak a language that is unknown\r\nto you, but one of them acts as an interpreter. You\r\nfind out that this is Atlantis. They tell you it is\r\ngoverned by a man who is greedy, selfish, and\r\ndangerous. The people are like slaves. Everyone is\r\nunhappy except a few who serve the ruler as his\r\nlieutenants. These new friends ask for your help.\r\nPerhaps you can help them escape.\r\n______________________________________\r\nIf you decide to leave\r\nyour new friends and search for\r\nthe ruler, turn to page 60.\r\nIf you decide to help your\r\nnew friends escape, turn to page 61.",
            "36\n44\r\nQuickly you get into the Seeker in an attempt to\r\nescape the strange submarine. You notice that the\r\nsub is chasing you so you put on full emergency\r\nascent power. You could use your laser cannon to\r\nblast the sub, but you do not wish to hurt anyone.\r\nThe ascent towardsthe surface isswift, but a few\r\nfathoms from the surface all systems on the Seeker\r\nfail. You are suspended in the water in a helpless\r\nposition. It seems that a mysterious force has disabled you.\r\nIf you decide to wait on board\r\nthe Seeker for help from the Maray,\r\nturn to page 64.\r\nIf you try to escape from\r\nthe Seeker and try for the surface on\r\nyour own, tum to page 63.",
            "37\n45\r\nCautiously you enter the ship's cabin. Clay jugs\r\ncalled amphorae, once filled with oils and wines, are\r\nstrewn about. There are no remains of the crew.\r\nYou do have a sense of being in ancient Greece\r\nand it is a strange feeling.\r\nA door leads to a smaller cabin. On a table near\r\nthe rear of this cabin is a golden box. You open it\r\nand find the remains of a map. It does not show\r\nAtlantis. It shows that the ship was searching for a\r\nhole that leads to the center of the earth!\r\nYou return to the Seeker and use the map to\r\nlocate this incredible shaft to the center of the\r\nearth. Using some guesswork to interpret the map,\r\nyou discover the tunnel opening, which appears to\r\nbe roughly 100 feet in diameter. The sonar\r\nreadings indicate the hole has no bottom.\r\n_____________________________________\r\nIf you decide to descend into the hole,\r\nturn to page 65.\r\nIf you decide it is time to go\r\nback up to the surface, turn to page 66.\r\n46\r\nThe trip back to the surface is smooth, and\r\nfinally the Seekeris hauled aboard the Maray. You\r\nclimb out and are greeted by the scientists and\r\ncrew. The Seeker is prepared for the second dive,\r\nbut suddenly the wind rises and the sea kicks up\r\ninto furious waves that crash over the deck of the\r\nMaray. All hands rush to prepare for hurricane\r\nforce winds. There is no chance for the second\r\ndive to begin. All day and all night the Maray\r\npitches on the stormy sea.\r\nThe next morning the wind has died and the sky\r\nclear. You are now ready to dive again.\r\n_____________________________________\r\nTurn to page 48.",
            "38\n47\r\nA helicopter is sent to pick you up and return\r\nyou to an air base for a flight back to the United\r\nStates. Newspaper reports indicate that the search\r\nfor Atlantis has been given up. Several months\r\nlater, however, a group of scientists get in touch\r\nwith you because they believe that Atlantis can be\r\nfound. They have put together another expedition\r\nand want you to join it. You are tempted. Adventure into the unknown is what you like.\r\nThe End\r\n48\r\nAgain the Seeker is lowered over the side of the\r\nMaray and slipsinto the ocean. Fish swim by peering cautiously at you in your metal shell. The sunlight fades as you descend into the abyss.\r\nYou are headed for the giant canyon below that\r\nmight lead to Atlantis. When you reach the canyon\r\nyou switch on the Seeker's searchlight. Immediately you spot the round hole that appears to\r\nbe made by intelligent beings. Perhaps it leads to\r\nAtlantis.\r\n________________________________________\r\nTurn to page 9.",
            "39\n50\r\nYou are dizzy from lack of oxygen and fatigue.\r\nWith your knife you slash away at the heavy brown\r\nkelp thatsurrounds you. Bit by bit, you seem to be\r\ngetting free. Then suddenly you shoot up through\r\nthe last clinging pieces of seaweed and reach the\r\nsurface. You fire the special signal flare and the\r\ncrew of the Maray quickly spot you. Within a few\r\nmoments you are safely aboard, surrounded by\r\nyour friends. What a relief to be out of that nightmare world!\r\n_______________________________________\r\nIf you dive again the next day,\r\nturn to page 67.\r\nIf you want to rest a few days and\r\nmake emergency plans, turn to page 68.",
            "40\n51\r\nThe three people of Atlantis sense your wish to\r\nreturn to the surface. Instantly, they produce a\r\nbubble-shaped capsule and put you inside.\r\n\"Farewell, earth person. May you live a long\r\nand prosperous life.\"\r\nYou shoot up swiftly through the sea and break\r\nout onto the surface near the Maray. The capsule\r\nthat protected you disintegrates upon reaching the\r\nsurface. Once aboard the Maray, you tell the crew\r\nand the scientists about your adventure. They are\r\nkind to you, but no one believes you. They think\r\nyou have imagined the world of Atlantis as a result\r\nof being so deep for so long.\r\nBack in the United States, you begin a television\r\ntour telling about Atlantis. You write articles and a\r\nbook. You are paid a great deal of money for this\r\nwork. You are tempted to use this money for\r\nanother expedition.\r\n______________________________________\r\nIf you use your money for\r\nanother expedition, turn to page 72.\r\nIf you decide to retire and\r\nlead a life of ease, turn to page 74.",
            "41\n53\r\nThe worst thing you could do would be to panic.\r\nYou relax and drift with the current which suddenly takes you upward. With your knife, you cut\r\nthrough the kelp and are free. What a relief.\r\nBut no sooner do you get out of the kelp, than\r\nyou are caught in the vortex of a giant whirlpool!\r\n_______________________________________\r\nIf you try to swim out\r\nof the whirlpool, turn to page 69.\r\nIf you dive into the vortex of\r\nthe whirlpool hoping to reach the bottom\r\nand get out, turn to page 70.",
            "42\n55\r\nThe three people lead you into an enormous\r\ncavern. In the center of the cavern is a huge,\r\nsilver-colored machine. It isshaped like a long tube\r\nwith several round panels attached to one end.\r\nThey lead you inside. It is the most advanced\r\ncontrol room that you have everseen. Computers,\r\nsensing devices, recording devices, monitors, and\r\na host of dials and panels fill the room. A strangely\r\nshaped figure with a very large head and totally\r\nblank eyes faces you.\r\n\"So, now you are in the control room of Atlantis. You see our secret. We landed on this planet\r\n3000 years ago. We used our anti-matter device to\r\nsink this continent beneath the sea so we could\r\nescape from your people. You can have a most\r\npleasant and useful life here with us if you wish. All\r\nyou need to do is allow us to inject you with a\r\nspecial serum to enable you to live down here. It is\r\nup to you. On the other hand, if you do not wish to\r\nbe one of us, you will be held prisoner.\"\r\n_____________________________________\r\nIf you submit to the injection,\r\nturn to page 71.\r\nIf you decline, turn to page 73.",
            "43\n56\r\n\"I wish to join the Nodoors,\" you tell your\r\nguide. He leads you to the outskirts of the city.\r\n\"I must leave you now. Good luck.\" The\r\nNodoors send a greeting party that is heavily\r\narmed. They are suspicious of you and believe that\r\nyou are a spy sent by the Atlanteans. They look\r\nexactly like the Atlanteans, but they rarely smile.\r\n\"Come with us. You must be questioned.\r\nPerhaps you will work for us.\"\r\nFor 3 days you are questioned and kept in a\r\nsmall room without windows. These people are\r\nnot kind and you believe that you have made a\r\nmistake. They ask you to help them spy on the\r\nAtlanteans. They suggest that, as a spy, you could\r\npass freely between both groups.\r\n_____________________________________\r\nIf you decide to escape, turn to page 75.\r\nIf you decide to accept their offer,\r\nturn to page 76.",
            "44\n57\r\nYou decide to remain with the Atlanteans. Their\r\napproach to life seemsideal. Time isspent in creating things to help life and not to destroy it. You\r\nbelieve their leader is speaking the truth when she\r\ntells of avoiding war and of not hating.\r\nYou are fascinated by this apparently ideal\r\nworld. You would like to stay and search out the\r\nhistory of how Atlantis became what it is and what\r\ncaused the split between the Atlanteans and the\r\nNodoors. Yet, in your mind remains the hope of\r\nescape so that you can go back to your own world.\r\n_________________________________________\r\nIf you decide to stay and spend\r\nyourlife searching out the history and\r\nsecrets of Atlantis, turn to page 77.\r\nIf you decide to escape, turn to page 79.",
            "45\n58\r\nA large white lightshines down on you as you lie\r\non the operating table. Then you become unconscious. Pleasant thoughts, sounds, and pictures\r\noccupy your mind. When you awake, you feel no\r\npain nor any real change. But, now you can\r\nbreathe underwater and join the Atlanteans in\r\ntheir world.\r\nFor several weeks you explore the world under\r\nthe sea as you never have seen it before. Without\r\nthe heavy oxygen equipment on your back, you\r\nfeel a marvelous sense of energy and you glide\r\nthrough a world of beauty. Your two guides have\r\nbecome very good friends and they take you on\r\nadventures in the deep, exploring the ocean bottom and getting to know the fish and other sea\r\ncreatures. It is a very exciting life indeed. You like\r\nit, but you regret that you will never again know\r\nthe world above the sea.\r\nThe End",
            "46\n59\r\n\"No, I refuse to have this insane operation. I\r\ndon't want to become a fish!\"\r\nThe Atlanteans try to convince you that life with\r\nthem will be happy, useful, and long. Yet, you still\r\nrefuse. Sadly they give up their arguments and\r\nspray you with a special mist that immediately\r\nknocks you out. Several hours later you gain your\r\nsenses only to find that you are in an underwater\r\nair tank where you breathe naturally. Your closest\r\nneighbor is a horse who looks at you with sorrow\r\nand understanding. The Atlanteans have built a\r\nsmall apartment very much like the ones in the\r\nworld above the sea. People come by and look at\r\nyou and talk with you.\r\nMaybe you have made a real mistake. They no\r\nlonger want you to join them in their world and\r\nway of life. You refused their offer and now you\r\nare a prisoner in a zoo.\r\nThe End",
            "47\n60\r\nIt doesn't take you long to find the king. One of\r\nhis countless agents leads you to him. He is in a\r\nsmall simple room with a strange light glowing\r\nfrom the rounded ceiling.\r\n\"So, you have found your way here after all. Put\r\nyour mind at rest. I won't hurt you.\" The king's\r\nbooming voice startles you. He invites you to sit\r\ndown.\r\nAfter several hours with the king, you find him to\r\nbe bright, friendly, and interesting. Maybe the Atlanteans are wrong about this person.\r\nHe offers you a chance to join his government.\r\nHe tells you that most people are lazy and selfish\r\nand deserve to be ruled with power and command. He has been king for almost 1000 years\r\nand he has survived because he is not afraid to be\r\ntough. He wants you to be an advisor on his staff.\r\n________________________________________\r\nIf you decide to accept the king's\r\noffer and work for him, turn to page 80.\r\nIf you decide to refuse and\r\ngo back to join the other people,\r\nturn to page 82.",
            "48\n61\r\nThe problem is where do they escape to? The\r\nking is in charge. He rules the world below the sea\r\nand his spies are everywhere. The only answer is\r\nto devise a plan to capture the king and put him in\r\nprison.\r\nThe people are frightened. Some citizens tried\r\nto revolt years before and are still in prison. The\r\nking is smart and suspicious of everyone.\r\nYou suggest a plan to put on a festival with a\r\nplay. On a given signal the actors and the people in\r\nthe audience will rise up and seize the king. The\r\nactors will be carrying real weapons, but no one\r\nwill suspect them because they are in the play.\r\nThe people like the plan. They ask you to become their leader.\r\n______________________________________\r\nIf you accept their wish to\r\nbecome their leader, turn to page 81.\r\nIf you decide to help them in\r\nthe planning, but also to escape from\r\nthis sad world, turn to page 86.",
            "49\n63\r\nThere is one way out, you decide. Leave the\r\nSeeker and try to reach the surface on your own.\r\nYou enter the airlock chamber which gives you\r\naccess to the ocean. With a quick push off, you\r\nleave the Seeker and swim towards the surface. A\r\nsmall, yellow life raft is part of your escape equipment. The surface of the sea is calm, but the Maray\r\nis nowhere in sight.\r\nFor 2 days and nights you drift in the life raft\r\nunder hot sun and sharp starlight. At last a search\r\nhelicopter spots you. Finally you are safe.\r\nThe exploration of Atlantis will have to depend\r\non a new diver. Your eyesight has been damaged\r\nby the strange force that immobilized the Seeker.\r\nYou career as an underwater adventurer is over.\r\nThe End",
            "50\n64\r\nThe best plan is to wait until the Maray locates\r\nyou with sonar equipment. You can't signal the\r\nship because none of the Seeker's electronic\r\nequipment is working. There is no sign of the\r\nmysterious submarine. Perhaps it has left, now\r\nthat you have been chased away from the world of\r\nAtlantis.\r\nLooking out of the thick glass porthole, you see\r\na giant blue whale heading for you. It looks as\r\nthough the whale is going to ram you. Maybe the\r\nother submarine has angered the whale and it is\r\nseeking revenge on any craft near it.\r\nSuddenly the whale hits you full force. The\r\nSeeker is badly damaged. Water begins to trickle\r\nin through the hatch cover. You must abandon the\r\nSeeker. The whale now remains close to the\r\nSeeker watching and waiting.\r\n______________________________________\r\nIf you decide to try and escape,\r\nturn to page 63.\r\nIf you try to hitch a ride on the whale,\r\nturn to page 85.\r\nIf you don't know what to do,\r\nturn to page 87.",
            "51\n65\r\nWhy not go? Who would believe it? The center\r\nof the earth! You push the control column forward\r\nand dive deep. Soon there is no more water, just a\r\nheavy gas that acts like water. You look at a world\r\nof colors and drifting forms. You pass by layers of\r\nrock and sand. Suddenly you sail into a gooey\r\nmass which almost fouls the Seeker's propellers.\r\nThen the Seeker's engine stops and you are pulled\r\nalong through the semi-liquid material by something like gravity or magnetism. You burst through\r\na thick elastic membrane and enter an area of giant\r\natoms. Electrons whirl around you at high speed,\r\nbut there is plenty of room to maneuver between\r\nthese fast-moving particles. The electrons are revolving around a small mass you know is called the\r\nnucleus. You are able to avoid collisions with the\r\nelectrons. What a world! Maybe you are having\r\nhallucinations.\r\n________________________________________\r\nIf you continue on in this trip\r\nto the center of the earth, turn to page 88.\r\nIf you try to turn back, turn to page 89.",
            "52\n66\r\nYou face the fact that it is too dangerous to dive\r\ninto a deep hole that might lead to the center of the\r\nearth. It is better judgment to return to the surface\r\nand work out a plan of action.\r\nYou give one last look at the opening, check the\r\nSeeker's instruments and head up to the surface.\r\nFinally the Seeker breaks through into fresh air\r\nand sunlight and you wait to be picked up by the\r\nMaray.\r\n_________________________________________\r\nTurn to page 32.",
            "53\n67\r\nYou insist that you are all right and will dive\r\nagain the next day. The scientists try to convince\r\nyou that it is foolhardy to go down again so soon.\r\nThe captain of the Maray reportsthat a large storm\r\nsystem is coming and the next day will probably be\r\nthe last day of diving for some time.\r\nAgainst advice, you enter the Seeker, wave\r\nfarewell to all your friends and descend into the\r\ndeep. You feel tired but excited.\r\nWhen you reach the bottom, you decide to\r\nexplore the ledge along the deep canyon.\r\n_____________________________________\r\nTurn to page 6.",
            "54\n68\r\nA violent storm is reported heading your way.\r\nThe captain decides to move the Maray to the\r\nshelter of a nearby island harbor. It is too dangerous to remain where you are. Deckhands lash the\r\nSeeker securely to the deck of the Moray and you\r\nget underway.\r\nThe storm breaks before you can reach the\r\nisland harbor. The Seeker is torn loose and lost\r\noverboard. The monitors aboard the Maray are\r\ndamaged by a frightful electric storm discharge.\r\nYou are all alive but there are no funds to replace\r\nthe damaged equipment. The expedition to Atlantis is over.\r\nThe End",
            "55\n69\r\nIt is no use. The whirlpool has you in its grip.\r\nYou feel your arms and legs being torn in every\r\ndirection. There is no way out. Round and round\r\nyou go.\r\n_______________________________________\r\nIf you use your laser pistol to\r\nblast a hole in the whirlpool wall,\r\nturn to page 97.\r\nIf you continue to struggle,\r\nturn to page 98.",
            "56\n70\r\nYou decide that you can't swim out of the\r\nwhirlpool. There is only one thing to do. Dive deep\r\ninto the center.\r\nYou kick several times and hurl yourself into the\r\ncenter of the whirlpool. Lights and colors dance\r\nbefore your eyes. You lose all track of where you\r\nare. You find yourself standing on the ocean floor.\r\nYou can look up through the center of the\r\nwhirlpool and see the sky more than 2000 feet\r\nabove you. It is a tiny patch of blue.\r\n______________________________________\r\nIf you try to return to\r\nthe surface, turn to page 99.\r\nIf you set out to explore\r\nthis strange area, turn to page 100.",
            "57\n71\r\nPerhaps you are being foolish, but you decide to\r\njoin them. The injection is painless and you feel no\r\ndifferent than before. They lead you to a comfortable room where you all share a special tea in\r\ncelebration of your decision.\r\n\"You see, all living beings are basically the\r\nsame. Everything is connected in life. We have\r\ncome from a different planet in search of other\r\nliving beings. We have to be very careful about\r\ntaking new people to our planet. Some of your\r\npeople seek us out, just like you. We choose carefully.\"\r\nYou are amazed at what they say. A choice is\r\ngiven to you. You can either journey with them\r\nthrough time and space to their planet, or you can\r\nremain in underwater Atlantis as a worker recording information about life on earth.\r\n_______________________________________\r\nIf you decide to travel\r\nwith them in space and time,\r\nturn to page 90.\r\nIf you decide to stay in Atlantis\r\nas a worker, turn to page 91.",
            "58\n72\r\nThe only way to prove that you are not crazy is\r\nto lead another expedition back to Atlantis. You\r\ntake all the money from the TV appearances and\r\narticles and outfit a boat, hire a crew, rent the\r\nSeeker, and set sail. Most people think that you are\r\nout of your mind. You will show them.\r\nPoised over the spot you so carefully marked on\r\nthe charts, you dive down in the Seeker. Again you\r\nfind the hidden grotto and the round metal panel.\r\nThe panel seems to seal off a passageway. It is\r\nlocked. You try to open it with the Seeker's drilling\r\narm, but it will not budge. It is frustrating to be so\r\nclose to the secret and yet so far from it.\r\n_______________________________________\r\nShould you blast the panel with\r\nthe laser beam? Ifso, turn to page 93.\r\nIf you wait patiently to be\r\nobserved and asked in, turn to page 94.",
            "59\n73\r\nThe idea of being injected with a serum and\r\njoining them for the rest of your life is awful. You\r\nmust plan an escape.\r\nWhen your captors are not looking, you slip\r\naway and dash for the door of the space craft. You\r\nfail to notice a laser beam guarding the exit hatch.\r\nStepping into the laser beam, you freeze in midstep. The Atlanteans gather round you sadly and\r\ntell you that you will have to remain this way for the\r\nearth equivalent of 23 years and 61 days until the\r\neffects wear off. Then you will be given a second\r\nchance.\r\nThe End",
            "60\n74\r\nYou argue with yourself for several weeks about\r\nsetting out on a new expedition. Money is not the\r\nissue. You fear that finding Atlantis will ruin it for\r\nthe Atlanteans. You believe that their civilization\r\nmust be protected. You decide to use the money\r\nyou have made to carry on research on space and\r\nlife on planets in other galaxies. Someday perhaps\r\nyou will meet the Atlanteans in space.\r\nThe End\r\nIf you don't like this ending,\r\nturn to page 107.",
            "61\n75\r\nEscape will be difficult, but you decide that you\r\nmust get away from these people. The best plan is\r\nto tell them that you want to accept their offer to\r\nspy on the Atlanteans. They are of course happy\r\nwhen you tell them that you will work for them.\r\n\"You see, the Atlanteans are jealous of us. We\r\nmust be on our guard or else they will invade our\r\narea and capture us.\"\r\nYou don't believe the Atlanteans are at all jealous of the Nodoors, but you won't argue. They\r\ntake you back to the outskirts of their area, and you\r\nleave to join the Atlanteans. Once back with the\r\nAtlanteans, you ask them to allow you to live with\r\nthem. You know that you will never be allowed to\r\nleave their underwater world, but there is always\r\nthe hope for escape. It could be a good life.\r\nThe End",
            "62\n76\r\n\"Ok, I'll do it,\" you say. \"I'll join you and spy on\r\nthe Atlanteans for you. Who knows, maybe they\r\naren't as bad as you think.\"\r\nThe Nodoors are delighted that you will help\r\nthem. They give you a room in a large building\r\nwhere most of them live. It is grey and forbidding,\r\nmore like a prison than anything else. That night\r\nwhen all are asleep, you sit sleepless and realize\r\nthat you are caught in a trap of your own making. It\r\ncomes to you that the Nodoors are from a different\r\nplanet and are unhappy outcasts. The Atlanteans\r\nwant nothing to do with them. You chose the\r\nwrong side.\r\nThe End\r\nIf you don't like this ending,\r\nturn to page 108.",
            "63\n77\r\nMaybe you can learn from the Atlanteans how\r\nthey achieve such happinessin their lives. You will\r\nseek out their history.\r\nWhen you announce your decision to stay, you\r\nare treated with kindness and friendship. You explain that you would like to help in their underwater food production.\r\nAtlantis was an advanced civilization thousands\r\nof years ago. The citizens nourished their peaceful\r\nthoughts and plucked out their hateful thoughts as\r\none would tend a garden. Their minds became a\r\nrich and dazzling universe, clear and unbounded.\r\nYou have so much to do, helping with sea plants\r\nand studying their history that you soon forget the\r\nSeeker.\r\nThe End",
            "64\n79\r\nWhen you get a chance and everyone is doing\r\nother things, you dash for the tunnel exit and make\r\nit out into the water. No alarms sound. No one\r\nchases you. It is strange; they said they wouldn't\r\nallow you to return to the world above the sea.\r\nWhy are they letting you escape?\r\nYou swim toward the surface; then you black\r\nout. It is too deep. No one could survive the pressure and lack of oxygen. But a miracle has happened because you suddenly find yourself hacking\r\naway at brown seaweed that surrounds you and\r\nyou are just a short way from the surface.\r\n______________________________________\r\nTurn to page 50.",
            "65\n80\r\nAn advisor to a king! What a chance. Maybe the\r\nking has ruled so long that he is out of touch with\r\nthe people. Perhaps as his advisor you can help\r\nthe people get what they want. You don't believe\r\nthat people are lazy and selfish. The king just needs\r\na new point of view.\r\nYou are appointed the king's special advisor on\r\nproblems of research on food and shelter. You\r\nimmediately call general meetings of all the people\r\nto discuss the food program and the work\r\nschedules. The king is so glad to have someone\r\nelse take over the problemsthat he leavesit in your\r\nhands entirely. He gives you land and a large\r\nsalary. You set up new programs and schedules.\r\nThe people are involved in the planning and the\r\nwork. You listen to their complaints and their\r\nideas. Life under the sea is rich and full. The\r\npeople are hard working and good. It was a wise\r\ndecision to remain.\r\nThe End",
            "66\n81\r\nYou do not wish to lead a revolt but the people\r\nneed you. You organize the play, and the king is\r\npleased to have his people involved in a project\r\nthat keeps them busy and happy. The people can't\r\nwait for the day when they can put the king in\r\nprison and make their own decisions.\r\nThe night of the play, the theater is filled, and\r\neveryone waits for the king to appear. But there is\r\na delay. The crowd grows nervous. Then a messenger from the king runs into the theater and\r\nannouncesthat the king has had a serious attack of\r\nbrain fever. He may not live.\r\nYou wonder whether the king is really ill or\r\nwhether he has found out about the plot against\r\nhim. The people are confused and do not know\r\nwhat to do. They turn to you and you tell them to\r\ngo on with the play.Just then, a squad of the king's\r\nsoldiers enter the theater. They are headed for\r\nyou.\r\n_______________________________________\r\nIf you allow them to capture you,\r\nturn to page 116.\r\nIf you try to escape, turn to page 117.",
            "67\n82\r\nAdvisor to a mean king? Not a chance! You tell\r\nhim that you want nothing to do with a tyrant who\r\ndoesn't believe in people. You tell him to his face\r\nthat the people are unhappy and angry. He laughs\r\nand tells you to go back to them if you wish. He\r\nwarns you that the people are complainers, not\r\nworkers.\r\nOnce back with your new friends, you discuss\r\nhow to overthrow the king and his henchmen. You\r\nhold secret meetings and work out a plan. But on\r\nthe day of the overthrow, someone discovers a\r\nleak in the volcano wall of the underwater world.\r\nThe entire civilization is in danger. All thoughts of\r\nrevolt are forgotten. The Atlanteans must stop the\r\nsea from crashing in on them. Everyone works for\r\na common purpose. Survival is the goal.\r\n______________________________________\r\nIf you decide to work with them\r\nin this time of disaster, turn to page 112.\r\nIf you decide to take advantage of\r\nthis emergency to escape, turn to page 114.",
            "68\n85\r\nPeople ride dolphins, and you have met scuba\r\ndivers who reported they held onto the flukes of\r\nwhalesforshort rides. Itsounds crazy, but this may\r\nbe your only way of escape. You leave the Seeker,\r\nswim to the whale, and grab its fluke. With a\r\nsmooth powerful movement, the giant mammal\r\nbegins to swim to the surface. You have trouble\r\nholding on. Then the whale breaksthe surface and\r\nlies there filling its lungs with air. You quietly swim\r\naway.\r\nYou drift for 2 or 3 days, dozing and waking\r\ncomfortably. You stay warm in your insulated sea\r\nsuit and its special air packs keep you afloat. You\r\nare hungry and thirsty, but unharmed by the time\r\nthe search helicopter spots you bobbing in the\r\nwaves.\r\nThe End",
            "69\n86\r\nIt is their world, but you are willing to help them\r\nwith the planning for the overthrow of the king.\r\nYou want no real part in the revolt.\r\nThe planning requires choosing new leaders\r\nand setting goals for the people. You almost decide to join them in the actual revolt, but you really\r\nwant to get back to your own world. Once the\r\nrevolt is underway, you hope to slip away and\r\nreturn to the Seeker for a quick escape to the\r\nsurface of the ocean.\r\nThe day of the revolt, you can't resist the excitement of the Atlanteans'bold enterprise, and\r\nyou decide to stay with them and help in any way\r\nthat you can. The endless planning and training\r\npays off. The carefully selected band of men and\r\nwomen easily capture the king and his guards. The\r\nrevolt has succeeded without shedding a drop of\r\nblood and the people celebrate for days.\r\nThe Atlanteans treat you as if you are one of\r\nthem, and, for the first time, you feel that you are.\r\nThe End",
            "70\n87\r\nYou admit that you just don't know what to do.\r\nThe whale is frightening looking and you don't\r\nhave any escape plans. So you wait and watch and\r\nlisten.\r\nAfter what seems a long time, but is probably\r\njust a few minutes, the mysterious submarine returns, attaches a cable to the Seeker, and pulls you\r\nup to the surface. Then the submarine vanishes\r\nunder the wavesleaving you to wait for the Maray.\r\nThe End",
            "71\n88\r\nThe electrons whirl about at dizzy speeds and\r\nyou continue until you get to a spot where your\r\ninstruments indicate that there is no time. The\r\nclocks stop, the speed indicator stops, your heart\r\nstops, and yet you are alive. Every sense in your\r\nbody seems more alive than ever before. You hear\r\nbeautiful music and see lights that you feel and\r\ntaste as well. Peace and well-being fill you.\r\nYou become aware of other beings close to you.\r\nNo one has entered through the only hatch and yet\r\nthere are other presences in the Seeker. Turning\r\naround, you see three Atlanteans. Then you feel\r\nthat the Seeker has become just a thought and that\r\nthe people from Atlantis have entered your mind\r\nand are aboard the Seeker. You try to enter their\r\nthoughts, but they tell you that you have not journeyed far enough yet to be able to become a\r\nthought-traveler.\r\n_______________________________________\r\nIf you try to turn back from\r\nthisstrange world, turn to page 95.\r\nIf you decide to travel in\r\nthought-time-space, turn to page 96.",
            "72\n89\r\nNo, you will not dive down toward the center of\r\nthe earth. Once through the thin outer layer of the\r\nearth, you know that the regions beneath change\r\nfrom solid to molten and then to a hard core. At\r\nleast that is the theory given by the scientists. You\r\ncouldn't possibly survive such a journey. Anyway,\r\nyou think that your sonar gear is probably not\r\nworking correctly. The hole is deep, but you don't\r\nbelieve that it really goes all the way to the center of\r\nthe earth. Caution is your approach. You go back\r\nto the surface to consult with the scientists aboard\r\nthe Moray.\r\nThe scientiststell you that their instruments have\r\nbeen damaged, perhaps by an approaching storm,\r\nand they too, are cautious. They decide to move\r\nthe Maray away from the site of the mysterious\r\nhole. The expedition retreats and you know your\r\nchance to discover Atlantis has slipped away.\r\nThe End",
            "73\n90\r\n\"I will go with you. I want to see other parts of\r\nthe universe.\"\r\n\"Congratulations. You will not regret this. We\r\nare ready to depart.\"\r\nThey take you to a small room and three of them\r\nstand with you under a beam of intense light. You\r\nfeel a rush of speed, and yet you are not moving.\r\nYou feel as though you have traveled hundreds of\r\nthousands of milesin space. You rush past the sun,\r\npast and through the Milky Way, and on into other\r\ngalaxies. Yet, you feel asthough you are stillstanding in the same spot.\r\nThen you are on the planet Aygr where the\r\nAtlanteans came from. It is a world of fantastic\r\nshapes and strange plants. The city gleams like a\r\nthousand search lights. The shapes that must be\r\ntheir buildings are pure light pulsing with energy.\r\nNothing is hard or sharp. Everything is light. You\r\nsee no people, just forms of brighter light that\r\nmove. Suddenly, some of the moving forms\r\nchange into Atlanteans.\r\n\"Our bodies are not important. It is our energy\r\nthat isimportant. You can see usin our body forms\r\nif you wish, but we only use them to communicate\r\nwith people like you. You may choose to remain as\r\nyou are or accept transformation.\"\r\n______________________________________\r\nIf you decide to stay in\r\nyour body form, turn to page 101.\r\nIf you decide to\r\nbe transformed into an energy shape,\r\nturn to page 102.",
            "74\n91\r\nYou have had enough adventure for now.\r\nTravel to another planet in a different galaxy\r\nsounds like more risk than you wish to take. Besides, you can always go later.\r\nYou tell the people that you wish to stay and\r\nwork in their society. Perhaps your knowledge of\r\nthe sea can help them. They discuss your case very\r\nseriously for several days. When they are through\r\ntalking, they offer you a choice of jobs in Atlantis.\r\nYou may become a farmer or a musician.\r\n______________________________________\r\nIf you decide to become an\r\nunderwater farmer, turn to page 103.\r\nIf you decide to become\r\na musician, turn to page 104.",
            "75\n93\r\nYou'll try to blast the hatch right off its hinges.\r\nYou have the power. Your finger presses the red\r\nbutton that fires the laser cannon. A blinding flash\r\nerupts immediately. But the hatch remains firm.\r\nYou fire again and again and again. Each time the\r\nSeeker is rocked by the force of the laser cannon.\r\nThe reflected energy is damaging to your craft.\r\nYou continue to fire the cannon, holding your\r\nfinger on the button.\r\nThen there is a blinding flash inside the Seeker\r\nitself. The laser cannon has exploded. You and the\r\nSeeker are destroyed instantly. The hatch remains\r\nclosed.\r\nThe End",
            "76\n94\r\nIt is never good to use force unless you are\r\nattacked and must defend yourself. You refuse\r\neven to consider using the laser cannon; it might\r\nkill people and would certainly destroy any chance\r\nfor friendship. You decide to wait patiently and\r\nhope that you will be noticed and invited in.\r\nFor six hours you sit quietly and wait for some\r\nsign. A green glow comes from the area ahead of\r\nyou. It bathes the Seeker in a gentle light. The\r\nhatch door opens. Three figures emerge and\r\nbeckon to you to follow them.\r\n______________________________________\r\nIf you follow, turn to page 105.\r\nIf you refuse to follow them,\r\nturn to page 106.",
            "77\n95\r\nThis is too much for you. It is like a nightmare\r\nand you decide to turn back. But going back is\r\nmuch harder than you expected. The electrons\r\nwhirl closer and closer to you as though they were\r\nguards keeping you from leaving. It is difficult to\r\nguide the Seeker in this maze of atoms. The instruments are useless now. The figures of the Atlanteans disappear. Suddenly, you are caught in\r\nthe elastic membrane that almost stopped you\r\nbefore. It sticks to the Seeker, holding you back.\r\nYou want to be free and return to the world you\r\nhave known all your life.\r\nYou lose consciousness and wake up several\r\nhours later in your sea suit floating above the hole\r\nin the ocean floor. The Seeker is gone. You're\r\ndazed: did you dream the whole thing? Slowly you\r\nreturn to the surface, but the Maray has disappeared. You can't decide how much time has\r\nelapsed. You realize that your crew must think you\r\nare lost forever and you know they are right. The\r\nwaves rock your unresisting body back and forth\r\nas you float alone in the vast sea. You feel your\r\nstrength slowly draining away.\r\nThe End",
            "78\n96\r\nA thought traveler! You realize that people do it\r\nall the time in day dreams. Of course, you want to\r\nbe a thought traveler, but how?\r\nThe Atlanteans speak softly and tell you that all\r\nthings are the same— past, present, future are all\r\nthe same. It simply requires you to concentrate\r\nand put your thoughts where you wish them to be.\r\nYou try, and amazingly you are rapidly rushed\r\nthrough time to the day you were born, then to the\r\nday you made your first deep-sea dive. Your mind\r\nflies from one time in your life to another. But\r\nwhen it comesto the future, you meet a blank wall.\r\nYou can't seem to travel into the future.\r\n\"Why can't I travel ahead in time,\" you ask the\r\nAtlanteans.\r\n\"Be patient,\" they reply. \"All in good time.\"\r\nSuddenly you whirl through time into the outer\r\nreaches of the universe where you can actually feel\r\nthe light going through you. You cast no shadow.\r\nA sense of peace fills you.\r\n______________________________________\r\nIf you decide to drop out of\r\nthought travel and return to earth\r\nlife, turn to page 110.\r\nIf not, The End.",
            "79\n97\r\nYou have a laser pistol that you carry for\r\nemergencies. You blast a hole in the whirlpool wall\r\nand dive through it. Facing you is a school of fish\r\nwho are puzzled by this strange intruder. Behind\r\nthem lurks the form of a shark. You swim toward\r\nthe surface slowly and the shark vanishes into the\r\ndeep.\r\nThe Maray is nowhere in sight. You are wondering how long you'll be waiting when a loud splashing sighing sound startles you. A huge whale has\r\nsurfaced and lies nearby spouting and sucking in\r\ngreat noisy draughts of air. It take you a good half\r\nhour to swim to the enormous creature. It pays no\r\nattention to you. You climb onto its tail and crawl\r\non hands and knees toward the highest point of its\r\nback. It's like creeping up a gigantic grey rock.\r\nFrom your vantage point on top, sure enough,\r\nyou can see the Moray and the tiny glint of binocular lenses reflecting in the sun. The Maray crew is\r\nwatching the whale. You wave, feeling certain they\r\nhave seen you. It won't be long before they come\r\nto collect you.\r\nThe End",
            "80\n98\r\nYou faint, and when you come to, you are\r\nfloating on the surface of the ocean. There is a\r\nheavy ocean swell and the sun beats down on you.\r\nThe whirlpool must have stopped as quickly and\r\nmysteriously as it began. You feel dizzy and\r\nexhausted and you move gently to make sure you\r\nhaven't broken any bones. As you move your\r\nhead slowly inside your helmet, you feel an intense\r\npain shooting across your right temple. You have\r\nto lie very still then and gradually your ears pick up\r\nthe thrum of the search helicopter. You don't dare\r\nmove to look, but as the minutes go by, the thrum\r\ngets louder and slowly disappears. The helicopter\r\nhas passed over you. It won't return this way. The\r\npain in your temple increases. You begin to lose\r\nconsciousness.\r\nThe End",
            "81\n99\r\nThe walls of the whirlpool look like solid ridges\r\nsloping upwards to the surface. The water is rushing so fast that the center looks absolutely calm.\r\nYou wonder if perhaps you could swim up through\r\nthat calm. It's worth a try, and you set off. Before\r\nyou can tell if you're making any progress, the\r\nwhirlpool reverses and instead of whirling down, it\r\nwhirls up and catapults you out of the ocean and\r\ninto the air. You fall back onto the surface of the\r\nocean close to the Maray. Although you are\r\nstunned by the fall, you quickly gain your senses\r\nand are picked up by the ship. Of course no one\r\nbelieves your story, but then even you think it is\r\nalmost too fantastic to have happened.\r\nThe End",
            "82\n100\r\nThe ocean floor has a small metal hatch on it.\r\nYou pull with all your strength but it will not open.\r\nYou rest for a moment and look through the wall of\r\nwatersurrounding you. Two fish stare back at you!\r\nIt's asthough you are in an aquarium for the fish to\r\nlook at.\r\nYou don't hear the hatch open. A voice commands you to enter. With fear and caution you\r\nwalk down a corridor that leads to a small room.\r\nThree people meet you.\r\n_____________________________________\r\nTurn to page 55.",
            "83\n101\r\nYou just can't give up your body. It might be all\r\nright for the Atlanteans to move about as pure\r\nenergy, but you have not reached a point where\r\nyou are willing to risk what you are for what they\r\nare.\r\nIt isstrange wandering about with bright glowing\r\nblobs of energy moving with you. They ask you to\r\ngive talks about life on earth as you know it, and\r\nyou agree. For two years you meet with the Atlanteans in their energy forms and talk about earth\r\nand how people live and what they do. The Atlanteans are interested in all aspects of earth life: the\r\ntechnology, politics, wars, and religion.\r\nYou ask them why, but they never give you a\r\ndirect answer. Then one day you look down at\r\nyourself and you only see bright, glowing energy.\r\nWith horror you realize you have become one of\r\nthem.\r\nThe End",
            "84\n102\r\nYou are in the Atlantean world; why not become like an Atlantean? Looking down at your\r\nhands, you see them gradually begin to glow with\r\na warm, yellow light. Little by little, the glow travels\r\nup your arms and legs until suddenly you have no\r\nbody left. You are a glowing energy form. You feel\r\na sense of freedom and happiness that you have\r\nnever known before. You can float, or fly, or zoom\r\nanywhere you want to. No wallsstop you; you just\r\nmelt through them. You don't need food or rest.\r\nYou can travel through time, and you can travel\r\ninstantly back to earth in your energy form.\r\nYou feel that this is the way you want to be.\r\nThe End",
            "85\n103\r\nFarming under the sea is a job that you enjoy.\r\nOutside Atlantis, there are fields of sea plants that\r\nare worked on just like gardens above the sea.\r\nAtlanteans go out each day and harvest the plants,\r\ntake care of the fields, and chase away the fish that\r\nlove to nibble on the growing plants. Then there\r\nare fish pens to work on. There you feed and tend\r\nthe fish until they are needed for food. Farming\r\nunder the sea is beautiful and it is much easier than\r\nyou had imagined. Danger lurks, though, in the\r\nform of sting rays, slender sea snakes, and occasional sharks. You have to be on your guard at all\r\ntimes.\r\nThe End",
            "86\n104\r\nA musician in the world of Atlantis. Who would\r\nbelieve it? You are asked to choose an instrument\r\nto play. You examine water lutes,sea drums,shark\r\nbone flutes, and a wide range of electronic instruments. You choose one of the electronic instruments, but it makes no sound at all. You are told\r\nthat it plays music that people feel rather than hear.\r\nWhat a world you're living in! Who would believe\r\nin music that is not heard? Gradually you learn to\r\nfeel the different notes with parts of your body:\r\nyour thighs, chest, temples, and fingertips. Your\r\ninterest in this new way of sensing music grows\r\nwith each day. You master this new art form. You\r\nbecome their greatest musician.\r\nThe End",
            "87\n105\r\nThese people lead you to a control room. There\r\nyou meet the commander of an underwater scientific center that is conducting secret research into\r\nlife underneath the sea. They inform you that it\r\nwas a good thing that you did not use your laser\r\ncannon, because they have anti-laser devices that\r\nwould have blown you and the Seeker to pieces.\r\nAfter a pleasant meal and a tour of the deepwater lab, you are sent back to the Seeker for a\r\nreturn journey to the surface. You are told never to\r\nreturn again; if you do, you will be kept a prisoner\r\nfor the rest of your life.\r\nThe End",
            "88\n106\r\nWhen you refuse to follow them, they take out\r\nsmall hand-held hypnotizers that put you into a\r\ndeep trance. You are led through a long tunnel\r\ninto a large underwater lab. Three military technicians come up to you and break the trance.\r\n\"You have stumbled into a secret military base.\r\nWe're developing too many secret plans to risk\r\nbeing discovered. You will remain our prisoner.\"\r\nThere is no escape.\r\nThe End",
            "89\n107\r\nYou argue with yourself for weeks. Then you\r\ndecide to go back to Atlantis. You are in such a\r\nhurry to return that you hire a small, fast hydrofoil\r\ncraft to take you to the spot in the ocean where\r\nAtlantis is. Once reaching the spot, you intend to\r\nmake a dive with just scuba gear! You know a\r\n2000 foot dive is impossible. But you don't care;\r\nyou feel you must make the attempt.\r\nA storm rips the sea for six days and when it\r\nclears you prepare to dive. Just as you slip into the\r\nwater, you look up into the sky and high above the\r\nclouds you see the sparkling city of Atlantis. No\r\ndive is necessary.\r\nThe End",
            "90\n108\r\nDuring the night, you are awakened by the\r\nsound of voices talking quietly. Listening, you\r\nrealize that a group of Nodoors is planning an\r\nescape. They want to join the Atlanteans. They\r\nbelieve that life in Atlantis can be better for them.\r\nYou join them and listen to the stories of fear and\r\ndarkness. They seek light and friendship. It sounds\r\nsimple, but nothing is easy.\r\nSuddenly the door bursts open. Three guards\r\narmed with special weapons rush in. They fire the\r\nweapons and in a flash of brilliant light you and\r\nyour companions are vaporized.\r\nThe End",
            "91\n110\r\nOver 1000 years of thought travel later, you are\r\ncalled into the main thinking room. You are told\r\nthat you may now return to earth life. You have\r\ndoubts about going back, but you are curious to\r\nsee what changes have occurred while you were\r\nliving in Atlantis.\r\nWhat a sight greets you as you circle earth at an\r\naltitude of 1000 feet! The great cities of the world,\r\nNew York, London, Paris, and Hong Kong are\r\novergrown with vegetation. The roadsleading into\r\nthe cities are barely visible. But you see signs of\r\nnew settlements. There are clusters of buildings\r\nspread out in the countryside. You don't see any\r\nsmokestacks. There are few roads and no cars.\r\nThe people live a simple life providing themselves\r\nwith food, shelter, and clothing. You wish to join\r\nthem.\r\nThe End",
            "92\n111\r\nOne day your friendstell you that you can return\r\nto earth if you wish. You consider it carefully and\r\ndecide that because of your thought traveling ability, the life you now lead is what you want. You\r\ndecide to stay where you are forever.\r\nThe End",
            "93\n114\r\nWith everyone worried about the sea crashing\r\nin, no one will notice you if you try to escape. You\r\nrun down a long, little-used corridor that leads to\r\nthe sea. The exit door is heavy and rusty from not\r\nbeing used. You push with all your might, and\r\nfinally it swings open into an airlock to the open\r\nwater. You push the emergency release button\r\nand shoot out into the water. The Seeker is where\r\nyou left it, and once inside, you head for the surface where the Maray waits for you.\r\nThe End",
            "94\n116\r\nIt is uselessto try to escape the soldiers. You are\r\nsurrounded. They take you to the king, and he\r\nsadly tells you that you are just like all the rest. He\r\ncan't trust anyone. He will have to decide what to\r\ndo with you and in the meantime he throws you\r\ninto the dungeon.\r\nThe End",
            "95\n117\r\nHow can you escape? The soldiers are coming\r\nafter you. You yell as loud as you can and everyone in the theatersurrounds you, forming a barrier\r\nto the soldiers. The soldiers stare at the people all\r\naround them, hesitate, and then quickly leave.\r\nThey know that the odds are too great to win such\r\na fight.\r\nThe people cry for the revolt to go on. The\r\ncrowd leaves the theater and heads to the king's\r\nquarters. All along the route people join you and\r\neven the king's soldiers begin to join the crowd.\r\nYou and the people are free; the king is put in\r\nprison. The revolt is a success.\r\nThe End"
        };

        Console.Clear();

        bool flag = true;

        int arrLength = ChooseYOA.Length;

        Console.ForegroundColor = ConsoleColor.Green;

        //Console.WriteLine(arrLength);

        while (flag)
        {
            Console.WriteLine(ChooseYOA[0]);
            string key = Console.ReadKey().Key.ToString();
            //var input = Console.ReadLine();
            //while(input != null) {  }
            if (key != null)
            {
                Console.Clear();
                Console.WriteLine(ChooseYOA[1]);
            }
            key = Console.ReadKey().Key.ToString();
            if (key != null)
            {
                Console.Clear();
                Console.WriteLine(ChooseYOA[2]);
            }
            string str = Console.ReadLine();
            int num = Int32.Parse(str);
            if (num == 6)
            {
                Console.Clear();
                Console.WriteLine(ChooseYOA[4]);
            }
            else if (num == 5)
            {
                Console.Clear();
                Console.WriteLine(ChooseYOA[3]);
            }
            else { }
            str = Console.ReadLine();
            num = Int32.Parse(str);
            flag = false;
        }
        
                

        /*Console.WriteLine("WELCOME TO CHOOSE YOUR OWN ADVENTURE");
            Console.WriteLine("DO YOU WISH TO PROCEED?");

        string userInput = Console.ReadLine();

        if (userInput == "y") { Console.WriteLine("WELCOME TO CHOOSE YOUR OWN ADVENTURE"); }

        Console.WriteLine("JOURNEY UNDER\r\nTHE SEA\r\nCHOOSE YOUR OWN ADVENTURE • 2\r\nWARNING! ! ! !\r\nDo not read this book straight through from beginning to end! These pages contain many different\r\nadventures you can go on as you journey under\r\nthe sea. From time to time as you read along, you\r\nwill be asked to make a choice. Your choice may\r\nlead to success or disaster!\r\nThe adventures you take are a result of your\r\nchoice. You are responsible because you choose!\r\nAfter you make your choice follow the instructions\r\nto see what happens to you next.\r\nRemember—you cannot go back! Think carefully\r\nbefore you make a move! One mistake can be\r\nyour last ... or it may lead you to fame and\r\nfortune!");

        Console.WriteLine();

        if (Console.ReadKey().Key == ConsoleKey.Enter) { Console.Clear(); }

        Console.WriteLine("You are an underwater explorer. You are leaving to explore the deepest oceans. You must find\r\nthe lost city of Atlantis. This is your most challenging assignment.\r\nIt is morning and the sun pushes up on the\r\nhorizon. The sea is calm. You climb into the narrow pilot's compartment of the underwater vessel\r\nSeeker with your special gear. The crew of the\r\nresearch vessel Maray screws down the hatch\r\nclamps. Now begins the plunge into the depths of\r\nthe ocean. The Seeker crew begins lowering by a\r\nstrong, but thin cable. Within minutes, you are so\r\ndeep in the ocean that little light filters down to\r\nyou. The silence is eerie as the Seeker slips deeper\r\nand deeper. You peer out the thick glass porthole\r\nand see fish drifting past, sometimes stopping to\r\nlook at you—an intruder from another world.");
        


        Console.WriteLine("\npress any key to exit the process...");

        // basic use of "Console.ReadKey()" method
        Console.ReadKey();*/
    }
}



/*class PAITools
{
    private char A = 'a';
    private char B = 'b';
    private char C = 'c';
    public char Lab()
    {
        return A;
    }
    public char Lab2()
    {
        return B;
    }
    public char Lab3()
    {
        return C;
    }
}*/

/*public class Transaction
{
    public decimal Balance
    {
        get
        {
            decimal balance = 10;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

    private List<Transaction> allTransactions = new List<Transaction>();
}

public class BankAccount
{
    private static int accountNumberSeed = 1234567890;

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        //this is a paper slip
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        //this is a paper slip
    }
}

public class Laboratory
{
    private static int Fruitmentations = 377;

    public string Genome { get; }
    public char Tag { get; set; }
    public decimal Mitochondria { get; }

    public Laboratory(string name, char tagLabel)
    {
        this.Genome = name;
        this.Tag = tagLabel;
        this.Mitochondria = Fruitmentations;
        Fruitmentations++;
    }

    public void ChangeGenome(decimal amount, DateTime date, char note)
    {
        //this is a paper slip
    }

    public void MakeWithdrawal(decimal amount, DateTime date, char note)
    {
        //this is a paper slip
    }
}



class PAI
{
    static void Main()
    {
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");

        Console.WriteLine("Hello, World!");
        Console.WriteLine("The current time is " + DateTime.Now);
        string MyWorld = "My World is a Marvel";
        Console.WriteLine(MyWorld);
        MyWorld = MyWorld.Replace("World", "Life");
        Console.WriteLine(MyWorld);
        string SongLyrics = "Nothing else matters, except love";
        var result = SongLyrics.StartsWith("love");
        Console.WriteLine(result);
        Console.WriteLine(SongLyrics.Contains("matters"));
        string SongLyrics1 = "Love of my life, you've hurt me";
        var result1 = SongLyrics1.StartsWith("Love");
        Console.WriteLine(result1);
        Console.WriteLine(SongLyrics1.Contains("life"));
        int character = 1;
        int energy = 2;
        int creativity = 3;
        int health = 4;
        int intuition = 5;
        int labour = 6;
        int luck = 7;
        int duty = 8;
        int memory = 9;
        int bernello = character + energy + creativity + health + luck + duty + memory;
        int division = energy / creativity;
        Console.WriteLine(bernello);
        Console.WriteLine($"quotient: {division}");
        int division2 = luck / energy;
        Console.WriteLine($"quotient: {division2}");
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} and {max}");
        int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}");
        double max2 = double.MaxValue;
        double min2 = double.MinValue;
        Console.WriteLine($"The range of double is {min2} to {max2}");
        double third = 1.0 / 3.0;
        Console.WriteLine(third);
        decimal min3 = decimal.MinValue;
        decimal second = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min3} to {second}");
        decimal third2 = decimal.MinValue;
        decimal second2 = decimal.MaxValue;
        decimal third3 = decimal.MinValue;
        int min4 = int.MaxValue;
        int second4 = int.MinValue;
        const int min5 = int.MaxValue;
        const int min6 = int.MaxValue;
        long min7 = long.MinValue;
        long second7 = long.MaxValue;
        short min8 = short.MinValue;
        short second8 = short.MaxValue;
        double radius = 5.0;
        double area = radius * radius;
        Console.WriteLine(area);

        char neuron = 'A';
        char neuron1 = 'B';
        char neuron3 = 'C';
        char neuron4 = 'D';
        char neuron5 = 'E';
        char neuron6 = 'S';

        //dvelpomnet 

        string neur = "A";
        string neur1 = "B";
        string neur3 = "C";
        string neur4 = "D";
        string neur5 = "E";
        string neur6 = "F";
        string neur7 = "G";
        string neur8 = "F";
        string neur9 = "H";

        List<string> NeuronDatabase = new List<string>(6);
        //The following code snippet adds items to the list.

        NeuronDatabase.Add("Long");
        NeuronDatabase.Add("Short");
        NeuronDatabase.Add("Character");
        NeuronDatabase.Add("Intuition");
        NeuronDatabase.Add("Health");
        NeuronDatabase.Add("Luck");

        //Alternatively, we can also pass an array of objects to create a List object.The following code snippet creates a List object from an array of strings.

        


        for(int i = 0; i < NeuronDatabase.Count; i++)
        {
            Console.WriteLine(NeuronDatabase[i]);

        }

// Create a List using Range    
/*string[] authors = { "Mike Gold", "Don Box",
                        "Sundar Lal", "Neel Beniwal" };
        List<string> authorsRange = new List<string>(authors);*/
//The following code snippet creates a list of integer type.

//List<int> AgeList = new List<int>();
//The following code snippet adds items to the dictionary.

/*AgeList.Add(35);
AgeList.Add(25);
AgeList.Add(29);
AgeList.Add(21);
AgeList.Add(84);*/
//We can also limit the size of a list.The following code snippet creates a list where the key type is float and the total number of items it can hold is 3.

//List<float> PriceList = new List<float>(3);
//The following code snippet adds items to the list.

/*PriceList.Add(3.25f);
PriceList.Add(2.76f);
PriceList.Add(1.15f);*/

/*var account = new BankAccount("<Bernello Gabon>", 123456789);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

for (int i = 0; i < 9; i++) 
{
    /*Console.WriteLine(PAITools.Lab());
    Console.WriteLine(PAITools.Lab2());
    Console.WriteLine(PAITools.Lab3());*/

/*Console.WriteLine(neur);
}

int counter = 0;
while (counter < 10)
{
Console.WriteLine($"Hello World! The counter is {counter}");
Console.WriteLine(char.MinValue);
Console.Write(nameof(counter));
counter = 0;
while (counter < 10) ;

counter++;
}
}
}*/


/*Console.WriteLine("Hello World");
string neuron = "Long";
Console.WriteLine(neuron);
Console.WriteLine("Hello " + neuron);
string neuron2 = "Happy";
string neuron3 = "Depressed";
Console.WriteLine($"My neurons are {neuron} and {neuron2} and {neuron3}");
Console.WriteLine("We have to change the dynamic!");
Console.WriteLine("Keep adding data!");
string neuron4 = "Character";
string neuron5 = "Energy";
string neuron6 = "Creativity";
string neuron7 = "Healthy";
string neuron8 = "Intuition";
string neuron9 = "labour";
string neuron10 = "Luck";
string neuron11 = "Duty";
string neuron12 = "Memory";
Console.WriteLine($"My neurons are {neuron} and {neuron2} and {neuron3} and { neuron4} and {neuron5} and {neuron6} and {neuron7} and {neuron8} and {neuron9} and {neuron10} and {neuron11} and {neuron12}");
Console.WriteLine("Really?");
Console.WriteLine("I'm not sure");
Console.WriteLine("Well google it or better yet use ChatGPT");
Console.WriteLine("So what are the properties of a neuron?");
string neuronproperty = "Excitability";
string neuronproperty2 = "Conductivity";
string neuronproperty3 = "Synaptic transmission";
string neuronproperty4 = "Plasticity";
string neuronproperty5 = "Integration";
Console.WriteLine($"The properties of a neuron are {neuronproperty} and {neuronproperty2} and {neuronproperty3} and {neuronproperty4} and {neuronproperty5}");

string neuronfunction = "Sensory processing";
string neuronfunction2 = "Motor Control";
string neuronfunction3 = "Integration of information";
string neuronfunction4 = "Learning and memoory";
string neuronfunction5 = "Regulation of bodily functions";
string neuronfunction6 = "Communication between neurons";
Console.WriteLine($"The functions of A NEURON ARE {neuronfunction} and {neuronfunction2} and {neuronfunction3} and {neuronfunction4} and {neuronfunction5} and {neuronfunction6}");
Console.WriteLine("Now we are going to go through some neuron numbers");
long neuronNumber = 100000000000;
long neuronNumber2 = 86000000000;
long glialCells = neuronNumber * 10;
long humanBrainMassGrams = 1508;
long powerLaw = neuronNumber * humanBrainMassGrams;
long massCerebralCortexGrams = 1233;
long neuronsCerebralCortex = 16000000000;
long neuronsCerebellum = 140000000000;
long neuronalDensityPMg = 600000;
/*for (long i = 0; i < 1000000000; i++)
{
    Console.Write('A');
}*/
//success
//
/*for (long j = 0; j < 200; j++)
{
    for (long i = 0; i < 26; i++)
    {
        Console.Write(alpha[i]);
    }
}*/
//success
/*for (long a = 0; a < 200; a++)
{
    Console.Write(" ");
    Console.Write("X");
}
/*Deoxyribonucleic acid (DNA) is the chemical compound 
 * that contains the instructions needed to develop 
 * and direct the activities of nearly all living organisms
 * . DNA molecules are made of two twisting, paired 
 * strands, often referred to as a double helix
 */

/*Each DNA strand is made of four chemical units, called 
nucleotide bases, which comprise the genetic "alphabet." 
The bases are adenine (A), thymine (T), 
guanine (G), and cytosine (C). Bases on opposite strands 
pair specifically: an A always pairs with a T; a C always 
pairs with a G. The order of the As, 
Ts, Cs and Gs determines the meaning of the information 
encoded in that part of the DNA molecule just as the 
order of letters determines the meaning of 
a word.*/

//char[] nucBases = "ATGC".ToCharArray();
//Perception of world class
//Philosophy of mind body and function
//Positive reaffirmations
//Optimistic stories
//Pessimistic Optimistic AI 
/*Console.WriteLine("I have the perception of world class");
Console.WriteLine("I have the philosophy of mind body and function");
for (int j = 0; j < 4; j++)
{
    for (int k = 0; k < 4; k++)
    {
        Console.Write(nucBases[k]);
    }
}
//success


string result = Genome.ChangeGenome(nucBases);
Console.WriteLine(result);*/