using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] private Transform PointA;
    [SerializeField] private Transform PointB;

    float waitingTime = 0f;
    float movingSpeed = 2f;

    Transform targetPoint;
    float waitTimer;
    bool isWaiting;

    // Start is called before the first frame update
    void Start()
    {
        targetPoint = PointB;
        waitTimer = 0f;
        isWaiting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWaiting == true)
        {
            waitTimer += Time.deltaTime;

            if (waitTimer >= waitingTime)
            {
                targetPoint = (targetPoint == PointA) ? PointB : PointA;
                isWaiting = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, movingSpeed * Time.deltaTime);

            /*
            O que isto faz é verifica se a distância entre a posição actual e a posição alvo, 
            define isWaiting = true para indicar que a plataforma deve agora aguardar e Reseta waitTimer 
            para 0 para começar a contar o tempo de espera novamente
            */
            if (Vector3.Distance(transform.position, targetPoint.position) < 0.01f)
            {
                transform.position = targetPoint.position;
                isWaiting = true;
                waitTimer = 0f;
            }
        }
    }
}
