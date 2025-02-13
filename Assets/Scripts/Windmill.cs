using UnityEngine;

public class Windmill : MonoBehaviour
{
    [SerializeField] private GameObject _blades;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        _blades.transform.Rotate(0, 0, _speed);
    }
}
