using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Tốc độ xoay của súng

    void Update()
    {
        // Lấy vị trí chuột trên màn hình
        Vector3 mousePosition = Input.mousePosition;

        // Chuyển vị trí chuột từ màn hình sang world space
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.transform.position.y));

        // Tính toán vector hướng từ súng tới vị trí chuột
        Vector2 direction = mouseWorldPosition - transform.position;

        // Tính toán góc quay (theo trục Z)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Tạo quaternion xoay theo góc quay (trục Z)
        Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

        // Áp dụng xoay súng theo quaternion mới với tốc độ quay
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
