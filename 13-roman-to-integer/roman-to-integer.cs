public class Solution {

    
    public int RomanToInt(string s) {

        var d = new Dictionary<char,int>();

        d['I'] = 1;
        d['V'] = 5;
        d['X'] = 10;
        d['L'] = 50;
        d['C'] = 100;
        d['D'] = 500;
        d['M'] = 1000;
    

        var value = 0;
        for(int i = 0; i < s.Length; i++){
            var ns = d[s[i]];

            if(i < s.Length - 1){
            
            int nv = d[s[i + 1]];  

            if(nv > ns){
                    ns = nv - ns;
                    i++;
                }
                
            }

                
            
            
            if(ns != null){
            value = value + ns;
            }

        }
        return value;
    }
}