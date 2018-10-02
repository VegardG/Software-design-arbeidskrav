using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class SnakeFood {

    public SnakeFood() {}

    public void SetSnakeFood(Setup mySetup) {
        while (true) {
				mySetup.AppPoint.X = mySetup.RandomSpot.Next(0, Console.WindowWidth); 
				mySetup.AppPoint.Y = mySetup.RandomSpot.Next(0, Console.WindowHeight);
				bool freeSpotFound = true;
				foreach (Point SnakePoint in mySetup.MySnake)
					if (SnakePoint.X == mySetup.AppPoint.X && SnakePoint.Y == mySetup.AppPoint.Y) {
						freeSpotFound = false;
						break;
					}
                
				if (freeSpotFound) {
                    mySetup.FreeMovementSpace = false;
					Console.ForegroundColor = ConsoleColor.Green; 
					Console.SetCursorPosition(mySetup.AppPoint.X, mySetup.AppPoint.Y); 
					Console.Write("$");
					break;
				}
			}
    }

}