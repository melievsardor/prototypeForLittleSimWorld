using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Headwear
{
    public Sprite downSprite;
    public Sprite sideSprite;
    public Sprite upSprite;
}

public class ClotherShop : MonoBehaviour
{
    [SerializeField]
    private CharacterSetup characterSetup;

    public Headwear[] headwearSprites = new Headwear[6];

    [SerializeField]
    private Sprite[] weaponSprites = new Sprite[3];

    private int oldIndex = -1;

    public void OnClickHeadItem(int index)
    {
        if (oldIndex == index || characterSetup == null)
            return;

        oldIndex = index;

        characterSetup.headwearDown = headwearSprites[index].downSprite;
        characterSetup.headwearSide = headwearSprites[index].sideSprite;
        characterSetup.headwearUp = headwearSprites[index].upSprite;

        characterSetup.UpdateHeadwear(false);

    }

    public void OnClickWeaponItem(int index)
    {
        switch(index)
        {
            case 0:
                characterSetup.bowWeapon = weaponSprites[index];
                break;
            case 1:
                characterSetup.swingWeapon = weaponSprites[index];
                break;
            case 2:
                characterSetup.thrustWeapon = weaponSprites[index];
                break;
        }

        characterSetup.UpdateWeapon(false);
        
    }

}
