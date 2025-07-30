public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

        var result = new List<bool>();
        int max = 0;

        foreach(int candy in candies)
        {
            if(candy > max){
                max = candy;
            }
        }

        foreach(int candy in candies)
        {
            result.Add(candy + extraCandies >= max);
        }

        return result;
    }
}