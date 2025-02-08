//{ Driver Code Starts
// Initial Template for javascript

'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => { inputString += inputStdin; });

process.stdin.on('end', _ => {
    inputString =
        inputString.trim().split('\n').map(string => { return string.trim(); });

    main();
});

function readLine() { return inputString[currentLine++]; }

function main() {
    let t = parseInt(readLine());
    let i = 0;
    for (; i < t; i++) {
        let N = parseInt(readLine());
        let obj = new Solution();
        let res = obj.evenlyDivides(N);
        console.log(res);

        console.log("~");
    }
}

// } Driver Code Ends

// } Driver Code Ends


// User function Template for javascript

/**
 * @param {number} n
 * @returns {number}
 */

class Solution {
    // Function to check whether the number evenly divides n.
    evenlyDivides(n) {
        // code here
        
        let values = this.separate(n);
        let nov = 0;
        
        for(let i =0; i < values.length; i++){
            
            if(n % values[i] == 0){
                nov = nov + 1;
            }
        }
        
        return nov;
    }
    
    separate(n) {
        let a = [];
        while(n > 0){  // 12
            let k = n%10;  // 2
            n = n - k; // 12-2 = 10
            if(k > 0){ //2

                a.push(k); //[2]
    
            }
            let d = n/10; // 10/10 =1
            if( d < 10 && d > 0){ // true
   
                a.push(d); //[2,1]
    
                n = -1; 
            }
            else{ 
            n = d; 
            }
        }
        
        return a; //[2,1]
        
    }
}