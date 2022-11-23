using Strategy.Strategies;

namespace Strategy
{
    public class Hero
    {
        private readonly string _name;
        private IWeapon? _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            if (_weapon == null)
            {
                Console.WriteLine($"{_name} не  может атаковать без оружия ;(");
                return;
            }

            Console.WriteLine("Start ATTACK");

            _weapon.Shoot();

            Console.WriteLine("End ATTACK");
        }
    }
}
