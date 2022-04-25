using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float speed = 8f;//Player�� �̵� �ӵ�
    public float moveableRange = 5.5f; // �̵� ������ ����
    public float power = 1000f; // CannonBall�� �߻��ϴ� ��

    // ��ź �߻� ���� �߰�
    public GameObject cannonBall; //Player���� �߻��� CannonBall
    public Transform spawnPoint; //Cannon �߻� ����
    // Transform: position, rotation, scale


    void Update()
    {
        //Player �̵� (�̵� ������ movableRange�� ����)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        //x������ horizontal �������� speed ��ŭ�� �ӵ��� 
        //horizontal: ������ ������ -1, �������� ������ +1 �̵� ��Ŵ

        transform.position
        = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);
        //transform.position.x ���� -5.5f���� �۾����ų� 5.5f���� Ŀ���� ���� -5.5f, 5.5f�� 

        // ��ź �߻� ��� �߰�  
        if (Input.GetKeyDown(KeyCode.Space))  //�����̽�Ű ��ư �̺�Ʈ ó��
        {
            Shoot(); //Shoot�Լ� ȣ��
        }

    }
    void Shoot()
    {
        //������ �� cannonBall�� �����Ͽ� newBullet�� �Ҵ�
        GameObject newBullet = Instantiate(cannonBall, spawnPoint.position, Quaternion.identity) as GameObject;
        // cannonBall�� ������ ��ġ(�߻� ����)�� ������ �������� ���� 
        //newBullet�� Rigidbody2D�� �����Ͽ� AddForce �Լ��� ���������� �߻�
        //Quaternion.identity: ȸ�� ���� (0, 0, 0)

        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
        //������ cannonball�� ������ �ִ� �Ӽ��� rigidbody2D�� ���� �߰�(y������ power��ŭ)
        //���� �߻��ϴ� ���� ���Ǹ� �߷��� ������ �޾� ������ ������
    }



}
