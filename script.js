function selectMode(mode) {
    document.getElementById('mode-selection').classList.add('hidden');
    if (mode === 1) {
        document.getElementById('single-player').classList.remove('hidden');
    } else {
        document.getElementById('multi-player').classList.remove('hidden');
        document.getElementById('player1-actions').classList.remove('hidden');
        document.getElementById('player2-actions').classList.add('hidden');
    }
}

function playerAction(action) {
    const username = document.getElementById('username').value;
    const botAction = bot();
    let result = '';

    if (!username) {
        result = 'Please enter a username.';
    } else {
        result = `Bot: ${botAction}<br>`;
        if (action === botAction) {
            result += 'Draw';
        } else if (
            (action === 'r' && botAction === 's') ||
            (action === 'p' && botAction === 'r') ||
            (action === 's' && botAction === 'p')
        ) {
            result += `${username} Wins!`;
        } else {
            result += 'Bot Wins!';
        }
    }

    document.getElementById('result').innerHTML = result;
}

let player1ActionValue = null;

function player1Action(action) {
    player1ActionValue = action;
    document.getElementById('player1-actions').classList.add('hidden');
    document.getElementById('player2-actions').classList.remove('hidden');
}

function player2Action(action) {
    const player1 = player1ActionValue;
    const player2 = action;
    let result = `Player 1: ${player1}<br>Player 2: ${player2}<br>`;

    if (player1 === player2) {
        result += 'Draw';
    } else if (
        (player1 === 'r' && player2 === 's') ||
        (player1 === 'p' && player2 === 'r') ||
        (player1 === 's' && player2 === 'p')
    ) {
        result += 'Player 1 Wins!';
    } else {
        result += 'Player 2 Wins!';
    }

    document.getElementById('multi-result').innerHTML = result;
    document.getElementById('player1-actions').classList.remove('hidden');
    document.getElementById('player2-actions').classList.add('hidden');
    player1ActionValue = null;
}

function resetGame() {
    document.getElementById('mode-selection').classList.remove('hidden');
    document.getElementById('single-player').classList.add('hidden');
    document.getElementById('multi-player').classList.add('hidden');
    document.getElementById('result').innerHTML = '';
    document.getElementById('multi-result').innerHTML = '';
    document.getElementById('username').value = '';
    player1ActionValue = null;
}

function bot() {
    const actions = ['r', 'p', 's'];
    return actions[Math.floor(Math.random() * actions.length)];
}
