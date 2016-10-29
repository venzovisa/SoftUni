/**
 * Created by Admin on 10/27/2016.
 */
function toHexAndBinary (integer){
    let  hex = parseInt(integer).toString(16);
    let  bin = parseInt(integer).toString(2);
    console.log(hex.toUpperCase());
    console.log(bin);
}
toHexAndBinary(10);