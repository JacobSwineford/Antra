// 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

let sum = 0;
for (let name in salaries) {
    sum += salaries[name];
}
console.log(sum + '\n');

// 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

multiplyNumeric(menu);
print(menu);

function multiplyNumeric(menu) {
    for (let o in menu) {
        console.log(typeof(menu[o]));
        if (typeof(menu[o]) == "number") {
            menu[o] = menu[o] * 2;
        }
    }
}

function print(object) {
    console.log(object);
    for (let i in object) {
        console.log(i + " " + object[i]);
    }
}

// 3
function checkEmailID(id) {
    return /@[a-z]+\./g.exec(id);
}

console.log(checkEmailID("jas47367@huskies.bloomu.edu"));

// 4
function truncate(str) {
    if (str.sen.length > 20) {
        str.sen = str.sen.substring(0, 17) + "...";
    }
}

let str = { // pass by reference
    sen: "hi there my name is jacob, nice to meet you!"
}
console.log(str.sen + " " + str.sen.length);
truncate(str);
console.log(str.sen);

// 5
let styles = ["James", "Brennie"];
console.log(styles);
styles.push("Robert");
console.log(styles);
styles[Math.floor(styles.length / 2)] = "Calvin";
console.log(styles);
styles.pop();
console.log(styles);
styles.unshift("Regal");
styles.unshift("Rose");
console.log(styles);

