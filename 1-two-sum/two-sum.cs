public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                if(i != j && nums[i] + nums[j] == target){
                    int[] a = new int[2];
                    a[0] = i;
                    a[1] = j;
                    return a;
                }
        }
        }
        return null;
    }
}