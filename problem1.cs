public class Solution {
    public int Change(int amount, int[] coins) {
        int m = coins.Length;
        int n=amount;
        int[,] dp=new int[m+1,n+1];
        dp[0,0]=1;
        for(var i=1;i<=m;i++)
        {
            for(var j=0;j<=n;j++)
            {
                if(j<coins[i-1])
                {
                    dp[i,j] = dp[i-1,j];
                }
                else
                {
                    dp[i,j] = dp[i-1,j]+dp[i,j-coins[i-1]];
                }
            }
        }
        return dp[m,n]; 
    }
}