const maxIntentos = 10;
let numeroGenerado;
let intentos;
let puntaje;
let puntajeAlto = 0;

function generarNumero() {
    numeroGenerado = Math.floor(Math.random() * 20) + 1;
    intentos = maxIntentos;
    puntaje = 100;
    actualizarPantalla();
}

function adivinar() {
    const inputNumero = document.getElementById("numero");
    const mensaje = document.getElementById("mensaje");
    const pista = document.getElementById("pista");

    const numeroUsuario = parseInt(inputNumero.value);

    if (isNaN(numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 20) {
        mensaje.innerHTML = "Por favor ingresa un numero valido entre 1 y 20.";
        mensaje.style.color = "black";
        return;
    }

    if (intentos > 0) {
        if (numeroUsuario === numeroGenerado) {
            mensaje.innerHTML = "Adivinaste!";
            mensaje.style.color = "green";
            inputNumero.disabled = true;
        } else {
            intentos--;
            puntaje -= 10;
            actualizarPantalla();
            if (intentos === 0) {
                mensaje.innerHTML = `Se acabaron los intentos! El numero era ${numeroGenerado}.`;
                mensaje.style.color = "red";
                inputNumero.disabled = true;
            } else {
                mensaje.innerHTML = `Intenta de nuevo. Te quedan ${intentos} intentos.`;
                mensaje.style.color = "black";
                if (numeroUsuario > numeroGenerado) {
                    pista.innerHTML = "El numero es menor.";
                } else {
                    pista.innerHTML = "El numero es mayor.";
                }
            }
        }
    }
}

function reiniciar() {
    const inputNumero = document.getElementById("numero");
    inputNumero.disabled = false;
    inputNumero.value = "";
    const mensaje = document.getElementById("mensaje");
    mensaje.innerHTML = "";
    const pista = document.getElementById("pista");
    pista.innerHTML = "";
    generarNumero();
}

function actualizarPantalla() {
    const puntajeElemento = document.getElementById("puntaje");
    const puntajeAltoElemento = document.getElementById("puntaje-alto");

    puntajeElemento.innerHTML = puntaje;
    if (puntaje > puntajeAlto) {
        puntajeAlto = puntaje;
        puntajeAltoElemento.innerHTML = puntajeAlto;
    }
}

generarNumero();
