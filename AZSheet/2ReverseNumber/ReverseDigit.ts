function reverse(x: number): number {
let ans = 0;
let min = -1 * (2 ** 31);
let max = 2 ** 31 - 1;
while(x!=0){

if( x > -10 && x < 10){
    ans = x;
x = 0;
return ans;
}
let k = x % 10;
ans = ans*10 + k;
x = x - k; 
let d = x/ 10;
if( d > -10 && d < 10){
    ans = ans*10 + d;
x = 0;
}
else {
    x = d;
}
if(ans < min || ans > max){
    return 0;
}
};
return ans;
}