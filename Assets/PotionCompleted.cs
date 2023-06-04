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
        if (other.gameObject.CompareTag("AAAAAAAAA"))
        {
            if (clientManager.ClientPhase[0] == true)
            {
                TestPotionCompleted1 = true;
            }
            if (clientManager.ClientPhase[1] == true)
            {
                TestPotionCompleted2 = true;
            }
            if (clientManager.ClientPhase[2] == true)
            {
                TestPotionCompleted3 = true;
            }
            if (clientManager.ClientPhase[3] == true)
            {
                TestPotionCompleted4 = true;
            }
        }
     
    }
}

