using UnityEngine;

public class IgagiriGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject igaguriPrefab;

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        var igaguri =
            Instantiate(this.igaguriPrefab);
        if (Camera.main is null) return;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var worldDir = ray.direction;
        igaguri.GetComponent<IgaguriController>().Shoot(
            worldDir.normalized * 2000);
    }
}
