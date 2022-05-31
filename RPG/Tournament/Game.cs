namespace CourseApp
{
    using System;

    public class Game
    {
        public int StartTheTournament(int tournamentParticipants)
        {
            Logger.LoggerOutput("Введите количество участников : ");
            tournamentParticipants = Convert.ToInt32(Console.ReadLine());
            while ((tournamentParticipants % 2 != 0) && (tournamentParticipants > 0))
            {
                Logger.LoggerOutput("Введите корректное количество участников (кратное двум и больше нуля!): ");
                tournamentParticipants = Convert.ToInt32(Console.ReadLine());
            }

            return tournamentParticipants;
        }
    }
}