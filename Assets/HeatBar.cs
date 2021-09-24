using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
 public Slider slider;
 public Gradient gradient;
 public Image fill;

 public int maxHeat = 100;
 public int currentHeat;

 void Start()
 {
     currentHeat = maxHeat / 2; 
     SetMaxHeat(maxHeat);
 }
 

 public void SetMaxHeat(int heat)
 {
     slider.maxValue = heat;
     slider.value = heat/2;

     fill.color = gradient.Evaluate(1f);
 }

 void SetHeat(int heat)
 {
     fill.color = gradient.Evaluate(slider.normalizedValue);
 }

 void Update()
 {
     if (Input.GetKeyDown(KeyCode.Space))
     {
         Hammer(20);
         
     }
     SetHeat(currentHeat);
     //currentHeat = slider.normalizedValue; I need to make the Slider value equal to the current heat but I cant figure it out since the slider is a float but currentHeat is a integer
 }

 void Hammer(int heat)
 {
     if (currentHeat <= 100)
     {
         currentHeat += heat;
     }
     else
     {
         currentHeat = 100;
     }
     
     slider.value += heat;
 }
}
