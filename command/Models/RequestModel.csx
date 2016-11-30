#load "Wall.csx"
#load "Tank.csx"
#load "Field.csx"

// {
//   matchId: string, // unique ID for each match
//   mapWidth: int, 
//   mapHeight: int, 
//   suddenDeath: int, // number of turns left until sudden death starts
//   wallDamage: int, // how much damage does it cause to run into a wall
//   tankDamage: int, // how much damage does it cause to run into a tank -- also, how much damage your tank causes when it runs into a wall
//   weaponDamage: int, // how much damage does it cause to hit something with a bullet
//   visibility: int, // how far, in fields, you can see on your radar 
//   weaponRange: int, // how far, in fields, you can hit with a bullet 
//   you: TANK, // your tank info -- see the tank structure below
//   enemies: [TANK], // array. enemy tank info. see the tank structure below
//   walls: [WALL], // array. visible walls. see the wall structure below
//   fire: [FIELD] // array, visible fields caught by fire
// };

public class RequestModel{
    public string matchId {get; set;}
    public int mapWidth {get; set;}
    public int mapHeight {get; set;}
    public int suddenDeath {get; set;}
    public int wallDamage {get; set;}
    public int tankDamage {get; set;}
    public int weaponDamage {get; set;}
    public int visibility {get; set;}
    public int weaponRange {get; set;}
    public Tank you {get; set;}
    public List<Tank> enemies {get; set;}
    public List<Wall> walls {get; set;}
    public List<Field> fire {get; set;}
}