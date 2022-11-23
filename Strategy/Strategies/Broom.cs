namespace Strategy.Strategies
{
    public class Broom : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("*Ударяет веником*");
        }
    }
}
