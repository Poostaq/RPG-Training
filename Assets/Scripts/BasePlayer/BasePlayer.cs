using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int stamina;
    private int endurance;
    private int strength;
    private int intellect;
    private int currentXP;
    private int requiredXP;
    
    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseCharacterClass PlayerClass { get; set; }
    public int Stamina { get; set; }
    public int Endurance { get; set; }
    public int Strength { get; set; }
    public int Intellect { get; set; }
    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
}
