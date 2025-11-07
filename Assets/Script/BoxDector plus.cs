using Unity.VisualScripting;
using UnityEngine;

public class BoxDectorplus : MonoBehaviour
{
    public BoxCounter counter;
    public float noBoxTimeout = 4f;
    public float JamTime = 2.5f;
    private float LastTime;
    private float BoxEnterTime;
    private bool isBoxInside = false;
    private bool BoxAlert = false;

    private void Start()
    {
        LastTime= Time.time;
    }

    private void Update()
    {
        if(Time.time - LastTime > noBoxTimeout)
        {
            Debug.Log("传送带断料");

        }
        if((Time.time - BoxEnterTime > JamTime) && isBoxInside)
        {
            Debug.Log("传送带堵塞");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Debug.Log("检测到Box进入");
            BoxEnterTime = Time.time;
            LastTime = Time.time;
            isBoxInside = true;
            Renderer boxRenderer = other.GetComponent<Renderer>();
            if (boxRenderer != null)
            {
                boxRenderer.material.color = Color.red;
            }
            if(counter != null)
            {
                counter.Addcount();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            BoxEnterTime = Time.time;
            isBoxInside = false;
        }
    }
}
