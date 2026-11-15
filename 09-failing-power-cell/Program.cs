int charge = 23;
int drainPerCycle = 5;

// TODO: Bruk while til å simulere utladingen.
while(charge>0)
{
    Console.WriteLine("Charge Percentage:" +charge);
    charge -= 5;
}

Console.WriteLine("Power cell offline.");