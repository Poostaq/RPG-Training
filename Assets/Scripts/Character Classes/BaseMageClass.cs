using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
    
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "Spell, ranged fighting class";
        Stamina = 12;
        Endurance = 14;
        Strength = 10;
        Intellect = 15;
    }
}
