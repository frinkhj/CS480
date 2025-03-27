using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;

    public void ShootLaser()
    {
        GameObject laser = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);

        laser.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 1000);
    }
}