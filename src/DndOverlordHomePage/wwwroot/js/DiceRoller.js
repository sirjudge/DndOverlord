$(document).ready(function() {
    console.log("page loaded")
});

function Roll(){
    let numberOfDice = $("#numberOfDiceToRoll").val();
    let numberOfSides = $("#diceSides").val();
    let rollTotal = 0;
    for (let i = 0; i < numberOfDice ; i ++){
        //todo: this can roll 0, figure out how to make it not roll 0
        let numRoller = Math.floor(Math.random() * numberOfSides);
        rollTotal += numRoller;
    }
    $("#rollOutputBox").val(rollTotal);
}