// Представим, что у нас есть спортзал, который
// выдает разные абонименты


using FactoryMethod.Domain;
using FactoryMethod.Factories;


Console.WriteLine("Wellcome to Fitness Club!");


/*
 * Select Membership
 */
var selectPlan = "best";

MembershipFactory factory = selectPlan.ToUpper() switch
{
    "BASIC" => new GymMembershipFactory(100, "Basic"),
    "PLUS" => new GymPlusPoolMembershipFactory(250, "Good"),
    "BEST" => new PersonalTrainingMembershipFactory(350, "The Best"),
    _ => throw new NotImplementedException()
};


/*
 * Get Membership
 */
IMembership membership = factory.GetMembership();


Console.WriteLine("Membership you've just created:");
Console.WriteLine($"\tName:\t\t{membership.Name}");
Console.WriteLine($"\tDescription:\t{membership.Description}");
Console.WriteLine($"\tPrice:\t\t{membership.GetPrice()}");