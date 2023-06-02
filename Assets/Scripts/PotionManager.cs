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

    //bool dryBranch, skull, feather, bean, carrot, chicken, branch;
    //bool potionBlue, potionPurple, potionYellow, potionRed, potionGreen;
    int currentPotion;

    Color blue = new Color(78, 190, 172);
    Color purple = new Color(196, 57, 207);
    Color yellow = new Color(212, 212, 55);
    Color red = new Color(166, 29, 29);
    Color green = new Color(28, 168, 51);
    Color skin = new Color(226, 171, 125);

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
                    CauldronColor.GetComponent<MeshRenderer>().material.color = blue;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = blue;
                }                
                CauldronColor.SetActive(true);
                break;
            case 1:
                if (DryBranch.activeInHierarchy && !Skull.activeInHierarchy && Feather.activeInHierarchy && Bean.activeInHierarchy &&
                    !Carrot.activeInHierarchy && !Chicken.activeInHierarchy && !Branch.activeInHierarchy)
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = Color.blue;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = purple;
                }                
                CauldronColor.SetActive(true);
                break;
            case 2:
                if (!DryBranch.activeInHierarchy && !Skull.activeInHierarchy && !Feather.activeInHierarchy && Bean.activeInHierarchy &&
                    Carrot.activeInHierarchy && !Chicken.activeInHierarchy && !Branch.activeInHierarchy)
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = skin;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = yellow;
                }
                CauldronColor.SetActive(true);
                break;
            case 3:
                if (!DryBranch.activeInHierarchy && Skull.activeInHierarchy && Feather.activeInHierarchy && !Bean.activeInHierarchy &&
                    !Carrot.activeInHierarchy && !Chicken.activeInHierarchy && Branch.activeInHierarchy)
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = Color.black;
                    UnactiveIngredients();
                }
                else
                {
                    CauldronColor.GetComponent<MeshRenderer>().material.color = red;
                }
                CauldronColor.SetActive(true);
                break;
            case 4:
                CauldronColor.GetComponent<MeshRenderer>().material.color = green;
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
        if (other.tag == "DryBranch")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            DryBranch.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Skull")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Skull.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Feather")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Feather.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Bean")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Bean.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Carrot")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Carrot.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Chicken")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Chicken.SetActive(true);

            other.gameObject.SetActive(true);
        }
        if (other.tag == "Branch")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Transform>().position = other.gameObject.GetComponent<Ingredient>().initialTransform.position;
            other.gameObject.GetComponent<Transform>().rotation = other.gameObject.GetComponent<Ingredient>().initialTransform.rotation;

            Branch.SetActive(true);

            other.gameObject.SetActive(true);
        }
    }
}
