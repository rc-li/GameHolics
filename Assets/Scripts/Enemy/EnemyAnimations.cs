using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator;
    //private GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        //_enemy = GetComponent<GameObject>();
    }

    private void PlayDieAnimation()
    {
        _animator.SetTrigger("Die");
    }

    private float GetCurrentAnimationLength()
    {
        float animationLength = _animator.GetCurrentAnimatorStateInfo(0).length;
        return animationLength;
    }

    private IEnumerator PlayDead()
    {
        PlayDieAnimation();
        Debug.Log("dead");
        yield return new WaitForSeconds(GetCurrentAnimationLength() + 0.3f);
        Destroy(gameObject);
    }
    private void EnemyDead(GameObject enemy)
    {
        if (gameObject == enemy)
        {
            StartCoroutine(PlayDead());
        }
    }

    private void OnEnable()
    {
        EnemyType4.OnEnemyKilled += EnemyDead;
    }

    private void OnDisable()
    {
        EnemyType4.OnEnemyKilled -= EnemyDead;
    }
}
