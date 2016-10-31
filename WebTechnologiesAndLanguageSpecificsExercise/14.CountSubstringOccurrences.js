/**
 * Created by Venzo on 29.10.2016.
 */
function counterString(arr){
    var string = arr[0];
    var word = arr[1];
    var counter = 0;
    for (var i = 0; i <= string.length; i++)
    {
        if (string.substring(i, word.length) == word){
            counter++;
        }
    }
    console.log(counter);
}

counterString(["aaaaaa","aa"]);