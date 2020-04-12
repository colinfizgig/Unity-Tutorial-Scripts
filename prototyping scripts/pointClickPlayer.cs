using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pointClickPlayer : MonoBehaviour
{
    public LayerMask objectsRecieveClicks;
    private NavMeshAgent myAgent;

    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast (myRay, out hitInfo, 100, objectsRecieveClicks))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
