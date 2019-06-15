using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mirror
{
    public class Movement : NetworkBehaviour
    {

        public float speed = 30;

        // need to use FixedUpdate for rigidbody
        void FixedUpdate()
        {
            // only let the local player control the racket.
            // don't control other player's rackets
            if (!isLocalPlayer) return;

            float vertical = Input.GetAxisRaw("Vertical");
            float h = Input.GetAxisRaw("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(h, vertical) * speed * Time.fixedDeltaTime;
        }
    }
}