using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    public CanvasGroup uiElement;
    public GameObject canvas;

    // Start is called before the first frame update
    
    public void FadeIn()
    {
        //canvas.SetActive(true);
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
        Debug.Log("fadeIn");
    }

    public void FadeOut()
    {
        //canvas.SetActive(true);
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
        Debug.Log("fadeout");
        //StartCoroutine("WaitForSec");
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 1f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;

            if (percentageComplete >= 1) {
                //canvas.SetActive(false);
                //StartCoroutine("WaitForSec");
                break;
            }
            yield return new WaitForEndOfFrame();
        }

        //Debug.Log("done");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        FadeOut();
        //break;
        //.SetActive(false);
    }
}
