using UnityEngine;

public class PotionCompleted : MonoBehaviour
{
    public NPCMovement clientManager;
    public bool TestPotionCompleted = false;

    private void OnTriggerEnter(Collider other)
    {
        //if (TestPotionCompleted)
        //{
        //    clientManager.TriggerActivated();
        //}
    }

    private void Update()
    {
        if (TestPotionCompleted)
        {
            clientManager.TriggerActivated();
        }
    }
}

