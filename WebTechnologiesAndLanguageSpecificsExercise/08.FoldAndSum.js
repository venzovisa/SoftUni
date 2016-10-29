/**
 * Created by Admin on 10/28/2016.
 */
function foldAndSum(arr){
    var temp = arr[0].split(' ');
    var number = [];
    for (var num = 0; num < temp.length; num++){
        number[num] = Number(temp[num]);
    }
    var middlePart = [];
    var leftPart = [];
    var rightPart = [];

    // left part
    for  (var x = 0; x < number.length / 4; x++){
        leftPart[x] = number[x];
    }
    leftPart.reverse();

    // right part
    var counter = 0;
    for  (var z = (number.length / 4) + (number.length / 2); z < number.length ; z++){
        rightPart[counter] = number[z];
        counter++;
    }
    rightPart.reverse();

    // middle part
    counter = 0;
    for  (var y = (number.length / 4); y < (number.length / 2 ) + (number.length / 4); y++){
        middlePart[counter] = number[y];
        counter++;
    }

    // left + middle
    counter = 0;
    for (var lm = 0; lm < leftPart.length; lm++){
        middlePart[lm] += leftPart[counter];
        counter++;
    }

    // right + middle
    counter = 0;
    for (var rm = (middlePart.length / 2 ) ; rm < middlePart.length; rm++){
        middlePart[rm] += rightPart[counter];
        counter++;
    }
    console.log(middlePart.join(" "));
}
foldAndSum(["5 2 3 6"]);