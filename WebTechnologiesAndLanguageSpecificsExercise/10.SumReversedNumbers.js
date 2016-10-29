/**
 * Created by Admin on 10/28/2016.
 */
function sumReversedNumbers(arr){
    var numArr = arr[0].split(' ');
    var sum = 0;
    for(var i = 0; i < numArr.length; i++){
       sum += Number(numArr[i].split('').reverse().join(''));
    }
    console.log(sum);
}
sumReversedNumbers(["123 234 12"]);