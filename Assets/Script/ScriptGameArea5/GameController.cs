using UnityEngine;

public class GameController : MonoBehaviour
{
    public float maxMoveSpeed = 10f; // Tốc độ di chuyển tối đa của player khi bắt theo chuột
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lấy vị trí chuột trên màn hình
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f; // Đặt z = 0 để di chuyển trong mặt phẳng 2D

        // Tính toán hướng và khoảng cách di chuyển
        Vector2 direction = (mousePosition - transform.position).normalized;
        float distance = Vector2.Distance(transform.position, mousePosition);

        // Giới hạn tốc độ di chuyển bắt theo chuột
        float moveSpeed = Mathf.Min(maxMoveSpeed, distance);

        // Di chuyển player theo hướng và tốc độ được giới hạn
        rb.velocity = direction * moveSpeed;
    }
}
