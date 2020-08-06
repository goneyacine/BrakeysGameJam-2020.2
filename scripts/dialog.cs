using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class dialog : MonoBehaviour
{
  public List<string> charactersNames;
  public List<string> dialogs;
  public float typingDelay = .4f;
  public float delayBetweenDialogv = 2f;
  private string currentDialogText;
  private string currentCharacterName;
  public TMP_Text characterNameText;
  public TMP_Text dialogText;
  public UnityEvent dialogEndEvent;
    public GameObject dialogPanel;
  private void OnEnable(){
      StartCoroutine(dialogCoroutine());
  }
  public string getCurrentDialogText(){ return currentDialogText; }
  public string getCurrentCharacterName(){ return currentCharacterName; }
  IEnumerator dialogCoroutine(){
        dialogPanel.SetActive(true);
      for(int i = 0; i < dialogs.Count;i++){
       currentCharacterName = charactersNames[i];
            characterNameText.text = getCurrentCharacterName();
            currentDialogText = "";
       for(int y = 0; y <  dialogs[i].Length;y++){
       FindObjectOfType<SoundManager>().Play("typing sounds");
       currentDialogText += dialogs[i][y];
        yield return new WaitForSeconds(typingDelay);
        dialogText.text = getCurrentDialogText();
       }
       yield return new WaitForSeconds(delayBetweenDialogv);
      }
        dialogPanel.SetActive(false);
        dialogEndEvent.Invoke();
  }
}
