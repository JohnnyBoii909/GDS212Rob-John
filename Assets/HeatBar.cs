using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
 public Slider slider;
 public Material material;

 public float maxHeat = 100f;
 public float currentHeat;
 //public float failState;
 

 void Start()
 {
     currentHeat = maxHeat / 2f; 
     SetMaxHeat(maxHeat);
 }
 

 void SetMaxHeat(float heat)
 {
     slider.maxValue = heat;
     slider.value = heat/2f;
 }

 void SetHeatColour(float heat)
 {
     //this.GetComponent<HeatBar>().material;
 }

 void Update()
 {
     if (Input.GetKeyDown(KeyCode.Space))
     {
         Hammer(20f);
         
     }
     SetHeatColour(currentHeat);
   
     currentHeat -= Time.deltaTime;
     //failState = Mathf.Clamp(currentHeat, slider.minValue, slider.maxValue);
     //currentHeat = slider.normalizedValue; I need to make the Slider value equal to the current heat but I cant figure it out since the slider is a float but currentHeat is a integer
 }

 void Hammer(float heat)
 {
     if (currentHeat < 100f)
     {
         currentHeat += heat;
     }
     else
     {
         currentHeat = 100f;
     }
     
     slider.value += heat;
 }
}
