//kendisine verilen sayinin yarisini alip 3 eklenmis halini
//donduren ozel toplama fonksiyonu
let girlsPowerToplami =number=>{ 
    number=number/2 +3;
    return number;
}

//parametre olarak array alan ve yine array donduren high order function
function girlsPower(...arr){ //gonderilen arrayin eleman sayisi belli olmadigi icin ...
    let result;
    arr.forEach(element => {
        result = arr.map(element => girlsPowerToplami(element)) //her bir elemani girlsPowerToplami fonksiyonuna yolluyoruz
    });
    return result;
}
const arr2=[4,8,12,16];
const arr =[2,3,4];
console.log(arr,"girlsPower =>",girlsPower(...arr));
console.log(arr2,"girlsPower =>",girlsPower(...arr2));