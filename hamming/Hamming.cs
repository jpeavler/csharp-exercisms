using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hamDistance = 0;
        if(firstStrand.Length != secondStrand.Length) {
            throw new System.ArgumentException("Strands must be identical in length");
        }
        for(int i = 0; i < firstStrand.Length; i++) {
            if(firstStrand[i] != secondStrand[i]) {hamDistance++;}
        }
        return hamDistance;
    }
}