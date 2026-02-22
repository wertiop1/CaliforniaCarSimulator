using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoadManager : MonoBehaviour
{
    public Transform player;              
    public GameObject roadPrefab;         
    public int numberOfSegments = 6;      
    public float segmentLength = 10f;     

    private List<GameObject> segments = new List<GameObject>();
    private float spawnY = -10f;

    // Rotation you want
    private Quaternion roadRotation = Quaternion.Euler(90f, 0f, 180f);

    void Start()
    {
        for (int i = 0; i < numberOfSegments; i++)
        {
            SpawnSegment();
        }
    }

    void Update()
    {
        if (player.position.y - 15f > segments[0].transform.position.y)
        {
            RecycleSegment();
        }
    }

    void SpawnSegment()
    {
        GameObject segment = Instantiate(
            roadPrefab,
            Vector3.up * spawnY,
            roadRotation
        );

        segments.Add(segment);
        spawnY += segmentLength;
    }

    void RecycleSegment()
    {
        GameObject oldSegment = segments[0];
        segments.RemoveAt(0);

        oldSegment.transform.position = Vector3.up * spawnY;
        oldSegment.transform.rotation = roadRotation;

        segments.Add(oldSegment);
        spawnY += segmentLength;
    }
}