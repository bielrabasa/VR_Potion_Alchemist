using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionPour : MonoBehaviour
{
    public CauldronGetPotion CauldronTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.gameObject.CompareTag("Cauldron")) return;

        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            CauldronTrigger.isPouring = true;
        }
        else
        {
            CauldronTrigger.isPouring = false;
        }
    }
}
