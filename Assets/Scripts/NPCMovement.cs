using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform destiny;
    public float velocity = 5f;

    private bool hasArrived = false;
    public GameObject PlaneDialog;

    private void Update()
    {
        if (!hasArrived)
        {
            transform.position = Vector3.MoveTowards(transform.position, destiny.position, velocity * Time.deltaTime);

            if (transform.position == destiny.position)
            {
                hasArrived = true;
                CreatePlaneWithText();
            }
        }
    }

    private void CreatePlaneWithText()
    {
        Instantiate(PlaneDialog, destiny.position, Quaternion.identity);
    }
}