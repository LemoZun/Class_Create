namespace ConsoleApp1
{
    internal class Program
    {
        class Trainer
        {
            string name;
            public Monster[] monsters = new Monster[6];

            public Trainer(string _name)
            {
                this.name = _name;
                Monster[] monsters = new Monster[6];
            }
            
            public string GetName()
            {
                return this.name;
            }


        }
         class Monster
        {
            public Monster(string _name, int _hp)
            {
                this.name = _name;
                this.hp = _hp;
            }
            string name;
            public int hp;



        }

        static void Main(string[] args)
        {
            Trainer trainer1 = new Trainer("레드");
            trainer1.monsters[0] = new Monster("피카츄",100);

            Console.WriteLine($"첫번째 트레이너의 이름은 {trainer1.GetName()}이고 첫번째 몬스터의 체력은 {trainer1.monsters[0].hp} 입니다.");
        }
    }
}
