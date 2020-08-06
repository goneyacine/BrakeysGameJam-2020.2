using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{
    public GameObject targetObject;
    public float delay;
  public void Enable()
  {
        Invoke("Enable_", delay);
  }
  private void Enable_()
  {
        targetObject.SetActive(true);
  }

}
