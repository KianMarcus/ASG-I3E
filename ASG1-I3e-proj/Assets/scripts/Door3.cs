using UnityEngine;

public class Door3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
    public float slideHeight = 3f;
    public float speed = 2f;
 
    private Vector3 closedPos;
    private Vector3 openPos;
    private bool isOpen = false;
 
    void Start()
    {
        closedPos = transform.position;
        openPos = closedPos + new Vector3(0, slideHeight, 0);
    }
 
    public void Open()
    {
        isOpen = true;
    }
 
    void Update()
    {
        if (isOpen)
        {
            transform.position = Vector3.MoveTowards(transform.position, openPos, speed * Time.deltaTime);
        }
    }
 

}
