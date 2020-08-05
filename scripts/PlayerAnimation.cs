using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
  private Animator animator;

  private void Start(){
      animator = GetComponent<Animator>();
  }
  private void Update(){
      if(GetComponent<Rigidbody2D>().velocity.x != 0)
      animator.SetBool("IsRuning",true);
      else 
      animator.SetBool("IsRuning",false);
  }
}
