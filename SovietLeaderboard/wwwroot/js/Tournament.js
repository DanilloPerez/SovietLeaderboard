function pickWinner(clickedButton) {
    var positionInRound = clickedButton.id.substring(1, clickedButton.id.length)
    var nextRound = parseInt(clickedButton.id.charAt(0)) + 1
    var positionInNextRound = nextRound.toString() + (Math.floor(positionInRound / 2)).toString()
    var nextRoundElement = document.getElementById(positionInNextRound)
    nextRoundElement.textContent = clickedButton.textContent

}