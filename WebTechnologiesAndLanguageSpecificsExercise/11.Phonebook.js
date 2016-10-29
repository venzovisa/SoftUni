/**
 * Created by Admin on 10/28/2016.
 */

function phonebook(arr){
    var pb = {};
    for (var i = 0; i < arr.length; i++ ) {
        var temp = arr[i].split(' ');
        var command = temp[0];
        var name = temp[1];
        var phone = temp[2];

        switch (command) {
            case "A" : {
                pb[name] = phone;
                break;
            }
            case "S" : {
                var hasKey = false;
                for (key in pb) {
                    if (key == name) {
                        console.log(key + " -> " + pb[key]);
                        hasKey = true;
                        break;
                    }
                }
                if (!hasKey) {
                    console.log("Contact " + name + " does not exist.");
                }
                break;
            }
            case "END" : {
                return;
            }
        }
    }
}
phonebook(["A Nakov 12346",
    "A Mariika 45893",
    "S Mariika",
    "S Nakov",
    "S Marto",
    "END",
    "A Venzo 007"]);