namespace Strategy.Strategies
{
    public class WatterGun : IWeapon
    {
        void IWeapon.Shoot()
        {
           Console.WriteLine("*Стреляет водой*");
        }
    }
}
