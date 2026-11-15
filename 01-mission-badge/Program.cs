string pilotName = "Rhea";
string shipName = "Halcyon";
string sector = "K-19";

// TODO: Lag badge med string interpolation.
//string badge = "PILOT: "+pilotName+"SHIPNAM: "+shipName+" SECTOR: "+sector;

string badge = $"PILOT: {pilotName} | SHIPNAME: {shipName} | SECTOR: {sector}";


Console.WriteLine(badge);
