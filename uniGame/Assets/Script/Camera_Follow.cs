using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

 public Transform Target;
    public float cameraSpeed;
    public float minX, maxX, minY, maxY;
	
	void Start () {
		
	}

    void FixedUpdate()
    {
        if (Target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * cameraSpeed);
            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position=new Vector3(ClampX,ClampY,-10f);
        }
    }
	
	void Update () {
		
	}
}

