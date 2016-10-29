/**
 * Created by Admin on 10/27/2016.
 */
function prime(num){
    var number = Number(num);
    if (number < 2) {console.log("False");}
    else {
        var isPrime = "True";
        var counter = 2;
        while (counter <= Math.sqrt(number)) {
            if (number % counter == 0) {isPrime = "False"; break;}
            counter++;
        }
        console.log(isPrime);
    }
}

prime(4);