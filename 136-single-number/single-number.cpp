class Solution {
public:
    int singleNumber(vector<int>& nums) {
        std::unordered_set<int> hash;

        for(int n : nums){
            if(!hash.contains(n)){
                hash.insert(n);
            }else{
                hash.erase(n);
            }
        }

        return *hash.begin();

    }
};