using SnakeGame;

//Dimensions of play area 
Coord gridDimensions = new Coord(50, 20);
Coord snakeStartPosition = new Coord(10, 1);

for (int y = 0; y < gridDimensions.Y; y++) {
    for (int x = 0; x < gridDimensions.X; x++)
    {
        Coord currentCord = new Coord(x, y);
        if (snakeStartPosition.Equals(currentCord)) {
            Console.WriteLine("■");
        }

        else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
        {
            Console.Write("*"); // Draw the border
        }
        else { Console.Write(" "); }
        
    }
    Console.WriteLine();
}