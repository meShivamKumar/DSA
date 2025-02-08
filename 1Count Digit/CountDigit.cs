//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {
            int N = Convert.ToInt32(Console.ReadLine()); // Input for size of array
            Solution obj = new Solution();
            int res = obj.evenlyDivides(N);
            Console.Write(res + "\n");

            Console.Write("~" + "\n");
        }
    }
}
}

// } Driver Code Ends


// User function Template for C#

class Solution {
    public int evenlyDivides(int n) {
        // code here
        int nov = 0;
    List<int> values = separate(n);
    
    for( int i =0; i<values.Count; i++){  //can aslo use foreach (int i in l)
        
        if(n % values[i] == 0){
            
        nov = nov + 1;
        }
        
    }
    
    return nov;
    }
    
    public List<int> separate(int n){
        List<int> sep = new List<int>();
        
        while(n > 0){
        int k = n % 10;
        n = n - k;
        if(k > 0){
            sep.Add(k);
        }
        int d = n / 10;
        if(d < 10 && d > 0){
            sep.Add(d);
            n = -1;
        }
        else {
            n = d;
        }
        }
        return sep;
        
    }
}