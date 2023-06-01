using UnityEngine;
using System.Collections.Generic;

public class OptimizedExplosion : MonoBehaviour
{
    public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, int maxAffectedCount)
    {
        // Create a sphere around the explosion position with the given radius
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius);

        // Sort the colliders based on their distance to the explosion center
        List<Collider> sortedColliders = new List<Collider>(colliders);
        sortedColliders.Sort((a, b) => (a.transform.position - explosionPosition).sqrMagnitude.CompareTo((b.transform.position - explosionPosition).sqrMagnitude));

        // Apply the force only to the first maxAffectedCount colliders
        for (int i = 0; i < Mathf.Min(maxAffectedCount, sortedColliders.Count); i++)
        {
            Rigidbody rb = sortedColliders[i].GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Calculate the explosion effect considering the Inverse Square Law
                Vector3 explosionDirection = rb.position - explosionPosition;
                float explosionDistance = explosionDirection.magnitude;
                float relativeDistance = (explosionRadius - explosionDistance) / explosionRadius;
                float force = relativeDistance * relativeDistance * explosionForce;

                rb.AddForce(explosionDirection.normalized * force, ForceMode.Impulse);
            }
        }
    }
}
