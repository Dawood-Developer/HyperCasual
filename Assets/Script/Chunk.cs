using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Vector3 size;

    public GameObject longChunk;
    public Transform playerLocation;

    public float GetLength () 
    { 
        return size.z;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, size);
    }

    public void ChunkGenerator()
    {
        for (int i = 0; i < 3; i++) 
        {
            GameObject chunkToCreate = Instantiate(longChunk,new Vector3(0,0,playerLocation.position.z+i*10),transform.rotation);
        }
    }
}