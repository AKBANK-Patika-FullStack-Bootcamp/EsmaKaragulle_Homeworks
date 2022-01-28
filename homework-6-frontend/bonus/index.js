var findWords = function(words) {
    var result = [];
    
    //karakterin yanlarindaki sayilar klavyenin kacinci satirinda olduklarini belirtmek icin tutulmustur
    //amac yalnizca ayni satirdaysa kelimeyi dondurmek.
    var keyboard = {'q':1, 'w':1, 'e':1, 'r':1, 't':1, 'y':1, 'u':1, 'i':1, 'o':1, 'p':1,'ğ':1, 'ü':1,
                    'a':2, 's':2, 'd':2, 'f':2, 'g':2, 'h':2, 'j':2, 'k':2, 'l':2,'ş':2, 'i':2,
                    'z':3, 'x':3, 'c':3, 'v':3, 'b':3, 'n':3, 'm':3, 'ö':3, 'ç':3
    };
    
    for (var i=0; i<words.length; i++) {
        var row = 0;
        
        for (var j=0; j<words[i].length; j++) {
            var ch = words[i][j].toLowerCase();
            
            if (j === 0) {
                row = keyboard[ch];
            }
            else if (keyboard[ch] !== row) {
               
                break;
            }
        }
        
        if (j === words[i].length) {
            
            result.push(words[i]);
        }
    }
    
    return result;
};
let input =["asli", "menekşe", "çöz", "giresun"];
console.log("girilen dizi: ",input);
console.log("sonuc: ",findWords(input))