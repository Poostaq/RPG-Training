using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

    public int maxPlayerLevel = 50;
    public void LevelUpCharacter()
    {
        //check to see if current xp > than required
        if(GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }
        if(GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }
        //give player stat points
        //randomly decide to give items
        //give move/ability
        //give monies
        //determine the next amount of required xp
        DetermineRequiredXP();
    }
		
    private void DetermineRequiredXP()
    {
        int temp = GameInformation.PlayerLevel * 1000 + 250;
        GameInformation.RequiredXP = temp;
    }
}
