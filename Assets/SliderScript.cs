using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject defender;


    // Start is called before the first frame update
    void Start()
    {
        slider.SetValueWithoutNotify(8.0f);
        slider.onValueChanged.AddListener((v) =>
        {
            text.text = "Robot Speed: " + v.ToString("0.00");
            defender.GetComponent<defenderSweep>().setVelocity(v);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
