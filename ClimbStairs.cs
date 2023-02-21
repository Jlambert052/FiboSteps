public class Solution {
    public int ClimbStairs(int n) {
        int prev = 0;
        int current = 1;
        int ways = 0;
        int steps;
        for(steps = 1; steps <= n; steps++) {
            ways = prev + current;
            prev = current;
            current = ways;
        }
        System.Console.WriteLine($"There are {ways} ways to climb {n} stairs");
        return ways;
    }
}