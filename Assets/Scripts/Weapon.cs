using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitVFX;
    [SerializeField] Ammo ammoSlot;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (ammoSlot.getAmountOfBullets() > 0)
        {
            PlayMuzzleFlash();
            ProcessRaycast();
            ammoSlot.reduceAmountOfBullets();
        }
    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            //TODO : Particles, VFX
            CreateExplosion(hit);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (!target) { return; }
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }

    private void CreateExplosion(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitVFX, transform.position, Quaternion.identity);
        Destroy(impact, .1f);
    }
}
