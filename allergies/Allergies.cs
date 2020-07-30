using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{
    private int allergyScore;
    public Allergies(int mask) {
        allergyScore = mask;
    }

    public bool IsAllergicTo(Allergen allergen) {
        return ((int)allergen & allergyScore) != 0;
    }

    public Allergen[] List()
    {
        List<Allergen> allergies = new List<Allergen>();
        foreach (Allergen item in Enum.GetValues(typeof(Allergen))) {
            if(IsAllergicTo(item)) {allergies.Add(item);}
        }
        return allergies.ToArray();
    }
}