using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollToMenu : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform contentPanel;

    private Vector3 _panelLocation;
    //[SerializeField] private float _percentTreshold = 0.4f;
    //[SerializeField] private float easing = 0.8f;
    private void Start()
    {
        _panelLocation = transform.position;
    }

    public void OnClickScrollTo(RectTransform target)
    {
        Canvas.ForceUpdateCanvases();
        Vector2 viewPortLocalPosition = scrollRect.viewport.localPosition;
        Vector2 viewTargetLocalPosition = target.localPosition;

        Vector2 newTargeLocaltPosition = new Vector2(
            0 - (viewPortLocalPosition.x + viewTargetLocalPosition.x) + (scrollRect.viewport.rect.width / 2) -
            (target.rect.width / 2),
            0 - (viewPortLocalPosition.y + viewTargetLocalPosition.y)
        );
        contentPanel.localPosition = newTargeLocaltPosition;
    }

    /*
     will delete later

    public void OnBeginDrag(PointerEventData eventData)
    {
        var difference = eventData.pressPosition.x - eventData.position.x;
        // why ?
        transform.position = _panelLocation - new Vector3(difference, 0, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float percentage = (eventData.pressPosition.x - eventData.position.x) / Screen.width;
        //if (Mathf.Abs(percentage) >= _percentTreshold)
        //{
            Vector3 newLocation = _panelLocation;
            // Left
            if (percentage > 0)
            {
                Canvas.ForceUpdateCanvases();
                Vector2 viewPortLocalPosition = scrollRect.viewport.localPosition;
                Vector2 viewTargetLocalPosition = new Vector3(-1170, 0);
                Vector2 newTargeLocaltPosition = new Vector2(
                    0 - (viewPortLocalPosition.x + viewTargetLocalPosition.x) + (scrollRect.viewport.rect.width / 2) -
                    (1170f / 2),
                    0 - (viewPortLocalPosition.y + viewTargetLocalPosition.y)
                );
                //contentPanel.localPosition -= new Vector3(1170, 0,0);
                var newPage =  contentPanel.localPosition - new Vector3(1170, 0,0);
                //StartCoroutine(SmothMove(contentPanel.localPosition, newPage, easing));
                contentPanel.localPosition = newTargeLocaltPosition;
            }
            // Right
            else if (percentage < 0)
            {
                Canvas.ForceUpdateCanvases();
                Vector2 viewPortLocalPosition = scrollRect.viewport.localPosition;
                Vector2 viewTargetLocalPosition = new Vector3(1170, 0);
                Vector2 newTargeLocaltPosition = new Vector2(
                    0 - (viewPortLocalPosition.x + viewTargetLocalPosition.x) + (scrollRect.viewport.rect.width / 2) -
                    (1170f / 2),
                    0 - (viewPortLocalPosition.y + viewTargetLocalPosition.y)
                );
                var newPage =  contentPanel.localPosition + new Vector3(1170, 0,0);
                //StartCoroutine(SmothMove(contentPanel.localPosition, newPage, easing));
                contentPanel.localPosition = newTargeLocaltPosition;
            }
        
    }

    IEnumerator SmothMove(Vector3 startPos, Vector3 endPos, float seconds)
    {
        float t = 0f;
        while (t <= 1f)
        {
            t += Time.deltaTime / seconds;
            contentPanel.localPosition = Vector3.Lerp(startPos,endPos,Mathf.SmoothStep(0,1,t));
            yield return null;
        }
    }
    */
}