
function setColours() {
    if (!localStorage.getItem('cssColours')) {
        const colours = {
            '--red': '#ff0606',
            '--blue': '#097bf1',
            '--green': '#37f608',
            '--yellow': '#ffd800',
            '--pink': '#ff00dc'
        };

        localStorage.setItem('cssColours', JSON.stringify(colours));
    }
    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    for (const [key, value] of Object.entries(storedColours)) {
        document.documentElement.style.setProperty(key, value);
    }
}
setColours();


function updateColour(inputId, colorKey) { // Şimdi burada sürekli güncellenen kısımlara bakmam lazım. html tag ı nın id' sine göre tetiklenen rengin değeri güncelleniyo

    document.getElementById(inputId).addEventListener('input', function () {

        const selectedValue = this.value;

        let storedColours = JSON.parse(localStorage.getItem('cssColours'));

        storedColours[colorKey] = selectedValue;

        localStorage.setItem('cssColours', JSON.stringify(storedColours));

        setColours();
    });
}

updateColour('emptyId', '--red');
updateColour('fullId', '--blue');
updateColour('brokenId', '--green');
updateColour('dirtyId', '--yellow');
updateColour('reservedId', '--pink');

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

setDefaultColor('emptyId', '--red');
setDefaultColor('fullId', '--blue');
setDefaultColor('brokenId', '--green');
setDefaultColor('dirtyId', '--yellow');
setDefaultColor('reservedId', '--pink'); 