using UnityEngine;
using System.Collections;

public class NewBehaviourScript : BaseStatItem {

    public enum PotionTypes
    {
        HEALTH,
        ENERGY,
        STRENGTH,
        INTELLECT,
        VITALITY,
        ENDURANCE,
        SPEED
    }

    private PotionTypes potionType;
    private int spellEffectID;

    public PotionTypes PotionType { get; set; }

    public int SpellEffectId { get; set; }
}
