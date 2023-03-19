let puntaje = 100;
let puntajeMaximo = 0;
let numeroAleatorio = Math.floor(Math.random() * 20) + 1;
let intentos = [];

function adivinar() {
    let numero = parseInt(document.getElementById("numero").value);

    if (isNaN(numero) || numero < 1 || numero > 20) {
        document.getElementById("mensaje").innerHTML = "Por favor ingresa un número valido entre 1 y 20.";
        return;
    }

    if (numero === numeroAleatorio) {
        document.getElementById("mensaje").innerHTML = "Felicitaciones! Adivinaste el numero.";
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
        }

        document.getElementById("puntaje").innerHTML = puntaje;
    }

    // Agregar número ingresado a la lista de intentos
    let li = document.createElement("li");
    li.appendChild(document.createTextNode(numero));
    document.getElementById("intentos").appendChild(li);
}

function reiniciar() {
    puntaje = 100;
    document.getElementById("puntaje").innerHTML = puntaje;
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
    intentos = [];
    document.getElementById("numero").disabled = false;
    document.getElementsByTagName("button")[0].disabled = false;
    document.getElementById("mensaje").innerHTML = "";
    document.getElementById("intentos").innerHTML = "";
    document.body.style.backgroundColor = "#eee";
}



