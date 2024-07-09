using UnityEngine;
using UnityEngine.Events;

public class OpenBagWarehouses : MonoBehaviour
{
    public UnityEvent ClickShowBag;

   private void OnMouseDown()
    {
        ClickForShowBag();
    }

  private  void ClickForShowBag()
    {
        ClickShowBag.Invoke();
    }
}
