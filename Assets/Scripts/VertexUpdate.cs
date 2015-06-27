using UnityEngine;
using System.Collections;

public class VertexUpdate : MonoBehaviour {
	public Vector3[] newVertices;
	public Vector2[] newUV;
	public int[] newTriangles;
	void Update() {
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.Clear();
		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
	}
}

