/**
 * Created by Venzo on 31.10.2016.
 */
function censore(arr) {
    var banned = arr[0].split(/[\s,]+/);
    function asterix(stringLength){
        var str = "";
        for (var i = 0; i < stringLength; i++){
            str = str.concat("*");
        }
        return str;
    }
        for (var b = 0; b < banned.length; b++) {

            arr[1] = arr[1].split(banned[b]).join(asterix(banned[b].length));
        }
    console.log(arr[1]);
}

censore(["Linux, Windows",
    "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client"]);