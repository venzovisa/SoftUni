/**
 * Created by Admin on 10/28/2016.
 */
function compare(strings){
    var str1 = strings[0].split(' ');
    var str2 = strings[1].split(' ');

    var print = '';

    function secondFirst(str1, str2){
        for (var x = 0; x < str2.length; x++) { print += str2[x]; }
        console.log(print);
        print = "";
        for (var y = 0; y < str1.length; y++) { print+= str1[y]; }
        console.log(print);
    }

    function firstSecond(str1, str2){
        for (var x2 = 0; x2 < str1.length; x2++) { print += str1[x2]; }
        console.log(print);
        print = "";
        for (var y2 = 0; y2 < str2.length; y2++) { print += str2[y2]; }
        console.log(print);
    }

    if (str1.length == str2.length)
    {

        if (str1[0] > str2[0])
        {
            secondFirst(str1, str2);
        }
        else
        {
            firstSecond(str1, str2);
        }
    }
    else if (str1[0] == str2[0]){
        if (str1.length < str2.length)
        {
            firstSecond(str1, str2);
        }
        else {
            secondFirst(str1, str2);
        }
    }
}

compare(["a n n i e", "a n"]);