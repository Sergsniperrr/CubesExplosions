using UnityEngine;

public class Explosion
{
    public void PushCubes(Cube[] cubes, Vector3 explosionCenter)
    {
        if (cubes.Length == 0)
            return;

        float force = 5000f;
        float radius = 10f;

        foreach (Cube cube in cubes)
            cube.RigitBody.AddExplosionForce(force, explosionCenter, radius);
    }
}
