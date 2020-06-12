using System;

public class SpaceAge
{
    private int Seconds;
    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        double earthAge = Seconds / 31557600.0;
        return earthAge;
    }

    public double OnMercury()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}