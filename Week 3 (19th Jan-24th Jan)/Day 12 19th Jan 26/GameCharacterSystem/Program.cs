namespace GameCharacterSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Warrior { Name = "Thor" };
            Character c2 = new Mage { Name = "Loki" };

            c1.Attack();
            c1.LevelUp();
            Skill s1 = new Skill();
            s1.Upgrade();
            c2.Attack();
            c2.LevelUp();
            Skill s2 = new Skill();
            s2.Upgrade();
        }
    }
}
