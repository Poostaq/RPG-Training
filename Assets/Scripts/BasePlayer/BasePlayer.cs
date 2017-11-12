using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;

    private int stamina; //health modifier
    private int endurance; //energy modifier
    private int strength; //physical damage mod
    private int intellect; //magical damage mod
    private int agility; //haste and crit modifier
    private int resistance; //damage reduction  

    private int gold; //in game currency

    private int currentXP;
    private int requiredXP;
    
    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseCharacterClass PlayerClass { get; set; }
    public int Stamina { get; set; }
    public int Endurance { get; set; }
    public int Strength { get; set; }
    public int Intellect { get; set; }
    public int Agility { get; set; }
    public int Resistance { get; set; }

    public int Gold { get; set; }

    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
}
