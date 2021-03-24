using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBehavior : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("PowerUp"))
      {
         PowerUp();
      }

      if (other.CompareTag("Ammo"))
      {
         AmmoAdd();
         
      }

      if (other.CompareTag("Health"))
      {
         HealthUpdate();
      }
   }

   public void PowerUp()
   {
      print("Got power");
   }

   public void HealthUpdate()
   {
      print("Updated health");
   }

   public void AmmoAdd()
   {
      print("Got more bullets");
   }
}
