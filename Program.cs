using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {

      // Test RandomMode()
      RandomMode();

      // Test out SwitchCase()
      //SwitchCase(1, 1, 1);

      // Test out BuildACreature() manually
      //BuildACreature("monster", "ghost", "monster");
      //BuildACreature("bug", "ghost", "monster");

      // Test out the functions MonsterHead(), GhostBody(), BugFeet() individually
      //MonsterHead();
      //GhostBody();
      //BugFeet();
    }


    // Easy swap of different creatures and quick creating many character combinations
    static void BuildACreature(
      string head,
      string body,
      string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      // call SwitchCase() with above as args
      SwitchCase(headNum, bodyNum, feetNum);

    }


    // Randomly assemble a body each time the program run
    static void RandomMode()
    {
      // create an instance and new Random object
      Random randomNumber = new Random();

      // randomly pick a number between 1 and inclusive of 3 - use range (1, 4) where 1 is the min value and 4 is the max value
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);

      // Call SwitchCase() with above variables passed in
      SwitchCase(head, body, feet);

    }


    // SwitchStatement Custom Method to Refractor
    static void SwitchCase(
      int head,
      int body,
      int feet)
    {
      switch (head)
      {
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
      }

      switch (body)
      {
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
      }

      switch (feet)
      {
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
      }
    }


    // Translate the meaning of string data into int
    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "ghost":
          return 1;
        case "bug":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }


// The code for creating each body part of the creature

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
