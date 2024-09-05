using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class DoorBehaviour : MonoBehaviour
{
    public enum BonusType {addition, substract, multiplication, divide}

    [Header("Colour")]
    public Color bonusColor;
    public Color penaltyColor;

    [Header("Bonus Door Setting")]
    public BonusType bonusDoorType;
    public SpriteRenderer bonusDoorSprite;
    public TextMeshPro bonusDoorTxt;

    [Header("Penalty Door Setting")]
    public BonusType PenaltyDoorType;
    public SpriteRenderer PenaltyDoorSprite;
    public TextMeshPro PenaltyDoorTxt;


    public void DoorManager()
    {
        switch
    }

}
