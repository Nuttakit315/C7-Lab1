using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
  public void getAnimatorDefeat(){
         this.GetComponent<Animator>().Play("Defeat");
    }
    public void getgetAnimatorDance(){
        this.GetComponent<Animator>().Play("Dance");
    }
}