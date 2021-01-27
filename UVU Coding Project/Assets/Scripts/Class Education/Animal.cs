using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
   public Color animalColor = Color.red;
   // = is called the assignment operator in legitimate circles
   public float speed = 1f;
   //changes may not be viewable. Reset the script in the inspector to see changes
   public string animalName = "Bob";
   public int health = 10;

   private void Start()
   {
      Debug.Log(message:"Hello World.");
   }
}
