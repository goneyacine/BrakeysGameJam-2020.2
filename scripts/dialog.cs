using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class dialog : MonoBehaviour
{
  public List<string> charactersNames;
  public List<string> dialogs;
  public float typingDelay = .4f;
  public float delayBetweenDialogv = 2f;
  private string currentDialogText;
  private string currentCharacterName;
  public Text characterNameText;
  public Text dialogText;
  public UnityEvent dialogEndEvent;
  private void OnEnable(){
      StartCoroutine(dialogCoroutine());
  }
  public string getCurrentDialogText(){ return currentDialogText; }
  public string getCurrentCharacterName(){ return currentCharacterName; }
  IEnumerator dialogCoroutine(){
      for(int i = 0; i < dialogs.Count;i++){
       currentCharacterName = charactersNames[i];
            characterNameText.text = getCurrentCharacterName();
            currentDialogText = "";
       foreach(char char_ in dialogs[i]){
        currentDialogText += char_;
        yield return new WaitForSeconds(typingDelay);
                dialogText.text = getCurrentDialogText();
       }
       yield return new WaitForSeconds(delayBetweenDialogv);
      }
        dialogEndEvent.Invoke();
  }
}
