using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{

    public Chunk[] chunkPrefab;

    public int platformLength;

    private void Start()
    {
        Vector3 chunkPosition = Vector3.zero;
        for (int i = 0; i < platformLength; i++)
        {
            Chunk chunkToCreate = chunkPrefab[Random.Range(0, chunkPrefab.Length)];
            if (i > 0)
            {
                chunkPosition.z += chunkToCreate.GetLength() / 2;
            }
            Chunk chunkInstance = Instantiate(chunkToCreate, chunkPosition, Quaternion.identity,transform);
            chunkPosition.z += chunkToCreate.GetLength() / 2;
        }
    }  
}
