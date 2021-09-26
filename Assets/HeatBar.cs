using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
 public Slider slider;
 public Gradient gradient;
 public Image fill;

 public float maxHeat = 100f;
 public float currentHeat;
 
 

 void Start()
 {
     currentHeat = maxHeat / 2f; 
     SetMaxHeat(maxHeat);
 }
 

 void SetMaxHeat(float heat)
 {
     slider.maxValue = heat;
     slider.value = heat/2f;

     fill.color = gradient.Evaluate(1f);
 }

 void SetHeat(float heat)
 {
     fill.color = gradient.Evaluate(slider.normalizedValue);
 }

 void Update()
 {
     if (Input.GetKeyDown(KeyCode.Space))
     {
         Hammer(20f);
         
     }
     SetHeat(currentHeat);
   
     currentHeat -= Time.deltaTime;
     Mathf.Clamp(currentHeat, 0f, 100f);
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
