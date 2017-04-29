using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RenderSine : MonoBehaviour {

    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public int lengthOfLineRenderer = 20;
    LineRenderer lineRenderer;
    void Start() {

        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        lineRenderer.SetColors(c1, c2);
        lineRenderer.SetWidth(0.2F, 0.2F);
        lineRenderer.SetVertexCount(lengthOfLineRenderer);
    }
    void Update() {
        int i = 0;
        while (i < lengthOfLineRenderer) {
            Vector3 pos = new Vector3(i * 0.5F, Mathf.Sin(i + Time.time), 0);
            lineRenderer.SetPosition(i, pos);
            i++;
        }
    }
}
