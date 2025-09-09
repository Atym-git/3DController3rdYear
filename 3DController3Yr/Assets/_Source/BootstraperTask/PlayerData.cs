
using UnityEngine;

namespace BootstrapperTask
{
    public class PlayerData : MonoBehaviour
    {
        [field: SerializeField] public Rigidbody PlayerRb {  get; private set; }
        [field: SerializeField] public float moveSpeed {  get; private set; }
    }

}


//1. Разделение объектов по разным логическим модулям
//2. Наглядная зависимость модулей друг от друга через using
//3. Возможность переиспользовать одинаковые имена в разных пространствах имен