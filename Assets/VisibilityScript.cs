using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityScript : MonoBehaviour
{
    public GameObject leftLineOne;
    public GameObject rightLineOne;
    public GameObject leftLineTwo;
    public GameObject rightLineTwo;

    public Text leftTextOne;
    public Text rightTextOne;
    public Text leftTextTwo;
    public Text rightTextTwo;
    public Text leftTextThree;
    public Text rightTextThree;

    public Text ButtonText;
    public Button toggleSpeedButton;

    [SerializeField] private bool isVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        leftTextOne.gameObject.SetActive(isVisible);
        rightTextOne.gameObject.SetActive(isVisible);
        leftTextTwo.gameObject.SetActive(isVisible);
        leftTextThree.gameObject.SetActive(isVisible);
        rightTextTwo.gameObject.SetActive(isVisible);
        rightTextThree.gameObject.SetActive(isVisible);
        //terrible hack
        toggleSpeedButton.gameObject.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleVisibility ()
    {
        isVisible = !isVisible;
        leftTextOne.gameObject.SetActive(isVisible);
        rightTextOne.gameObject.SetActive(isVisible);
        leftTextTwo.gameObject.SetActive(isVisible);
        leftTextThree.gameObject.SetActive(isVisible);
        rightTextTwo.gameObject.SetActive(isVisible);
        rightTextThree.gameObject.SetActive(isVisible);
        leftLineOne.GetComponent<Renderer>().enabled = isVisible;
        leftLineTwo.GetComponent<Renderer>().enabled = isVisible;
        rightLineOne.GetComponent<Renderer>().enabled = isVisible;
        rightLineTwo.GetComponent<Renderer>().enabled = isVisible;

        if (isVisible) { ButtonText.text = "Hide Regions";}
        else { ButtonText.text = "Show Regions"; }
    }
}
