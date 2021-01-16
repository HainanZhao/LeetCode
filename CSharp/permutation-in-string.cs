using System;
using System.Collections.Generic;
using System.Text;

namespace PermutationInString
{
    public class Solution
    {
        private void AddToDict(Dictionary<char, int> dict, char key)
        {
            if (dict.ContainsKey(key))
                dict[key]++;
            else
                dict.Add(key, 1);
        }

        private void RemoveFromDict(Dictionary<char, int> dict, char key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]--;
                if (dict[key] == 0)
                    dict.Remove(key);
            }
        }

        private void UpdateDict(Dictionary<char, int> dict, char newKey, char oldKey)
        {
            //Console.WriteLine(newKey + "|" + oldKey);
            if (newKey == oldKey)
                return;

            AddToDict(dict, newKey);
            RemoveFromDict(dict, oldKey);
        }

        private void PrintDict(Dictionary<char, int> dict)
        {
            Console.WriteLine("----");
            foreach (var k in dict.Keys)
            {
                Console.WriteLine(k + ":" + dict[k]);
            }
        }

        private bool CompareDict(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            //PrintDict(dict2);
            if (dict1.Count != dict2.Count)
                return false;

            foreach (var k in dict1.Keys)
            {
                if (!dict2.ContainsKey(k))
                    return false;

                if (dict1[k] != dict2[k])
                    return false;
            }

            return true;
        }

        public bool CheckInclusion(string s1, string s2)
        {

            var dict1 = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                AddToDict(dict1, s1[i]);
            }

            PrintDict(dict1);

            var dict2 = new Dictionary<char, int>();
            for (int j = 0; j < s2.Length; j++)
            {
                if (j < s1.Length)
                {
                    AddToDict(dict2, s2[j]);
                }
                else
                {
                    UpdateDict(dict2, s2[j], s2[j - s1.Length]);
                }

                if (j >= s1.Length - 1 && CompareDict(dict1, dict2))
                    return true;
            }

            return false;
        }
    }
}
