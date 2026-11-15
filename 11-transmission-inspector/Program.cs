string transmission = "AB#CD##EF";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.

foreach (char hash in transmission)
{
    if (hash=='#')
    {
        interferenceCount++;
    }
}
Console.WriteLine($"Interference markers: {interferenceCount}");