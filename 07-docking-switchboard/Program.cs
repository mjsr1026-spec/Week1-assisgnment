using System.Collections;
using System.Linq.Expressions;

string dockingCode = "SERVICE";
string instruction = "";

// TODO: Bruk switch statement til å sette instruction.
switch (dockingCode)
{
    case "NORTH":
    instruction = "Dock at gate 1";
    break;

    case "EAST":
    instruction = "Dock at gate 2";
    break;

    case "SERVICE":
    instruction = "Dock at maintenance bay";
    break;

    case "CLOSED":
    instruction = "Hold position";
    break;

    default:
    instruction = "Unknowing docking code";
    break;

}

Console.WriteLine(instruction);
