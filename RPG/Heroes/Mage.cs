namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Маг";
            UltimateName = "Ледяная глыба";
        }

        public override int Ultimate(Player player, Player rival)
        {
            if (player.Effect)
            {
                player.Afk = 1;
                rival.Afk = 2;
            }
            else if (rival.Effect)
            {
                player.Afk = 2;
                rival.Afk = 1;
            }

            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал скилл {UltimateName}!");
            return 0;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}