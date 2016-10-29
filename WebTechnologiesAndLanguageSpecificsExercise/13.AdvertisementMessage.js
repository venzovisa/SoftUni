/**
 * Created by Venzo on 29.10.2016.
 */
function message(number) {
    function random(min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
var phrases = ["Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."];
var events = ["Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"];
var author = ["Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"];
var cities = ["Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"];
    for (var i = 0; i < number; i++){
        console.log(phrases[random(0, phrases.length - 1)] + " " + events[random(0, events.length - 1)] + " " + author[random(0, author.length - 1)] + " - " + cities[random(0, cities.length - 1)]);
    }
}

message(3);