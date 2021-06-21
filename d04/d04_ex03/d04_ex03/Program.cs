using System;
using d04_ex03;
using d04_ex03.Models;

IdentityUser instanceOfIdentityUserConstructor = TypeFactory.CreateWithConstructor<IdentityUser>();
IdentityRole instanceOfIdentityRoleConstructor = TypeFactory.CreateWithConstructor<IdentityRole>();

IdentityUser instanceOfIdentityUserActivator = TypeFactory.CreateWithActivator<IdentityUser>();
IdentityRole instanceOfIdentityRoleActivator = TypeFactory.CreateWithActivator<IdentityRole>();


Console.WriteLine(instanceOfIdentityUserConstructor.GetType().FullName);
if (instanceOfIdentityUserConstructor == instanceOfIdentityUserActivator)
{
    Console.WriteLine("user1 == user2");
}
else
{
    Console.WriteLine("user1 != user2");
}

Console.WriteLine(instanceOfIdentityRoleActivator.GetType().FullName);
if (instanceOfIdentityRoleConstructor == instanceOfIdentityRoleActivator)
{
    Console.WriteLine("role1 == role2\n");
}
else
{
    Console.WriteLine("role1 != role2\n");
}

Console.WriteLine(instanceOfIdentityUserActivator.GetType().FullName);
Console.WriteLine("Set name:");
var input = Console.ReadLine();
var constructorWithOneParameter = TypeFactory.CreateWithParameters<IdentityUser>(new object[]{input});
Console.WriteLine($"Username set: {constructorWithOneParameter.UserName}");