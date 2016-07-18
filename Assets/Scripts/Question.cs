using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Question : MonoBehaviour
{

    public Vector2 touchPos;
    public Transform touchTrans;
    public GameObject circle;
    public Text debugText;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
    
    }

    public void moveProblem()
    {
        Invoke("invokeTransform", 2);
    }

    void invokeTransform()
    {
        gameObject.transform.Translate(Vector3.right * 20);
    }
}
