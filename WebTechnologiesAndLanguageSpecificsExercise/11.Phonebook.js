/**
 * Created by Admin on 10/28/2016.
 */
var pb = {};
function phonebook(arr){

    var str = arr[0].split(' ');
    var command = str[0];
    var name = str[1];
    var phone = str[2];

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
            if (!hasKey) {console.log("Contact " + name + " does not exist.");}
            break;
        }
        case 'END' : {break;}
    }
}
phonebook(["A Nakov 12346"]);
phonebook(["A Mariika 45893"]);
phonebook(["S Mariika"]);
phonebook(["S Nakov"]);
phonebook(["END"]);