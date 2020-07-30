using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        int aCount = 0;
        int cCount = 0;
        int gCount = 0;
        int tCount = 0;
        foreach (char c in sequence) {
            if(c == 'A') { aCount++;}
            else if (c == 'C') { cCount++;}
            else if (c == 'G') { gCount++;}
            else if (c == 'T') { tCount++;}
            else {throw new System.ArgumentException("Includes invalid Characters");}
        }
        var nucleoCount = new Dictionary<char, int>();
        nucleoCount.Add('A', aCount); 
        nucleoCount.Add('C', cCount); 
        nucleoCount.Add('G', gCount); 
        nucleoCount.Add('T', tCount); 
        

        return nucleoCount;
    }
}