using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSound : MonoBehaviour
{
    Vector3 lastPos;
    Vector3 moved;
    public AudioClip MovingSound;
    private const float movingConditioner = 0f;
    public AudioSource moveMusic;
    private GameObject Goat_Man;
    // Start is called before the first frame update

    private void Awake()
    {
        Goat_Man = GameObject.FindWithTag("goatman");
    }

    void Start()
    {
        lastPos = Goat_Man.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moved = Goat_Man.transform.position - lastPos;
        if (moved.x != movingConditioner || moved.y != movingConditioner)
        {
            moveMusic.Play();
            moveMusic.loop = true;
        }
        else
        {
            moveMusic.Stop();
        }

    }
}
