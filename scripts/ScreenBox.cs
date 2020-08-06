using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
public class ScreenBox : MonoBehaviour
{
  public CinemachineVirtualCamera cinemachineCamera;
  private BoxCollider2D collider2D;
  public string playerTag = "Player";
  public int defaultCamPriority = 0;
  public int onSelectCamPriority = 10;
  
  //getting the boxCollider2D component 
   private void Start() {collider2D = GetComponent<BoxCollider2D>();}

//draw the box collider as gizmos
  private void OnDrawGizmos()
   { 
      Gizmos.color = Color.red;
      Gizmos.DrawWireCube((Vector2)transform.position + collider2D.offset,collider2D.size);
   }
 private void OnTriggerEnter2D(Collider2D other) {
     if(other.tag == playerTag)
      cinemachineCamera.Priority = onSelectCamPriority;
 }
 private void OnTriggerExit2D(Collider2D other) {
     if(other.tag == playerTag)
     cinemachineCamera.Priority = defaultCamPriority;
 }
}
