let puntaje = 100;
let puntajeMaximo = 0;
let numeroAleatorio = Math.floor(Math.random() * 20) + 1;
let intentos = [];

function adivinar() {
    let numero = parseInt(document.getElementById("numero").value);

    if (isNaN(numero) || numero < 1 || numero > 20) {
        document.getElementById("mensaje").innerHTML = "Por favor ingresa un numero valido entre 1 y 20.";
        return;
    }

    if (numero === numeroAleatorio) {
        document.getElementById("mensaje").innerHTML = "Felicitaciones! Adivinaste el numero.";
        lanzarConfetti();
        document.body.style.backgroundColor = "#4CAF50";
        document.getElementById("numero").disabled = true;
        document.getElementsByTagName("button")[0].disabled = true;

        if (puntaje > puntajeMaximo) {
            puntajeMaximo = puntaje;
            document.getElementById("puntaje-alto").innerHTML = puntajeMaximo;
        }

    } else {
        puntaje -= 10;

        if (puntaje <= 0) {
            document.getElementById("mensaje").innerHTML = "Te has quedado sin intentos.";
            document.body.style.backgroundColor = "#ff0000";
            document.getElementById("numero").disabled = true;
            document.getElementsByTagName("button")[0].disabled = true;
            puntaje = 0;
        } else {
            let pista = (numero > numeroAleatorio) ? "El numero es menor." : "El numero es mayor.";
            document.getElementById("mensaje").innerHTML = "Intenta de nuevo. " + pista;

            let li = document.createElement("li");
            li.appendChild(document.createTextNode(numero));
            document.getElementById("intentos").appendChild(li);
        }

        document.getElementById("puntaje").innerHTML = puntaje;
    }
   
}

function reiniciar() {
    puntaje = 100;
    document.getElementById("puntaje").innerHTML = puntaje;
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
    intentos = [];
    document.getElementById("numero").disabled = false;
    document.getElementById("numero").value = "";
    document.getElementsByTagName("button")[0].disabled = false;
    document.getElementById("mensaje").innerHTML = "";
    document.getElementById("intentos").innerHTML = "";
    document.body.style.backgroundColor = "#eee";
    //console.log("El número generado es:", numeroAleatorio);
}

function lanzarConfetti() {
    const duration = 3000;
    const animationEnd = Date.now() + duration;
    const defaults = { startVelocity: 30, spread: 360, ticks: 60, zIndex: 0 };

    function randomInRange(min, max) {
        return Math.random() * (max - min) + min;
    }

    const interval = setInterval(function () {
        const timeLeft = animationEnd - Date.now();

        if (timeLeft <= 0) {
            return clearInterval(interval);
        }

        const particleCount = 50 * (timeLeft / duration);      
        confetti({
            ...defaults,
            particleCount,
            origin: { x: randomInRange(0.1, 0.3), y: 0.5 }
        });
        confetti({
            ...defaults,
            particleCount,
            origin: { x: randomInRange(0.7, 0.9), y: 0.5 }
        });
    }, 250);
}





