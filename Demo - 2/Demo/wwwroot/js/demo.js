
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

document.getElementById('emptyId').addEventListener('input', function () {
    const selectedValue = this.value;

    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    storedColours['--red'] = selectedValue;

    localStorage.setItem('cssColours', JSON.stringify(storedColours));

    setColours();
});


document.getElementById('fullId').addEventListener('input', function () {
    const selectedValue = this.value;

    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    storedColours['--blue'] = selectedValue;

    localStorage.setItem('cssColours', JSON.stringify(storedColours));

    setColours();
});

document.getElementById('brokenId').addEventListener('input', function () {
    const selectedValue = this.value;

    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    storedColours['--green'] = selectedValue;

    localStorage.setItem('cssColours', JSON.stringify(storedColours));

    setColours();
});

document.getElementById('dirtyId').addEventListener('input', function () {
    const selectedValue = this.value;

    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    storedColours['--yellow'] = selectedValue;

    localStorage.setItem('cssColours', JSON.stringify(storedColours));

    setColours();
});

document.getElementById('reservedId').addEventListener('input', function () {

    const selectedValue = this.value;

    let storedColours = JSON.parse(localStorage.getItem('cssColours'));

    storedColours['--pink'] = selectedValue;

    localStorage.setItem('cssColours', JSON.stringify(storedColours));

    setColours();
});

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