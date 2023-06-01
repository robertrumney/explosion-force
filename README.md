# Unity Optimized Explosion

Unity Optimized Explosion is a high-performance, more realistic alternative to Unity's built-in AddExplosionForce function. The primary goal of this project is to provide a practical and efficient way to apply explosion forces to the objects in your Unity scenes.

## Why is it more realistic?

In a realistic explosion scenario, the explosion force isn't constant, but rather decreases with the square of the distance from the explosion's epicenter (Inverse Square Law). An object closer to the explosion should experience a significantly higher force than an object farther away.

Unity's AddExplosionForce applies a constant force to all objects within the explosion radius, which doesn't follow the realistic behaviour of explosions. Unity Optimized Explosion, on the other hand, applies a force that decreases with the square of the distance, which is a more accurate simulation of an actual explosion.

## Why is it more optimized?

The built-in Unity AddExplosionForce function applies explosion force to all objects within a defined radius. This approach can be computationally expensive when dealing with scenes containing a large number of rigid bodies, which may cause performance degradation, particularly in real-time applications.

Unity Optimized Explosion solves this issue by introducing a maxAffectedCount parameter, which limits the maximum number of objects that the explosion can affect. By providing this limit, you can control the maximum computational cost and avoid potential performance problems.

## Why should you use it?

Unity Optimized Explosion provides a balance of realism and performance optimization. If you're developing a game or a real-time simulation in Unity, using this function will not only give your explosions a more realistic look and feel, but also help ensure that your application runs smoothly even in high-load scenarios.

This function is an easy drop-in replacement for Unity's AddExplosionForce, making it a simple way to improve both the realism and performance of your Unity projects.

## Usage

To use Unity Optimized Explosion, simply call the AddExplosionForce method from a GameObject that has the OptimizedExplosion script attached, providing the total force of the explosion, the center position, the explosion radius, and the maximum number of rigid bodies to be affected:

```csharp
optimizedExplosion.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, maxAffectedCount);
```

## License

This project is licensed under the terms of the MIT license. See [LICENSE](LICENSE) for more details.
