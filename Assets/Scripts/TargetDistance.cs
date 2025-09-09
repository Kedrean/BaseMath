using UnityEngine;

public class TargetDistance : MonoBehaviour
{
    public Transform target; // Reference to the target object

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            var distance = Mathf.Sqrt(Mathf.Pow(target.position.x - this.transform.position.x, 2)
            + Mathf.Pow(target.position.y - this.transform.position.y, 2));
            var vectorDist = Vector3.Distance(target.position, this.transform.position);
            Debug.Log($"Distance to target:  {distance:F2}, Vector {vectorDist:F2}");
	    }        
    }
}
