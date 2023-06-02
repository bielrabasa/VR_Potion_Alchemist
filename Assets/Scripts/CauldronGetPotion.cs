using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronGetPotion : MonoBehaviour
{
    public bool isPouring;
    public PotionManager potionManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void PourPotion(int index)  //0: Blue | 1: Purple | 2: Yellow | 3: Red | 4: Green
    {
        switch (index)
        {
            case 0:
                Debug.Log("Pouring potion Blue");
                potionManager.GetPotion(0);
                break;
            case 1:
                Debug.Log("Pouring potion Purple");
                potionManager.GetPotion(1);
                break;
            case 2:
                Debug.Log("Pouring potion Yellow");
                potionManager.GetPotion(2);
                break;
            case 3:
                Debug.Log("Pouring potion Red");
                potionManager.GetPotion(3);
                break;
            case 4:
                Debug.Log("Pouring potion Green");
                potionManager.GetPotion(4);
                break;
            default:
                break;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "PotionBlue" && isPouring)
        {
            PourPotion(0);
        }

        if (other.tag == "PotionPurple" && isPouring)
        {
            PourPotion(1);
        }

        if (other.tag == "PotionYellow" && isPouring)
        {
            PourPotion(2);
        }

        if (other.tag == "PotionRed" && isPouring)
        {
            PourPotion(3);
        }

        if (other.tag == "PotionGreen" && isPouring)
        {
            PourPotion(4);
        }
    }
}
