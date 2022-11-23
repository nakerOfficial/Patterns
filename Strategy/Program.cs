// Представим, что у нас есть герой, коротый
// должен стрелять из разного вида оружия.


/*
 * It's exemmple realization strategies pattern
 */
using Strategy;
using Strategy.Strategies;


/*
 * init Weapons
 */
Broom broom = new Broom();
Plunger plunger = new Plunger();
WatterGun watterGun = new WatterGun();


/*
 * init Hero
 */
Hero hero = new Hero("Бэтман");


/*
 * Select Weapon 
 */
hero.SetWeapon(plunger); // hero.SetWeapon(broom); // hero.SetWeapon(plunger);

/*
 * Finaly acction
 */
hero.Attack();