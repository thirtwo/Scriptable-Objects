using UnityEngine;

public class MPBController : MonoBehaviour
{
    [SerializeField] private Color mainColor;
    Renderer _renderer;
    MaterialPropertyBlock _MPB;

    private void Start()
    {
        _renderer = GetComponent<Renderer>(); // getting renderer of this obj
        _MPB = new MaterialPropertyBlock(); // instancing new Material Propery Block
        _MPB.SetColor("_Color", mainColor); // Setting color only this obj. Not creating new material. Because we said that shader only hold color values per obj. Other values same.
        _renderer.SetPropertyBlock(_MPB); // we setting this Material Propery Block to our obj
    }
}
