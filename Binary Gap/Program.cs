

public class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int max_gap_length = 0;
        int gap_length = 0;
        string binary = Convert.ToString(N, 2);
        foreach (char c in binary)
        {
            if (c.Equals('0'))
            {
                gap_length = gap_length + 1;
            }
            else
            {
                if (max_gap_length < gap_length)
                {
                    max_gap_length = gap_length;
                }
                gap_length = 0;    
            }
        }
        return max_gap_length;
    }
}



