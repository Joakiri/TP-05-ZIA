namespace TP_05_ZIA;
using Newtonsoft.Json;
using System.Timers;
public class Partida
{
    [JsonProperty]
    public int currentRoom {get; private set;}
    [JsonProperty]
    public string name {get; private set;}

    [JsonProperty]
    public Timer timer {get; private set;}

    [JsonProperty]
    public Dictionary <int, string> hints {get; private set;}

    public string[] correctAnswers  {get; private set;}
    public Partida(String name){
        this.currentRoom = 0;
        this.name = name;
        this.timer = new Timer(500);
        this.hints = new Dictionary<int, string>();
        hints.Add(1, "Encontrar la llave para poder salir de la celda");hints.Add(2, "Encontra el codido par abrir la puerta");hints.Add(3, "Me usan para entrar, me ocultan para escapar.Sin mí, la cerradura no se puede desbloquear. No soy palabra ni truco, pero soy la clave del lugar. ¿Qué soy?");hints.Add(4, "Cada puerta tiene un cartel, pero solo uno de ellos dice la verdad. Los otros dos mienten.Puerta 1: 'La puerta 2 conduce a la libertad.'Puerta 2: 'No saldrás por esta puerta.'Puerta 3: 'La puerta 1 miente.'");
        this.correctAnswers = new string[4];
        correctAnswers[1] = ""; correctAnswers[2] = "";  correctAnswers[3] = "";  correctAnswers[4] = "";     
    }
    public void moveFoward(){
        
    }
    public int moveFowardForm(string answer){
        if(answer == correctAnswers[currentRoom]){
            currentRoom++;
        }
        return currentRoom;
    }
    public int moveFowardButton(){
        currentRoom++;
        return currentRoom;
    }
}