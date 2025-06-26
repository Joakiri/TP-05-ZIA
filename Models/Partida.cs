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
    public string[] correctAnswers  {get; private set;}

    [JsonProperty]
    public DateTime inicio { get; private set; }

    [JsonProperty]
    public DateTime final { get; private set; }
    
    [JsonProperty]
    public string cronometro { get; private set; }
    public Partida(String name){
        this.currentRoom = 0;
        this.name = name;
        this.correctAnswers = new string[4];
        correctAnswers[0] = ""; correctAnswers[1] = "723";  correctAnswers[2] = "CULPA";  correctAnswers[3] = "";   
        this.inicio = DateTime.Now;
        this.final = DateTime.MinValue;
        this.cronometro = "";
    }
    public int moveFowardForm(string answer){
        if(answer.ToUpper() == correctAnswers[currentRoom]){
            currentRoom++;
        }
        return currentRoom;
    }
    public int moveFowardButton(){
        currentRoom++;
        if (currentRoom >= 4){
            if (final == DateTime.MinValue)
            {
                 final = DateTime.Now;
                 currentRoom++;
            }
            var crono = final - inicio;
            cronometro = crono.ToString(@"hh\:mm\:ss");
        }
        return currentRoom;
    }
}