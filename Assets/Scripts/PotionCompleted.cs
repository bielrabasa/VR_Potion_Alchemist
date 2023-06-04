using UnityEngine;

public class PotionCompleted : MonoBehaviour
{
    public NPCMovement clientManager;
    public bool TestPotionCompleted1 = false;
    public bool TestPotionCompleted2 = false;
    public bool TestPotionCompleted3 = false;
    public bool TestPotionCompleted4 = false;

    private void OnTriggerEnter(Collider other)
    {
        bool correctPotion = false;

        if (other.gameObject.CompareTag("PotionDarkBlue")) //the final potion should have the same tag as here
        {
            if (clientManager.ClientPhase[0] == true)
            {
                TestPotionCompleted1 = true;
                correctPotion = true;
            }              
                    
        }

        if (other.gameObject.CompareTag("PotionBlack")) //the final potion should have the same tag as here
        {
            if(clientManager.ClientPhase[1] == true)
            {
                TestPotionCompleted2 = true;
                correctPotion = true;
            }
        }

        if (other.gameObject.CompareTag("PotionWhite")) //the final potion should have the same tag as here
        {
            if (clientManager.ClientPhase[2] == true)
            {
                correctPotion = true;
                TestPotionCompleted3 = true;
            }
        }

        if (other.gameObject.CompareTag("PotionSkin")) //the final potion should have the same tag as here
        {
            if (clientManager.ClientPhase[3] == true)
            {
                correctPotion = true;
                TestPotionCompleted4 = true;
            }
        }

        if (correctPotion)
        {
            Ingredient ing = other.gameObject.GetComponent<Ingredient>();
            other.transform.SetPositionAndRotation(ing.initialPosition, ing.initialRotation);
            other.gameObject.SetActive(false);
        }

    }
}

