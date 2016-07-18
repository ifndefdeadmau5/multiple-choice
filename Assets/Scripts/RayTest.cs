using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class RayTest : MonoBehaviour
{
    public GameObject bullet;
    public GameObject questions;
    void Start( )
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), transform.forward.normalized, Color.green, 1.0f);
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    Transform objectHit = hit.transform;
                    Debug.Log(objectHit);
                    objectHit.gameObject.GetComponent<Question>().moveProblem();
                    // Do something with the object that was hit by the raycast.
                }

                Fire();
            }
        }
    }
    public void startTest( )
    {
        questions.SetActive(true);
    }
    void Fire()
    {
        Rigidbody bulletClone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
        bulletClone.velocity = transform.forward * 3;
    }

}
