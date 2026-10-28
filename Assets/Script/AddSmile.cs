using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AddSmile : MonoBehaviour
{
    [SerializeField]
    public GameObject[] smile;

    public float moveDistance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        int number = Random.Range(0, smile.Length);
        Instantiate(smile[number], transform.position, transform.rotation);
    }

    public void MoveFront()
    {
        transform.position += transform.forward * moveDistance;
    }
    public void MoveBack()
    {
        transform.position -= transform.forward * moveDistance;
    }
    public void MoveRight()
    {
        transform.position += transform.right * moveDistance;
    }
    public void MoveLeft()
    {
        transform.position -= transform.right * moveDistance;
    }
}
