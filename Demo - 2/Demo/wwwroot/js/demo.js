
function setColours() {
    var x = localStorage.getItem('cssColours');
    if (!x) {
        const colours = {
            '--red': '#ff0606',
            '--blue': '#097bf1',
            '--green': '#37f608',
            '--yellow': '#ffd800',
            '--pink': '#ff00dc'
        };

        localStorage.setItem('cssColours', JSON.stringify(colours));
    }
    let storedColours = JSON.parse(x);

    for (const [key, value] of Object.entries(storedColours)) {
        document.documentElement.style.setProperty(key, value);
    }
}
setColours();


// function  selectColor
//function selectColor(inputId, colorKey) {
//    document.getElementById(inputId).addEventListener('input', function () {
//        const selectedValue = this.value;

//        let storedColours = JSON.parse(localStorage.getItem('cssColours'));

//        storedColours[colorKey] = selectedValue;

//        localStorage.setItem('cssColours', JSON.stringify(storedColours));

//        setColours();
//    });
//}

function selectColor(inputId, colorKey) {
    document.getElementById(inputId).addEventListener('input', function () {
        // Renk kabul fonksiyonu buraya yazılacak içerisine inputId ve colorkey gönbderilerecek. Dönüş olarak true veya false dönecek. Dönüş tipine göre işleme izin verecek veya işlemden çıkacak.

        beValidColorByInputId();

        //var x = hexToDecimal(colorKey);


        if (x) {
            const selectedValue = this.value;

            let storedColours = JSON.parse(localStorage.getItem('cssColours'));

            storedColours[colorKey] = selectedValue;

            localStorage.setItem('cssColours', JSON.stringify(storedColours));

            setColours();
        }
        else {
            //Hata
        }


        
        //// HEX'ten Decimal'e Dönüşüm Fonksiyonu
        //function hexToDecimal(hex) {
        //    return parseInt(hex.slice(1), 16); // '#' karakterini atarak hexadecimal'i decimal'e çevirir
        //}

        //const redStart = hexToDecimal('#800000'); 
        //const redEnd = hexToDecimal('#FF7F7F');   

        //const yellowStart = hexToDecimal('#808000'); 
        //const yellowEnd = hexToDecimal('#FFFF7F');   
        
        //const greenStart = hexToDecimal('#008000'); 
        //const greenEnd = hexToDecimal('#80FF80');   
        
        //const selectedDecimal = hexToDecimal(selectedValue);

        
        //if (selectedDecimal >= redStart && selectedDecimal <= redEnd ) {
        //    alert("KIRMIZI RENK SEÇEMEZSİN!");
        //}
        
        //else if (selectedDecimal >= yellowStart && selectedDecimal <= yellowEnd) {
        //    alert("SARI RENK SEÇEMEZSİN!");
        //}
        
        //else if (selectedDecimal >= greenStart && selectedDecimal <= greenEnd) {
        //    alert("YEŞİL RENK SEÇEMEZSİN!");
        //}
        
    });
}

// 3 tanesi için olduğunu düşünüyorum. Input a göre değişecek yine. o zaman tek input değişkeni alıcam ve o inputa göre hangi renk olmuyor ise onu çağırcam.
//function blockColor(inputId) {

//    if (inputId == "" && colorKey = "") {
//        alert(`${colorKey} rengini kullanamzsınız.`);
//    }
//}

// Colorpicker' ın default olarak renklerinin gelmesi 
function setDefaultColor(inputId, colorKey) {

    const storedColours = JSON.parse(localStorage.getItem('cssColours'));

    if (storedColours) {

        const colorInput = document.getElementById(inputId);

        if (colorInput) {
            colorInput.value = storedColours[colorKey];
        }
    }
}  


setDefaultColor('inputStatusColorEmpty', '--red');
setDefaultColor('inputStatusColorFull', '--blue');
setDefaultColor('inputStatusColorBroken', '--green');
setDefaultColor('inputStatusColorDirty', '--yellow');
setDefaultColor('inputStatusColorReserved', '--pink'); 

function beValidColorByInputId(inputId, colorKey) {

    // Gelen renk ile gelen inputıd karşılaştırılıp geçerli olup olmadıgı kontrol edilecek.

    // Kırmızı #FF0000
    // Beyaz #FFFFFF
    // Siyah #000000

    if (colorKey == '#FF0000' && inputId == "inputStatusColorEmpty") {
        alert("Empty için kırmızı renk seçemezsiniz.");
    } else if (colorKey == '#000000' && inputId == "inputStatusColorDirty") {
        alert("Dirty için siyah renk seçemezsiniz.");
    } else if (colorKey == '#FFFFFF' && inputId == "inputStatusColorReserved") {
        alert("Reserved için beyaz renk seçemezsiniz.");
    } else {
        return true;
    }
}