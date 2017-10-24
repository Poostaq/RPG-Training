using UnityEngine;
using System.Collections;

public class BaseCharacterClass {

    private string characterClassName;
    private string characterClassDescription;
    //stats
    private int stamina;
    private int endurance;
    private int strength;
    private int intellect;

    public string CharacterClassName { get; set; }

    public string CharacterClassDescription { get; set; }

    public int Stamina { get; set; }

    public int Endurance { get; set; }

    public int Strength { get; set; }


    public int Intellect { get; set; }
}
