using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    private Material material;
    public MeshRenderer wiiMesh;

    // Start is called before the first frame update

    public void SelectedMesh()
    {
        material = GetComponent<HoldMaterial>().material;
        wiiMesh.material = material;
    }
}
