using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform firstNPC;
    public Transform secondNPC;
    public Transform thirdNPC;
    public Transform fourthNPC;

    private bool isFirstNPCMoving = true;
    private bool isSecondNPCMoving = false;
    private bool isThirdNPCMoving = false;
    private bool isFourthNPCMoving = false;

    public bool[] ClientPhase;

    public Transform point1;
    public Transform point2;
    public GameObject planeDialog;
    public PotionCompleted potionCompleted;

    public float movementSpeed = 2.5f;

    private void Start()
    {
        ClientPhase[0] = true;
    }
    private void Update()
    {
        /*--------------------First NPC----------------------*/
        if (ClientPhase[0] == true)
        {
            if (isFirstNPCMoving == true)  // Moves first NPC to the desk
            {
                MoveToPosition(firstNPC, point1.position);
                if (firstNPC.position == point1.position) //this is to make sure that first NPC don't return to point 1 after the trigger is activated and meking impossible for first NPC to go to point 2
                {
                    isFirstNPCMoving = false;
                }
            }

            if (potionCompleted.TestPotionCompleted1==true)  // Moves first NPC outside if the trigger is activated
            {
                MoveToPosition(firstNPC, point2.position);
                if (firstNPC.position == point2.position)
                    potionCompleted.TestPotionCompleted1 = false;
            }

            if (firstNPC.position == point2.position)  // if first NPC arrives to second point, the second NPC starts moving
            {
                isSecondNPCMoving = true;
                ClientPhase[0] = false;
                ClientPhase[1] = true;
            }
        }

        /*--------------------Second NPC----------------------*/
        if (ClientPhase[1] == true)
        {
            if (isSecondNPCMoving == true)
            {
                MoveToPosition(secondNPC, point1.position);
                if (secondNPC.position == point1.position)
                {
                    isSecondNPCMoving = false;
                }
            }

            if (potionCompleted.TestPotionCompleted2 == true)
            {
                MoveToPosition(secondNPC, point2.position);
                if (secondNPC.position == point2.position)
                    potionCompleted.TestPotionCompleted2 = false;
            }

            if (secondNPC.position == point2.position)
            {
                isThirdNPCMoving = true;
                ClientPhase[1] = false;
                ClientPhase[2] = true;
            }
        }

        /*--------------------Third NPC----------------------*/
        if (ClientPhase[2] == true)
        {
            if (isThirdNPCMoving == true)
            {
                MoveToPosition(thirdNPC, point1.position);
                if (thirdNPC.position == point1.position)
                {
                    isThirdNPCMoving = false;
                }
            }

            if (potionCompleted.TestPotionCompleted3 == true)
            {
                MoveToPosition(thirdNPC, point2.position);
                if (thirdNPC.position == point2.position)
                    potionCompleted.TestPotionCompleted3 = false;
            }

            if (thirdNPC.position == point2.position)
            {
                isFourthNPCMoving = true;
                ClientPhase[2] = false;
                ClientPhase[3] = true;
            }
        }
        /*--------------------Fourth NPC----------------------*/
        if (ClientPhase[3] == true)
        {
            if (isFourthNPCMoving == true)
            {
                MoveToPosition(fourthNPC, point1.position);
                if (fourthNPC.position == point1.position)
                {
                    isFourthNPCMoving = false;
                }
            }

            if (potionCompleted.TestPotionCompleted4 == true)
            {
                MoveToPosition(fourthNPC, point2.position);
                if (fourthNPC.position == point2.position)
                    potionCompleted.TestPotionCompleted4 = false;
            }

            //if (thirdNPC.position == point2.position)
            //{
            //    //Finish
            //}
        }

    }
    private void MoveToPosition(Transform NPC, Vector3 targetPosition)
    {
        NPC.position = Vector3.MoveTowards(NPC.position, targetPosition, Time.deltaTime * movementSpeed);
    }
}