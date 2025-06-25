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
    public string[] correctAnswers  {get; private set;}
    public Partida(String name){
        this.currentRoom = 0;
        this.name = name;
        this.timer = new Timer(500);
        this.correctAnswers = new string[4];
        correctAnswers[0] = ""; correctAnswers[1] = "723";  correctAnswers[2] = "LLAVE";  correctAnswers[3] = "";     
    }
    public int moveFowardForm(string answer){
        if(answer == correctAnswers[currentRoom + 1]){
            currentRoom++;
        }
        return currentRoom;
    }
    public int moveFowardButton(){
        currentRoom++;
        return currentRoom;
    }
}