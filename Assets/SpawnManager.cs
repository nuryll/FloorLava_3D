using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Spawn edilecek kürenin prefab'ı
    public GameObject spherePrefab;

    // Spawn süresi
    public float spawnInterval = 5.0f;

    // İlk kürenin konumu
    private Vector3 initialPosition;

    // Başlangıçta çağrılır
    void Start()
    {
        
        // İlk kürenin konumunu al
        initialPosition = transform.position;

        // Hemen ilk küreyi oluştur
        Instantiate(spherePrefab, initialPosition, Quaternion.identity);

        // Coroutine başlat
        StartCoroutine(SpawnSpheres());
    }

    // Coroutine: Belirli aralıklarla küre spawn eder
    IEnumerator SpawnSpheres()
    {
        for (int i = 0; i < 20; i++)
        {
            // SpawnInterval kadar bekle
            yield return new WaitForSeconds(spawnInterval);

            // Yeni küre oluştur
            Instantiate(spherePrefab, initialPosition, Quaternion.identity);
        }
    }
}
