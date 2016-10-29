var dict = {};
dict["key1"] = "value1";
dict["key2"] = "value2";
dict["key1"] = "valueEdit";
for (key in dict) {
    console.log(dict[key]);
}