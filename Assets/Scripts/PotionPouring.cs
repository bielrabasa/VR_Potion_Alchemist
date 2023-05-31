using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPouring : MonoBehaviour
{
    public Transform wristTransform; // Transform de la muñeca
    public float wristInclination = 45f; // Inclinació de la muñeca necessaria per a vertir

    public bool isPouring = false; // Variable per controlar el estat de la poció

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion wristRotation = wristTransform.rotation;

        // Calcular l'inclinacio de la muñeca
        float wristTilt = wristTransform.rotation.eulerAngles.z;

        if(wristTilt > wristInclination && !isPouring)
        {
            isPouring = true;
        }

        if(wristTilt < wristInclination && isPouring)
        {
            isPouring = false;
        }

    }
}
