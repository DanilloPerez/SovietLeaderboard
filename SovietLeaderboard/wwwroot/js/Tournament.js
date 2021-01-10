// first number is round (column), the rest is position (button)

function pickWinner(clickedButton, List) {
    console.log(clickedButton.id)
    var positionInRound = clickedButton.id.substring(1, clickedButton.id.length) // ID - First character
    var nextRound = parseInt(clickedButton.id.charAt(0)) + 1 // Roundnumber + 1
    var positionInNextRound = nextRound.toString() + (Math.floor(positionInRound / 2)).toString() // Determine position in next round 
    document.getElementById(positionInNextRound).textContent = clickedButton.textContent // Get buttonElement by previously set ID
    console.log(positionInNextRound)
    //  Give button teamname 
}
function placeTeams(teams) {
    teams.forEach(function (team) {
        document.getElementByID(team.PositionID).textContent = team.team.TeamName // fill first buttons with teamnames
    })
}