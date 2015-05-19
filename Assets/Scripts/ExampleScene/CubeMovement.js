#pragma strict

public var terrain : Terrain;

function Update () {
	transform.Translate(Vector3.forward * Time.deltaTime * 10.0f);
	transform.localEulerAngles.y += Time.deltaTime * 5.0f;
	transform.position.y = terrain.SampleHeight(transform.position) + 5.0f;
}