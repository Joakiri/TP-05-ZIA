namespace TP_04_ZIA;
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

    public Partida(String name){
        this.currentRoom = 0;
        this.name = name;
        this.timer = new Timer(100);
    }
}