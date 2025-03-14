using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private const float Timer2 = 0.1f;
    private float _currentTimer = 0.5f;
    private float _currentTimer2 = 0.1f;
    private bool _canShoot = true;
    private bool _canShoot2 = true;

    private void Update()
    {
        TimerMethod();
        SuperBulletTimer();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTimer -= Time.deltaTime;

            if (_currentTimer < 0)
            {
                _canShoot = true;
                _currentTimer = Timer;
            }
        }
    }

    private void SuperBulletTimer()
    {
        if (!_canShoot2)
        {
            _currentTimer2 -= Time.deltaTime;

            if (_currentTimer2 < 0)
            {
                _canShoot2 = true;
                _currentTimer2 = Timer2;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);
            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject Super_bullet = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);
            Super_bullet.transform.SetParent(bulletTrash);

            _canShoot2 = false;
        }
    }
}
