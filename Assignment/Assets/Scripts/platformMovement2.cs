using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement2 : MonoBehaviour {

    private Vector3 posA2;

    private Vector3 posB2;

    private Vector3 nexPos2;

    [SerializeField]
    private float speed2;

    [SerializeField]
    private Transform childTransform2;

    [SerializeField]
    private Transform transformB2;

    void Start()
    {
        posB2 = childTransform2.localPosition;
        posB2 = transformB2.localPosition;
        nexPos2 = posB2;
    }

    // Update is called once per frame
    void Update()
    {

        Move2();
    }

    private void Move2()
    {
        childTransform2.localPosition = Vector3.MoveTowards(childTransform2.localPosition, nexPos2, speed2 * Time.deltaTime);

        if (Vector3.Distance(childTransform2.localPosition, nexPos2) <= 0.1)
        {
            ChangeDestination2();
        }
    }

    private void ChangeDestination2()
    {
        nexPos2 = nexPos2 != posA2 ? posA2 : posB2;
    }
}
