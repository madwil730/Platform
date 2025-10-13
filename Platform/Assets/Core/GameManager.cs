using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Player Player;

    private void Awake()
    {
        // 이미 인스턴스가 있으면 자신을 파괴
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // 인스턴스 등록
        Instance = this;
        DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 유지
    }

    void Start()
    {
        // 초기화 코드
    }

    void Update()
    {
        // 매 프레임 실행
    }
}
