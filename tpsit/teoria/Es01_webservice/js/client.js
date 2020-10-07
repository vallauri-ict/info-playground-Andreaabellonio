let datiComuni;
let comuni;
let provincie;
let regioni;

function init() {
    caricaComuni();
}

function caricaComuni() {
    $.ajax({
        url: "http://raw.githubusercontent.com/matteocontrini/comuni-json/master/comuni.json",
        type: "GET",
        success: function (response) {
            if (typeof (response) === "string") {
                try {
                    regioni = new Array();
                    comuni = new Array();
                    provincie = new Array();
                    let oggetto;
                    datiComuni = JSON.parse(response);
                    //eleboro i dati ed estraggo i vettori
                    for (let i = 0; i < datiComuni.length; i++) {
                        //estraggo le regioni
                        let esiste = regioni.map(function () { }).indexOf(datiComuni[i].regione.nome);
                        if (esiste == -1) {
                            oggetto = new Object();
                            oggetto.nome = datiComuni[i].regione.nome;
                            regioni.push(oggetto);
                        }
                        //estraggo le provincie
                        esiste = provincie.map(function () { }).indexOf(datiComuni[i].provincia.nome);
                        if (esiste == -1) {
                            oggetto = new Object();
                            oggetto.nome = datiComuni[i].provincia.nome;
                            oggetto.reg = datiComuni[i].regione.nome;
                            provincie.push(oggetto);
                        }
                        oggetto = new Object();
                        oggetto.nome = datiComuni[i].nome;
                        oggetto.reg = datiComuni[i].regione.nome;
                        oggetto.pro = datiComuni[i].provincia.nome;
                        comuni.push(oggetto);
                    }
                    //ordinamento vettori
                    comuni.sort();
                    //caricamento delle select con i vettori
                    caricaSelect("selComuni", comuni);
                    caricaSelect("selProvincie", provincie);
                    caricaSelect("selRegioni", regioni);
                }
                catch (e) {
                    errore(e);
                }
            }
        },
        error: errore
    });
}

function caricaSelect(id, dati) {
    let sel = document.getElementById(id);
    for (let i = 0; i < dati.length; i++) {
        let option = document.createElement("option");
        option.value = i;
        option.text = dati[i].nome;
        sel.appendChild(option);
    }
}

function cambioRegione(sel){
    alert(sel);
}

function errore(e) {
    stampa("Errore: " + e);
}

function stampa(msg) {
    alert(msg);
}