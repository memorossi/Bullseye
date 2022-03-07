using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFix : MonoBehaviour
{

    SkinnedMeshRenderer meshRenderer;
    MeshCollider coll;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
        coll = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCollider();
    }

    public void UpdateCollider()
    {
        Mesh colliderMesh = new Mesh();
        meshRenderer.BakeMesh(colliderMesh);
        coll.sharedMesh = null;
        coll.sharedMesh= colliderMesh;
    }
}
