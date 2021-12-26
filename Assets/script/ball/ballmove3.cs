using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove3 : MonoBehaviour
{
    Rigidbody ball;
    public LayerMask hitLayers;
    public UnityEngine.AI.NavMeshAgent nmAgent;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        //ball.AddForce(new Vector3(1, 0, 1).normalized * 500f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) {
            Vector3 mouse = Input.mousePosition;//Get the mouse Position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get where the mouse is pointing at
            RaycastHit hit;//Stores the position where the ray hit.
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))//If the raycast doesnt hit a wall
            {
                nmAgent.SetDestination(hit.point);
                //this.transform.position = hit.point;//Move the target to the mouse position
            }
        }
            
        
    }
}
