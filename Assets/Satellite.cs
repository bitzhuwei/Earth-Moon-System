using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour
{

    private Transform planetTransform;
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
    void Start()
    {
        this.planetTransform = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaAngle = Time.deltaTime * Mathf.PI * 2 / this.RevolutionPeriod;
        float newAngle = this.currentAngle + deltaAngle;
        this.transform.position = new Vector3(
            (this.RevolutionRadius * Mathf.Cos(newAngle)),
            0,
            (this.RevolutionRadius * Mathf.Sin(newAngle)))
            + this.planetTransform.position;
        this.currentAngle = newAngle;
    }
}
