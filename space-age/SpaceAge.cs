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
        return OnEarth()/.2408467;
    }

    public double OnVenus()
    {
        return OnEarth()/.61519726;
    }

    public double OnMars()
    {
        return OnEarth()/1.8808158;
    }

    public double OnJupiter()
    {
        return OnEarth()/11.862615;
    }

    public double OnSaturn()
    {
        return OnEarth()/29.447498;
    }

    public double OnUranus()
    {
        return OnEarth()/84.016846;
    }

    public double OnNeptune()
    {
        return OnEarth()/164.79132;
    }
}