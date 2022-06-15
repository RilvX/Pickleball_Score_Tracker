
class Program
{
    //Main Method
    static void mainMethod()
    {

        Boolean gameOn = true;
        Boolean teamOneWin = false;
        Boolean teamTwoWin = false;

        int teamOneScore = 0;
        int teamTwoScore = 0;

        int server = 2;
        int teamServing = 1;

        List<int> teamOneBackUp = new List<int>();
        List<int> teamTwoBackUp = new List<int>();
        //var operators = new List<string>();

        while (gameOn)
        {
            Console.WriteLine("Who got the point? Team One: (1) + Team Two: (2)");
            int pointInput = Convert.ToInt32(Console.ReadLine());

            //Team One Gets the Point
            if (pointInput == 1)
            {
                if (teamServing == 1)
                {
                    teamOneScore += 1;
                }
                else if (teamServing == 2)
                {
                    if (server == 1)
                    {
                        server = 2;
                    }
                    else if (server == 2)
                    {
                        teamServing = 1;
                        server = 1;
                    }
                }
            }
            //Team Two Gets the Point
            else if (pointInput == 2)
            {
                if (teamServing == 2)
                {
                    teamTwoScore += 1;
                }
                else if (teamServing == 1)
                {
                    if (server == 1)
                    {
                        server = 2;
                    }
                    else if (server == 2)
                    {
                        teamServing = 2;
                        server = 1;
                    }
                }
            }

            if (teamOneScore >= 11)
            {
                if (teamTwoScore <= 9)
                {
                    gameOn = false;
                    teamOneWin = true;
                }
                else if ((teamOneScore - teamTwoScore) > 1)
                {
                    gameOn = false;
                    teamOneWin = true;
                }
            }

            if (teamTwoScore >= 11)
            {
                if (teamOneScore <= 9)
                {
                    gameOn = false;
                    teamTwoWin = true;
                }
                else if ((teamTwoScore - teamOneScore) > 1)
                {
                    gameOn = false;
                    teamTwoWin = true;
                }
            }

            Console.WriteLine("Team One Score: " + teamOneScore + " Team Two Score: " + teamTwoScore + " Server: " + server);
        }

        if (teamOneWin)
        {
            Console.WriteLine("Team One is the Winner!");
        }
        else if (teamTwoWin)
        {
            Console.WriteLine("Team Two is the Winner!");
        }

    }

    static void gameStatus()
    {

    }

    //Execute Main Method
    static void Main(string[] args)
    {
        mainMethod();
    }

}





