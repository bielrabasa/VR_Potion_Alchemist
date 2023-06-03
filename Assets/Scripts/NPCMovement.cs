//using UnityEngine;

//public class NPCMovement : MonoBehaviour
//{
//    public Transform destiny;
//    public float velocity = 5f;

//    private bool hasArrived = false;
//    public GameObject PlaneDialog;

//    private void Update()
//    {
//        if (!hasArrived)
//        {
//            transform.position = Vector3.MoveTowards(transform.position, destiny.position, velocity * Time.deltaTime);

//            if (transform.position == destiny.position)
//            {
//                hasArrived = true;
//                CreatePlaneWithText();
//            }
//        }
//    }

//    private void CreatePlaneWithText()
//    {
//        Instantiate(PlaneDialog, destiny.position, Quaternion.identity);
//    }
//}

using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform firstNPC;
    public Transform secondNPC;
    public Transform thirdNPC;
    public Transform fourthNPC;
    public Transform point1;
    public Transform point2;
    public GameObject planeDialog;

    public float movementSpeed = 2.5f;

    private bool isFirstNPCMoving;
    private bool isTriggerActivated;
    private bool isSecondNPCMoving;

    private void Update()
    {
        if (!isFirstNPCMoving)  // Moves first NPC to the desk
        {
            MoveToPosition(firstNPC, point1.position);
        }

        if (isTriggerActivated == true && !isSecondNPCMoving)  // Moves first NPC outside if the trigger is activated
        {
            MoveToPosition(firstNPC, point2.position);
            //isTriggerActivated = false;            
        }

        if (firstNPC.position == point2.position)  // if first NPC arrives to second point, the second NPC starts moving
        {
            isSecondNPCMoving = true;
            MoveToPosition(secondNPC, point1.position);
        }

    }
    private void MoveToPosition(Transform NPC, Vector3 targetPosition)
    {
        NPC.position = Vector3.MoveTowards(NPC.position, targetPosition, Time.deltaTime * movementSpeed);
    }

    public void TriggerActivated()
    {
        isTriggerActivated = true;
    }
}

//    private void CreatePlaneWithText()
//    {
//       Instantiate(planeDialog, point1.position, Quaternion.identity);
//    }
//}

