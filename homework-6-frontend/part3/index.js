
//1.yontem
const firstMetod = (str) => {
    return str.split("").reverse().join("");
  };
  console.log("esma: "+firstMetod("esma"));

  //2.yontem
  function secondMethod(str) {
    var newStr = "";
    for (var i = str.length - 1; i >= 0; i--) {
      newStr += str[i];
    }
    return newStr;
  }
  console.log("asli: "+secondMethod("asli"));

  //3.yontem
  //rekursif yapida calistigi icin 3.yontemin en optimal cozum
  //oldugunu dusunuyorum.
  function thirdMethod(str){
    if(str.length==0)
    return "";
    else
    return thirdMethod(str.slice(1)) + str.charAt(0); 
}
console.log("seda: "+thirdMethod("seda"));

//4.yontem
const fourthMethod = (str) => {
    let newStr = [];
    for (const letter of str) {
      newStr.unshift(letter); //push dizinin sonuna,unshift dizinin basina eleman ekler
    }
    return newStr.join("");
  };
  console.log("belgin: "+fourthMethod("belgin"));

