using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

    //private Transform transform;
    private float currentAngle;

    /// <summary>
    /// 公转半径
    /// </summary>
    public float RevolutionRadius;

    /// <summary>
    /// 公转周期
    /// </summary>
    public float RevolutionPeriod;

    // Use this for initialization
    void Start () {
        //this.transform = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {

        float deltaAngle = Time.deltaTime * Mathf.PI * 2 / this.RevolutionPeriod;
        float newAngle = this.currentAngle + deltaAngle;
        this.gameObject.transform.position = new Vector3(
            (float)(this.RevolutionRadius * Mathf.Cos(newAngle)),
            0,
            (float)(this.RevolutionRadius * Mathf.Sin(newAngle)));

        this.currentAngle = newAngle;
    }
}
