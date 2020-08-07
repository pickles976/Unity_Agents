using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek_script : MonoBehaviour
{
    base_behavior bb;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        bb = gameObject.GetComponent<base_behavior>();
        target = bb.target;

        
        if(bb.seekScript == null)
        {
            bb.seekScript = gameObject.AddComponent<Seek>();
            bb.seekScript.target = target;
            bb.seekScript.weight = 1.0f;
            bb.seekScript.enabled = true;

            //bb.fleeScript = gameObject.AddComponent<Flee>();
            //bb.fleeScript.target = target;
            //bb.fleeScript.enabled = true;
        }
        
    }

    
    private void OnDestroy()
    {
        DestroyImmediate(bb.seekScript);
    }
    

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.Label(transform.position + Vector3.up * 3, "Seek");
    }

}
