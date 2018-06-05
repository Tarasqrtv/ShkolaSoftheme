
//a function that returns a new array within [min, max] of the old array
function filterArray(numbers, min, max) {
    var _arrayresult = [];
    var _j = 0;
    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] >= min && numbers[i] <= max) {
            _arrayresult[_j] = numbers[i];
            _j++;
        }
        else { continue }
    }
    return _arrayresult;
}
var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var result = filterArray(array, 3, 8);
console.log(result);

//a function that will check if the object is empty
function IsEmptyObject(MyObject) {
    if (Object.keys(MyObject).length === 0) {
        return true;
    }else{return false;}
}

var obj1 = {a: 1};
//var obj2 = {};

var res1 = IsEmptyObject(obj1);
console.log(res1);

// var res2 = IsEmptyObject(obj2);
// console.log(res2);

//The function returns an array of object keys
function GetArrayKeysObject(MyObject) {
    var _arr = [];
     if (Object.keys(MyObject).length!==0) {
        _arr = Object.keys(MyObject);
        return _arr;
    }else{return("Nothing to do")}  
}

var obj1 = { a: 1 , b: 2, c: 3};
var obj2 = {};

var res1 = GetArrayKeysObject(obj1);
console.log(res1);

// var res2 = GetArrayKeysObject(obj2);
// console.log(res2);