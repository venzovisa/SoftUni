/**
 * Created by Admin on 10/27/2016.
 */
function fibonacci(input){


    var result = 0;
    var f1 = 1;
    var f2 = 1;

    if (input < 2) { console.log("1"); }
    else
    {
        for (var i = 0; i < input - 1; i++)
        {
            result = f1 + f2;
            f1 = f2;
            f2 = result;
        }
        console.log(result)
    }
}

fibonacci(6);