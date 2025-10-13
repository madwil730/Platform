using UnityEngine;

public class EnemyA : MonoBehaviour, IEmemy
{
    public float HP;
    public float Damage;


    public void OnDamaged()
    {
        throw new System.NotImplementedException();
    }

    public void OnHit()
    {
        GameManager.Instance.Player.IsDaed = true;  
        throw new System.NotImplementedException();
    }

    public void OnMove()
    {
        throw new System.NotImplementedException();
    }
}
