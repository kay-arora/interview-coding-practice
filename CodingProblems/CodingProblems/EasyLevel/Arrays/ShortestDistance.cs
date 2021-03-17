using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class ShortestDistance
    {
        public static int FindShortestDistance(string[] wordsDict, string word1, string word2)
        {

            int word1Index = -1;
            int word2Index = -1;
            int minDist = wordsDict.Length;

            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                    word1Index = i;
                else if (wordsDict[i] == word2)
                    word2Index = i;

                if (word1Index != -1 && word2Index != -1)
                {
                    minDist = Math.Min(minDist, Math.Abs(word1Index - word2Index));
                }
            }

            return minDist;
        }
    }
}


/*
 *     public int shortestWordDistance(String[] words, String word1, String word2) {
        if(words == null || words.length < 2){
            return -1;
        }
        int l1=-1,l2=-1,prevl1=-1,minlen=words.length;
        for(int k = 0; k < words.length; k++){
            String word = words[k];
            if(word1.equals(word)){
                prevl1 = l1;
                l1=k;
            }
            if(word2.equals(word)){
                if(!word1.equals(word2)){
                    l2=k;
                }
                else{
                    l2 = prevl1;
                    }
            }
            if(l1!=-1&&l2!=-1)
                if(minlen>Math.abs(l2-l1)){
                    minlen = Math.abs(l2-l1);
                }
        }
        if(l1==-1||l2==-1){
            return -1;
        }
        return minlen;
    }
}*/