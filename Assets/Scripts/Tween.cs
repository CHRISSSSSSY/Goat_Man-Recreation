using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; set; }
    public Vector3 StartPos { get; set; }
    public Vector3 EndPos { get; set; }
    public float StartTime { get; set; }
    public float Duration { get; set; }

    public Tween(Transform transform, Vector3 startPos, Vector3 endPos, float start, float duration)
    {
        Target = transform;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = start;
        Duration = duration;
    }
}