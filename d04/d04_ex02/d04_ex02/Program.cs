using System;
using d04_ex02.ConsoleSetter;
using d04_ex02.Models;

//for user
ConsoleSetter classUserForSetter = new();
IdentityUser objectOfClassIdentityUser = new();
classUserForSetter.SetValues(objectOfClassIdentityUser);

//for role
ConsoleSetter classRoleForSetter = new();
IdentityRole objectOfClassIdentityRole = new();
classRoleForSetter.SetValues(objectOfClassIdentityRole);