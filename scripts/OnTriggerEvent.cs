using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEvent : MonoBehaviour
{
    public string colliderTag = "Player";
    public UnityEvent onTriggerEvent;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == colliderTag)
            onTriggerEvent.Invoke();
    }
}
