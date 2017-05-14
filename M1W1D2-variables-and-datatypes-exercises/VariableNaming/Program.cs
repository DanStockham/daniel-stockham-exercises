using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */

            int birds = 4;
            int flownAway = 1;
            int birdsLeftOnBranch = birds - flownAway;
            Console.WriteLine(birdsLeftOnBranch);

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            birds = 6;
            int nests = 3;

            Console.WriteLine(birds / nests);


            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */

            int raccons = 3;
            int racconsWentHome = 2;

            Console.WriteLine(raccons - racconsWentHome);

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int flowers = 5;
            int bees = 3;

            Console.WriteLine(flowers - bees);

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int firstPigeon = 1;
            int newPigeons = 1;
            int pigeonDinnerParty = firstPigeon + newPigeons;
            Console.WriteLine(pigeonDinnerParty);

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int owls = 3;
            int incomingOwls = 2;

            Console.WriteLine(owls + incomingOwls);
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int beavers = 2;
            int goHomeBeaver = 1;

            Console.WriteLine(beavers - goHomeBeaver);
            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int toucans = 2;
            int incomingToucan = 1;

            Console.WriteLine(toucans + incomingToucan);
            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;

            Console.WriteLine(squirrels * nuts);
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double quarter = 0.25F;
            double dime = 0.10F;
            double nickels = 0.05F;

            Console.WriteLine((quarter * 2) + dime + (nickels * 2));

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int brier = 18;
            int macadam = 20;
            int flannery = 17;

            Console.WriteLine(brier + macadam + flannery);

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyo = 0.24f;
            double whistle = 0.14f;

            Console.WriteLine(yoyo + whistle);

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int large = 8;
            int mini = 10;

            Console.WriteLine(large + mini);

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouse = 29;
            int school = 17;

            Console.WriteLine(hiltHouse - school);

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltPurse = 10;
            int truck = 3;
            int pencil = 2;

            Console.WriteLine(hiltPurse - (truck - pencil));
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marbles = 16;
            int lost = 7;

            Console.WriteLine(marbles - lost);

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int seashells = 19;

            Console.WriteLine(25 - seashells);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int ballons = 17;

            Console.WriteLine(ballons - 8);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int books = 38;

            Console.WriteLine(books + 10);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legs = 6;
            bees = 8;

            Console.WriteLine(legs * bees);
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double coneCost = 0.99;
            double cones = 2;

            Console.WriteLine(coneCost * cones);

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currRocks = 64;
            int neededRocks = 125;

            Console.WriteLine(neededRocks - currRocks);

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            marbles = 38;
            int lostMarbles = 15;

            Console.WriteLine(marbles - lostMarbles);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesToGo = 78;
            int distancedTraveled = 32;

            Console.WriteLine(milesToGo - distancedTraveled);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            double morning = 1.5;
            double afternoon = 0.75;

            Console.WriteLine(morning + afternoon);
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            double hotdogCost = 0.50;
            int totalHotdogs = 6;
            double totalCost = hotdogCost * totalHotdogs;

            Console.WriteLine(totalCost);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal purse = 0.50M;
            decimal pencilCost = 0.07M;

            Console.WriteLine(purse / pencilCost);
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterflies = 33;
            int orange = 20;

            Console.WriteLine(butterflies - orange);
            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double tender = 1.0;
            double candy = 0.54;

            Console.WriteLine(tender - candy);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int trees = 13;
            int planted = 12;

            Console.WriteLine(trees + planted);
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int joy = 2;
            int hoursInDays = 24;

            Console.WriteLine(joy * hoursInDays);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kim = 4;

            Console.WriteLine(kim * 5);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double dan = 3.0;
            candy = 1.0;

            Console.WriteLine(dan - candy);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boats = 5;
            int people = 3;

            Console.WriteLine(boats * people);
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legos = 380;
            int legosLost = 57;

            Console.WriteLine(legos - legosLost);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthur = 35;
            int muffinsNeeded = 83;

            Console.WriteLine(muffinsNeeded - arthur);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willy = 1400;
            int lucy = 290;

            Console.WriteLine(willy - lucy);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickers = 10;
            int pages = 22;

            Console.WriteLine(stickers * pages);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakes = 96;
            int children = 8;

            Console.WriteLine(cupcakes / children);

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerbread = 47;
            int amountFitJars = 6;

            Console.WriteLine(gingerbread % amountFitJars);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int marian = 59;
            int neighbors = 8;

            Console.WriteLine(marian % neighbors);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int tray = 12;
            int totalCookies = 276;
            int totalTraysNeeded = totalCookies / tray;

            Console.WriteLine(totalTraysNeeded);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzels = 480;
            int servings = 12;
            int amountPerServing = pretzels / servings;

            Console.WriteLine(amountPerServing);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53 - 2;
            int box = 3;
            int totalBoxes = lemonCupcakes / box;

            Console.WriteLine(totalBoxes);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            people = 12;

            Console.WriteLine(carrotSticks % people);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBears = 98;
            int shelf = 7;

            Console.WriteLine(teddyBears / shelf);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int pictures = 480;
            int albums = 20;

            Console.WriteLine(pictures / albums);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 98;
            int boxes = tradingCards / 8;
            int leftOver = tradingCards % 8;

            Console.WriteLine($"{boxes} boxes and {leftOver} cards left over");
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int roomBooks = 210;
            int shelves = 10;
            int booksContained = roomBooks / shelves;

            Console.WriteLine(booksContained);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissant = 17;
            int guests = 7;

            Console.WriteLine(croissant / guests);

        }
    }
}
