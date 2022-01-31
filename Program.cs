using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string after reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = "";
                //for each character in string one by one
                foreach (char chr in s)
                {
                    //Applying If Condition to exclude required vowels/characters
                    if (chr != 'u' & chr != 'o' & chr != 'i' & chr != 'e' &
                        chr != 'a' & chr != 'U' & chr != 'O' & chr != 'I' & chr != 'E' & chr != 'A')
                    {
                        //storing value after each iteration
                        final_string = final_string + chr;
                    }
                }
                //Returning the final value
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //concatenating the string and comparing with the other concatenated string
                if (string.Join("", bulls_string1) == string.Join("", bulls_string2))
                {
                    //returning true to flag when both strings are same
                    return true;
                }
                else
                {
                    //returning false to flag when both strings are same
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //declaring an integer
                int x = 0;
                //assigning length of the input array to a variable length
                int length = bull_bucks.Length;
                //checking each value in variable bull bucks one by one
                foreach (int y in bull_bucks)
                {
                    //initializing count variable
                    int count = 0;
                    //initializing a loop beginning from zero through the length of variable bull bucks
                    for (int l = 0; l < length; l++)
                    {
                        //comparing for same integer values inside the array
                        if (y == bull_bucks[l])
                        {
                            //incrementing the count variable if repeating value found inside array
                            count = count + 1;
                        }
                    }
                    //if condition to check count variable is equal to 1
                    if (count == 1)
                    {
                        //finding the sum of the non repeated values and storing on variable x
                        x = x + y;
                    }
                }
                return x;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                //declaring integer with length of the array
                int x = bulls_grid.Length;
                int y = Convert.ToInt32(Math.Sqrt(x));
                //initializing variable z with value 0 to display total sum at end in z
                int z = 0;
                //for loop going through the length of the matrix
                for (int j = 0; j < y; j++)
                {
                    //sum of all primary and secondary diagonal elements of the matrix
                    z = z + bulls_grid[j, j] + bulls_grid[j, y - j - 1];
                }
                if (y % 2 != 0)
                {
                    /*subtracting the intersection value for both primary and secondary deagonals
                      if the matrix is odd length matrix(3*3/5*5/7*7 etc--*/
                    return z - bulls_grid[(y - 1) / 2, (y - 1) / 2];
                }
                else
                {
                    return z;
                }
            }
            catch (Exception a)
            {

                Console.WriteLine("An error occured: " + a.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //declaring the length of the bull string to another string x
                string[] x = new string[bulls_string.Length];
                string y = "";
                //running for loop for entire length of the bull string
                for (int m = 0; m < bulls_string.Length; m++)
                {
                    //assigning indices to integer variable b
                    int b = indices[m];
                    //rearranging the string according in incremental order of the array values
                    x[b] = Convert.ToString(bulls_string[m]);
                }
                for (int n = 0; n < bulls_string.Length; n++)
                {
                    //concatenating the rearranged string values throughout the entire length
                    y = y + x[n];
                }
                //finally returning the rearranged string
                return y;
            }
            catch (Exception b)
            {
                Console.WriteLine(b.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //declaring the length of the bull string to another string x
                string[] x = new string[bulls_string6.Length];
                //running for loop for entire length of the bull string
                for (int m = 0; m < bulls_string6.Length; m++)
                {
                    //condition to check if character in the string equals the particular given character
                    if (bulls_string6[m] == ch)
                    {
                        //string x has the value of the bull string till the character given
                        x = bulls_string6.Split(ch);
                    }
                }
                string y = "";
                //initializing the for loop reverse for the concatenated length of the bull string 
                for (int n = x[0].Length - 1; n >= 0; n--)
                {
                    y = y + bulls_string6[n];
                }
                //concatenating the reverse ordered string to the complete string value
                String prefix_string = ch + y + x[1];
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
