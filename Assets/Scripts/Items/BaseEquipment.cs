﻿using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

    public enum EquipmentTypes
    {
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        NECK,
        EARRING,
        RING
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquipmentTypes EquipmentType { get; set; }

    public int SpellEffectID { get; set; }
}
