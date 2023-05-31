using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPouring : MonoBehaviour
{
    public Transform wristTransform; // Transform de la mu�eca
    public float wristInclination = 45f; // Inclinaci� de la mu�eca necessaria per a vertir

    public bool isPouring = false; // Variable per controlar el estat de la poci�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion wristRotation = wristTransform.rotation;

        // Calcular l'inclinacio de la mu�eca
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
