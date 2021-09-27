using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Tweener tweener;
    //private int tempItem;
    [SerializeField]
    public GameObject[] item;
    private bool conditioner1;
    private bool conditioner2;
    private Vector3 endPos;
    private Vector3 temPosition;
    private const float moveWait = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        conditioner1 = true;
        conditioner2 = true;
        InvokeRepeating("tempUpdate", 0f, moveWait);
        InvokeRepeating("conditioner1Generator", moveWait, moveWait);
        InvokeRepeating("conditioner2Generator", moveWait, moveWait);
        tweener = GetComponent<Tweener>();
    }


    // Update is called once per frame
    void tempUpdate()
    {
        if(conditioner1 == true)
        {
            temPosition = new Vector3(item[1].transform.position.x, item[1].transform.position.y, item[1].transform.position.z);
            item[1].transform.position = new Vector3(item[1].transform.position.x, item[0].transform.position.y, item[1].transform.position.z);

        }
        else if (conditioner1 == false)
        {
            temPosition = new Vector3(item[1].transform.position.x, item[1].transform.position.y, item[1].transform.position.z);
            item[1].transform.position = new Vector3(item[0].transform.position.x, item[1].transform.position.y, item[1].transform.position.z);


        }

    }
    void conditioner1Generator()
    {
        if(conditioner1 == true)
        {
            conditioner1 = false;
        }
        else if(conditioner1 == false)
        {
            conditioner1 = true;
        }
    }

    void conditioner2Generator()
    {
        if (conditioner2 == true)
        {
            conditioner2 = false;
        }
        else if (conditioner2 == false)
        {
            conditioner2 = true;
        }
    }

    void Update()
    {

        if (conditioner2 == true)
        {

            endPos = new Vector3(item[0].transform.position.x, temPosition.y, item[0].transform.position.z);
            tweener.AddTween(item[0].transform, item[0].transform.position, endPos, 1.5f);
        }
        else if (conditioner2 == false)
        {

            endPos = new Vector3(temPosition.x, item[0].transform.position.y, item[0].transform.position.z);
            tweener.AddTween(item[0].transform, item[0].transform.position, endPos, 1.5f);
        }
    }
}
