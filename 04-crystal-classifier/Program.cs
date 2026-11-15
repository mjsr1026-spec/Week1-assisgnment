int energy = 52;
string classification = "";

if (energy < 20)
{
    classification = "Dormant";
}
else if (energy>=20 && energy<50)
{
    classification = "Stable";
}
else if (energy>=50 && energy<80)
{
    classification = "Unstable";
}
else
{
    classification = "Critical";
}

// TODO: Sett classification med if / else if / else.

Console.WriteLine($"Classification: {classification}");
