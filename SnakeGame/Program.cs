using SnakeGame;

//Dimensions of play area 
Coord gridDimensions = new Coord(50, 20);
Coord snakePosition = new Coord(10, 1);
Random random = new Random();
Coord applePosition = new Coord(random.Next(1, gridDimensions.X - 1), random.Next(1, gridDimensions.Y - 1));//Random position for appple within dimensions of play area 
int frameRate = 100; // Frame rate in milliseconds
Direction snakeDirection = Direction.Down; // Initial direction of the snake

List<Coord> snakeBody = new List<Coord>(); // List to hold the snake's body segments
int tailLength = 1; // Initial length of the snake's tail




// Main game loop
while (true)
{   Console.Clear(); // Clear the console for each frame
    snakePosition.ApplyMovementDirection(snakeDirection); // Move the snake in the current direction

    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            Coord currentCord = new Coord(x, y);
            if (snakePosition.Equals(currentCord) || snakeBody.Contains(currentCord))
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

    if(snakePosition.Equals(applePosition)) // Check if the snake's head collides with the apple
    {
        tailLength++; // Increase the tail length
        applePosition = new Coord(random.Next(1, gridDimensions.X - 1), random.Next(1, gridDimensions.Y - 1)); // Generate a new apple position
    }

    snakeBody.Add(new Coord(snakePosition.X, snakePosition.Y)); // Add the current position to the snake's body

    if(snakeBody.Count > tailLength) // If the snake's body exceeds the tail length, remove the oldest segment
    {
        snakeBody.RemoveAt(0);
    }


    DateTime time = DateTime.Now;// start of frame time

    while ((DateTime.Now - time).Milliseconds < frameRate){ 

        if(Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key) {
                case ConsoleKey.LeftArrow:
                    snakeDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    snakeDirection = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    snakeDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    snakeDirection = Direction.Down;
                    break;

            }
        }
    }
    {
        // Wait for the specified frame rate
    }
}