namespace Strategy.Strategies
{
    public class Plunger : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("*Ударяет вантусом*");
        }
    }
}
