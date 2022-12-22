using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  [SerializeField]
  float speed = 0;

  [SerializeField]
  GameObject bulletPrefab;

  [SerializeField]
  Transform gunTransform;

  void Update()
  {
    float xMovement = Input.GetAxisRaw("Horizontal");
    float yMovement = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(xMovement, yMovement) * speed * Time.deltaTime;
    transform.Translate(movement);

    if (Input.GetAxisRaw("Fire1") > 0)
    {
      Instantiate(bulletPrefab, gunTransform.position, Quaternion.identity);
    }
  }
}
