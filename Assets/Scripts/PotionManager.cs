using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{
    public GameObject DryBranch;
    public GameObject Skull;
    public GameObject Feather;
    public GameObject Bean;
    public GameObject Carrot;
    public GameObject Chicken;
    public GameObject Branch;

    public GameObject CauldronColor;

    public GameObject WhitePotion;
    public GameObject SkinPotion;
    public GameObject BlackPotion;
    public GameObject DarkBluePotion;

    //bool dryBranch, skull, feather, bean, carrot, chicken, branch;
    //bool potionBlue, potionPurple, potionYellow, potionRed, potionGreen;
    int currentPotion;

    Color blue = new Color(0.31f, 0.75f, 0.67f);
    Color purple = new Color(0.77f, 0.22f, 0.81f);
    Color yellow = new Color(0.83f, 0.83f, 0.22f);
    Color red = new Color(0.95f, 0.11f, 0.11f);
    Color green = new Color(0.11f, 0.66f, 0.20f);
    Color skin = new Color(0.89f, 0.67f, 0.49f);

    // Start is called before the first frame update
    void Start()
    {
        DryBranch.SetActive(false);
        Skull.SetActive(false);
        Feather.SetActive(false);
        Bean.SetActive(false);
        Carrot.SetActive(false);
        Chicken.SetActive(false);
        Branch.SetActive(false);

        WhitePotion.SetActive(false);
        SkinPotion.SetActive(false);
        BlackPotion.SetActive(false);
        DarkBluePotion.SetActive(false);


        CauldronColor.SetActive(false);

        //dryBranch = skull = feather = bean = carrot = chicken = branch = false;

        //potionBlue = potionPurple = potionYellow = potionRed = potionGreen = false;

        currentPotion = 9; //0: Blue | 1: Purple | 2: Yellow | 3: Red | 4: Green | 5 White | 6 Skin | 7 Black | 8 DarkBlue | 9 Nothing
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentPotion)
        {
            case 0:
                if(!DryBranch.activeInHierarchy && !Skull.activeInHierarchy && Feather.activeInHierarchy && !Bean.activeInHierarchy &&
                    !Carrot.activeInHierarchy && Chicken.activeInHierarchy && !Branch.activeInHierarchy)
                {
                    currentPotion = 5;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = blue;
                    CauldronColor.SetActive(true);
                }                
                break;
            case 1:
                if (DryBranch.activeInHierarchy && !Skull.activeInHierarchy && Feather.activeInHierarchy && Bean.activeInHierarchy &&
                    !Carrot.activeInHierarchy && !Chicken.activeInHierarchy && !Branch.activeInHierarchy)
                {                    
                    currentPotion = 8;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = purple;
                    CauldronColor.SetActive(true);
                }                
                break;
            case 2:
                if (!DryBranch.activeInHierarchy && !Skull.activeInHierarchy && !Feather.activeInHierarchy && Bean.activeInHierarchy &&
                    Carrot.activeInHierarchy && !Chicken.activeInHierarchy && !Branch.activeInHierarchy)
                {                    
                    currentPotion = 6;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = yellow;
                    CauldronColor.SetActive(true);
                }
                break;
            case 3:
                if (!DryBranch.activeInHierarchy && Skull.activeInHierarchy && Feather.activeInHierarchy && !Bean.activeInHierarchy &&
                    !Carrot.activeInHierarchy && !Chicken.activeInHierarchy && Branch.activeInHierarchy)
                {                    
                    currentPotion = 7;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = red;
                    CauldronColor.SetActive(true);
                }
                break;
            case 4:
                CauldronColor.GetComponent<MeshRenderer>().material.color = green;
                CauldronColor.SetActive(true);
                break;
            case 5:
                CauldronColor.GetComponent<MeshRenderer>().material.color = Color.white;
                CauldronColor.SetActive(true);
                break;
            case 6:
                CauldronColor.GetComponent<MeshRenderer>().material.color = skin;
                CauldronColor.SetActive(true);
                break;
            case 7:
                CauldronColor.GetComponent<MeshRenderer>().material.color = Color.black;
                CauldronColor.SetActive(true);
                break;
            case 8:
                CauldronColor.GetComponent<MeshRenderer>().material.color = Color.blue;
                CauldronColor.SetActive(true);
                break;
            case 9:
                CauldronColor.SetActive(false);
                break;
            default:
                CauldronColor.SetActive(false);
                break;
        }
    }

    public void GetPotion(int index) //0: Blue | 1: Purple | 2: Yellow | 3: Red | 4: Green
    {
        switch(index)
        {
            case 0:
                if(currentPotion != 9)
                {
                    if (currentPotion == 0) break;
                    else
                    {
                        FailPotion();
                    }
                }
                else
                {
                    currentPotion = 0;
                }
                break;
            case 1:
                if (currentPotion != 9)
                {
                    if (currentPotion == 1) break;
                    else
                    {
                        FailPotion();
                    }
                }
                else
                {
                    currentPotion = 1;
                }
                break;
            case 2:
                if (currentPotion != 9)
                {
                    if (currentPotion == 2) break;
                    else
                    {
                        FailPotion();
                    }
                }
                else
                {
                    currentPotion = 2;
                }
                break;
            case 3:
                if (currentPotion != 9)
                {
                    if (currentPotion == 3) break;
                    else
                    {
                        FailPotion();
                    }
                }
                else
                {
                    currentPotion = 3;
                }
                break;
            case 4:
                if (currentPotion != 9)
                {
                    if (currentPotion == 4) break;
                    else
                    {
                        FailPotion();
                    }
                }
                else
                {
                    currentPotion = 4;
                }
                break;
            default:
                break;
        }
    }

    void TakePotion() //5 White | 6 Skin | 7 Black | 8 DarkBlue
    {
        if(currentPotion == 5)
        {
            WhitePotion.SetActive(true);
            FailPotion();
        }

        if (currentPotion == 6)
        {
            SkinPotion.SetActive(true);
            FailPotion();
        }

        if (currentPotion == 7)
        {
            BlackPotion.SetActive(true);
            FailPotion();
        }

        if (currentPotion == 8)
        {
            DarkBluePotion.SetActive(true);
            FailPotion();
        }
    }

    void FailPotion()
    {
        currentPotion = 9;
        UnactiveIngredients();
    }

    void UnactiveIngredients()
    {
        DryBranch.SetActive(false);
        Skull.SetActive(false);
        Feather.SetActive(false);
        Bean.SetActive(false);
        Carrot.SetActive(false);
        Chicken.SetActive(false);
        Branch.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Spoon"))
        {
            TakePotion();
        }
            bool correctIngredient = false;

        if (other.CompareTag("DryBranch"))
        {
            DryBranch.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Skull"))
        {
            Skull.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Feather"))
        {
            Feather.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Bean"))
        {
            Bean.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Carrot"))
        {
            Carrot.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Chicken"))
        {
            Chicken.SetActive(true);
            correctIngredient = true;
        }
        else if (other.CompareTag("Branch"))
        {
            Branch.SetActive(true);
            correctIngredient = true;
        }

        //tp to initial shelf
        if (correctIngredient)
        {
            Ingredient ing = other.gameObject.GetComponent<Ingredient>();
            other.transform.SetPositionAndRotation(ing.initialPosition, ing.initialRotation);
            
            //Stop object
            other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.angularVelocity = Vector3.zero;
        }
    }
}
