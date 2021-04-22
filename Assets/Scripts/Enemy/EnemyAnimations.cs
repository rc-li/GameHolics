using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
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
        EnemyType3.OnEnemyKilled += EnemyDead;
        EnemyType4.OnEnemyKilled += EnemyDead;
        EnemyType5.OnEnemyKilled += EnemyDead;
    }

    private void OnDisable()
    {
        EnemyType3.OnEnemyKilled -= EnemyDead;
        EnemyType4.OnEnemyKilled -= EnemyDead;
        EnemyType5.OnEnemyKilled -= EnemyDead;
    }
}
