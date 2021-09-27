using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) >= 0.00000001f)
            {
                activeTween.Target.position =
                Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, (Time.time - activeTween.StartTime) / activeTween.Duration);

            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;

            }
        }
    }

 
}
