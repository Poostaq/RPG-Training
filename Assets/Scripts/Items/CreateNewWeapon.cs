using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID);
        Debug.Log(newWeapon.WeaponType);
        Debug.Log(newWeapon.Stamina);
        Debug.Log(newWeapon.Endurance);
    }
    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
        //assign name to the weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create a weapon description
        newWeapon.ItemDescription = "Generic Desc for new Weapon";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Endurance = Random.Range(1, 11);
        newWeapon.Intellect = Random.Range(1, 11);
        newWeapon.Strength = Random.Range(1, 11);
        //choose type of weapon
        ChooseWeaponType();

        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 7);
        if (randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }
        else if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        }
        else if (randomTemp == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
        }
    }
}
