using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BootstrapperTask
{
    public class PlayerMovement
    {
        public void Move(Rigidbody playerRb, float playerSpeed)
        {
            playerRb.angularVelocity = new Vector3 (playerSpeed, 0, 0);
        }
    }
}
