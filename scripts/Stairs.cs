using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
 public Transform upTransform;
 public Transform downTransform;
 public GameObject upText;
 public GameObject downText;

 private void OnTriggerStay2D(Collider2D other) {
     if(other.tag == "Player"){
         if(Input.GetKeyDown(KeyCode.UpArrow) && upTransform != null)
        {
            other.transform.position = upTransform.position;
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && downTransform != null)
        {
            other.transform.position = downTransform.position;
        }
        if(upTransform != null && upText != null)
        upText.SetActive(true);
        else
        upText.SetActive(false);
        
        if(downTransform != null && downText != null)
        downText.SetActive(true);
        else 
        downText.SetActive(false);
     }
 }
 private void OnTriggerExit2D(Collider2D other){
     if(other.tag == "Player")
     {
         upText.SetActive(false);
         downText.SetActive(false);
     }
 }
}
