using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CrowdPlacement : MonoBehaviour
{
    [Header("Crowd Distance Settings")]
    public float radius;
    public float angle;

    [Header("Elements Refrence")]
    public Transform runnerParent;
    public TextMeshPro crowdCounter;
    void Update()
    {
        placeRunner();
        CrowdCounter();
    }
    private void CrowdCounter()
    {
        crowdCounter.text = runnerParent.childCount.ToString();
    }
    private void placeRunner()
    {
        for (int i = 0; i < runnerParent.childCount; i++)
        {
            Vector3 childLocalPosition = placeRunnerLocalPosition(i);
            runnerParent.GetChild(i).localPosition = childLocalPosition ;
        }
    }
    private Vector3 placeRunnerLocalPosition(int index)
    {
        float x = radius * Mathf.Sqrt(index) * Mathf.Cos(Mathf.Deg2Rad * index * angle);
        float z = radius * Mathf.Sqrt(index) * Mathf.Sin(Mathf.Deg2Rad * index * angle);
        return new Vector3(x,0,z) ;
    }
}
