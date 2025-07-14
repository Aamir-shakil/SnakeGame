using SnakeGame;

//Dimensions of play area 
Coord gridDimensions = new Coord(50, 20);
Coord snakePosition = new Coord(10, 1);
Random random = new Random();
Coord applePosition = new Coord(random.Next(1, gridDimensions.X - 1), random.Next(1, gridDimensions.Y - 1));//Random position for appple within dimensions of play area 
int frameRate = 100; // Frame rate in milliseconds
Direction snakeDirection = Direction.Down; // Initial direction of the snake

// Main game loop
while (true)
{   Console.Clear(); // Clear the console for each frame
    snakePosition.ApplyMovementDirection(snakeDirection); // Move the snake in the current direction

    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            Coord currentCord = new Coord(x, y);
            if (snakePosition.Equals(currentCord))
            {
                Console.Write("■");//Snake head
            }
            else if (applePosition.Equals(currentCord))
            {
                Console.Write("@");// Apple item
            }

            else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
            {
                Console.Write("*"); // Draw the border
            }
            else { Console.Write(" "); }

        }
        Console.WriteLine();
    }
    Thread.Sleep(frameRate); // Control the frame rate

}