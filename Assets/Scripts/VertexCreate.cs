using UnityEngine;
using System.Collections;

public class VertexCreate : MonoBehaviour {

		public Vector3[] newVertices;
		public Vector2[] newUV;
		public int[] newTriangles;

	void Start() {

		Mesh mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;

		newVertices[0] = new Vector3(0.1f, 0.5f, 0.5f);
		newVertices[1] = new Vector3(0.5f, -0.5f, 0.5f);
		newVertices[2] = new Vector3(-0.5f, -0.5f, 0.5f);

		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
	}
}
