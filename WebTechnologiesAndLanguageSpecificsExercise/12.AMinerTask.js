/**
 * Created by Venzo on 29.10.2016.
 */
function minerTask(arr){
    var resources = {};
    var hasEmpty = false;
    var emptyName = "";
    for (var a = 0; a < arr.length - 1; a += 2) {
        if (arr[a] != "stop") {
            if (resources.hasOwnProperty(arr[a])){
                resources[arr[a]] += Number(arr[a+1]);
            } else {resources[arr[a]] = Number(arr[a+1]);
                    if (arr[a] == "" || arr[a] == " ") {hasEmpty = true;emptyName = arr[a]; break;}
                        }
        } else {break;}
    }

    if (!hasEmpty){
        for (key in resources){
            console.log(key + ' -> ' + resources[key]);
        }
    } else {console.log('-> ' + resources[emptyName]);}

}

//minerTask(["Gold", "155", "Silver", "10", "Copper", "17", "Silver", "90", "stop", "Venzo", "007"]);
minerTask([" ", "12", "", "10", "stop", "Venzo", "007"]);