using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{

  float speed = 7;

  // Update is called once per frame
  void Update()
  {
    Vector2 movement = Vector2.up * speed * Time.deltaTime;
    transform.Translate(movement);

    if (transform.position.y > 7)
    {
      Destroy(this.gameObject);
    }

  }
}
