using Unity.VisualScripting;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3.0f;                   // ˆÚ“®’l
    [SerializeField] Vector3 moveVec = new Vector3(0, -1, 0);  // ˆÚ“®•ûŒü
    GameObject enemyObj = null;
   public const float dell = 100;

    private void Start()
    {
        enemyObj = GameObject.Find("Circle");
        
    }
    



    void Update()
    {
        float add_move = moveSpeed * Time.deltaTime;
        transform.Translate(moveVec * add_move);
        float distance = (enemyObj.transform.position - transform.position).sqrMagnitude;

        if (distance > dell)
        {
            Destroy(gameObject);
        }
    }

    public void SetMoveSpeed(float _speed)
    {
        moveSpeed = _speed;
    }

    public void SetMoveVec(Vector3 _vec)
    {
        moveVec = _vec.normalized;
    }

    



}