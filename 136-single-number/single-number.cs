public class Solution {
    public int SingleNumber(int[] nums) {
        
        HashSet<int> hash = new HashSet<int>();
        

        foreach(var n in nums){
            if(!hash.Contains(n)){
            hash.Add(n);
            }else{
            hash.Remove(n);
            }
        }
        return hash.First();
    }
}