using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience {

    private static int xptoGive;
    private static LevelUp levelUpScript = new LevelUp();

    public static void AddExperience()
    {
        xptoGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXP += xptoGive;
        Debug.Log(xptoGive);
        CheckIfLevelUp();
    }

    public static void AddExplorationExperience()
    {
        xptoGive = GameInformation.PlayerLevel * 10;
        GameInformation.CurrentXP += xptoGive;
    }

    private static void CheckIfLevelUp()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            //player levelled up
            //TODO: create level up script
            levelUpScript.LevelUpCharacter();
        }
    }

}
